namespace IOOP_Assignment_Group10_.UserControls.CustomerUCs
{
    partial class ViewRoom
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
            ViewRoomTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ViewRoomTable).BeginInit();
            SuspendLayout();
            // 
            // ViewRoomTable
            // 
            ViewRoomTable.BackgroundColor = Color.White;
            ViewRoomTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewRoomTable.GridColor = Color.Black;
            ViewRoomTable.Location = new Point(110, 218);
            ViewRoomTable.Name = "ViewRoomTable";
            ViewRoomTable.RowHeadersWidth = 51;
            ViewRoomTable.Size = new Size(529, 205);
            ViewRoomTable.TabIndex = 27;
            // 
            // ViewRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ViewRoomTable);
            Name = "ViewRoom";
            Size = new Size(748, 641);
            ((System.ComponentModel.ISupportInitialize)ViewRoomTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ViewRoomTable;
    }
}
