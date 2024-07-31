using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment_Group10_.UserControls.CustomerUCs
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(61, 89);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(61, 48);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // UserControl1
            // 
            BackColor = Color.White;
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Name = "UserControl1";
            Size = new Size(748, 641);
            Load += UserControl1_Load;
            ResumeLayout(false);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
    }
}
