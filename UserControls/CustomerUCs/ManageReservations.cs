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
    public partial class ManageReservations : UserControl
    {
        public ManageReservations(string n)
        {
            InitializeComponent();
            Name = n;
            RefreshTable();
        }

        private void RefreshTable()
        {
            ReservationsTable.AutoGenerateColumns = false;
            ReservationsTable.Columns.Clear();
            ReservationsTable.Columns.Add("resID", "resID");
            ReservationsTable.Columns.Add("username", "username");
            ReservationsTable.Columns.Add("roomNum", "roomNum");
            ReservationsTable.Columns.Add("checkInDate", "checkInDate");
            ReservationsTable.Columns.Add("checkOutDate", "checkOutDate");
            ReservationsTable.Columns.Add("totalCharges", "totalCharges");
            ReservationsTable.Columns.Add("status", "status");
            ReservationsTable.Columns.Add("payment", "payment");

            List<Reservations> allres = Reservations.ViewAllReservations();
            var pending = allres.Where(u => u.Status == "Pending" && u.Username == Name).ToList();

            foreach (Reservations reservations in pending)
            {
                ReservationsTable.Rows.Add(reservations.ResID, reservations.Username, reservations.RoomNum, reservations.CheckinDate, reservations.CheckoutDate, reservations.TotalCharges, reservations.Status, reservations.Payment);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (ReservationsTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ReservationsTable.SelectedRows[0];

                object value = selectedRow.Cells[0].Value;
                object value2 = selectedRow.Cells[0].Value;

                if (value != null && value is string strValue && value2 != null && value2 is decimal)
                {
                    string resID = strValue;
                    decimal total = (decimal)value2;
                    DateTime checkin = CheckInDatePicker.Value.Date;
                    DateTime checkOut = CheckOutPicker.Value.Date;

                    if (!string.IsNullOrEmpty(resID))
                    {
                        Reservations res = new Reservations(resID);
                        res.EditReservation(checkin, checkOut, total);
                        RefreshTable();
                    }
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (ReservationsTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ReservationsTable.SelectedRows[0];

                object value = selectedRow.Cells[0].Value;

                if (value != null && value is string strValue)
                {
                    string resID = strValue;


                    if (!string.IsNullOrEmpty(resID))
                    {
                        Reservations res = new Reservations(resID);
                        res.deleteReservation();
                    }
                }
            }
        }
    }

}


