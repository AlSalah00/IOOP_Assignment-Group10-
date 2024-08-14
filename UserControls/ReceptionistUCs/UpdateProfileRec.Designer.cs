namespace IOOP_Assignment_Group10_.UserControls.ReceptionistUCs
{
    partial class UpdateProfileRec
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
            UpdateBTN = new Button();
            txtUsername = new TextBox();
            lblPayable = new Label();
            label1 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // UpdateBTN
            // 
            UpdateBTN.BackColor = SystemColors.HotTrack;
            UpdateBTN.CausesValidation = false;
            UpdateBTN.FlatAppearance.BorderSize = 0;
            UpdateBTN.FlatStyle = FlatStyle.Flat;
            UpdateBTN.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBTN.ForeColor = Color.White;
            UpdateBTN.Location = new Point(88, 314);
            UpdateBTN.Name = "UpdateBTN";
            UpdateBTN.Size = new Size(101, 36);
            UpdateBTN.TabIndex = 28;
            UpdateBTN.Text = "Update";
            UpdateBTN.UseVisualStyleBackColor = false;
            UpdateBTN.Click += UpdateBTN_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(88, 151);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(204, 27);
            txtUsername.TabIndex = 30;
            // 
            // lblPayable
            // 
            lblPayable.AutoSize = true;
            lblPayable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPayable.Location = new Point(88, 120);
            lblPayable.Name = "lblPayable";
            lblPayable.Size = new Size(155, 28);
            lblPayable.TabIndex = 31;
            lblPayable.Text = "New Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 203);
            label1.Name = "label1";
            label1.Size = new Size(150, 28);
            label1.TabIndex = 32;
            label1.Text = "New Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(88, 49);
            label2.Name = "label2";
            label2.Size = new Size(149, 28);
            label2.TabIndex = 33;
            label2.Text = "Update Profile";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(88, 234);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(204, 27);
            txtPassword.TabIndex = 34;
            // 
            // UpdateProfileRec
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPayable);
            Controls.Add(txtUsername);
            Controls.Add(UpdateBTN);
            Name = "UpdateProfileRec";
            Size = new Size(748, 641);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView UpdateTBL;
        private Button UpdateBTN;
        private TextBox txtpass;
        private TextBox txtUsername;
        private Label lblPayable;
        private Label label1;
        private Label label2;
        private TextBox txtPassword;
    }
}
