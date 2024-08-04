namespace IOOP_Assignment_Group10_.UserControls.CustomerUCs
{
    partial class SearchRooms
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
            ReservationGrid = new DataGridView();
            AddResBtn = new Button();
            DatePicker = new DateTimePicker();
            DatePicker2 = new DateTimePicker();
            CheckInPicker = new Label();
            CheckOutPicker = new Label();
            ((System.ComponentModel.ISupportInitialize)ReservationGrid).BeginInit();
            SuspendLayout();
            // 
            // ReservationGrid
            // 
            ReservationGrid.BackgroundColor = Color.White;
            ReservationGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReservationGrid.Location = new Point(41, 179);
            ReservationGrid.Name = "ReservationGrid";
            ReservationGrid.Size = new Size(409, 150);
            ReservationGrid.TabIndex = 0;
            ReservationGrid.CellContentClick += SearchGrid_CellContentClick;
            // 
            // AddResBtn
            // 
            AddResBtn.BackColor = SystemColors.HotTrack;
            AddResBtn.FlatStyle = FlatStyle.Flat;
            AddResBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddResBtn.ForeColor = Color.White;
            AddResBtn.Location = new Point(41, 357);
            AddResBtn.Name = "AddResBtn";
            AddResBtn.Size = new Size(101, 36);
            AddResBtn.TabIndex = 1;
            AddResBtn.Text = "Reserve";
            AddResBtn.UseVisualStyleBackColor = false;
            AddResBtn.Click += AddResBtn_Click;
            // 
            // DatePicker
            // 
            DatePicker.CustomFormat = "dd MMMM yyyy";
            DatePicker.Format = DateTimePickerFormat.Custom;
            DatePicker.Location = new Point(41, 53);
            DatePicker.Margin = new Padding(3, 2, 3, 2);
            DatePicker.MinDate = new DateTime(2024, 7, 29, 0, 0, 0, 0);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(174, 23);
            DatePicker.TabIndex = 14;
            // 
            // DatePicker2
            // 
            DatePicker2.CustomFormat = "dd MMMM yyyy";
            DatePicker2.Format = DateTimePickerFormat.Custom;
            DatePicker2.Location = new Point(276, 53);
            DatePicker2.Margin = new Padding(3, 2, 3, 2);
            DatePicker2.MinDate = new DateTime(2024, 7, 29, 0, 0, 0, 0);
            DatePicker2.Name = "DatePicker2";
            DatePicker2.Size = new Size(174, 23);
            DatePicker2.TabIndex = 15;
            // 
            // CheckInPicker
            // 
            CheckInPicker.AutoSize = true;
            CheckInPicker.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckInPicker.Location = new Point(41, 30);
            CheckInPicker.Name = "CheckInPicker";
            CheckInPicker.Size = new Size(76, 21);
            CheckInPicker.TabIndex = 24;
            CheckInPicker.Text = "Check-in";
            // 
            // CheckOutPicker
            // 
            CheckOutPicker.AutoSize = true;
            CheckOutPicker.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckOutPicker.Location = new Point(276, 30);
            CheckOutPicker.Name = "CheckOutPicker";
            CheckOutPicker.Size = new Size(87, 21);
            CheckOutPicker.TabIndex = 25;
            CheckOutPicker.Text = "Check-out";
            CheckOutPicker.Click += label1_Click;
            // 
            // SearchRooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(CheckOutPicker);
            Controls.Add(CheckInPicker);
            Controls.Add(DatePicker2);
            Controls.Add(DatePicker);
            Controls.Add(AddResBtn);
            Controls.Add(ReservationGrid);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SearchRooms";
            Size = new Size(654, 481);
            ((System.ComponentModel.ISupportInitialize)ReservationGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ReservationGrid;
        private Button AddResBtn;
        private DateTimePicker DatePicker;
        private DateTimePicker DatePicker2;
        private Label CheckInPicker;
        private Label CheckOutPicker;
    }
}
