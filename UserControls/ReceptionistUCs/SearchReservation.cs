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

namespace IOOP_Assignment_Group10_.UserControls.ReceptionistUCs
{
    public partial class SearchReservation : UserControl
    {
        public SearchReservation()
        {
            InitializeComponent();
        }

        private void lblPayable_Click(object sender, EventArgs e)
        {

        }
        private void RefreshTable()
        {
            ReservationsTable.AutoGenerateColumns = false;
            ReservationsTable.Columns.Clear();
            ReservationsTable.Columns.Add("resID", "Reservation ID");
            ReservationsTable.Columns.Add("username", "Username");
            ReservationsTable.Columns.Add("roomNum", "Room Number");
            ReservationsTable.Columns.Add("checkinDate", "Check-in Date");
            ReservationsTable.Columns.Add("checkoutDate", "Check-out Date");
            ReservationsTable.Columns.Add("totalCharges", "Total Charges");
            ReservationsTable.Columns.Add("status", "Status");
            ReservationsTable.Columns.Add("payment", "Payment");

            string username = txtCusName.Text;
            int rn = 0;     

            List<Reservations> allRes = Reservations.ViewAllReservations();

            if (username != null)
            {
                var res = allRes.Where(r => r.Username == username);

                foreach (Reservations reservations in res)
                {
                    ReservationsTable.Rows.Add(reservations.ResID, reservations.Username, reservations.RoomNum, reservations.CheckinDate, reservations.CheckoutDate, reservations.TotalCharges, reservations.Status, reservations.Payment);
                }
            }

            if (int.TryParse(txtRoomNum.Text, out rn))
            {
                int roomNum = rn;

                if (roomNum > 0)
                {
                    var res2 = allRes.Where(r => r.RoomNum == roomNum);

                    foreach (Reservations reservations in res2)
                    {
                        ReservationsTable.Rows.Add(reservations.ResID, reservations.Username, reservations.RoomNum, reservations.CheckinDate, reservations.CheckoutDate, reservations.TotalCharges, reservations.Status, reservations.Payment);
                    }

                }
            }

        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtCusName.Text) ||
                !string.IsNullOrEmpty(txtRoomNum.Text))
            {
                RefreshTable();
                txtCusName.Clear();
                txtRoomNum.Clear();
            }
            else
                MessageBox.Show("Please fill the field.");

        }
       
    }
}
