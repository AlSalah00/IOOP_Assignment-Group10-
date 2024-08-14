namespace IOOP_Assignment_Group10_.UserControls.HousekeepingUCs
{
    partial class ManageCleaningSupps
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtQnt = new TextBox();
            txtPrice = new TextBox();
            AddBtn = new Button();
            EditBtn = new Button();
            DelBtn = new Button();
            SuppsTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)SuppsTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 64);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 0;
            label1.Text = "Itam Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 146);
            label2.Name = "label2";
            label2.Size = new Size(144, 28);
            label2.TabIndex = 1;
            label2.Text = "Itam Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 228);
            label3.Name = "label3";
            label3.Size = new Size(108, 28);
            label3.TabIndex = 2;
            label3.Text = "Itam Price";
            // 
            // txtName
            // 
            txtName.Location = new Point(61, 95);
            txtName.Name = "txtName";
            txtName.Size = new Size(286, 27);
            txtName.TabIndex = 3;
            // 
            // txtQnt
            // 
            txtQnt.Location = new Point(61, 177);
            txtQnt.Name = "txtQnt";
            txtQnt.Size = new Size(286, 27);
            txtQnt.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(61, 259);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(286, 27);
            txtPrice.TabIndex = 5;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.HotTrack;
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(61, 342);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(101, 36);
            AddBtn.TabIndex = 6;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = SystemColors.HotTrack;
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(196, 342);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(101, 36);
            EditBtn.TabIndex = 7;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // DelBtn
            // 
            DelBtn.BackColor = Color.Red;
            DelBtn.FlatAppearance.BorderSize = 0;
            DelBtn.FlatStyle = FlatStyle.Flat;
            DelBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DelBtn.ForeColor = Color.White;
            DelBtn.Location = new Point(342, 342);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(101, 36);
            DelBtn.TabIndex = 8;
            DelBtn.Text = "Delete";
            DelBtn.UseVisualStyleBackColor = false;
            DelBtn.Click += DelBtn_Click;
            // 
            // SuppsTable
            // 
            SuppsTable.BackgroundColor = Color.White;
            SuppsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SuppsTable.GridColor = Color.Black;
            SuppsTable.Location = new Point(61, 417);
            SuppsTable.Name = "SuppsTable";
            SuppsTable.RowHeadersWidth = 51;
            SuppsTable.Size = new Size(364, 189);
            SuppsTable.TabIndex = 9;
            SuppsTable.SelectionChanged += SuppsTable_SelectionChanged;
            // 
            // ManageCleaningSupps
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(SuppsTable);
            Controls.Add(DelBtn);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(txtPrice);
            Controls.Add(txtQnt);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ManageCleaningSupps";
            Size = new Size(748, 641);
            ((System.ComponentModel.ISupportInitialize)SuppsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtQnt;
        private TextBox txtPrice;
        private Button AddBtn;
        private Button EditBtn;
        private Button DelBtn;
        private DataGridView SuppsTable;
    }
}
