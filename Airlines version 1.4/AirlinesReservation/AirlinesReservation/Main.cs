﻿using System;
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
        string UserId;
        public Main(string id)
        {
            UserId = id;
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbAirlinesReservationDataSet.tbCountry' table. 
            this.tbCountryTableAdapter.Fill(this.dbAirlinesReservationDataSet.tbCountry);
         
            comboBox3.SelectedIndex = 0;
            Location = new Point(3, 60);
            dateTimePicker2.Text = DateTime.Now.AddDays(1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Visible==false)
            {
                Availability ablty = new Availability(UserId,dateTimePicker1.Value, comboBox1.Text, comboBox3.Text, 1,Convert.ToInt32(numericUpDown1.Value));
                ablty.ShowDialog();
            }
            else
            {

           
            if (comboBox1.Text == comboBox2.Text)
            {
                MessageBox.Show("Please change return city", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Availability ablty = new Availability(UserId, dateTimePicker1.Value, dateTimePicker2.Value, comboBox1.Text, comboBox2.Text, comboBox3.Text, Convert.ToInt32(numericUpDown1.Value));
                ablty.ShowDialog();
            }
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
