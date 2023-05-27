namespace gymVideo
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
            toolStripMenuItem1 = new ToolStripMenuItem();
            newMemberToolStripMenuItem = new ToolStripMenuItem();
            newStaffToolStripMenuItem = new ToolStripMenuItem();
            equipmentToolStripMenuItem = new ToolStripMenuItem();
            searchMemberToolStripMenuItem = new ToolStripMenuItem();
            deleteMemberToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Margin = new Padding(0, 8, 20, 0);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Padding = new Padding(15, 15, 30, 15);
            toolStripMenuItem1.Size = new Size(49, 55);
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // newMemberToolStripMenuItem
            // 
            newMemberToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
            newMemberToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newMemberToolStripMenuItem.Image = (Image)resources.GetObject("newMemberToolStripMenuItem.Image");
            newMemberToolStripMenuItem.Margin = new Padding(0, 8, 20, 0);
            newMemberToolStripMenuItem.Name = "newMemberToolStripMenuItem";
            newMemberToolStripMenuItem.Padding = new Padding(15, 15, 50, 15);
            newMemberToolStripMenuItem.Size = new Size(190, 55);
            newMemberToolStripMenuItem.Text = "New Member";
            newMemberToolStripMenuItem.TextAlign = ContentAlignment.MiddleRight;
            newMemberToolStripMenuItem.Click += newMemberToolStripMenuItem_Click;
            // 
            // newStaffToolStripMenuItem
            // 
            newStaffToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
            newStaffToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newStaffToolStripMenuItem.Image = (Image)resources.GetObject("newStaffToolStripMenuItem.Image");
            newStaffToolStripMenuItem.Margin = new Padding(0, 8, 20, 0);
            newStaffToolStripMenuItem.Name = "newStaffToolStripMenuItem";
            newStaffToolStripMenuItem.Padding = new Padding(15, 15, 50, 15);
            newStaffToolStripMenuItem.Size = new Size(162, 55);
            newStaffToolStripMenuItem.Text = "New Staff";
            newStaffToolStripMenuItem.TextAlign = ContentAlignment.MiddleRight;
            newStaffToolStripMenuItem.Click += newStaffToolStripMenuItem_Click;
            // 
            // equipmentToolStripMenuItem
            // 
            equipmentToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
            equipmentToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            equipmentToolStripMenuItem.Image = (Image)resources.GetObject("equipmentToolStripMenuItem.Image");
            equipmentToolStripMenuItem.Margin = new Padding(0, 8, 20, 0);
            equipmentToolStripMenuItem.Name = "equipmentToolStripMenuItem";
            equipmentToolStripMenuItem.Padding = new Padding(15, 15, 50, 15);
            equipmentToolStripMenuItem.Size = new Size(170, 55);
            equipmentToolStripMenuItem.Text = "Equipment";
            equipmentToolStripMenuItem.TextAlign = ContentAlignment.MiddleRight;
            equipmentToolStripMenuItem.Click += equipmentToolStripMenuItem_Click;
            // 
            // searchMemberToolStripMenuItem
            // 
            searchMemberToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
            searchMemberToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchMemberToolStripMenuItem.Image = (Image)resources.GetObject("searchMemberToolStripMenuItem.Image");
            searchMemberToolStripMenuItem.Margin = new Padding(0, 8, 20, 0);
            searchMemberToolStripMenuItem.Name = "searchMemberToolStripMenuItem";
            searchMemberToolStripMenuItem.Padding = new Padding(15, 15, 50, 15);
            searchMemberToolStripMenuItem.Size = new Size(205, 55);
            searchMemberToolStripMenuItem.Text = "Search Member";
            searchMemberToolStripMenuItem.TextAlign = ContentAlignment.MiddleRight;
            searchMemberToolStripMenuItem.Click += searchMemberToolStripMenuItem_Click;
            // 
            // deleteMemberToolStripMenuItem
            // 
            deleteMemberToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
            deleteMemberToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteMemberToolStripMenuItem.Image = (Image)resources.GetObject("deleteMemberToolStripMenuItem.Image");
            deleteMemberToolStripMenuItem.Margin = new Padding(0, 8, 20, 0);
            deleteMemberToolStripMenuItem.Name = "deleteMemberToolStripMenuItem";
            deleteMemberToolStripMenuItem.Padding = new Padding(15, 15, 50, 15);
            deleteMemberToolStripMenuItem.Size = new Size(202, 55);
            deleteMemberToolStripMenuItem.Text = "Delete Member";
            deleteMemberToolStripMenuItem.TextAlign = ContentAlignment.MiddleRight;
            deleteMemberToolStripMenuItem.Click += deleteMemberToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
            exitToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.Margin = new Padding(0, 8, 20, 0);
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Padding = new Padding(15, 15, 50, 15);
            exitToolStripMenuItem.Size = new Size(119, 55);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.TextAlign = ContentAlignment.MiddleRight;
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, newMemberToolStripMenuItem, newStaffToolStripMenuItem, equipmentToolStripMenuItem, searchMemberToolStripMenuItem, deleteMemberToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1563, 67);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1563, 845);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem newMemberToolStripMenuItem;
        private ToolStripMenuItem newStaffToolStripMenuItem;
        private ToolStripMenuItem equipmentToolStripMenuItem;
        private ToolStripMenuItem searchMemberToolStripMenuItem;
        private ToolStripMenuItem deleteMemberToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private MenuStrip menuStrip1;
    }
}