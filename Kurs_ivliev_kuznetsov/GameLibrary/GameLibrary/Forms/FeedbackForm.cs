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

namespace GameLibraryDA
{
    public partial class FeedBackForm : Form
    {
        public FeedBackForm()
        {
            InitializeComponent();
        }
        public void CreateReview(string gameName, string gamerName, float rating, string comment)
        {

            // Находим game_id по имени игры
            string gameQuery = "SELECT game_id FROM games WHERE name = @gameName";
            int gameId = -1;
            using (var cmd = new NpgsqlCommand(gameQuery, LoginForm.conn))
            {
                cmd.Parameters.AddWithValue("gameName", gameName);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        gameId = reader.GetInt32(reader.GetOrdinal("game_id"));
                    }
                }
            }

            // Находим gamer_id по имени пользователя
            string gamerQuery = "SELECT gamer_id FROM gamers WHERE name = @gamerName";
            int gamerId = -1;
            using (var cmd = new NpgsqlCommand(gamerQuery, LoginForm.conn))
            {
                cmd.Parameters.AddWithValue("gamerName", gamerName);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        gamerId = reader.GetInt32(reader.GetOrdinal("gamer_id"));
                    }
                }
            }

            // Если найдены game_id и gamer_id, то добавляем новый отзыв
            if (gameId != -1 && gamerId != -1)
            {
                string insertReviewQuery = "INSERT INTO reviews (game_id, gamer_id, rating, comment, reviewdate) " +
                                           "VALUES (@gameId, @gamerId, @rating, @comment, @reviewDate)";
                using (var cmd = new NpgsqlCommand(insertReviewQuery, LoginForm.conn))
                {
                    cmd.Parameters.AddWithValue("gameId", gameId);
                    cmd.Parameters.AddWithValue("gamerId", gamerId);
                    cmd.Parameters.AddWithValue("rating", rating);
                    cmd.Parameters.AddWithValue("comment", comment);
                    cmd.Parameters.AddWithValue("reviewDate", DateTime.Now);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Review added successfully.");
                Close();
                }
            }
            else
            {
                MessageBox.Show("Game or Gamer not found.");
                Close();
            }
        }

        private void BTNPublication_Click(object sender, EventArgs e)
        {
            Review riv = new Review(LibraryForm.crntgame.Name, ShopForm.CurrentGamer.Name, (float)numericUpDown1.Value, TBFeedback.Text, DateTime.Now);
            CreateReview(LibraryForm.crntgame.Name, ShopForm.CurrentGamer.Name, (float)numericUpDown1.Value, TBFeedback.Text);
            LibraryForm.crntgame.Reviews.Add(riv);
        }
    }
}
