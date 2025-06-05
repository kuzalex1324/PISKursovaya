using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using GameLibraryDA.Classes;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GameLibraryDA
{
    public partial class LoginForm : Form
    {
        private static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1717;Database=GameLibrary";
        public static NpgsqlConnection conn = new NpgsqlConnection(connectionString);
        public LoginForm()
        {
            InitializeComponent();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection error: {ex.Message}");
            }
        }

        private void BTNCreateAccount_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }
        public List<Applicationn> GetDeveloperApplications(string developerName)
        {
            var applications = new List<Applicationn>();

            string query = @"
SELECT 
    a.createddate, 
    a.ischecked, 
    a.reason,
    ad.administrator_id,
    ad.name AS admin_name, 
    ad.email AS admin_email,
    ad.password AS admin_password,
    ad.registrationdate AS admin_regdate,
    c.country_id,
    c.name AS country_name,
    c.iso_code
FROM applications a
JOIN developers d ON a.developer_id = d.developer_id
LEFT JOIN administrators ad ON a.administrator_id = ad.administrator_id
LEFT JOIN countries c ON ad.country_id = c.country_id
WHERE d.name = @devName";

            using (var cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("devName", developerName);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime createdDate = reader.GetDateTime(reader.GetOrdinal("createddate"));
                        bool isChecked = reader.GetBoolean(reader.GetOrdinal("ischecked"));
                        string reason = reader.IsDBNull(reader.GetOrdinal("reason"))
                            ? null
                            : reader.GetString(reader.GetOrdinal("reason"));

                        Administrator reviewer = null;
                        if (!reader.IsDBNull(reader.GetOrdinal("administrator_id")))
                        {
                            string adminName = reader.GetString(reader.GetOrdinal("admin_name"));
                            string adminEmail = reader.GetString(reader.GetOrdinal("admin_email"));
                            string adminPassword = reader.GetString(reader.GetOrdinal("admin_password"));
                            DateTime adminRegDate = reader.GetDateTime(reader.GetOrdinal("admin_regdate"));

                            Country adminCountry = null;
                            if (!reader.IsDBNull(reader.GetOrdinal("country_id")))
                            {
                                int countryId = reader.GetInt32(reader.GetOrdinal("country_id"));
                                string countryName = reader.GetString(reader.GetOrdinal("country_name"));
                                string isoCode = reader.GetString(reader.GetOrdinal("iso_code"));

                                adminCountry = new Country(countryName, isoCode);
                            }

                            reviewer = new Administrator(
                                adminName,
                                adminEmail,
                                adminPassword,
                                adminRegDate,
                                adminCountry
                            );
                        }

                        var application = new Applicationn(createdDate, isChecked, reviewer, reason);
                        applications.Add(application);
                    }
                }
            }

            return applications;
        }

        public GameLibrary GetGameLibrary(NpgsqlConnection conn, string gamerName)
        {
            List<Game> games = new List<Game>();
            Game currentGame = null;

            string query = @"
        SELECT g.name AS gamename, g.size, g.price, g.genre, 
               r.rating, r.comment, r.reviewdate, gm.name AS gamername
        FROM gamerlibrary gl
        JOIN games g ON gl.game_id = g.game_id
        LEFT JOIN reviews r ON g.game_id = r.game_id
        LEFT JOIN gamers gm ON r.gamer_id = gm.gamer_id
        WHERE gl.gamer_id = (SELECT gamer_id FROM gamers WHERE name = @gamerName)";

            using (var cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("gamerName", gamerName);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string gameName = reader.GetString(reader.GetOrdinal("GameName"));
                        float gameSize = reader.GetFloat(reader.GetOrdinal("Size"));
                        float gamePrice = reader.GetFloat(reader.GetOrdinal("Price"));
                        string gameGenre = reader.GetString(reader.GetOrdinal("Genre"));

                        var reviews = new List<Review>();

                        // Проверяем, есть ли отзыв для этой игры
                        if (!reader.IsDBNull(reader.GetOrdinal("Rating")) && !reader.IsDBNull(reader.GetOrdinal("Comment")))
                        {
                            string gamerNameFromReview = reader.GetString(reader.GetOrdinal("GamerName"));
                            float rating = reader.GetFloat(reader.GetOrdinal("Rating"));
                            string comment = reader.GetString(reader.GetOrdinal("Comment"));
                            DateTime reviewDate = reader.GetDateTime(reader.GetOrdinal("ReviewDate")); // Считывание reviewDate

                            reviews.Add(new Review(gameName, gamerNameFromReview, rating, comment, reviewDate)); // Передача reviewDate
                        }

                        // Проверяем, существует ли уже игра в списке
                        var existingGame = games.FirstOrDefault(g => g.Name == gameName);

                        if (existingGame != null)
                        {
                            // Если игра уже существует, добавляем отзывы
                            existingGame.Reviews.AddRange(reviews);
                        }
                        else
                        {
                            // Если игры нет, создаём новую и добавляем её
                            Game game = new Game(gameName, gameSize, gamePrice, gameGenre, reviews);

                            // Проверяем, является ли это текущей игрой, например, первой по добавлению
                            if (currentGame == null)
                            {
                                currentGame = game;
                            }

                            games.Add(game);
                        }
                    }
                }
            }

            return new GameLibrary(games, currentGame);
        }


        public Developer GetFullDeveloper(string developerName)
        {
            // 1. Получаем основную информацию о разработчике
            string developerQuery = @"
SELECT 
    d.name,
    d.email,
    d.password,
    d.registrationdate,
    c.country_id,
    c.name AS country_name,
    c.iso_code
FROM developers d
LEFT JOIN countries c ON d.country_id = c.country_id
WHERE d.name = @devName";

            Developer developer = null;
            List<Applicationn> applications = null;
            List<Game> games = null;

            using (var cmd = new NpgsqlCommand(developerQuery, conn))
            {
                cmd.Parameters.AddWithValue("devName", developerName);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string name = reader.GetString(reader.GetOrdinal("name"));
                        string email = reader.GetString(reader.GetOrdinal("email"));
                        string password = reader.GetString(reader.GetOrdinal("password"));
                        DateTime regDate = reader.GetDateTime(reader.GetOrdinal("registrationdate"));

                        Country country = null;
                        if (!reader.IsDBNull(reader.GetOrdinal("country_id")))
                        {
                            int countryId = reader.GetInt32(reader.GetOrdinal("country_id"));
                            string countryName = reader.GetString(reader.GetOrdinal("country_name"));
                            string isoCode = reader.GetString(reader.GetOrdinal("iso_code"));

                            country = new Country(countryName, isoCode);
                        }

                        reader.Close();

                        // 2. Получаем активные заявки разработчика
                        applications = GetDeveloperApplications(developerName)
                            .Where(app => !app.IsChecked).ToList();

                        // 3. Получаем игры разработчика с отзывами
                        games = GetDeveloperGamesWithReviews(developerName);

                        developer = new Developer(
                            name,
                            email,
                            password,
                            regDate,
                            country,
                            applications,
                            games
                        );
                    }
                }
            }

            return developer;
        }

        private List<Game> GetDeveloperGamesWithReviews(string developerName)
        {
            var games = new List<Game>();

            // Сначала получаем все игры разработчика
            string gamesQuery = @"
SELECT 
    g.game_id,
    g.name,
    g.size,
    g.price,
    g.genre
FROM games g
JOIN developers d ON g.developer_id = d.developer_id
WHERE d.name = @devName";

            var gameIdToGameMap = new Dictionary<int, Game>();

            using (var cmd = new NpgsqlCommand(gamesQuery, conn))
            {
                cmd.Parameters.AddWithValue("devName", developerName);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int gameId = reader.GetInt32(reader.GetOrdinal("game_id"));
                        string name = reader.GetString(reader.GetOrdinal("name"));
                        float size = (float)reader.GetDouble(reader.GetOrdinal("size"));
                        float price = (float)reader.GetDouble(reader.GetOrdinal("price"));
                        string genre = reader.GetString(reader.GetOrdinal("genre"));

                        var game = new Game(name, size, price, genre, new List<Review>());
                        games.Add(game);
                        gameIdToGameMap[gameId] = game;
                    }
                }
            }

            // Затем получаем все отзывы для этих игр
            if (gameIdToGameMap.Any())
            {
                string reviewsQuery = @"
SELECT 
    r.game_id,
    g.name AS game_name,
    gm.name AS gamer_name,
    r.rating,
    r.comment,
    r.reviewdate
FROM reviews r
JOIN games g ON r.game_id = g.game_id
JOIN gamers gm ON r.gamer_id = gm.gamer_id
WHERE g.game_id IN (" + string.Join(",", gameIdToGameMap.Keys) + ")";

                using (var cmd = new NpgsqlCommand(reviewsQuery, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int gameId = reader.GetInt32(reader.GetOrdinal("game_id"));
                        string gameName = reader.GetString(reader.GetOrdinal("game_name"));
                        string gamerName = reader.GetString(reader.GetOrdinal("gamer_name"));
                        float rating = (float)reader.GetDouble(reader.GetOrdinal("rating"));
                        string comment = reader.IsDBNull(reader.GetOrdinal("comment"))
                            ? null
                            : reader.GetString(reader.GetOrdinal("comment"));
                        DateTime reviewDate = reader.GetDateTime(reader.GetOrdinal("reviewdate"));

                        var review = new Review(gameName, gamerName, rating, comment, reviewDate);

                        if (gameIdToGameMap.TryGetValue(gameId, out var game))
                        {
                            game.Reviews.Add(review);
                        }
                    }
                }
            }

            return games;
        }

        public Gamer GetGamerByCredentials(NpgsqlConnection conn, string name, string password)
        {
            string query = "SELECT g.name, g.email, g.password, g.registrationdate, g.balance, c.name AS countryname, g.country_id " +
               "FROM gamers g " +
               "JOIN countries c ON g.country_id = c.country_id " +
               "WHERE g.name = @name AND g.password = @password";




            using (var cmd = new NpgsqlCommand(query, conn))
            {
                string gamerName;
                string email = "";
                string gamerPassword = "";
                DateTime registrationDate;
                decimal balance;
                string countryName;

                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("password", password);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Получаем данные из результата запроса
                        gamerName = reader.GetString(0);
                        countryName = reader.GetString(1);
                        countryName = reader.GetString(2);
                        registrationDate = reader.GetDateTime(3);
                        balance = reader.GetDecimal(4);
                        countryName = reader.GetString(5);

                    }
                    else
                    {
                        return null; // Геймер не найден
                    }
                }

                // Получаем страну (предположим, что у вас есть объект Country)
                Country country = new Country(countryName);

                // Создаем объект геймера
                List<Game> games = new List<Game>();
                GameLibrary gameLibrary = GetGameLibrary(conn, gamerName);  // Получаем библиотеку игр для этого геймера

                // Создаем объект геймера
                return new Gamer(gamerName, email, gamerPassword, registrationDate, country, balance, gameLibrary);
            }
        }


        private void BTNLogin_Click(object sender, EventArgs e)
        {
            string name = TBLoginMail.Text;
            string password = TBLoginPassword.Text;

            if (IsAdministrator(name, password))
            {
                var form = new AdministrationPanelForm();
                form.Show();
            }
            else if (IsDeveloper(name, password))
            {
                var form = new DeveloperPanelForm(GetFullDeveloper(name));
                form.Show();
            }
            else if (IsGamer(name, password))
            {
                // Получаем геймера по логину и паролю
                var gamer = GetGamerByCredentials(conn, name, password);

                if (gamer != null)
                {
                    // Создаем форму и передаем в нее объект геймера
                    var form = new ShopForm(gamer);  // Передаем геймера в форму
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Неверные логин или пароль.");
                }
            }
            else
            {
                MessageBox.Show("Неверные логин или пароль или вы забанены)");
            }
        }
        private bool IsAdministrator(string name, string password)
        {
            using var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM administrators WHERE name = @name AND password = @pass", conn);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("pass", password);
            return (long)cmd.ExecuteScalar() > 0;
        }

        private bool IsDeveloper(string name, string password)
        {
            using var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM developers WHERE name = @name AND password = @pass", conn);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("pass", password);
            return (long)cmd.ExecuteScalar() > 0;
        }

        private bool IsGamer(string name, string password)
        {
            using var cmd = new NpgsqlCommand(
                "SELECT COUNT(*) FROM gamers WHERE name = @name AND password = @pass AND NOT banned",
                conn);

            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("pass", password);

            return (long)cmd.ExecuteScalar() > 0;
        }

    }
}

