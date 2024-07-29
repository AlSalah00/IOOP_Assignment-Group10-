using System;
using System.Collections;
using System.Collections.Generic;
using IOOP_Assignment_Group10_.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IOOP_Assignment_Group10_.UserControls.ManagerUCs
{
    public partial class RoomCSH : UserControl
    {
        public RoomCSH()
        {
            InitializeComponent();
            RefreshList();
        }

        private void RefreshList()
        {
            List<Room> rooms = Room.viewAll();

            List<int> roomNumbers = rooms.Select(r => r.RoomNum).ToList();
            roomNumbers.Sort();
            lstRoomNum.DataSource = roomNumbers;

            List<User> allUsers = User.viewAll();
            var housekeepers = allUsers.Where(u => u.Role == "Housekeeper").ToList();

            lstHousekeeper.Items.Clear();
            foreach (var user in housekeepers)
            {
                lstHousekeeper.Items.Add(user.Username);
            }
        }
        private void AssignBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
