namespace IOOP_Assignment_Group10_.UserControls.ReceptionistUCs
{
    partial class UpdateReceptionistProfile
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
            usersTBL = new DataGridView();
            CheckInBtn = new Button();
            txtNewPassword = new TextBox();
            txtNewUsername = new TextBox();
            lblUsername = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)usersTBL).BeginInit();
            SuspendLayout();
            // 
            // usersTBL
            // 
            usersTBL.BackgroundColor = Color.White;
            usersTBL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersTBL.GridColor = Color.Black;
            usersTBL.Location = new Point(88, 264);
            usersTBL.Name = "usersTBL";
            usersTBL.RowHeadersWidth = 51;
            usersTBL.Size = new Size(571, 160);
            usersTBL.TabIndex = 27;
            // 
            // CheckInBtn
            // 
            CheckInBtn.BackColor = SystemColors.HotTrack;
            CheckInBtn.CausesValidation = false;
            CheckInBtn.FlatAppearance.BorderSize = 0;
            CheckInBtn.FlatStyle = FlatStyle.Flat;
            CheckInBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckInBtn.ForeColor = Color.White;
            CheckInBtn.Location = new Point(88, 502);
            CheckInBtn.Name = "CheckInBtn";
            CheckInBtn.Size = new Size(101, 36);
            CheckInBtn.TabIndex = 28;
            CheckInBtn.Text = "Update";
            CheckInBtn.UseVisualStyleBackColor = false;
            CheckInBtn.Click += CheckInBtn_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(88, 164);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(316, 27);
            txtNewPassword.TabIndex = 30;
            // 
            // txtNewUsername
            // 
            txtNewUsername.Location = new Point(88, 72);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(316, 27);
            txtNewUsername.TabIndex = 31;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(88, 41);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(180, 28);
            lblUsername.TabIndex = 32;
            lblUsername.Text = "Update Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 133);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 33;
            label1.Text = "Update Password";
            // 
            // UpdateReceptionistProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(lblUsername);
            Controls.Add(txtNewUsername);
            Controls.Add(txtNewPassword);
            Controls.Add(CheckInBtn);
            Controls.Add(usersTBL);
            Name = "UpdateReceptionistProfile";
            Size = new Size(748, 641);
            ((System.ComponentModel.ISupportInitialize)usersTBL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView usersTBL;
        private Button CheckInBtn;
        private TextBox txtNewPassword;
        private TextBox txtNewUsername;
        private Label lblUsername;
        private Label label1;
    }
}
