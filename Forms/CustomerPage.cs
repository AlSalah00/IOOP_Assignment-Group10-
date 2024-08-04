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
        public CustomerPage(string n)
        {
            InitializeComponent();
            Name = n;
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
            ManageReservations mr = new ManageReservations();
            addUserControl(mr);
        }

        private void RVRTBtn_Click(object sender, EventArgs e)
        {
            SendReview sr = new SendReview();
            addUserControl(sr);
        }

        private void UpdateProfileBtnCus_Click(object sender, EventArgs e)
        {
            UpdateProfileCus upc = new UpdateProfileCus();
            addUserControl(upc);
        }
    }
}
