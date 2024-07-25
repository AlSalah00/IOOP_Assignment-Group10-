namespace IOOP_Assignment_Group10_.UserControls
{
    partial class ManageUsers
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
            lblEmail = new Label();
            lblPassword = new Label();
            txtUserName = new TextBox();
            txtEmail = new TextBox();
            HouseKeeperRB = new RadioButton();
            lblRole = new Label();
            ReceptionistRB = new RadioButton();
            AddUserBtn = new Button();
            DelUserBtn = new Button();
            txtPassword = new MaskedTextBox();
            UsersTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)UsersTable).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(93, 57);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(106, 28);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(93, 139);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 28);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(93, 221);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(101, 28);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(93, 88);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(316, 27);
            txtUserName.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(93, 170);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(316, 27);
            txtEmail.TabIndex = 4;
            // 
            // HouseKeeperRB
            // 
            HouseKeeperRB.AutoSize = true;
            HouseKeeperRB.Checked = true;
            HouseKeeperRB.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HouseKeeperRB.Location = new Point(93, 334);
            HouseKeeperRB.Name = "HouseKeeperRB";
            HouseKeeperRB.Size = new Size(135, 27);
            HouseKeeperRB.TabIndex = 6;
            HouseKeeperRB.TabStop = true;
            HouseKeeperRB.Text = "Housekeeper";
            HouseKeeperRB.UseVisualStyleBackColor = true;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(93, 303);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(54, 28);
            lblRole.TabIndex = 7;
            lblRole.Text = "Role";
            // 
            // ReceptionistRB
            // 
            ReceptionistRB.AutoSize = true;
            ReceptionistRB.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReceptionistRB.Location = new Point(234, 334);
            ReceptionistRB.Name = "ReceptionistRB";
            ReceptionistRB.Size = new Size(130, 27);
            ReceptionistRB.TabIndex = 8;
            ReceptionistRB.Text = "Receptionist";
            ReceptionistRB.UseVisualStyleBackColor = true;
            // 
            // AddUserBtn
            // 
            AddUserBtn.BackColor = SystemColors.HotTrack;
            AddUserBtn.FlatAppearance.BorderSize = 0;
            AddUserBtn.FlatStyle = FlatStyle.Flat;
            AddUserBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddUserBtn.ForeColor = Color.White;
            AddUserBtn.Location = new Point(93, 390);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new Size(101, 36);
            AddUserBtn.TabIndex = 9;
            AddUserBtn.Text = "Add";
            AddUserBtn.UseVisualStyleBackColor = false;
            AddUserBtn.Click += AddUserBtn_Click;
            // 
            // DelUserBtn
            // 
            DelUserBtn.BackColor = Color.Red;
            DelUserBtn.FlatAppearance.BorderSize = 0;
            DelUserBtn.FlatStyle = FlatStyle.Flat;
            DelUserBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DelUserBtn.ForeColor = Color.White;
            DelUserBtn.Location = new Point(215, 390);
            DelUserBtn.Name = "DelUserBtn";
            DelUserBtn.Size = new Size(101, 36);
            DelUserBtn.TabIndex = 10;
            DelUserBtn.Text = "Delete";
            DelUserBtn.UseVisualStyleBackColor = false;
            DelUserBtn.Click += DelUserBtn_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(93, 252);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(316, 27);
            txtPassword.TabIndex = 12;
            // 
            // UsersTable
            // 
            UsersTable.BackgroundColor = Color.White;
            UsersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersTable.GridColor = Color.Black;
            UsersTable.Location = new Point(93, 450);
            UsersTable.Name = "UsersTable";
            UsersTable.RowHeadersWidth = 51;
            UsersTable.Size = new Size(571, 160);
            UsersTable.TabIndex = 13;
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(UsersTable);
            Controls.Add(txtPassword);
            Controls.Add(DelUserBtn);
            Controls.Add(AddUserBtn);
            Controls.Add(ReceptionistRB);
            Controls.Add(lblRole);
            Controls.Add(HouseKeeperRB);
            Controls.Add(txtEmail);
            Controls.Add(txtUserName);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Name = "ManageUsers";
            Size = new Size(748, 641);
            Load += ManageUsers_Load;
            ((System.ComponentModel.ISupportInitialize)UsersTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtUserName;
        private TextBox txtEmail;
        private RadioButton HouseKeeperRB;
        private Label lblRole;
        private RadioButton ReceptionistRB;
        private Button AddUserBtn;
        private Button DelUserBtn;
        private MaskedTextBox txtPassword;
        private DataGridView UsersTable;
    }
}
