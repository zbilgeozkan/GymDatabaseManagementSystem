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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace gymVideo
{
    public partial class Equipments : Form
    {
        public Equipments()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEquipments_Click(object sender, EventArgs e)
        {
            viewEquipments ve = new viewEquipments();
            ve.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            String EquipName = textEquipmentName.Text;
            String Description = richTextBoxDescription.Text;
            String MUsed = textMusclesUsed.Text;

            String DDate = dateTimePickerDD.Text;

            Int64 cost = Int64.Parse(textCost.Text);


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = BILGE; database = gym; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Equipment (EquipName, EDescription, MUsed, DDate, Cost) values ('" + EquipName + "','" + Description + "','" + MUsed + "','" + DDate + "','" + cost + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data saved.", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void richTextBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textEquipmentName.Clear();
            richTextBoxDescription.Clear();
            textMusclesUsed.Clear();
            textCost.Clear();

            dateTimePickerDD.Value = DateTime.Now;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textEquipmentName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
