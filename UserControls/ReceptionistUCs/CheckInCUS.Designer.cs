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
            ReservationsTBL = new DataGridView();
            CheckInBtn = new Button();
            lblPayable = new Label();
            ((System.ComponentModel.ISupportInitialize)ReservationsTBL).BeginInit();
            SuspendLayout();
            // 
            // ReservationsTBL
            // 
            ReservationsTBL.BackgroundColor = Color.White;
            ReservationsTBL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReservationsTBL.GridColor = Color.Black;
            ReservationsTBL.Location = new Point(88, 264);
            ReservationsTBL.Name = "ReservationsTBL";
            ReservationsTBL.RowHeadersWidth = 51;
            ReservationsTBL.Size = new Size(571, 160);
            ReservationsTBL.TabIndex = 26;
            // 
            // CheckInBtn
            // 
            CheckInBtn.BackColor = SystemColors.HotTrack;
            CheckInBtn.CausesValidation = false;
            CheckInBtn.FlatAppearance.BorderSize = 0;
            CheckInBtn.FlatStyle = FlatStyle.Flat;
            CheckInBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckInBtn.ForeColor = Color.White;
            CheckInBtn.Location = new Point(88, 502);
            CheckInBtn.Name = "CheckInBtn";
            CheckInBtn.Size = new Size(101, 36);
            CheckInBtn.TabIndex = 27;
            CheckInBtn.Text = "Check In";
            CheckInBtn.UseVisualStyleBackColor = false;
            CheckInBtn.Click += CheckInBtn_Click;
            // 
            // lblPayable
            // 
            lblPayable.AutoSize = true;
            lblPayable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPayable.Location = new Point(447, 510);
            lblPayable.Name = "lblPayable";
            lblPayable.Size = new Size(173, 28);
            lblPayable.TabIndex = 29;
            lblPayable.Text = "Payable Amount:";
            // 
            // CheckInCUS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblPayable);
            Controls.Add(CheckInBtn);
            Controls.Add(ReservationsTBL);
            Name = "CheckInCUS";
            Size = new Size(748, 641);
            ((System.ComponentModel.ISupportInitialize)ReservationsTBL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ReservationsTBL;
        private Button CheckInBtn;
        private Label lblPayable;
    }
}
