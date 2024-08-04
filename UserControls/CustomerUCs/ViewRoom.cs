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

namespace IOOP_Assignment_Group10_.UserControls.CustomerUCs
{
    public partial class ViewRoom : UserControl
    {
        public ViewRoom()
        {
            InitializeComponent();
            RefreshTable();
        }

        private void RefreshTable()
        {
            ViewRoomTable.AutoGenerateColumns = false;
            ViewRoomTable.Columns.Clear();
            ViewRoomTable.Columns.Add("RoomNum", "RoomNum");
            ViewRoomTable.Columns.Add("RoomType", "RoomType");
            ViewRoomTable.Columns.Add("Amenities", "Amenities");
            ViewRoomTable.Columns.Add("Price", "Price");
            ViewRoomTable.Columns.Add("RoomDetails", "RoomDetails");
            ViewRoomTable.Columns.Add("Status", "Status");

            List<Room> rooms = Room.viewAll();

            foreach (Room room in rooms)
            {
                ViewRoomTable.Rows.Add(room.RoomNum, room.RoomType, room.Amenities, room.Price, room.RoomDetails, room.Status);
            }
        }


        private void ViewRoomTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
