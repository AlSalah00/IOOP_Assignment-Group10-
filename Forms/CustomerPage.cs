using IOOP_Assignment_Group10_.UserControls;
using IOOP_Assignment_Group10_.UserControls.CustomerUCs;
using IOOP_Assignment_Group10_.UserControls.ManagerUCs;
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
        public CustomerPage()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            CustomerPanel.Controls.Clear();
            CustomerPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchRooms sr = new SearchRooms();
            addUserControl(sr);

        }

        private void addUserControl(SearchRooms sr)
        {
            throw new NotImplementedException();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            View_room_details vr = new View_room_details();
            addUserControl(vr);
        }

        private void ManageResBtn_Click(object sender, EventArgs e)
        {
            Manage_reservations mr = new Manage_reservations();
            addUserControl(mr);
        }

        private void SendRevBtn_Click(object sender, EventArgs e)
        {
            SendReview sr = new SendReview();
            addUserControl(sr);
        }

        private void Update3Btn_Click(object sender, EventArgs e)
        {
            UpdateProfile3 up = new UpdateProfile3();
            addUserControl(up);
        }
    }
}
