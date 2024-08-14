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

        private Color highlight = ColorTranslator.FromHtml("#0066cc");
        private Color defaultColor = Color.Navy;
        private Button[] buttons;

        public HousekeepingPage(string n)
        {
            InitializeComponent();
            Name = n;
            RoomCSCH_HK rcsch = new RoomCSCH_HK(Name);
            addUserControl(rcsch);

            buttons = new Button[] { RoomCSCHBtn, URRBtn, RoomClnsBtn, ClnSuppsBtn, UpdateProfileHKBtn, LOBtn_HK};

            foreach (Button btn in buttons)
            {
                btn.Click += Button_Click;
            }

            HighlightButton(RoomCSCHBtn);
        }

        private void Button_Click(object? sender, EventArgs e)
        {

            if (sender is Button clickedButton)
            {
                // Reset all buttons to default color
                foreach (Button btn in buttons)
                {
                    btn.BackColor = defaultColor;
                }

                // Highlight the clicked button
                HighlightButton(clickedButton);
            }

        }

        private void HighlightButton(Button button)
        {
            button.BackColor = highlight;
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
            UpdateProfile_HK up = new UpdateProfile_HK(Name);
            addUserControl(up);
        }
    }
}
