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
            InitializeReservationsTBL();
        }

        private void lblPayable_Click(object sender, EventArgs e)
        {

        }
        private void InitializeReservationsTBL()
        {
            ReservationsTBL.Columns.Clear();

            ReservationsTBL.Columns.Add("resID", "Reservation ID");
            ReservationsTBL.Columns.Add("username", "Username");
            ReservationsTBL.Columns.Add("roomNum", "Room Number");
            ReservationsTBL.Columns.Add("checkinDate", "Check-in Date");
            ReservationsTBL.Columns.Add("checkoutDate", "Check-out Date");
            ReservationsTBL.Columns.Add("totalCharges", "Total Charges");
            ReservationsTBL.Columns.Add("status", "Status");
            ReservationsTBL.Columns.Add("payment", "Payment");
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {

            string resID = txtResID.Text.Trim();

            if (!string.IsNullOrEmpty(resID))
            {
                List<Reservations> result = Reservations.SearchReservationByResID(resID);
                DisplayReservations(result);
            }
            else
            {
                MessageBox.Show("Please enter a Reservation ID to search.");
            }

        }
        private void DisplayReservations(List<Reservations> reservations)
        {
            ReservationsTBL.Rows.Clear();

            foreach (var res in reservations)
            {
                ReservationsTBL.Rows.Add(res.ResID, res.Username, res.RoomNum, res.CheckinDate, res.CheckoutDate, res.TotalCharges, res.Status, res.Payment);
            }
        }
    }
}
