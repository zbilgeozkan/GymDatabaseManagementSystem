using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymVideo
{
    public partial class newStaff : Form
    {
        public newStaff()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textFirstName.Clear();
            textLastName.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            textPhone.Clear();
            textCity.Clear();
            textState.Clear();
            textEmail.Clear();

            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJD.Value = DateTime.Now;
        }

        private void buttonSave_Click(object sender, EventArgs e)
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

            String state = textState.Text;
            String city = textCity.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = BILGE; database = gym; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewStaff (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Statee, City) values ('" + fname + "','" + lname + "','" + gender + "','" + dob + "','" + phone + "','" + email + "','" + joindate + "','" + state + "','" + city + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data saved.");
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void comboBoxGymTime_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxMembership_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void richTextBoxAddress_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePickerJD_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void textPhone_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePickerDOB_ValueChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void textLastName_TextChanged(object sender, EventArgs e)
        {
        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {
        }

        private void newStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
