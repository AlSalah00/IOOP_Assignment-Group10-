namespace IOOP_Assignment_Group10_.UserControls.ManagerUCs
{
    partial class RoomCSH
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstHousekeeper = new ListBox();
            AssignBtn = new Button();
            monthCalendar1 = new MonthCalendar();
            lstRoomNum = new ListBox();
            SuspendLayout();
            // 
            // lstHousekeeper
            // 
            lstHousekeeper.FormattingEnabled = true;
            lstHousekeeper.Location = new Point(61, 268);
            lstHousekeeper.Name = "lstHousekeeper";
            lstHousekeeper.Size = new Size(626, 244);
            lstHousekeeper.TabIndex = 0;
            // 
            // AssignBtn
            // 
            AssignBtn.BackColor = SystemColors.HotTrack;
            AssignBtn.FlatAppearance.BorderSize = 0;
            AssignBtn.FlatStyle = FlatStyle.Flat;
            AssignBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AssignBtn.ForeColor = Color.White;
            AssignBtn.Location = new Point(61, 537);
            AssignBtn.Name = "AssignBtn";
            AssignBtn.Size = new Size(101, 36);
            AssignBtn.TabIndex = 10;
            AssignBtn.Text = "Assign";
            AssignBtn.UseVisualStyleBackColor = false;
            AssignBtn.Click += AssignBtn_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(61, 28);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 11;
            // 
            // lstRoomNum
            // 
            lstRoomNum.FormattingEnabled = true;
            lstRoomNum.Location = new Point(357, 31);
            lstRoomNum.Name = "lstRoomNum";
            lstRoomNum.Size = new Size(330, 204);
            lstRoomNum.TabIndex = 12;
            // 
            // RoomCSH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lstRoomNum);
            Controls.Add(monthCalendar1);
            Controls.Add(AssignBtn);
            Controls.Add(lstHousekeeper);
            Name = "RoomCSH";
            Size = new Size(748, 641);
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstHousekeeper;
        private Button AssignBtn;
        private MonthCalendar monthCalendar1;
        private ListBox lstRoomNum;
    }
}
