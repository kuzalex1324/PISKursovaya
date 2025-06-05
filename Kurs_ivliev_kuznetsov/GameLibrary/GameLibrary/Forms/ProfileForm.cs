using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLibraryDA.Forms;

namespace GameLibraryDA
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
            foreach (var game in ShopForm.CurrentGamer.GameLibrary.Games)
            {
                listView1.Items.Add(game.Name);
            }
            LabelCountry.Text = ShopForm.CurrentGamer.Country.Name;
            LabelUserName.Text = ShopForm.CurrentGamer.Name;
        }

        private void BTNEditForm_Click(object sender, EventArgs e)
        {
            ReductForm reductForm = new ReductForm();
            reductForm.ShowDialog();
            LabelCountry.Text = ShopForm.CurrentGamer.Country.Name;
            LabelUserName.Text = ShopForm.CurrentGamer.Name;
        }
    }
}
