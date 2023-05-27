using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymVideo
{
    public partial class newMember : Form
    {
        public newMember()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fname = textFirstName.Text;
            String lname = textLastName.Text;

            String gender = "";

            bool isChecked = radioButton1.Checked;

            if (isChecked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }

            String dob = dateTimePickerDOB.Text;

            Int64 phone = Int64.Parse(textPhone.Text);

            String email = textEmail.Text;

            String joindate = dateTimePickerJD.Text;

            String gymtime = comboBoxGymTime.Text;

            String address = richTextBoxAddress.Text;

            String membership = comboBoxMembership.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = BILGE; database = gym; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewMember (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Gymtime, Maddress, MembershipTime) values ('" + fname + "','" + lname + "','" + gender + "','" + dob + "','" + phone + "','" + email + "','" + joindate + "','" + gymtime + "','" + address + "','" + membership + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data saved.");

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void newMember_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textFirstName.Clear();
            textLastName.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            textPhone.Clear();
            textEmail.Clear();

            comboBoxGymTime.ResetText();
            comboBoxMembership.ResetText();

            richTextBoxAddress.Clear();

            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJD.Value = DateTime.Now;

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
