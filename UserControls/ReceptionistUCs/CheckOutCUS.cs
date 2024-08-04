using IOOP_Assignment_Group10_.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment_Group10_.UserControls.ReceptionistUCs
{
    public partial class CheckOutCUS : UserControl
    {
        public CheckOutCUS()
        {
            InitializeComponent();
            RefreshTable();
        }
        private void RefreshTable()
        {
            ReservationsTBL.AutoGenerateColumns = false;
            ReservationsTBL.Columns.Clear();
            ReservationsTBL.Columns.Add("resID", "resID");
            ReservationsTBL.Columns.Add("username", "username");
            ReservationsTBL.Columns.Add("roomNum", "roomNum");
            ReservationsTBL.Columns.Add("checkInDate", "checkInDate");
            ReservationsTBL.Columns.Add("checkOutDate", "checkOutDate");
            ReservationsTBL.Columns.Add("totalCharges", "totalCharges");
            ReservationsTBL.Columns.Add("status", "status");
            ReservationsTBL.Columns.Add("payment", "payment");

            List<Reservations> allres = Reservations.ViewAllReservations();
            var checkedIn = allres.Where(u => u.Status == "Checked-in" || u.Status == "Checked-out" && u.Payment == "Uncompleted").ToList();

            foreach (Reservations reservations in checkedIn)
            {
                ReservationsTBL.Rows.Add(reservations.ResID, reservations.Username, reservations.RoomNum, reservations.CheckinDate, reservations.CheckoutDate, reservations.TotalCharges, reservations.Status, reservations.Payment);
            }
        }

        private void CheckOutBtn_Click(object sender, EventArgs e)
        {
            if (ReservationsTBL.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ReservationsTBL.SelectedRows[0];

                object value = selectedRow.Cells[0].Value;
                object value2 = selectedRow.Cells[2].Value;

                if (value != null && value is string strValue && value2 != null && value2 is int)
                {
                    string resID = strValue;
                    int roomNum = (int)value2;

                    if (!string.IsNullOrEmpty(resID))
                    {
                        Reservations res = new Reservations(resID, roomNum);
                        res.checkOutCustomer("Checked-out", "Available");
                        RefreshTable();
                    }
                    else
                        MessageBox.Show("Error: Unable to check-in.");
                }
                else
                    MessageBox.Show("Error: Selected row is empty.");
            }
            else
                MessageBox.Show("Error: No reservation selected.");
        }

        private void paymentBTN_Click(object sender, EventArgs e)
        {
            if (ReservationsTBL.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ReservationsTBL.SelectedRows[0];

                object value = selectedRow.Cells[0].Value;
                object value2 = selectedRow.Cells[5].Value;

                if (value2 != null && value2 is decimal && value != null && value is string strValue)
                {

                    string resID = strValue.ToString();
                    decimal payment = (decimal)value2;

                    if (payment > 0)
                    {
                        Reservations res = new Reservations(resID);
                        res.updateProfit(payment);
                        res.collectPayment("Completed");
                        RefreshTable();
                    }
                    else
                        MessageBox.Show("Error: Unable to update profit.");
                }
                else
                    MessageBox.Show("Error: Selected row is empty.");
            }
            else
                MessageBox.Show("Error: No reservation selected.");
        }
       
    }
}
