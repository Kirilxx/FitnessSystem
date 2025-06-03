namespace FitnessSystem_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            newMemberToolStripMenuItem = new ToolStripMenuItem();
            newStaffToolStripMenuItem = new ToolStripMenuItem();
            equipmentToolStripMenuItem = new ToolStripMenuItem();
            searchMemberToolStripMenuItem = new ToolStripMenuItem();
            deleteMemberToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.MenuBar;
            menuStrip1.Items.AddRange(new ToolStripItem[] { newMemberToolStripMenuItem, newStaffToolStripMenuItem, equipmentToolStripMenuItem, searchMemberToolStripMenuItem, deleteMemberToolStripMenuItem, logOutToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1018, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // newMemberToolStripMenuItem
            // 
            newMemberToolStripMenuItem.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            newMemberToolStripMenuItem.ForeColor = Color.Black;
            newMemberToolStripMenuItem.Name = "newMemberToolStripMenuItem";
            newMemberToolStripMenuItem.Size = new Size(118, 24);
            newMemberToolStripMenuItem.Text = "New Member";
            newMemberToolStripMenuItem.Click += newMemberToolStripMenuItem_Click;
            // 
            // newStaffToolStripMenuItem
            // 
            newStaffToolStripMenuItem.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            newStaffToolStripMenuItem.ForeColor = Color.Black;
            newStaffToolStripMenuItem.Name = "newStaffToolStripMenuItem";
            newStaffToolStripMenuItem.Size = new Size(92, 24);
            newStaffToolStripMenuItem.Text = "New Staff";
            newStaffToolStripMenuItem.Click += newStaffToolStripMenuItem_Click;
            // 
            // equipmentToolStripMenuItem
            // 
            equipmentToolStripMenuItem.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            equipmentToolStripMenuItem.ForeColor = Color.Black;
            equipmentToolStripMenuItem.Name = "equipmentToolStripMenuItem";
            equipmentToolStripMenuItem.Size = new Size(104, 24);
            equipmentToolStripMenuItem.Text = "Equipment";
            equipmentToolStripMenuItem.Click += equipmentToolStripMenuItem_Click;
            // 
            // searchMemberToolStripMenuItem
            // 
            searchMemberToolStripMenuItem.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            searchMemberToolStripMenuItem.ForeColor = Color.Black;
            searchMemberToolStripMenuItem.Name = "searchMemberToolStripMenuItem";
            searchMemberToolStripMenuItem.Size = new Size(137, 24);
            searchMemberToolStripMenuItem.Text = "Search Member";
            searchMemberToolStripMenuItem.Click += searchMemberToolStripMenuItem_Click;
            // 
            // deleteMemberToolStripMenuItem
            // 
            deleteMemberToolStripMenuItem.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deleteMemberToolStripMenuItem.ForeColor = Color.Black;
            deleteMemberToolStripMenuItem.Name = "deleteMemberToolStripMenuItem";
            deleteMemberToolStripMenuItem.Size = new Size(133, 24);
            deleteMemberToolStripMenuItem.Text = "Delete Member";
            deleteMemberToolStripMenuItem.Click += deleteMemberToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            logOutToolStripMenuItem.ForeColor = Color.Crimson;
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(81, 24);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exitToolStripMenuItem.ForeColor = Color.Crimson;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(53, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1018, 566);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem newMemberToolStripMenuItem;
        private ToolStripMenuItem newStaffToolStripMenuItem;
        private ToolStripMenuItem equipmentToolStripMenuItem;
        private ToolStripMenuItem searchMemberToolStripMenuItem;
        private ToolStripMenuItem deleteMemberToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
