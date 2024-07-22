namespace IOOP_Assignment_Group10_.UserControls.ManagerUCs
{
    partial class RoomCSH
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
            listBox1 = new ListBox();
            AssignBtn = new Button();
            monthCalendar1 = new MonthCalendar();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(61, 268);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(626, 244);
            listBox1.TabIndex = 0;
            // 
            // AssignBtn
            // 
            AssignBtn.BackColor = SystemColors.HotTrack;
            AssignBtn.FlatAppearance.BorderSize = 0;
            AssignBtn.FlatStyle = FlatStyle.Flat;
            AssignBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AssignBtn.ForeColor = Color.White;
            AssignBtn.Location = new Point(61, 537);
            AssignBtn.Name = "AssignBtn";
            AssignBtn.Size = new Size(101, 36);
            AssignBtn.TabIndex = 10;
            AssignBtn.Text = "Assign";
            AssignBtn.UseVisualStyleBackColor = false;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(61, 28);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 11;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(357, 31);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(330, 204);
            listBox2.TabIndex = 12;
            // 
            // RoomCSH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(listBox2);
            Controls.Add(monthCalendar1);
            Controls.Add(AssignBtn);
            Controls.Add(listBox1);
            Name = "RoomCSH";
            Size = new Size(748, 641);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button AssignBtn;
        private MonthCalendar monthCalendar1;
        private ListBox listBox2;
    }
}
