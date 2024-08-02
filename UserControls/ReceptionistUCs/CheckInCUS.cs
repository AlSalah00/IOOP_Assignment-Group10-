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
    public partial class CheckInCUS : UserControl
    {
        public CheckInCUS()
        {
            InitializeComponent();
            RefreshTable();
        }
        private void RefreshTable()
        {
            ReservationsTBL.AutoGenerateColumns = false;
            ReservationsTBL.Columns.Clear();
           // ReservationsTBL.Columns.Add("resID", "resID");
            ReservationsTBL.Columns.Add("username", "username");
            ReservationsTBL.Columns.Add("roomNum", "roomNum");
            ReservationsTBL.Columns.Add("checkInDate", "checkInDate");
            ReservationsTBL.Columns.Add("checkOutDate", "checkOutDate");
            ReservationsTBL.Columns.Add("totalCharges", "totalCharges");
            ReservationsTBL.Columns.Add("status", "status");
            // List<User> allUsers = User.viewAll();
            //var Customer = allUsers.Where(u => u.Role == "Customer").ToList();
            //foreach (User user in Customer)
            //{
             //   UsersTable.Rows.Add(user.Username, user.Password, user.Email);
            //}
       // }
        List<Reservations> allres = Reservations.ViewAllReservations();
            var pending = allres.Where(u => u.Status == "pending").ToList();

            foreach (Reservations reservations in pending)
            {
                ReservationsTBL.Rows.Add( reservations.Username, reservations.RoomNum, reservations.CheckinDate,reservations.CheckoutDate, reservations.TotalCharges,reservations.Status);
            }
        }
    }
}
