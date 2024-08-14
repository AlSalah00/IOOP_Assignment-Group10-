namespace IOOP_Assignment_Group10_.UserControls.ManagerUCs
{
    partial class CustomerReviews
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
            ReviewsTable = new DataGridView();
            lblReviews = new Label();
            ((System.ComponentModel.ISupportInitialize)ReviewsTable).BeginInit();
            SuspendLayout();
            // 
            // ReviewsTable
            // 
            ReviewsTable.BackgroundColor = Color.White;
            ReviewsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReviewsTable.GridColor = Color.Black;
            ReviewsTable.Location = new Point(97, 373);
            ReviewsTable.Name = "ReviewsTable";
            ReviewsTable.RowHeadersWidth = 51;
            ReviewsTable.Size = new Size(530, 160);
            ReviewsTable.TabIndex = 31;
            // 
            // lblReviews
            // 
            lblReviews.AutoSize = true;
            lblReviews.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReviews.Location = new Point(61, 64);
            lblReviews.Name = "lblReviews";
            lblReviews.Size = new Size(194, 28);
            lblReviews.TabIndex = 32;
            lblReviews.Text = "Customers Reviews";
            // 
            // CustomerReviews
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblReviews);
            Controls.Add(ReviewsTable);
            Name = "CustomerReviews";
            Size = new Size(748, 641);
            ((System.ComponentModel.ISupportInitialize)ReviewsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ReviewsTable;
        private Label lblReviews;
    }
}
