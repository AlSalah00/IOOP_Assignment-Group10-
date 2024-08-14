using IOOP_Assignment_Group10_.UserControls.CustomerUCs;
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
    public partial class CustomerPage : Form
    {

        private Color highlight = ColorTranslator.FromHtml("#0066cc");
        private Color defaultColor = Color.Navy;
        private Button[] buttons;

        public CustomerPage(string n)
        {
            InitializeComponent();
            Name = n;
            SearchRooms sr = new SearchRooms(Name);
            addUserControl(sr);

            buttons = new Button[] { searchRoomBtn, RoomDTLBtn, MNGReservationBtn, RVRTBtn, UpdateProfileBtnCus, LOBtn_Cus,};

            foreach (Button btn in buttons)
            {
                btn.Click += Button_Click;
            }

            HighlightButton(searchRoomBtn);
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

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            CustomerPanel.Controls.Clear();
            CustomerPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {
            lblIdentityCus.Text = $"Welcome, {Name}";
        }

        private void LOBtn_Cus_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage login = new LoginPage();
            login.ShowDialog();
        }

        private void searchRoomBtn_Click(object sender, EventArgs e)
        {
            SearchRooms sr = new SearchRooms(Name);
            addUserControl(sr);
        }

        private void RoomDTLBtn_Click(object sender, EventArgs e)
        {
            ViewRoom vr = new ViewRoom();
            addUserControl(vr);
        }

        private void MNGReservationBtn_Click(object sender, EventArgs e)
        {
            ManageReservations mr = new ManageReservations(Name);
            addUserControl(mr);
        }

        private void RVRTBtn_Click(object sender, EventArgs e)
        {
            SendReview sr = new SendReview(Name);
            addUserControl(sr);
        }

        private void UpdateProfileBtnCus_Click(object sender, EventArgs e)
        {
            UpdateProfileCus upc = new UpdateProfileCus(Name);
            addUserControl(upc);
        }
    }
}
