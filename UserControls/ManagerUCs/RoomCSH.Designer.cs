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
            lstRoomNum = new ListBox();
            DatePicker = new DateTimePicker();
            lblDate = new Label();
            lblRoomNum = new Label();
            lblHouseKeeper = new Label();
            CleaningScheduleTable = new DataGridView();
            TimePicker = new DateTimePicker();
            lblTime = new Label();
            ((System.ComponentModel.ISupportInitialize)CleaningScheduleTable).BeginInit();
            SuspendLayout();
            // 
            // lstHousekeeper
            // 
            lstHousekeeper.FormattingEnabled = true;
            lstHousekeeper.Location = new Point(333, 177);
            lstHousekeeper.Name = "lstHousekeeper";
            lstHousekeeper.Size = new Size(198, 164);
            lstHousekeeper.TabIndex = 0;
            // 
            // AssignBtn
            // 
            AssignBtn.BackColor = SystemColors.HotTrack;
            AssignBtn.FlatAppearance.BorderSize = 0;
            AssignBtn.FlatStyle = FlatStyle.Flat;
            AssignBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AssignBtn.ForeColor = Color.White;
            AssignBtn.Location = new Point(61, 368);
            AssignBtn.Name = "AssignBtn";
            AssignBtn.Size = new Size(101, 36);
            AssignBtn.TabIndex = 10;
            AssignBtn.Text = "Assign";
            AssignBtn.UseVisualStyleBackColor = false;
            AssignBtn.Click += AssignBtn_Click;
            // 
            // lstRoomNum
            // 
            lstRoomNum.FormattingEnabled = true;
            lstRoomNum.Location = new Point(61, 177);
            lstRoomNum.Name = "lstRoomNum";
            lstRoomNum.Size = new Size(198, 164);
            lstRoomNum.TabIndex = 12;
            // 
            // DatePicker
            // 
            DatePicker.CustomFormat = "dd MMMM yyyy";
            DatePicker.Format = DateTimePickerFormat.Custom;
            DatePicker.Location = new Point(61, 95);
            DatePicker.MinDate = new DateTime(2024, 7, 29, 0, 0, 0, 0);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(198, 27);
            DatePicker.TabIndex = 13;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(61, 64);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(57, 28);
            lblDate.TabIndex = 14;
            lblDate.Text = "Date";
            // 
            // lblRoomNum
            // 
            lblRoomNum.AutoSize = true;
            lblRoomNum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomNum.Location = new Point(61, 146);
            lblRoomNum.Name = "lblRoomNum";
            lblRoomNum.Size = new Size(106, 28);
            lblRoomNum.TabIndex = 15;
            lblRoomNum.Text = "Room No.";
            // 
            // lblHouseKeeper
            // 
            lblHouseKeeper.AutoSize = true;
            lblHouseKeeper.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHouseKeeper.Location = new Point(333, 146);
            lblHouseKeeper.Name = "lblHouseKeeper";
            lblHouseKeeper.Size = new Size(135, 28);
            lblHouseKeeper.TabIndex = 16;
            lblHouseKeeper.Text = "Housekeeper";
            // 
            // CleaningScheduleTable
            // 
            CleaningScheduleTable.BackgroundColor = Color.White;
            CleaningScheduleTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CleaningScheduleTable.GridColor = Color.Black;
            CleaningScheduleTable.Location = new Point(61, 433);
            CleaningScheduleTable.Name = "CleaningScheduleTable";
            CleaningScheduleTable.RowHeadersWidth = 51;
            CleaningScheduleTable.Size = new Size(470, 173);
            CleaningScheduleTable.TabIndex = 17;
            // 
            // TimePicker
            // 
            TimePicker.CustomFormat = "hh:mm tt";
            TimePicker.Format = DateTimePickerFormat.Custom;
            TimePicker.Location = new Point(333, 95);
            TimePicker.Name = "TimePicker";
            TimePicker.ShowUpDown = true;
            TimePicker.Size = new Size(121, 27);
            TimePicker.TabIndex = 18;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(333, 64);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(59, 28);
            lblTime.TabIndex = 19;
            lblTime.Text = "Time";
            // 
            // RoomCSH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblTime);
            Controls.Add(TimePicker);
            Controls.Add(CleaningScheduleTable);
            Controls.Add(lblHouseKeeper);
            Controls.Add(lblRoomNum);
            Controls.Add(lblDate);
            Controls.Add(DatePicker);
            Controls.Add(lstRoomNum);
            Controls.Add(AssignBtn);
            Controls.Add(lstHousekeeper);
            Name = "RoomCSH";
            Size = new Size(748, 641);
            ((System.ComponentModel.ISupportInitialize)CleaningScheduleTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstHousekeeper;
        private Button AssignBtn;
        private ListBox lstRoomNum;
        private DateTimePicker DatePicker;
        private Label lblDate;
        private Label lblRoomNum;
        private Label lblHouseKeeper;
        private DataGridView CleaningScheduleTable;
        private DateTimePicker TimePicker;
        private Label lblTime;
    }
}
