using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace GameLibraryDA
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            CBRegistrationCountry.Items.Clear();

            using (var cmd = new NpgsqlCommand("SELECT Name FROM Countries ORDER BY Name", LoginForm.conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    CBRegistrationCountry.Items.Add(reader.GetString(0));
                }
            }
        }

        private void BTNCreateAccount_Click(object sender, EventArgs e)
        {
            string username = TBRegistrationLogin.Text;
            string email = TBRegistrationMail.Text;
            string password = TBRegistrationPassword.Text;
            string nationality = CBRegistrationCountry.Text; // Название страны из ComboBox

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(nationality))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            // Получаем ID страны по названию
            int countryId = -1;
            using (var cmd = new NpgsqlCommand("SELECT country_id FROM countries WHERE name = @name", LoginForm.conn))
            {
                cmd.Parameters.AddWithValue("name", nationality);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        countryId = reader.GetInt32(0);
                    }
                    else
                    {
                        MessageBox.Show("Страна не найдена.");
                        return;
                    }
                }
            }

            // Вставляем нового геймера
            using (var cmd = new NpgsqlCommand(@"
    INSERT INTO gamers (country_id, name, email, password, registrationdate, balance)
    VALUES (@country_id, @name, @email, @password, CURRENT_DATE, @balance)", LoginForm.conn))
            {
                cmd.Parameters.AddWithValue("country_id", countryId);
                cmd.Parameters.AddWithValue("name", username);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("password", password); // Лучше хешировать!
                cmd.Parameters.AddWithValue("balance", 0.0m); // Стартовый баланс

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Аккаунт успешно создан!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при создании аккаунта: " + ex.Message);
                }
            }


        }
    }
}
