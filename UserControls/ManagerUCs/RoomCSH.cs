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

namespace IOOP_Assignment_Group10_.UserControls.ManagerUCs
{
    public partial class RoomCSH : UserControl
    {
        public RoomCSH()
        {
            InitializeComponent();
            RefreshList();
            RefreshTable();
        }

        private void RefreshList()
        {
            List<Room> rooms = Room.viewAll();

            List<int> roomNumbers = rooms.Select(r => r.RoomNum).ToList();
            roomNumbers.Sort();
            lstRoomNum.DataSource = roomNumbers;

            List<User> allUsers = User.viewAll();
            var housekeepers = allUsers.Where(u => u.Role == "Housekeeper").ToList();

            lstHousekeeper.Items.Clear();
            foreach (var user in housekeepers)
            {
                lstHousekeeper.Items.Add(user.Username);
            }
        }

        private void RefreshTable()
        {
            CleaningScheduleTable.AutoGenerateColumns = false;
            CleaningScheduleTable.Columns.Clear();
            CleaningScheduleTable.Columns.Add("Housekeeper", "Housekeeper");
            CleaningScheduleTable.Columns.Add("RoomNum", "RoomNum");
            CleaningScheduleTable.Columns.Add("Date", "Date");

            List<CleaningSchedule> schedules = CleaningSchedule.viewAll();

            foreach (CleaningSchedule schedule in schedules)
            {
                CleaningScheduleTable.Rows.Add(schedule.Username, schedule.RoomNum, schedule.Date);
            }
        }
        private void AssignBtn_Click(object sender, EventArgs e)
        {
            if (lstRoomNum.SelectedItem != null && lstHousekeeper.SelectedItem != null)
            {
                DateTime date = DatePicker.Value.Date + TimePicker.Value.TimeOfDay;
                string? username = lstHousekeeper.SelectedItem.ToString();
                if (int.TryParse(lstRoomNum.SelectedItem?.ToString(), out int roomNum) && username != null)
                {
                    CleaningSchedule csch = new CleaningSchedule(username, roomNum, date);
                    csch.assign();
                    RefreshTable();
                }
                else
                {
                    MessageBox.Show("Invalid room number.");
                }
            }
            else
            {
                if (lstRoomNum?.SelectedItem == null)
                {
                    MessageBox.Show("Please select a room.");
                }
                if (lstHousekeeper?.SelectedItem == null)
                {
                    MessageBox.Show("Please select a housekeeper.");
                }
            }
        }
    }
}
