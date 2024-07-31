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
    public partial class RoomOccupancy : UserControl
    {
        public RoomOccupancy()
        {
            InitializeComponent();
            RefreshTable();
        }

        private void RefreshTable()
        {
            RoomOccupancyTable.AutoGenerateColumns = false;
            RoomOccupancyTable.Columns.Add("RoomNum", "RoomNum");
            RoomOccupancyTable.Columns.Add("Status", "Status");

            List<Room> rooms = Room.viewAll();
            foreach (Room room in rooms)
            {
                RoomOccupancyTable.Rows.Add(room.RoomNum, room.Status);
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
