using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlinesReservation
{
    public partial class BusinessSeat : Form
    {
        DateTime dt;
        DateTime dtReturn;
        string Departure, Return, Cabin;
        int adult;
        string UserId;
        string money, money2, SeatNumber;
        //Photo Path
        string filename = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "full.png");
        int dep = 0, returnDep = 0;
        //Construction gets other form attributes
        public BusinessSeat(string id, string dep, string rtn, int adlt, string cbn, DateTime date, DateTime Returndt, string m1, string m2)
        {
            UserId = id;
            Departure = dep;
            Return = rtn;
            adult = adlt;
            Cabin = cbn;
            dt = date;
            dtReturn = Returndt;
            money = m1;
            money2 = m2;
            InitializeComponent();
        }

        private void BusinessSeat_Load(object sender, EventArgs e)
        {
            Location = new Point(400, 60);
            pictureBox2.Click += new EventHandler(pictureBox1_Click);
            pictureBox3.Click += new EventHandler(pictureBox1_Click);
            pictureBox4.Click += new EventHandler(pictureBox1_Click);
            pictureBox5.Click += new EventHandler(pictureBox1_Click);
            pictureBox6.Click += new EventHandler(pictureBox1_Click);
            pictureBox7.Click += new EventHandler(pictureBox1_Click);
            pictureBox8.Click += new EventHandler(pictureBox1_Click);
            pictureBox9.Click += new EventHandler(pictureBox1_Click);
            pictureBox10.Click += new EventHandler(pictureBox1_Click);
            pictureBox11.Click += new EventHandler(pictureBox1_Click);
            pictureBox12.Click += new EventHandler(pictureBox1_Click);
            pictureBox13.Click += new EventHandler(pictureBox1_Click);
            pictureBox14.Click += new EventHandler(pictureBox1_Click);
            pictureBox15.Click += new EventHandler(pictureBox1_Click);
            pictureBox16.Click += new EventHandler(pictureBox1_Click);
            pictureBox17.Click += new EventHandler(pictureBox1_Click);
            pictureBox18.Click += new EventHandler(pictureBox1_Click);
            pictureBox19.Click += new EventHandler(pictureBox1_Click);
            pictureBox20.Click += new EventHandler(pictureBox1_Click);
            pictureBox21.Click += new EventHandler(pictureBox1_Click);
            pictureBox22.Click += new EventHandler(pictureBox1_Click);
            pictureBox23.Click += new EventHandler(pictureBox1_Click);
            pictureBox24.Click += new EventHandler(pictureBox1_Click);
            SqlConnectionStr sql = new SqlConnectionStr();
             dep = sql.CityId(Departure);
             returnDep = sql.ReturnCityId(Return);
            string[] number = sql.CheckSeatNumber(dep, returnDep, dt.ToShortDateString().ToString(), dtReturn.ToShortDateString().ToString(), Cabin);
            foreach (var item in number)
            {
                if (item == "A1")
                {
                    pictureBox1.Image = Image.FromFile(filename);
                    pictureBox1.Image.Tag = "full";
                }
                else if (item == "A2")
                {
                    pictureBox2.Image = Image.FromFile(filename);
                    pictureBox2.Image.Tag = "full";
                }
                else if (item == "A3")
                {
                    pictureBox3.Image = Image.FromFile(filename);
                    pictureBox3.Image.Tag = "full";
                }
                else if (item == "A4")
                {
                    pictureBox4.Image = Image.FromFile(filename);
                    pictureBox4.Image.Tag = "full";
                }
                else if (item == "A5")
                {
                    pictureBox5.Image = Image.FromFile(filename);
                    pictureBox5.Image.Tag = "full";
                }
                else if (item == "A6")
                {
                    pictureBox6.Image = Image.FromFile(filename);
                    pictureBox6.Image.Tag = "full";
                }
                /////////////////////////////////////////
                else if (item == "B6")
                {
                    pictureBox7.Image = Image.FromFile(filename);
                    pictureBox7.Image.Tag = "full";
                }
                else if (item == "B5")
                {
                    pictureBox8.Image = Image.FromFile(filename);
                    pictureBox8.Image.Tag = "full";
                }
                else if (item == "B4")
                {
                    pictureBox9.Image = Image.FromFile(filename);
                    pictureBox9.Image.Tag = "full";
                }
                else if (item == "B3")
                {
                    pictureBox10.Image = Image.FromFile(filename);
                    pictureBox10.Image.Tag = "full";
                }
                else if (item == "B2")
                {
                    pictureBox11.Image = Image.FromFile(filename);
                    pictureBox11.Image.Tag = "full";
                }
                else if (item == "B1")
                {
                    pictureBox12.Image = Image.FromFile(filename);
                    pictureBox12.Image.Tag = "full";
                }
                /////////////////////////////////////////
                else if (item == "C6")
                {
                    pictureBox13.Image = Image.FromFile(filename);
                    pictureBox13.Image.Tag = "full";
                }
                else if (item == "C5")
                {
                    pictureBox14.Image = Image.FromFile(filename);
                    pictureBox14.Image.Tag = "full";
                }
                else if (item == "C4")
                {
                    pictureBox15.Image = Image.FromFile(filename);
                    pictureBox15.Image.Tag = "full";
                }
                else if (item == "C3")
                {
                    pictureBox16.Image = Image.FromFile(filename);
                    pictureBox16.Image.Tag = "full";
                }
                else if (item == "C2")
                {
                    pictureBox17.Image = Image.FromFile(filename);
                    pictureBox17.Image.Tag = "full";
                }
                else if (item == "C1")
                {
                    pictureBox18.Image = Image.FromFile(filename);
                    pictureBox18.Image.Tag = "full";
                }
                /////////////////////////////////////////
                else if (item == "D6")
                {
                    pictureBox19.Image = Image.FromFile(filename);
                    pictureBox19.Image.Tag = "full";
                }
                else if (item == "D5")
                {
                    pictureBox20.Image = Image.FromFile(filename);
                    pictureBox20.Image.Tag = "full";
                }
                else if (item == "D4")
                {
                    pictureBox21.Image = Image.FromFile(filename);
                    pictureBox21.Image.Tag = "full";
                }
                else if (item == "D3")
                {
                    pictureBox22.Image = Image.FromFile(filename);
                    pictureBox22.Image.Tag = "full";
                }
                else if (item == "D2")
                {
                    pictureBox23.Image = Image.FromFile(filename);
                    pictureBox23.Image.Tag = "full";
                }
                else if (item == "D1")
                {
                    pictureBox24.Image = Image.FromFile(filename);
                    pictureBox24.Image.Tag = "full";
                }
            }
            label25.Text = (Convert.ToInt32(money.Substring(0, money.Length - 1)) + Convert.ToInt32(money2.Substring(0, money2.Length - 1))).ToString() + " $";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
              PictureBox pbox = sender as PictureBox;

            if (pbox.Image.Tag != "full")
            {
                pictureBox65.Visible = true;
                pictureBox65.Location = pbox.Location;
                if (pbox.Name == "pictureBox1")
                    SeatNumber = "A1";
                else if (pbox.Name == "pictureBox2")
                    SeatNumber = "A2";
                else if (pbox.Name == "pictureBox3")
                    SeatNumber = "A3";
                else if (pbox.Name == "pictureBox4")
                    SeatNumber = "A4";
                else if (pbox.Name == "pictureBox5")
                    SeatNumber = "A5";
                else if (pbox.Name == "pictureBox6")
                    SeatNumber = "A6";
                //////////////////////////////////////////
                else if (pbox.Name == "pictureBox7")
                    SeatNumber = "B6";
                else if (pbox.Name == "pictureBox8")
                    SeatNumber = "B5";
                else if (pbox.Name == "pictureBox9")
                    SeatNumber = "B4";
                else if (pbox.Name == "pictureBox10")
                    SeatNumber = "B3";
                else if (pbox.Name == "pictureBox11")
                    SeatNumber = "B2";
                else if (pbox.Name == "pictureBox12")
                    SeatNumber = "B1";
                //////////////////////////////////////////
                else if (pbox.Name == "pictureBox13")
                    SeatNumber = "C6";
                else if (pbox.Name == "pictureBox14")
                    SeatNumber = "C5";
                else if (pbox.Name == "pictureBox15")
                    SeatNumber = "C4";
                else if (pbox.Name == "pictureBox16")
                    SeatNumber = "C3";
                else if (pbox.Name == "pictureBox17")
                    SeatNumber = "C2";
                else if (pbox.Name == "pictureBox18")
                    SeatNumber = "C1";
                //////////////////////////////////////////
                else if (pbox.Name == "pictureBox19")
                    SeatNumber = "D6";
                else if (pbox.Name == "pictureBox20")
                    SeatNumber = "D5";
                else if (pbox.Name == "pictureBox21")
                    SeatNumber = "D4";
                else if (pbox.Name == "pictureBox22")
                    SeatNumber = "D3";
                else if (pbox.Name == "pictureBox23")
                    SeatNumber = "D2";
                else if (pbox.Name == "pictureBox24")
                    SeatNumber = "D1";
                //////////////////////////////////////////
                linkLabel1.Visible = true;
                label23.Text = SeatNumber;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Sql connection and add db
            SqlConnectionStr sql = new SqlConnectionStr();
            sql.CreateReservation(Convert.ToInt32(UserId), dep, returnDep, adult, Cabin, dt, dtReturn, SeatNumber, label25.Text);
            MessageBox.Show("Thank you for reservation", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
