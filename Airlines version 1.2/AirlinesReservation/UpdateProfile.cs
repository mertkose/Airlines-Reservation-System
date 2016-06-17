using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlinesReservation
{
    public partial class UpdateProfile : Form
    {
        string UserId;
        public UpdateProfile(string id)
        {
            UserId = id;
            InitializeComponent();
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Sql Connection
            SqlConnectionStr sql = new SqlConnectionStr();
            bool cender=true;
            if (radioButton1.Checked)
            {
                cender = true;
            }
            else
            {
                cender = false;
            }
            sql.UpdateAccount(textBox3.Text, textBox4.Text, textBox5.Text, cender, textBox8.Text, textBox7.Text, UserId);
            MessageBox.Show("Information Updated","Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            Close();
        }
    }
}
