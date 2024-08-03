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
            SearchGrid = new DataGridView();
            AddResBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)SearchGrid).BeginInit();
            SuspendLayout();
            // 
            // SearchGrid
            // 
            SearchGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SearchGrid.Location = new Point(214, 103);
            SearchGrid.Name = "SearchGrid";
            SearchGrid.Size = new Size(240, 150);
            SearchGrid.TabIndex = 0;
            // 
            // AddResBtn
            // 
            AddResBtn.BackColor = SystemColors.HotTrack;
            AddResBtn.FlatStyle = FlatStyle.Flat;
            AddResBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddResBtn.ForeColor = Color.White;
            AddResBtn.Location = new Point(284, 279);
            AddResBtn.Name = "AddResBtn";
            AddResBtn.Size = new Size(101, 36);
            AddResBtn.TabIndex = 1;
            AddResBtn.Text = "Reserve";
            AddResBtn.UseVisualStyleBackColor = false;
            AddResBtn.Click += AddResBtn_Click;
            // 
            // SearchRooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(AddResBtn);
            Controls.Add(SearchGrid);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SearchRooms";
            Size = new Size(654, 481);
            ((System.ComponentModel.ISupportInitialize)SearchGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView SearchGrid;
        private Button AddResBtn;
    }
}
