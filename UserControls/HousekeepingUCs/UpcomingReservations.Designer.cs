namespace IOOP_Assignment_Group10_.UserControls.HousekeepingUCs
{
    partial class UpcomingReservations
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
            UpcomingResTBL = new DataGridView();
            lblUpcomingRes = new Label();
            ((System.ComponentModel.ISupportInitialize)UpcomingResTBL).BeginInit();
            SuspendLayout();
            // 
            // UpcomingResTBL
            // 
            UpcomingResTBL.BackgroundColor = Color.White;
            UpcomingResTBL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UpcomingResTBL.GridColor = Color.Black;
            UpcomingResTBL.Location = new Point(61, 162);
            UpcomingResTBL.Name = "UpcomingResTBL";
            UpcomingResTBL.RowHeadersWidth = 51;
            UpcomingResTBL.Size = new Size(440, 297);
            UpcomingResTBL.TabIndex = 1;
            // 
            // lblUpcomingRes
            // 
            lblUpcomingRes.AutoSize = true;
            lblUpcomingRes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpcomingRes.Location = new Point(61, 64);
            lblUpcomingRes.Name = "lblUpcomingRes";
            lblUpcomingRes.Size = new Size(236, 28);
            lblUpcomingRes.TabIndex = 2;
            lblUpcomingRes.Text = "Upcoming Reservations";
            // 
            // UpcomingReservations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblUpcomingRes);
            Controls.Add(UpcomingResTBL);
            Name = "UpcomingReservations";
            Size = new Size(748, 641);
            ((System.ComponentModel.ISupportInitialize)UpcomingResTBL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView UpcomingResTBL;
        private Label lblUpcomingRes;
    }
}
