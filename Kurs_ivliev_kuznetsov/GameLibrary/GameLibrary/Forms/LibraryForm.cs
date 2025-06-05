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
    public partial class LibraryForm : Form
    {
        public static Game crntgame;
        public LibraryForm()
        {
            InitializeComponent();
            foreach (var game in ShopForm.CurrentGamer.GameLibrary.Games)
            {
                LVGames.Items.Add(game.Name);
            }
            if (LVGames.SelectedItems.Count <= 0)
            {
                return;
            }
            LVGames.Items[0].Selected = true;
            LVGames.Select();
        }

        private void BTNWriteFeedback_Click(object sender, EventArgs e)
        {
            FeedBackForm feedbackForm = new FeedBackForm();
            feedbackForm.ShowDialog();
            LVGames.Items.Clear();
            foreach (var game in ShopForm.CurrentGamer.GameLibrary.Games)
            {
                LVGames.Items.Add(game.Name);
            }
            if (LVGames.SelectedItems.Count <= 0)
            {
                return;
            }
            LVGames.Items[0].Selected = true;
            LVGames.Select();
        }



        private void LVGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LVGames.SelectedItems.Count <= 0)
            {
                return;
            }

            Game game = ShopForm.CurrentGamer.GameLibrary.Games.FirstOrDefault(g => g.Name == LVGames.SelectedItems[0].Text);
            crntgame = game;
            if (game.Name == "Assassins Creed")
            {
                PBCurrentGame.Image = GameLibraryDA.Properties.Resources.AC2_1;
            }
            else if (game.Name == "Fortnite")
            {
                PBCurrentGame.Image = GameLibraryDA.Properties.Resources.FP1;
            }
            else
            {
                PBCurrentGame.Image = GameLibraryDA.Properties.Resources.error;
            }
            LabelNeedGB.Text = game.Size.ToString() + " ГБ";
            string query = @"
            SELECT gl.addeddate, gl.hoursplayed
            FROM gamerlibrary gl
            JOIN gamers g ON gl.gamer_id = g.gamer_id
            JOIN games ga ON gl.game_id = ga.game_id
            WHERE g.name = @gamerName AND ga.name = @gameName";

            using (var command = new NpgsqlCommand(query, LoginForm.conn))
            {
                command.Parameters.AddWithValue("@gamerName", ShopForm.CurrentGamer.Name);
                command.Parameters.AddWithValue("@gameName", game.Name);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        DateTime addedDate = reader.GetDateTime(0);
                        int hoursPlayed = reader.GetInt32(1);
                        LabelGameHours.Text = hoursPlayed.ToString();
                        LabelLastStart.Text = addedDate.ToString().Substring(0, 10);

                    }
                }
            }

            LVFeedbacks.Items.Clear();

            foreach (var review in game.Reviews)
            {
                LVFeedbacks.Items.Add(review.GamerName + "            " + review.Comment + "            " + review.Rating + "/10" + "            " + review.ReviewDate.ToString().Substring(0, 10));
            }

        }

        private void BTNInstallGame_Click(object sender, EventArgs e)
        {
            if (BTNInstallGame.Text == "↓ Установить")
            {
                MessageBox.Show("Игра установлена!");
                BTNInstallGame.Text = "x Удалить";
            }
            else
            {
                MessageBox.Show("Игра удалена!");
                BTNInstallGame.Text = "↓ Установить";
            }



        }

        private void BTNStart_Click(object sender, EventArgs e)
        {
            string frame1 = @"
                      O     O
                     /|\   /|\
                     / \   / \
                    ";
            MessageBox.Show(frame1);
        }
    }
}
