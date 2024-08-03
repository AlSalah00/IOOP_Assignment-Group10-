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
            LBLCheckout = new Label();
            pendingReservationsTBL = new DataGridView();
            ChekoutLBL = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pendingReservationsTBL).BeginInit();
            SuspendLayout();
            // 
            // LBLCheckout
            // 
            LBLCheckout.AutoSize = true;
            LBLCheckout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLCheckout.Location = new Point(88, 63);
            LBLCheckout.Name = "LBLCheckout";
            LBLCheckout.Size = new Size(308, 28);
            LBLCheckout.TabIndex = 32;
            LBLCheckout.Text = "Check-out and Collect payment";
            // 
            // pendingReservationsTBL
            // 
            pendingReservationsTBL.BackgroundColor = Color.White;
            pendingReservationsTBL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendingReservationsTBL.GridColor = Color.Black;
            pendingReservationsTBL.Location = new Point(88, 264);
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
            ChekoutLBL.Location = new Point(88, 502);
            ChekoutLBL.Name = "ChekoutLBL";
            ChekoutLBL.Size = new Size(111, 36);
            ChekoutLBL.TabIndex = 33;
            ChekoutLBL.Text = "Check Out";
            ChekoutLBL.UseVisualStyleBackColor = false;
            ChekoutLBL.Click += ChekoutLBL_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.OliveDrab;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(276, 502);
            button1.Name = "button1";
            button1.Size = new Size(120, 36);
            button1.TabIndex = 34;
            button1.Text = "Collect";
            button1.UseVisualStyleBackColor = false;
            // 
            // CheckOutCUS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button1);
            Controls.Add(ChekoutLBL);
            Controls.Add(LBLCheckout);
            Controls.Add(pendingReservationsTBL);
            Name = "CheckOutCUS";
            Size = new Size(748, 641);
            ((System.ComponentModel.ISupportInitialize)pendingReservationsTBL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBLCheckout;
        private DataGridView pendingReservationsTBL;
        private Button ChekoutLBL;
        private Button button1;
    }
}
