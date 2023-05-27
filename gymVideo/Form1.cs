namespace gymVideo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean b = true;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                menuStrip1.Dock = DockStyle.Left;
                b = false;
                toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\User\Desktop\DataBaseProject\img2.png");
            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
                toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\User\Desktop\DataBaseProject\img3.png");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\User\Desktop\DataBaseProject\img3.png");
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newMember nm = new newMember();
            nm.Show();
        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newStaff ns = new newStaff();
            ns.Show();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipments eq = new Equipments();
            eq.Show();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchMember sm = new searchMember();
            sm.Show();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteMember dm = new deleteMember();
            dm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will close your application.\n Do you want to confirm?", "CLOSE", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Welcome Back", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}