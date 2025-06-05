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

namespace GameLibraryDA.Forms
{
    public partial class ReductForm : Form
    {
        public ReductForm()
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
            if (TBRegistrationLogin.Text == "")
            {
                MessageBox.Show("Имя не может быть пустым");
                return;
            }
            else
            {
                string nameee = TBRegistrationLogin.Text;
                string cntry = CBRegistrationCountry.SelectedItem.ToString();
                string query = @"
                    UPDATE gamers
                    SET name = @newName,
                        country_id = (SELECT country_id FROM countries WHERE name = @newCountry)
                    WHERE name = @oldName";

                using (var cmd = new NpgsqlCommand(query, LoginForm.conn))
                {
                    cmd.Parameters.AddWithValue("newName", nameee);        
                    cmd.Parameters.AddWithValue("newCountry", cntry);  
                    cmd.Parameters.AddWithValue("oldName", ShopForm.CurrentGamer.Name);        

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Данные изменены");
                ShopForm.CurrentGamer.Country.Name = cntry;
                ShopForm.CurrentGamer.Name = nameee;
                Close();
            }
        }
    }
}
