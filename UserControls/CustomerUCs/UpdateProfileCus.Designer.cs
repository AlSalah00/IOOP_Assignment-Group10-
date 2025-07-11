﻿namespace IOOP_Assignment_Group10_.UserControls.CustomerUCs
{
    partial class UpdateProfileCus
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
            lblUsername = new Label();
            txtUserName = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            UpdateBtn = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(61, 64);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(106, 28);
            lblUsername.TabIndex = 23;
            lblUsername.Text = "Username";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(61, 95);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(316, 27);
            txtUserName.TabIndex = 24;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(61, 147);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(101, 28);
            lblPassword.TabIndex = 25;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(61, 177);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(316, 27);
            txtPassword.TabIndex = 27;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = SystemColors.HotTrack;
            UpdateBtn.FlatAppearance.BorderSize = 0;
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.White;
            UpdateBtn.Location = new Point(61, 245);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(101, 36);
            UpdateBtn.TabIndex = 29;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // UpdateProfileCus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(UpdateBtn);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUsername);
            Name = "UpdateProfileCus";
            Size = new Size(747, 641);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private TextBox txtUserName;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button UpdateBtn;
    }
}
