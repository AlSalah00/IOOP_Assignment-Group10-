namespace IOOP_Assignment_Group10_.UserControls.ReceptionistUCs
{
    partial class CheckInCUS
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
            CustomerCb = new ComboBox();
            RoomCb = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            DurationTb = new TextBox();
            AmountTb = new TextBox();
            lblDate = new Label();
            RoomLBL = new Label();
            AssignBtn = new Button();
            CancelBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // CustomerCb
            // 
            CustomerCb.FormattingEnabled = true;
            CustomerCb.Location = new Point(267, 180);
            CustomerCb.Name = "CustomerCb";
            CustomerCb.Size = new Size(151, 28);
            CustomerCb.TabIndex = 1;
            // 
            // RoomCb
            // 
            RoomCb.FormattingEnabled = true;
            RoomCb.Location = new Point(44, 180);
            RoomCb.Name = "RoomCb";
            RoomCb.Size = new Size(151, 28);
            RoomCb.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(44, 84);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // DurationTb
            // 
            DurationTb.Location = new Point(267, 278);
            DurationTb.Name = "DurationTb";
            DurationTb.Size = new Size(177, 27);
            DurationTb.TabIndex = 4;
            // 
            // AmountTb
            // 
            AmountTb.Location = new Point(267, 346);
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(177, 27);
            AmountTb.TabIndex = 5;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(44, 52);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(57, 28);
            lblDate.TabIndex = 15;
            lblDate.Text = "Date";
            // 
            // RoomLBL
            // 
            RoomLBL.AutoSize = true;
            RoomLBL.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoomLBL.Location = new Point(44, 149);
            RoomLBL.Name = "RoomLBL";
            RoomLBL.Size = new Size(67, 28);
            RoomLBL.TabIndex = 16;
            RoomLBL.Text = "Room";
            // 
            // AssignBtn
            // 
            AssignBtn.BackColor = SystemColors.HotTrack;
            AssignBtn.FlatAppearance.BorderSize = 0;
            AssignBtn.FlatStyle = FlatStyle.Flat;
            AssignBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AssignBtn.ForeColor = Color.White;
            AssignBtn.Location = new Point(242, 432);
            AssignBtn.Name = "AssignBtn";
            AssignBtn.Size = new Size(101, 36);
            AssignBtn.TabIndex = 17;
            AssignBtn.Text = "Assign";
            AssignBtn.UseVisualStyleBackColor = false;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.Red;
            CancelBtn.FlatAppearance.BorderSize = 0;
            CancelBtn.FlatStyle = FlatStyle.Flat;
            CancelBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelBtn.ForeColor = Color.White;
            CancelBtn.Location = new Point(382, 432);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(101, 36);
            CancelBtn.TabIndex = 18;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 149);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 19;
            label1.Text = "Customer";
            // 
            // CheckInCUS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(CancelBtn);
            Controls.Add(AssignBtn);
            Controls.Add(RoomLBL);
            Controls.Add(lblDate);
            Controls.Add(AmountTb);
            Controls.Add(DurationTb);
            Controls.Add(dateTimePicker1);
            Controls.Add(RoomCb);
            Controls.Add(CustomerCb);
            Name = "CheckInCUS";
            Size = new Size(748, 641);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CustomerCb;
        private ComboBox RoomCb;
        private DateTimePicker dateTimePicker1;
        private TextBox DurationTb;
        private TextBox AmountTb;
        private Label lblDate;
        private Label RoomLBL;
        private Button AssignBtn;
        private Button CancelBtn;
        private Label label1;
    }
}
