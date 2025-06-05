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
    public partial class DeveloperPanelForm : Form
    {
        public static Developer dev;

        public DeveloperPanelForm(Developer developer)
        {
            InitializeComponent();
            dev = developer;
            dev_name.Text = dev.Name;
            foreach (var app in developer.ActiveApplications)
            {
                LVApps.Items.Add(app.ToString());
            }
        }

        private void BTNLoadFiles_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Файлы загружены!");
        }
        public void CreateApplicationForDeveloper(string developerName)
        {
            // 1. Сначала получаем developer_id по имени разработчика
            int developerId;
            string getDeveloperIdQuery = @"
SELECT developer_id 
FROM developers 
WHERE name = @devName";

            using (var cmd = new NpgsqlCommand(getDeveloperIdQuery, LoginForm.conn))
            {
                cmd.Parameters.AddWithValue("devName", developerName);
                developerId = (int)cmd.ExecuteScalar();
            }

            // 2. Генерируем случайный administrator_id от 1 до 5
            Random random = new Random();
            int randomAdminId = random.Next(1, 6); // MaxValue is exclusive

            // 3. Создаем заявку с пустым reason (не NULL)
            string createApplicationQuery = @"
INSERT INTO applications (
    ischecked, 
    createddate, 
    developer_id, 
    administrator_id, 
    reason
) 
VALUES (
    false, 
    CURRENT_DATE, 
    @developerId, 
    @adminId, 
    ''
)";

            using (var cmd = new NpgsqlCommand(createApplicationQuery, LoginForm.conn))
            {
                cmd.Parameters.AddWithValue("developerId", developerId);
                cmd.Parameters.AddWithValue("adminId", randomAdminId);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    throw new Exception("Не удалось создать заявку");
                }
            }
        }

        private void BTNSubmitRequest_Click(object sender, EventArgs e)
        {
            CreateApplicationForDeveloper(dev.Name);
            
            MessageBox.Show("Заявка создана");
        }
    }
}
