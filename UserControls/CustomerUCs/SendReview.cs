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

namespace IOOP_Assignment_Group10_.UserControls.CustomerUCs
{
    public partial class SendReview : UserControl
    {
        public SendReview(string n)
        {
            InitializeComponent();
            Name = n;
            RefreshTable();
        }

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
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
            var checkedout = allres.Where(u => u.Status == "Checked-out" && u.Username == Name).ToList();

            foreach (Reservations reservations in checkedout)
            {
                ReservationsTable.Rows.Add(reservations.ResID, reservations.Username, reservations.RoomNum, reservations.CheckinDate, reservations.CheckoutDate, reservations.TotalCharges, reservations.Status, reservations.Payment);
            }
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
           // ignore
        }

        private void SendBtn_Click_1(object sender, EventArgs e)
        {
            string rating = "";

            if (Rate1RB.Checked)
            {
                rating = "1 Star";
            }
            else if (Rate2RB.Checked)
            {
                rating = "2 Stars";
            }
            else if (Rate3RB.Checked)
            {
                rating = "3 Stars";
            }
            else if (Rate4RB.Checked)
            {
                rating = "4 Stars";
            }
            else if (Rate5RB.Checked)
            {
                rating = "5 Stars";
            }
            else
            {
                rating = "0 Stars";
            }

            string review = txtReview.Text;

            if (string.IsNullOrEmpty(review))
            {
                review = "None";
            }

            if (ReservationsTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ReservationsTable.SelectedRows[0];

                object value = selectedRow.Cells[0].Value;

                if (value != null && value is string strValue)
                {
                    string resID = strValue;


                    if (!string.IsNullOrEmpty(resID) &&
                        !string.IsNullOrEmpty(rating))
                    {
                        Review r1 = new Review(resID, Name, rating, review);
                        r1.addReview();
                    }

                }
                else
                    MessageBox.Show("Error: An unexpected error occurred.");
            }
        }
    }
}
