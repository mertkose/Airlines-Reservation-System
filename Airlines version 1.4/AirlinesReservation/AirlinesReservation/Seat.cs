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
    public partial class Seat : Form
    {
        DateTime dt;
        DateTime dtReturn;
        string Departure, Return, Cabin;
        int adult;
        string UserId;
        string money,money2,SeatNumber;
        //Photo Path
        string filename = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "full.png");
        int dep=0, returnDep=0;
        //Construction gets other form attributes
        public Seat(string id,string dep,string rtn,int adlt,string cbn,DateTime date,DateTime Returndt,string m1,string m2)
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

        private void Seat_Load(object sender, EventArgs e)
        {
            Location = new Point(400, 60);
            //All Picture control combining
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
            pictureBox25.Click += new EventHandler(pictureBox1_Click);
            pictureBox26.Click += new EventHandler(pictureBox1_Click);
            pictureBox27.Click += new EventHandler(pictureBox1_Click);
            pictureBox28.Click += new EventHandler(pictureBox1_Click);
            pictureBox29.Click += new EventHandler(pictureBox1_Click);
            pictureBox30.Click += new EventHandler(pictureBox1_Click);
            pictureBox31.Click += new EventHandler(pictureBox1_Click);
            pictureBox32.Click += new EventHandler(pictureBox1_Click);
            pictureBox33.Click += new EventHandler(pictureBox1_Click);
            pictureBox34.Click += new EventHandler(pictureBox1_Click);
            pictureBox35.Click += new EventHandler(pictureBox1_Click);
            pictureBox36.Click += new EventHandler(pictureBox1_Click);
            pictureBox37.Click += new EventHandler(pictureBox1_Click);
            pictureBox38.Click += new EventHandler(pictureBox1_Click);
            pictureBox39.Click += new EventHandler(pictureBox1_Click);
            pictureBox40.Click += new EventHandler(pictureBox1_Click);
            pictureBox41.Click += new EventHandler(pictureBox1_Click);
            pictureBox42.Click += new EventHandler(pictureBox1_Click);
            pictureBox43.Click += new EventHandler(pictureBox1_Click);
            pictureBox44.Click += new EventHandler(pictureBox1_Click);
            pictureBox45.Click += new EventHandler(pictureBox1_Click);
            pictureBox46.Click += new EventHandler(pictureBox1_Click);
            pictureBox47.Click += new EventHandler(pictureBox1_Click);
            pictureBox48.Click += new EventHandler(pictureBox1_Click);
            pictureBox49.Click += new EventHandler(pictureBox1_Click);
            pictureBox50.Click += new EventHandler(pictureBox1_Click);
            pictureBox51.Click += new EventHandler(pictureBox1_Click);
            pictureBox52.Click += new EventHandler(pictureBox1_Click);
            pictureBox53.Click += new EventHandler(pictureBox1_Click);
            pictureBox54.Click += new EventHandler(pictureBox1_Click);
            pictureBox55.Click += new EventHandler(pictureBox1_Click);
            pictureBox56.Click += new EventHandler(pictureBox1_Click);
            pictureBox57.Click += new EventHandler(pictureBox1_Click);
            pictureBox58.Click += new EventHandler(pictureBox1_Click);
            pictureBox59.Click += new EventHandler(pictureBox1_Click);
            pictureBox60.Click += new EventHandler(pictureBox1_Click);
            SqlConnectionStr sql = new SqlConnectionStr();
             dep = sql.CityId(Departure);
             returnDep = sql.ReturnCityId(Return);
            string[] number = sql.CheckSeatNumber(dep, returnDep, dt.ToShortDateString().ToString(), dtReturn.ToShortDateString().ToString(), Cabin);
            foreach (var item in number)
            {
                if (item == "E1")
                {
                    pictureBox1.Image = Image.FromFile(filename);
                    pictureBox1.Image.Tag = "full";
                }
                else if (item == "E2"){
                    pictureBox2.Image = Image.FromFile(filename); 
                    pictureBox2.Image.Tag = "full";
                }
                else if (item == "E3"){
                    pictureBox3.Image = Image.FromFile(filename);
                    pictureBox3.Image.Tag = "full";
                }
                else if (item == "E4"){
                    pictureBox4.Image = Image.FromFile(filename);
                    pictureBox4.Image.Tag = "full";
                }
                else if (item == "E5"){
                    pictureBox5.Image = Image.FromFile(filename);
                    pictureBox5.Image.Tag = "full";
                }
                else if (item == "E6"){
                    pictureBox6.Image = Image.FromFile(filename);
                    pictureBox6.Image.Tag = "full";
                }
                /////////////////////////////////////////
                else if (item == "F6"){
                    pictureBox7.Image = Image.FromFile(filename);
                    pictureBox7.Image.Tag = "full";
                }
                else if (item == "F5"){
                    pictureBox8.Image = Image.FromFile(filename);
                    pictureBox8.Image.Tag = "full";
                }
                else if (item == "F4"){
                    pictureBox9.Image = Image.FromFile(filename);
                    pictureBox9.Image.Tag = "full";
                }
                else if (item == "F3"){
                    pictureBox10.Image = Image.FromFile(filename);
                    pictureBox10.Image.Tag = "full";
                }
                else if (item == "F2"){
                    pictureBox11.Image = Image.FromFile(filename);
                    pictureBox11.Image.Tag = "full";
                }
                else if (item == "F1"){
                    pictureBox12.Image = Image.FromFile(filename);
                    pictureBox12.Image.Tag = "full";
                }
                /////////////////////////////////////////
                else if (item == "G6")
                {
                    pictureBox13.Image = Image.FromFile(filename);
                    pictureBox13.Image.Tag = "full";
                }
                else if (item == "G5")
                {
                    pictureBox14.Image = Image.FromFile(filename);
                    pictureBox14.Image.Tag = "full";
                }
                else if (item == "G4")
                {
                    pictureBox15.Image = Image.FromFile(filename);
                    pictureBox15.Image.Tag = "full";
                }
                else if (item == "G3")
                {
                    pictureBox16.Image = Image.FromFile(filename);
                    pictureBox16.Image.Tag = "full";
                }
                else if (item == "G2")
                {
                    pictureBox17.Image = Image.FromFile(filename);
                    pictureBox17.Image.Tag = "full";
                }
                else if (item == "G1")
                {
                    pictureBox18.Image = Image.FromFile(filename);
                    pictureBox18.Image.Tag = "full";
                }
                /////////////////////////////////////////
                else if (item == "H6")
                {
                    pictureBox19.Image = Image.FromFile(filename);
                    pictureBox19.Image.Tag = "full";
                }
                else if (item == "H5")
                {
                    pictureBox20.Image = Image.FromFile(filename);
                    pictureBox20.Image.Tag = "full";
                }
                else if (item == "H4")
                {
                    pictureBox21.Image = Image.FromFile(filename);
                    pictureBox21.Image.Tag = "full";
                }
                else if (item == "H3")
                {
                    pictureBox22.Image = Image.FromFile(filename);
                    pictureBox22.Image.Tag = "full";
                }
                else if (item == "H2")
                {
                    pictureBox23.Image = Image.FromFile(filename);
                    pictureBox23.Image.Tag = "full";
                }
                else if (item == "H1")
                {
                    pictureBox24.Image = Image.FromFile(filename);
                    pictureBox24.Image.Tag = "full";
                }
                /////////////////////////////////////////
                else if (item == "I6")
                {
                    pictureBox25.Image = Image.FromFile(filename);
                    pictureBox25.Image.Tag = "full";
                }
                else if (item == "I5")
                {
                    pictureBox26.Image = Image.FromFile(filename);
                    pictureBox26.Image.Tag = "full";
                }
                else if (item == "I4")
                {
                    pictureBox27.Image = Image.FromFile(filename);
                    pictureBox27.Image.Tag = "full";
                }
                else if (item == "I3")
                {
                    pictureBox28.Image = Image.FromFile(filename);
                    pictureBox28.Image.Tag = "full";
                }
                else if (item == "I2")
                {
                    pictureBox29.Image = Image.FromFile(filename);
                    pictureBox29.Image.Tag = "full";
                }
                else if (item == "I1")
                {
                    pictureBox30.Image = Image.FromFile(filename);
                    pictureBox30.Image.Tag = "full";
                }
                /////////////////////////////////////////
                else if (item == "J6")
                {
                    pictureBox31.Image = Image.FromFile(filename);
                    pictureBox31.Image.Tag = "full";
                }
                else if (item == "J5")
                {
                    pictureBox32.Image = Image.FromFile(filename);
                    pictureBox32.Image.Tag = "full";
                }
                else if (item == "J4")
                {
                    pictureBox33.Image = Image.FromFile(filename);
                    pictureBox33.Image.Tag = "full";
                }
                else if (item == "J3")
                {
                    pictureBox34.Image = Image.FromFile(filename);
                    pictureBox34.Image.Tag = "full";
                }
                else if (item == "J2")
                {
                    pictureBox35.Image = Image.FromFile(filename);
                    pictureBox35.Image.Tag = "full";
                }
                else if (item == "J1")
                {
                    pictureBox36.Image = Image.FromFile(filename);
                    pictureBox36.Image.Tag = "full";
                }
                /////////////////////////////////////////
                else if (item == "K6")
                {
                    pictureBox37.Image = Image.FromFile(filename);
                    pictureBox37.Image.Tag = "full";
                }
                else if (item == "K5")
                {
                    pictureBox38.Image = Image.FromFile(filename);
                    pictureBox38.Image.Tag = "full";
                }
                else if (item == "K4")
                {
                    pictureBox39.Image = Image.FromFile(filename);
                    pictureBox39.Image.Tag = "full";
                }
                else if (item == "K3")
                {
                    pictureBox40.Image = Image.FromFile(filename);
                    pictureBox40.Image.Tag = "full";
                }
                else if (item == "K2")
                {
                    pictureBox41.Image = Image.FromFile(filename);
                    pictureBox41.Image.Tag = "full";
                }
                else if (item == "K1")
                {
                    pictureBox42.Image = Image.FromFile(filename);
                    pictureBox42.Image.Tag = "full";
                }
                /////////////////////////////////////////
                else if (item == "L6")
                {
                    pictureBox43.Image = Image.FromFile(filename);
                    pictureBox43.Image.Tag = "full";
                }
                else if (item == "L5")
                {
                    pictureBox44.Image = Image.FromFile(filename);
                    pictureBox44.Image.Tag = "full";
                }
                else if (item == "L4")
                {
                    pictureBox45.Image = Image.FromFile(filename);
                    pictureBox45.Image.Tag = "full";
                }
                else if (item == "L3")
                {
                    pictureBox46.Image = Image.FromFile(filename);
                    pictureBox46.Image.Tag = "full";
                }
                else if (item == "L2")
                {
                    pictureBox47.Image = Image.FromFile(filename);
                    pictureBox47.Image.Tag = "full";
                }
                else if (item == "L1")
                {
                    pictureBox48.Image = Image.FromFile(filename);
                    pictureBox48.Image.Tag = "full";
                }
                /////////////////////////////////////////
                else if (item == "M6")
                {
                    pictureBox49.Image = Image.FromFile(filename);
                    pictureBox49.Image.Tag = "full";
                }
                else if (item == "M5")
                {
                    pictureBox50.Image = Image.FromFile(filename);
                    pictureBox50.Image.Tag = "full";
                }
                else if (item == "M4")
                {
                    pictureBox51.Image = Image.FromFile(filename);
                    pictureBox51.Image.Tag = "full";
                }
                else if (item == "M3")
                {
                    pictureBox52.Image = Image.FromFile(filename);
                    pictureBox52.Image.Tag = "full";
                }
                else if (item == "M2")
                {
                    pictureBox53.Image = Image.FromFile(filename);
                    pictureBox53.Image.Tag = "full";
                }
                else if (item == "M1")
                {
                    pictureBox54.Image = Image.FromFile(filename);
                    pictureBox54.Image.Tag = "full";
                }
                /////////////////////////////////////////
                else if (item == "N6")
                {
                    pictureBox55.Image = Image.FromFile(filename);
                    pictureBox55.Image.Tag = "full";
                }
                else if (item == "N5")
                {
                    pictureBox56.Image = Image.FromFile(filename);
                    pictureBox56.Image.Tag = "full";
                }
                else if (item == "N4")
                {
                    pictureBox57.Image = Image.FromFile(filename);
                    pictureBox57.Image.Tag = "full";
                }
                else if (item == "N3")
                {
                    pictureBox58.Image = Image.FromFile(filename);
                    pictureBox58.Image.Tag = "full";
                }
                else if (item == "N2")
                {
                    pictureBox59.Image = Image.FromFile(filename);
                    pictureBox59.Image.Tag = "full";
                }
                else if (item == "N1")
                {
                    pictureBox60.Image = Image.FromFile(filename);
                    pictureBox60.Image.Tag = "full";
                }
            }
            label25.Text = (Convert.ToInt32(money.Substring(0, money.Length - 1)) + Convert.ToInt32(money2.Substring(0, money2.Length - 1))).ToString()+" $";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pbox = sender as PictureBox;
            //Full Seat Number Control
            if (pbox.Image.Tag != "full")
            {
                pictureBox65.Visible = true;
                pictureBox65.Location = pbox.Location;
                if (pbox.Name == "pictureBox1")
                    SeatNumber = "E1";
                else if (pbox.Name == "pictureBox2")
                    SeatNumber = "E2";
                else if (pbox.Name == "pictureBox3")
                    SeatNumber = "E3";
                else if (pbox.Name == "pictureBox4")
                    SeatNumber = "E4";
                else if (pbox.Name == "pictureBox5")
                    SeatNumber = "E5";
                else if (pbox.Name == "pictureBox6")
                    SeatNumber = "E6";
                //////////////////////////////////////////
                else if (pbox.Name == "pictureBox7")
                    SeatNumber = "F6";
                else if (pbox.Name == "pictureBox8")
                    SeatNumber = "F5";
                else if (pbox.Name == "pictureBox9")
                    SeatNumber = "F4";
                else if (pbox.Name == "pictureBox10")
                    SeatNumber = "F3";
                else if (pbox.Name == "pictureBox11")
                    SeatNumber = "F2";
                else if (pbox.Name == "pictureBox12")
                    SeatNumber = "F1";
                //////////////////////////////////////////
                else if (pbox.Name == "pictureBox13")
                    SeatNumber = "G6";
                else if (pbox.Name == "pictureBox14")
                    SeatNumber = "G5";
                else if (pbox.Name == "pictureBox15")
                    SeatNumber = "G4";
                else if (pbox.Name == "pictureBox16")
                    SeatNumber = "G3";
                else if (pbox.Name == "pictureBox17")
                    SeatNumber = "G2";
                else if (pbox.Name == "pictureBox18")
                    SeatNumber = "G1";
                //////////////////////////////////////////
                else if (pbox.Name == "pictureBox19")
                    SeatNumber = "H6";
                else if (pbox.Name == "pictureBox20")
                    SeatNumber = "H5";
                else if (pbox.Name == "pictureBox21")
                    SeatNumber = "H4";
                else if (pbox.Name == "pictureBox22")
                    SeatNumber = "H3";
                else if (pbox.Name == "pictureBox23")
                    SeatNumber = "H2";
                else if (pbox.Name == "pictureBox24")
                    SeatNumber = "H1";
                //////////////////////////////////////////
                else if (pbox.Name == "pictureBox25")
                    SeatNumber = "I6";
                else if (pbox.Name == "pictureBox26")
                    SeatNumber = "I5";
                else if (pbox.Name == "pictureBox27")
                    SeatNumber = "I4";
                else if (pbox.Name == "pictureBox28")
                    SeatNumber = "I3";
                else if (pbox.Name == "pictureBox29")
                    SeatNumber = "I2";
                else if (pbox.Name == "pictureBox30")
                    SeatNumber = "I1";
                //////////////////////////////////////////
                else if (pbox.Name == "pictureBox31")
                    SeatNumber = "J6";
                else if (pbox.Name == "pictureBox32")
                    SeatNumber = "J5";
                else if (pbox.Name == "pictureBox33")
                    SeatNumber = "J4";
                else if (pbox.Name == "pictureBox34")
                    SeatNumber = "J3";
                else if (pbox.Name == "pictureBox35")
                    SeatNumber = "J2";
                else if (pbox.Name == "pictureBox36")
                    SeatNumber = "J1";
                //////////////////////////////////////////
                else if (pbox.Name == "pictureBox37")
                    SeatNumber = "K6";
                else if (pbox.Name == "pictureBox38")
                    SeatNumber = "K5";
                else if (pbox.Name == "pictureBox39")
                    SeatNumber = "K4";
                else if (pbox.Name == "pictureBox40")
                    SeatNumber = "K3";
                else if (pbox.Name == "pictureBox41")
                    SeatNumber = "K2";
                else if (pbox.Name == "pictureBox42")
                    SeatNumber = "K1";
                //////////////////////////////////////////
                else if (pbox.Name == "pictureBox43")
                    SeatNumber = "L6";
                else if (pbox.Name == "pictureBox44")
                    SeatNumber = "L5";
                else if (pbox.Name == "pictureBox45")
                    SeatNumber = "L4";
                else if (pbox.Name == "pictureBox46")
                    SeatNumber = "L3";
                else if (pbox.Name == "pictureBox47")
                    SeatNumber = "L2";
                else if (pbox.Name == "pictureBox48")
                    SeatNumber = "L1";
                //////////////////////////////////////////
                else if (pbox.Name == "pictureBox49")
                    SeatNumber = "M6";
                else if (pbox.Name == "pictureBox50")
                    SeatNumber = "M5";
                else if (pbox.Name == "pictureBox51")
                    SeatNumber = "M4";
                else if (pbox.Name == "pictureBox52")
                    SeatNumber = "M3";
                else if (pbox.Name == "pictureBox53")
                    SeatNumber = "M2";
                else if (pbox.Name == "pictureBox54")
                    SeatNumber = "M1";
                //////////////////////////////////////////
                else if (pbox.Name == "pictureBox55")
                    SeatNumber = "N6";
                else if (pbox.Name == "pictureBox56")
                    SeatNumber = "N5";
                else if (pbox.Name == "pictureBox57")
                    SeatNumber = "N4";
                else if (pbox.Name == "pictureBox58")
                    SeatNumber = "N3";
                else if (pbox.Name == "pictureBox59")
                    SeatNumber = "N2";
                else if (pbox.Name == "pictureBox60")
                    SeatNumber = "N1";
                //////////////////////////////////////////
                linkLabel1.Visible = true;
                label23.Text = SeatNumber;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnectionStr sql = new SqlConnectionStr();
            sql.CreateReservation(Convert.ToInt32(UserId), dep, returnDep, adult, Cabin, dt, dtReturn, SeatNumber, label25.Text);
            MessageBox.Show("Thank you for reservation", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
