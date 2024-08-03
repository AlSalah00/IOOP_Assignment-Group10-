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
    public partial class CheckOutCUS : UserControl
    {
        public CheckOutCUS()
        {
            InitializeComponent();
            RefreshTable();
        }
        private void RefreshTable()
        {
            pendingReservationsTBL.AutoGenerateColumns = false;
            pendingReservationsTBL.Columns.Clear();
            pendingReservationsTBL.Columns.Add("resID", "resID");
            pendingReservationsTBL.Columns.Add("username", "username");
            pendingReservationsTBL.Columns.Add("roomNum", "roomNum");
            pendingReservationsTBL.Columns.Add("checkInDate", "checkInDate");
            pendingReservationsTBL.Columns.Add("checkOutDate", "checkOutDate");
            pendingReservationsTBL.Columns.Add("totalCharges", "totalCharges");
            pendingReservationsTBL.Columns.Add("status", "status");
            pendingReservationsTBL.Columns.Add("payment", "payment");

            List<Reservations> allres = Reservations.ViewAllReservations();
            var pending = allres.Where(u => u.Status == "Pending").ToList();

            foreach (Reservations reservations in pending)
            {
                pendingReservationsTBL.Rows.Add(reservations.ResID, reservations.Username, reservations.RoomNum, reservations.CheckinDate, reservations.CheckoutDate, reservations.TotalCharges, reservations.Status, reservations.Payment);
            }
        }

        private void ChekoutLBL_Click(object sender, EventArgs e)
        {
            if (pendingReservationsTBL.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = pendingReservationsTBL.SelectedRows[0];

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
 
    }
}
