using IOOP_Assignment_Group10_.UserControls.HousekeepingUCs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment_Group10_.Forms
{
    public partial class HousekeepingPage : Form
    {
        public HousekeepingPage(string n)
        {
            InitializeComponent();
            Name = n;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //ignore this.
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            HousekeepingPanel.Controls.Clear();
            HousekeepingPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void HousekeepingPage_Load(object sender, EventArgs e)
        {
            lblIdentityHK.Text = $"Welcome, {Name}";
        }

        private void LOBtn_HK_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage login = new LoginPage();
            login.ShowDialog();
        }

        private void RoomCSCHBtn_Click(object sender, EventArgs e)
        {
            RoomCSCH_HK rcsch = new RoomCSCH_HK(Name);
            addUserControl(rcsch);
        }

        private void URRBtn_Click(object sender, EventArgs e)
        {
            UpcomingReservations urr = new UpcomingReservations();
            addUserControl(urr);
        }

        private void RoomClnsBtn_Click(object sender, EventArgs e)
        {
            RoomCleanliness rcln = new RoomCleanliness(Name);
            addUserControl(rcln);
        }

        private void ClnSuppsBtn_Click(object sender, EventArgs e)
        {
            ManageCleaningSupps mcsp = new ManageCleaningSupps();
            addUserControl(mcsp);
        }

        private void UpdateProfileHKBtn_Click(object sender, EventArgs e)
        {
            UpdateProfile_HK up = new UpdateProfile_HK();
            addUserControl(up);
        }
    }
}
