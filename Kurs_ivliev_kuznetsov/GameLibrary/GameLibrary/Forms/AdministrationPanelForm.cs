using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLibraryDA.Classes;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GameLibraryDA
{
    public partial class AdministrationPanelForm : Form
    {
        public static List<Game> all_games;
        public AdministrationPanelForm()
        {
            InitializeComponent();
            all_games = GetAllGames();
            foreach (var game in all_games)
            {
                cbgames.Items.Add(game.Name);
            }
            cbgames.SelectedIndex = 0;
        }
        public List<Game> GetAllGames()
        {
            var games = new List<Game>();

            string query = @"
        SELECT g.name AS gamename,
               g.size,
               g.price,
               g.genre,
               r.rating,
               r.comment,
               r.reviewdate,
               gm.name AS gamername
        FROM games g
        LEFT JOIN reviews r ON g.game_id = r.game_id
        LEFT JOIN gamers gm ON r.gamer_id = gm.gamer_id";

            using (var cmd = new NpgsqlCommand(query, LoginForm.conn))
            using (var reader = cmd.ExecuteReader())
            {
                var gameMap = new Dictionary<string, List<Review>>();

                while (reader.Read())
                {
                    string gameName = reader.GetString(reader.GetOrdinal("gamename"));
                    float size = reader.GetFloat(reader.GetOrdinal("size"));
                    float price = reader.GetFloat(reader.GetOrdinal("price"));
                    string genre = reader.GetString(reader.GetOrdinal("genre"));

                    string gamerName = reader.IsDBNull(reader.GetOrdinal("gamername")) ? "" : reader.GetString(reader.GetOrdinal("gamername"));
                    float rating = reader.IsDBNull(reader.GetOrdinal("rating")) ? 0 : reader.GetFloat(reader.GetOrdinal("rating"));
                    string comment = reader.IsDBNull(reader.GetOrdinal("comment")) ? "" : reader.GetString(reader.GetOrdinal("comment"));
                    DateTime reviewDate = reader.IsDBNull(reader.GetOrdinal("reviewdate")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("reviewdate"));

                    if (!gameMap.ContainsKey(gameName))
                        gameMap[gameName] = new List<Review>();

                    if (!string.IsNullOrEmpty(gamerName))
                    {
                        var review = new Review(gameName, gamerName, rating, comment, reviewDate);
                        gameMap[gameName].Add(review);

                    }

                    // Avoid duplicating game objects
                    if (!games.Any(g => g.Name == gameName))
                    {
                        games.Add(new Game(gameName, size, price, genre, gameMap[gameName]));
                    }
                }
            }


            return games;
        }
        private void BTNBan_Click(object sender, EventArgs e)
        {
            string nickname = player_name.Text;

            if (string.IsNullOrWhiteSpace(nickname))
            {
                MessageBox.Show("Введите никнейм игрока");
                return;
            }

            try
            {

                using (var cmd = new NpgsqlCommand(
                    "UPDATE gamers SET banned = true WHERE name = @nickname",
                    LoginForm.conn))
                {
                    cmd.Parameters.AddWithValue("nickname", nickname);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Игрок {nickname} успешно забанен");
                    }
                    else
                    {
                        MessageBox.Show($"Игрок {nickname} не найден");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при бане игрока: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nickname = player_name.Text;

            if (string.IsNullOrWhiteSpace(nickname))
            {
                MessageBox.Show("Введите никнейм игрока");
                return;
            }

            try
            {
                using (var cmd = new NpgsqlCommand(
                    "UPDATE gamers SET banned = false WHERE name = @nickname",
                    LoginForm.conn))
                {
                    cmd.Parameters.AddWithValue("nickname", nickname);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Игрок {nickname} успешно разбанен");
                    }
                    else
                    {
                        MessageBox.Show($"Игрок {nickname} не найден");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при разбане игрока: {ex.Message}");
            }
        }

        private void cbgames_SelectedIndexChanged(object sender, EventArgs e)
        {
            LVAdminFeedbacks.Items.Clear();
            Game game = all_games.FirstOrDefault(g => g.Name == cbgames.SelectedItem.ToString());
            foreach (var review in game.Reviews)
            {
                LVAdminFeedbacks.Items.Add(review.GamerName + "            " + review.Comment + "            " + review.Rating + "/10" + "            " + review.ReviewDate.ToString().Substring(0, 10));
            }

        }


        private void BTNDeleteFeedback_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка выбранной игры
                if (cbgames.SelectedItem == null)
                {
                    MessageBox.Show("Выберите игру из списка");
                    return;
                }

                // Проверка выбранного отзыва в ListView
                if (LVAdminFeedbacks.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Выберите отзыв для удаления");
                    return;
                }

                string gameName = cbgames.SelectedItem.ToString();

                // Находим игру в локальной коллекции
                Game game = all_games.FirstOrDefault(g => g.Name == gameName);
                if (game == null)
                {
                    MessageBox.Show("Выбранная игра не найдена");
                    return;
                }

                // Находим отзыв по тексту
                int selectedIndex = LVAdminFeedbacks.SelectedIndices[0];
                Review rev = game.Reviews[selectedIndex];
                string commentText = rev.Comment; // Получаем текст выбранного элемента

                if (rev == null)
                {
                    MessageBox.Show("Выбранный отзыв не найден");
                    return;
                }

                // Подтверждение удаления
                var confirmResult = MessageBox.Show(
                    $"Вы уверены, что хотите удалить отзыв от {rev.GamerName}?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo);

                if (confirmResult != DialogResult.Yes)
                    return;

                // Удаление из базы данных
                using (var cmd = new NpgsqlCommand(
                    @"DELETE FROM reviews 
              WHERE game_id = (SELECT game_id FROM games WHERE name = @gameName)
              AND comment = @commentText
              AND gamer_id = (SELECT gamer_id FROM gamers WHERE name = @gamerName)",
                    LoginForm.conn))
                {
                    cmd.Parameters.AddWithValue("gameName", gameName);
                    cmd.Parameters.AddWithValue("commentText", commentText);
                    cmd.Parameters.AddWithValue("gamerName", rev.GamerName);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    game.Reviews.Remove(rev);
                    LVAdminFeedbacks.Items.RemoveAt(LVAdminFeedbacks.SelectedIndices[0]);
                    MessageBox.Show("Отзыв успешно удален");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении отзыва: {ex.Message}");
            }
        }

    }
}
