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
            //Update for get Account Information
            SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-HAMUMM9;Initial Catalog=dbAirlinesReservation;Integrated Security=True");

            try
            {
                sql.Open();
                SqlCommand command = new SqlCommand("Select * from tbUser Where Id=@id", sql);
                command.Parameters.AddWithValue("@id", UserId);
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    textBox3.Text = dr[1].ToString();
                    textBox4.Text = dr[2].ToString();
                    textBox5.Text = dr[3].ToString();
                    if (Convert.ToBoolean(dr[4].ToString()))
                    {
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        radioButton2.Checked = false;
                    }
                    textBox8.Text = dr[5].ToString();
                    textBox7.Text = dr[6].ToString();
                }

            }
            catch
            {

            }

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
