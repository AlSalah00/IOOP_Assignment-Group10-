namespace IOOP_Assignment_Group10_.UserControls.CustomerUCs
{
    partial class ManageReservations
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
            lblRoomNum = new Label();
            lblCheckIn = new Label();
            lblCheckOut = new Label();
            textBox1 = new TextBox();
            CheckInDatePicker = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            ReservationsTable = new DataGridView();
            EditReservationBtn = new Button();
            CancelBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ReservationsTable).BeginInit();
            SuspendLayout();
            // 
            // lblRoomNum
            // 
            lblRoomNum.AutoSize = true;
            lblRoomNum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomNum.Location = new Point(53, 48);
            lblRoomNum.Name = "lblRoomNum";
            lblRoomNum.Size = new Size(86, 21);
            lblRoomNum.TabIndex = 20;
            lblRoomNum.Text = "Room No.";
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckIn.Location = new Point(53, 110);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(116, 21);
            lblCheckIn.TabIndex = 21;
            lblCheckIn.Text = "Check-in Date";
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckOut.Location = new Point(53, 171);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(127, 21);
            lblCheckOut.TabIndex = 22;
            lblCheckOut.Text = "Check-out Date";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 71);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 23;
            // 
            // CheckInDatePicker
            // 
            CheckInDatePicker.CustomFormat = "dd /MMMM/ yyyy";
            CheckInDatePicker.Format = DateTimePickerFormat.Custom;
            CheckInDatePicker.Location = new Point(53, 133);
            CheckInDatePicker.Margin = new Padding(3, 2, 3, 2);
            CheckInDatePicker.Name = "CheckInDatePicker";
            CheckInDatePicker.Size = new Size(219, 23);
            CheckInDatePicker.TabIndex = 24;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd /MMMM/ yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(53, 194);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(219, 23);
            dateTimePicker2.TabIndex = 25;
            // 
            // ReservationsTable
            // 
            ReservationsTable.BackgroundColor = Color.White;
            ReservationsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReservationsTable.GridColor = Color.Black;
            ReservationsTable.Location = new Point(53, 297);
            ReservationsTable.Margin = new Padding(3, 2, 3, 2);
            ReservationsTable.Name = "ReservationsTable";
            ReservationsTable.RowHeadersWidth = 51;
            ReservationsTable.Size = new Size(463, 154);
            ReservationsTable.TabIndex = 26;
            // 
            // EditReservationBtn
            // 
            EditReservationBtn.BackColor = SystemColors.HotTrack;
            EditReservationBtn.FlatAppearance.BorderSize = 0;
            EditReservationBtn.FlatStyle = FlatStyle.Flat;
            EditReservationBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditReservationBtn.ForeColor = Color.White;
            EditReservationBtn.Location = new Point(53, 251);
            EditReservationBtn.Margin = new Padding(3, 2, 3, 2);
            EditReservationBtn.Name = "EditReservationBtn";
            EditReservationBtn.Size = new Size(88, 27);
            EditReservationBtn.TabIndex = 27;
            EditReservationBtn.Text = "Edit";
            EditReservationBtn.UseVisualStyleBackColor = false;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.Red;
            CancelBtn.FlatAppearance.BorderSize = 0;
            CancelBtn.FlatStyle = FlatStyle.Flat;
            CancelBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelBtn.ForeColor = Color.White;
            CancelBtn.Location = new Point(160, 251);
            CancelBtn.Margin = new Padding(3, 2, 3, 2);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(88, 27);
            CancelBtn.TabIndex = 28;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            // 
            // ManageReservations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(CancelBtn);
            Controls.Add(EditReservationBtn);
            Controls.Add(ReservationsTable);
            Controls.Add(dateTimePicker2);
            Controls.Add(CheckInDatePicker);
            Controls.Add(textBox1);
            Controls.Add(lblCheckOut);
            Controls.Add(lblCheckIn);
            Controls.Add(lblRoomNum);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageReservations";
            Size = new Size(654, 481);
            ((System.ComponentModel.ISupportInitialize)ReservationsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRoomNum;
        private Label lblCheckIn;
        private Label lblCheckOut;
        private TextBox textBox1;
        private DateTimePicker CheckInDatePicker;
        private DateTimePicker dateTimePicker2;
        private DataGridView ReservationsTable;
        private Button EditReservationBtn;
        private Button CancelBtn;
    }
}
