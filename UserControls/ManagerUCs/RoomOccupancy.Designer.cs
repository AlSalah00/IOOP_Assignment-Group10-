namespace IOOP_Assignment_Group10_.UserControls.ManagerUCs
{
    partial class RoomOccupancy
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
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(57, 58);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(634, 524);
            listBox1.TabIndex = 0;
            // 
            // RoomOccupancy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(listBox1);
            Name = "RoomOccupancy";
            Size = new Size(748, 641);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
    }
}
