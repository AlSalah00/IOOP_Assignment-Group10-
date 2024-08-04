namespace IOOP_Assignment_Group10_.UserControls.ReceptionistUCs
{
    partial class Editcustomers
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
            UpdateTBL = new DataGridView();
            UpdateBTN = new Button();
            txtpass = new TextBox();
            txtusername = new TextBox();
            lblPayable = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)UpdateTBL).BeginInit();
            SuspendLayout();
            // 
            // UpdateTBL
            // 
            UpdateTBL.BackgroundColor = Color.White;
            UpdateTBL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UpdateTBL.GridColor = Color.Black;
            UpdateTBL.Location = new Point(88, 264);
            UpdateTBL.Name = "UpdateTBL";
            UpdateTBL.RowHeadersWidth = 51;
            UpdateTBL.Size = new Size(571, 160);
            UpdateTBL.TabIndex = 27;
            // 
            // UpdateBTN
            // 
            UpdateBTN.BackColor = SystemColors.HotTrack;
            UpdateBTN.CausesValidation = false;
            UpdateBTN.FlatAppearance.BorderSize = 0;
            UpdateBTN.FlatStyle = FlatStyle.Flat;
            UpdateBTN.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBTN.ForeColor = Color.White;
            UpdateBTN.Location = new Point(88, 502);
            UpdateBTN.Name = "UpdateBTN";
            UpdateBTN.Size = new Size(101, 36);
            UpdateBTN.TabIndex = 28;
            UpdateBTN.Text = "Update";
            UpdateBTN.UseVisualStyleBackColor = false;
            UpdateBTN.Click += UpdateBTN_Click;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(307, 204);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(204, 27);
            txtpass.TabIndex = 29;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(307, 147);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(204, 27);
            txtusername.TabIndex = 30;
            // 
            // lblPayable
            // 
            lblPayable.AutoSize = true;
            lblPayable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPayable.Location = new Point(88, 146);
            lblPayable.Name = "lblPayable";
            lblPayable.Size = new Size(149, 28);
            lblPayable.TabIndex = 31;
            lblPayable.Text = "NewUsername";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 203);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 32;
            label1.Text = "NewPassword";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(114, 50);
            label2.Name = "label2";
            label2.Size = new Size(254, 28);
            label2.TabIndex = 33;
            label2.Text = "Update Customers Profile";
            // 
            // Editcustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPayable);
            Controls.Add(txtusername);
            Controls.Add(txtpass);
            Controls.Add(UpdateBTN);
            Controls.Add(UpdateTBL);
            Name = "Editcustomers";
            Size = new Size(748, 641);
            ((System.ComponentModel.ISupportInitialize)UpdateTBL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView UpdateTBL;
        private Button UpdateBTN;
        private TextBox txtpass;
        private TextBox txtusername;
        private Label lblPayable;
        private Label label1;
        private Label label2;
    }
}
