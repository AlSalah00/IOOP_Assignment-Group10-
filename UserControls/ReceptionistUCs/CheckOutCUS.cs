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
            var pending = allres.Where(u => u.Status == "Pending").ToList();

            foreach (Reservations reservations in pending)
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
                        res.checkOutCustomer("Checked-out", "available");
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

                string resID = selectedRow.Cells["resID"].Value?.ToString();
                decimal totalCharges = Convert.ToDecimal(selectedRow.Cells["totalCharges"].Value);

                if (!string.IsNullOrEmpty(resID))
                {
                    var reservations = Reservations.SearchReservationByResID(resID);
                    var res = reservations.FirstOrDefault();

                    if (res != null)
                    {
                        res.collectPayment("Collected");
                        AddToProfitTable(totalCharges);
                        RefreshTable();
                    }
                    else
                    {
                        MessageBox.Show("Error: Reservation not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Error: Reservation ID is missing.");
                }
            }
            else
            {
                MessageBox.Show("Error: No reservation selected.");
            }
        }
        private void AddToProfitTable(decimal totalCharges)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                con.Open();
                string query = "INSERT INTO ProfitTable (amount, date) VALUES (@amount, @date)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@amount", totalCharges);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Profit updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Error: Failed to update profit.");
                    }
                }
            }
        }
    }
}
