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

namespace IOOP_Assignment_Group10_.UserControls.HousekeepingUCs
{
    public partial class RoomCleanliness : UserControl
    {
        public RoomCleanliness(string n)
        {
            InitializeComponent();
            Name = n;
            RefreshTable();
        }

        private void RefreshTable()
        {
            RoomsTBL.AutoGenerateColumns = false;
            RoomsTBL.Columns.Clear();
            RoomsTBL.Columns.Add("RoomNum", "RoomNum");
            RoomsTBL.Columns.Add("Status", "Status");
            RoomsTBL.Columns.Add("Issues", "Issues");

            List<CleaningSchedule> allSchedules = CleaningSchedule.viewAll();

            var userSchedules = allSchedules.Where(schedule => schedule.Username == Name);

            RoomsTBL.Rows.Clear();
            foreach (var schedule in userSchedules)
            {
                RoomsTBL.Rows.Add(schedule.RoomNum, schedule.Status, schedule.Issues);
            }
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            string issues = txtIssues.Text;
            string status;

            if (CleanRB.Checked == true)
            {
                status = "Clean";
            }
            else
                status = "Dirty";


            if (string.IsNullOrEmpty(issues))
            {
                issues = "None";
            }

            if (RoomsTBL.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = RoomsTBL.SelectedRows[0];

                object value = selectedRow.Cells[0].Value;

                if (value != null && value is int)
                {

                    int roomNum = (int)value;

                    if (roomNum > 0)
                    {
                        CleaningSchedule csch = new CleaningSchedule(roomNum);
                        csch.updateRoomCleanliness(status, issues);
                        RefreshTable();
                    }
                    else
                        MessageBox.Show("Error: Unable to update room cleanliness.");
                }
                else
                    MessageBox.Show("Error: Selected row is empty.");
            }
            else
                MessageBox.Show("Error: No room selected.");

            txtIssues.Clear();
        }
    }
}
