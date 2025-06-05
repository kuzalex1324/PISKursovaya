using GameLibraryDA.Classes;
using Npgsql;

namespace GameLibraryDA
{
    public partial class ShopForm : Form
    {
        public static List<Game> all_games;
        public static Gamer CurrentGamer;

        public ShopForm(Gamer currentGamer)
        {
            CurrentGamer = currentGamer;
            InitializeComponent();
            LabelBalance.Text = currentGamer.Balance.ToString()+"$";
            all_games = GetAllGames(LoginForm.conn);
            foreach (var game in all_games)
            {
                CBShopFormSearch.Items.Add(game.Name);
            }
            CBShopFormSearch.SelectedIndex = 0;

        }
        public List<Game> GetAllGames(NpgsqlConnection conn)
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

            using (var cmd = new NpgsqlCommand(query, conn))
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


        private void BTNLibrary_Click(object sender, EventArgs e)
        {
            LibraryForm libraryForm = new LibraryForm();
            libraryForm.Show();
        }

        private void BTNProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.Show();
        }

        private void CBShopFormSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Game game = all_games.FirstOrDefault(g => g.Name == CBShopFormSearch.SelectedItem.ToString());
            LabelGameGenre.Text = game.Genre;
            LabelGameName.Text = game.Name;
            LabelPrice.Text = game.Price.ToString() + "$";

            if (game.Name == "Assassins Creed")
            {
                PBLargePhoto.Image = GameLibraryDA.Properties.Resources.AC2_1;
                PBSmallPhotoTopLeft.Image = GameLibraryDA.Properties.Resources.AC2_2;
                PBSmallPhotoTopRight.Image = GameLibraryDA.Properties.Resources.AC2_3;
                PBSmallPhotoBottomLeft.Image = GameLibraryDA.Properties.Resources.AC2_4;
                PBSmallPhotoBottomRight.Image = GameLibraryDA.Properties.Resources.AC2_5;

            }
            else if (game.Name == "Fortnite")
            {
                PBLargePhoto.Image = GameLibraryDA.Properties.Resources.F1;
                PBSmallPhotoTopLeft.Image = GameLibraryDA.Properties.Resources.F2;
                PBSmallPhotoTopRight.Image = GameLibraryDA.Properties.Resources.F3;
                PBSmallPhotoBottomLeft.Image = GameLibraryDA.Properties.Resources.F4;
                PBSmallPhotoBottomRight.Image = GameLibraryDA.Properties.Resources.F5;
            }
            else
            {
                PBLargePhoto.Image = GameLibraryDA.Properties.Resources.error;
                PBSmallPhotoTopLeft.Image = GameLibraryDA.Properties.Resources.error;
                PBSmallPhotoTopRight.Image = GameLibraryDA.Properties.Resources.error;
                PBSmallPhotoBottomLeft.Image = GameLibraryDA.Properties.Resources.error;
                PBSmallPhotoBottomRight.Image = GameLibraryDA.Properties.Resources.error;
            }
        }

        private void BTNBuy_Click(object sender, EventArgs e)
        {
            Game game = all_games.FirstOrDefault(g => g.Name == CBShopFormSearch.SelectedItem.ToString());

            if (CurrentGamer.PurchaseGame(game))
            {
                LabelBalance.Text = CurrentGamer.Balance.ToString()+"$";
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = LoginForm.conn;

                    // Запрос для вставки данных в таблицу gamerlibrary
                    string query = @"
        INSERT INTO gamerlibrary (gamer_id, game_id, addeddate, hoursplayed)
        VALUES ((SELECT gamer_id FROM gamers WHERE name = @gamerName), 
                (SELECT game_id FROM games WHERE name = @gameName), 
                @addedDate, 
                @hoursPlayed)";

                    // Установка параметров
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("gamerName", CurrentGamer.Name);
                    cmd.Parameters.AddWithValue("gameName", game.Name);
                    cmd.Parameters.AddWithValue("addedDate", DateTime.Now); // Или другая дата, если требуется
                    cmd.Parameters.AddWithValue("hoursPlayed", 0); // Указывайте количество часов, если необходимо

                    // Выполнение запроса
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = LoginForm.conn;

                    // Запрос для уменьшения баланса игрока
                    string query = @"
        UPDATE gamers
        SET balance = balance - @amount
        WHERE gamer_id = (SELECT gamer_id FROM gamers WHERE name = @gamerName)";

                    // Установка параметров
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("gamerName", CurrentGamer.Name); // Имя игрока
                    cmd.Parameters.AddWithValue("amount", (float)game.Price); // Сумма для уменьшения (например, 10.00)

                    // Выполнение запроса
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }
}
