namespace IOOP_Assignment_Group10_.UserControls.ReceptionistUCs
{
    partial class CheckOutCUS
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
            lblPayable = new Label();
            pendingReservationsTBL = new DataGridView();
            ChekoutLBL = new Button();
            ((System.ComponentModel.ISupportInitialize)pendingReservationsTBL).BeginInit();
            SuspendLayout();
            // 
            // lblPayable
            // 
            lblPayable.AutoSize = true;
            lblPayable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPayable.Location = new Point(462, 541);
            lblPayable.Name = "lblPayable";
            lblPayable.Size = new Size(173, 28);
            lblPayable.TabIndex = 32;
            lblPayable.Text = "Payable Amount:";
            // 
            // pendingReservationsTBL
            // 
            pendingReservationsTBL.BackgroundColor = Color.White;
            pendingReservationsTBL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendingReservationsTBL.GridColor = Color.Black;
            pendingReservationsTBL.Location = new Point(103, 295);
            pendingReservationsTBL.Name = "pendingReservationsTBL";
            pendingReservationsTBL.RowHeadersWidth = 51;
            pendingReservationsTBL.Size = new Size(571, 160);
            pendingReservationsTBL.TabIndex = 30;
            // 
            // ChekoutLBL
            // 
            ChekoutLBL.BackColor = Color.Red;
            ChekoutLBL.FlatAppearance.BorderSize = 0;
            ChekoutLBL.FlatStyle = FlatStyle.Flat;
            ChekoutLBL.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChekoutLBL.ForeColor = Color.White;
            ChekoutLBL.Location = new Point(103, 533);
            ChekoutLBL.Name = "ChekoutLBL";
            ChekoutLBL.Size = new Size(101, 36);
            ChekoutLBL.TabIndex = 33;
            ChekoutLBL.Text = "Delete";
            ChekoutLBL.UseVisualStyleBackColor = false;
            // 
            // CheckOutCUS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ChekoutLBL);
            Controls.Add(lblPayable);
            Controls.Add(pendingReservationsTBL);
            Name = "CheckOutCUS";
            Size = new Size(748, 641);
            ((System.ComponentModel.ISupportInitialize)pendingReservationsTBL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPayable;
        private DataGridView pendingReservationsTBL;
        private Button ChekoutLBL;
    }
}
