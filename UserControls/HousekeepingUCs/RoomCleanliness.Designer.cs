namespace IOOP_Assignment_Group10_.UserControls.HousekeepingUCs
{
    partial class RoomCleanliness
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
            RoomsTBL = new DataGridView();
            txtIssues = new TextBox();
            lblIssues = new Label();
            CleanRB = new RadioButton();
            DirtyRB = new RadioButton();
            ConfirmBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)RoomsTBL).BeginInit();
            SuspendLayout();
            // 
            // RoomsTBL
            // 
            RoomsTBL.BackgroundColor = Color.White;
            RoomsTBL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RoomsTBL.GridColor = Color.Black;
            RoomsTBL.Location = new Point(61, 180);
            RoomsTBL.Name = "RoomsTBL";
            RoomsTBL.RowHeadersWidth = 51;
            RoomsTBL.Size = new Size(504, 207);
            RoomsTBL.TabIndex = 2;
            // 
            // txtIssues
            // 
            txtIssues.Location = new Point(61, 95);
            txtIssues.Name = "txtIssues";
            txtIssues.Size = new Size(465, 27);
            txtIssues.TabIndex = 3;
            // 
            // lblIssues
            // 
            lblIssues.AutoSize = true;
            lblIssues.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIssues.Location = new Point(61, 64);
            lblIssues.Name = "lblIssues";
            lblIssues.Size = new Size(170, 28);
            lblIssues.TabIndex = 4;
            lblIssues.Text = "Issues (Optional)";
            // 
            // CleanRB
            // 
            CleanRB.AutoSize = true;
            CleanRB.Checked = true;
            CleanRB.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CleanRB.Location = new Point(61, 418);
            CleanRB.Name = "CleanRB";
            CleanRB.Size = new Size(75, 27);
            CleanRB.TabIndex = 9;
            CleanRB.TabStop = true;
            CleanRB.Text = "Clean";
            CleanRB.UseVisualStyleBackColor = true;
            // 
            // DirtyRB
            // 
            DirtyRB.AutoSize = true;
            DirtyRB.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DirtyRB.Location = new Point(156, 418);
            DirtyRB.Name = "DirtyRB";
            DirtyRB.Size = new Size(72, 27);
            DirtyRB.TabIndex = 10;
            DirtyRB.Text = "Dirty";
            DirtyRB.UseVisualStyleBackColor = true;
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.BackColor = SystemColors.HotTrack;
            ConfirmBtn.FlatAppearance.BorderSize = 0;
            ConfirmBtn.FlatStyle = FlatStyle.Flat;
            ConfirmBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmBtn.ForeColor = Color.White;
            ConfirmBtn.Location = new Point(61, 471);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new Size(101, 36);
            ConfirmBtn.TabIndex = 11;
            ConfirmBtn.Text = "Confirm";
            ConfirmBtn.UseVisualStyleBackColor = false;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // RoomCleanliness
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ConfirmBtn);
            Controls.Add(DirtyRB);
            Controls.Add(CleanRB);
            Controls.Add(lblIssues);
            Controls.Add(txtIssues);
            Controls.Add(RoomsTBL);
            Name = "RoomCleanliness";
            Size = new Size(748, 641);
            ((System.ComponentModel.ISupportInitialize)RoomsTBL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView RoomsTBL;
        private TextBox txtIssues;
        private Label lblIssues;
        private RadioButton CleanRB;
        private RadioButton DirtyRB;
        private Button ConfirmBtn;
    }
}
