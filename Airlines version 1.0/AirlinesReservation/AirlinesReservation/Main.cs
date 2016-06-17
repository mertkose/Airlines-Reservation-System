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

namespace AirlinesReservation
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbAirlinesReservationDataSet.tbCountry' table. You can move, or remove it, as needed.
            this.tbCountryTableAdapter.Fill(this.dbAirlinesReservationDataSet.tbCountry);
            // TODO: This line of code loads data into the 'dbAirlinesDataSet.tbCountry' table. You can move, or remove it, as needed.

            comboBox3.SelectedIndex = 0;
            Location = new Point(3, 60);
            dateTimePicker2.Text = DateTime.Now.AddDays(1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == comboBox2.Text)
            {
                MessageBox.Show("Please change return country", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Availability ablty = new Availability(dateTimePicker1.Value, dateTimePicker2.Value, comboBox1.Text , comboBox2.Text,comboBox3.Text);
                ablty.ShowDialog();
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime(dateTimePicker1.Text);
            dateTimePicker2.MinDate = dt;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
        }


    }
}
