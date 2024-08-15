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


namespace IOOP_Assignment_Group10_.UserControls.CustomerUCs
{
    public partial class SearchRooms : UserControl
    {
        public SearchRooms(string n)
        {
            InitializeComponent();
            Name = n;
            Refreshtable();
        }

        private void AddResBtn_Click(object sender, EventArgs e)
        {
            if (ReservationGrid.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = ReservationGrid.SelectedRows[0];

                object value1 = selectedRow.Cells[0].Value;
                object value2 = selectedRow.Cells[3].Value;
                DateTime CheckInDate = DatePicker.Value.Date;
                DateTime CheckOutDate = DatePicker2.Value.Date;


                if (value1 != null && value1 is int && value2 != null && value2 is decimal)
                {
                    int roomNum = (int)value1;
                    decimal price = (decimal)value2;

                    TimeSpan stayDuration = CheckOutDate - CheckInDate;
                    int numberOfNights = stayDuration.Days;

                    decimal TotalCharges = numberOfNights * price;

                    if (roomNum > 0 && TotalCharges > 0)
                    {
                        Reservations r1 = new Reservations("ID", Name, roomNum, CheckInDate, CheckOutDate, TotalCharges, "Pending", "Uncompleted");
                        r1.AddReservation();
                        Refreshtable();
                    }
                    else
                        MessageBox.Show("Error: Unable to reserve room.");
                }
                else
                    MessageBox.Show("Error: Selected row is empty.");
            }
            else
                MessageBox.Show("Error: No room selected");
        }


        private void Refreshtable()
        {
            ReservationGrid.AutoGenerateColumns = false;
            ReservationGrid.Columns.Clear();
            ReservationGrid.Columns.Add("RoomNum", "RoomNum");
            ReservationGrid.Columns.Add("RoomType", "RoomType");
            ReservationGrid.Columns.Add("Amenities", "Amenities");
            ReservationGrid.Columns.Add("Price", "Price");
            ReservationGrid.Columns.Add("RoomDetails", "RoomDetails");
            ReservationGrid.Columns.Add("Status", "Status");

            List<Room> allRooms = Room.viewAll();
            var available = allRooms.Where(r => r.Status == "Available").ToList();

            foreach (Room rooms in available)
            {
                ReservationGrid.Rows.Add(rooms.RoomNum, rooms.RoomType, rooms.Amenities, rooms.Price, rooms.RoomDetails, rooms.Status);
            }
        }
        private void SearchGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
