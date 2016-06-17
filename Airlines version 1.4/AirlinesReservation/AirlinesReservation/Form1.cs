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
    public partial class Form1 : Form
    {
        SqlConnectionStr connection = new SqlConnectionStr();
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Width == 405)
                Width = 863;
            else Width = 405;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            connection.CreateAccount(textBox3.Text, textBox4.Text, textBox4.Text, radioButton1.Checked, textBox8.Text, textBox7.Text);
            
      

            Width = 405;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 405;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (connection.Login(textBox1.Text, textBox2.Text)==1)
            {
                Hide();
                MainProgram mn = new MainProgram(connection.CheckUserId(textBox1.Text,textBox2.Text));
                mn.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Wrong UserName or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
