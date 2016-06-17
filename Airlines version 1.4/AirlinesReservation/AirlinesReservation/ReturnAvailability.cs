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
    public partial class ReturnAvailability : Form
    {
        DateTime dt,Returndt;
        string Return,Cabin,UserId,Departure,Money,Money2;
        int Adult;
        //Construction gets other form attributes
        public ReturnAvailability(string id,string dep,string rn,DateTime date,DateTime rtn,string cbn,string mny,int adlt)
        {
            UserId = id;
            Departure = dep;
            Return = rn;
            dt = date;
            Returndt = rtn;
            Cabin = cbn;
            Money = mny;
            Adult = adlt;
            InitializeComponent();
        }

        private void ReturnAvailability_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Location = new Point(593, 370);
            label15.Text = Return;
            label2.Text = Returndt.ToShortDateString();
            label9.Text = Returndt.AddDays(1).ToShortDateString();
            label10.Text = Returndt.AddDays(2).ToShortDateString();
            label11.Text = Returndt.AddDays(3).ToShortDateString();
            label12.Text = Returndt.AddDays(4).ToShortDateString();
            label13.Text = Returndt.AddDays(5).ToShortDateString();
            label14.Text = Returndt.AddDays(6).ToShortDateString();
            radioButton1.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton2.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton3.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton4.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton5.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton6.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton7.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton8.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton9.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton10.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton11.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton12.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton13.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton14.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton15.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton16.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton17.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton18.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton19.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton20.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton21.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton22.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton23.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton24.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton25.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton26.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton27.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton28.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton29.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton30.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton31.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton32.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton33.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton34.Text = rnd.Next(50, 250).ToString() + "$";
            radioButton35.Text = rnd.Next(50, 250).ToString() + "$";
            //All radioButton control combining
            radioButton2.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton3.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton4.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton5.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton6.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton7.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton8.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton9.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton9.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton10.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton11.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton12.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton13.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton14.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton15.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton16.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton17.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton18.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton19.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton20.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton21.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton22.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton23.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton24.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton25.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton26.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton27.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton28.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton29.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton30.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton31.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton32.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton33.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton34.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton35.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked || radioButton5.Checked || radioButton6.Checked || radioButton7.Checked || radioButton8.Checked || radioButton9.Checked || radioButton10.Checked || radioButton11.Checked || radioButton12.Checked || radioButton13.Checked || radioButton14.Checked || radioButton15.Checked || radioButton16.Checked || radioButton17.Checked || radioButton18.Checked || radioButton19.Checked || radioButton20.Checked || radioButton21.Checked || radioButton22.Checked || radioButton23.Checked || radioButton24.Checked || radioButton25.Checked || radioButton26.Checked || radioButton27.Checked || radioButton28.Checked || radioButton29.Checked || radioButton30.Checked || radioButton31.Checked || radioButton32.Checked || radioButton33.Checked || radioButton34.Checked || radioButton35.Checked)
            {
                if (Cabin=="Economy")
                {
                    //Form show
                    Seat st = new Seat(UserId, Departure, Return, Adult, Cabin, dt, Returndt, Money, Money2);
                    st.ShowDialog();
                }
                else
                {
                    //Form show
                    BusinessSeat bs = new BusinessSeat(UserId, Departure, Return, Adult, Cabin, dt, Returndt, Money, Money2);
                    bs.ShowDialog();
                }
            }
            else MessageBox.Show("Please Select Return Time and CLock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Click change to Date
            RadioButton rb = sender as RadioButton;
            Money2 = rb.Text;
            if (radioButton1.Checked || radioButton14.Checked || radioButton21.Checked || radioButton28.Checked || radioButton35.Checked)
            {
                //nothing
            }
            else if (radioButton2.Checked || radioButton13.Checked || radioButton20.Checked || radioButton27.Checked || radioButton34.Checked)
            {
                Returndt = Returndt.AddDays(1);

            }
            else if (radioButton3.Checked || radioButton12.Checked || radioButton19.Checked || radioButton26.Checked || radioButton33.Checked)
            {
                Returndt = Returndt.AddDays(2);
            }
            else if (radioButton4.Checked || radioButton11.Checked || radioButton18.Checked || radioButton25.Checked || radioButton32.Checked)
            {
                Returndt = Returndt.AddDays(3);
            }
            else if (radioButton5.Checked || radioButton10.Checked || radioButton17.Checked || radioButton24.Checked || radioButton31.Checked)
            {
                Returndt = Returndt.AddDays(4);
            }
            else if (radioButton6.Checked || radioButton9.Checked || radioButton16.Checked || radioButton23.Checked || radioButton30.Checked)
            {
                Returndt = Returndt.AddDays(5);
            }
            else if (radioButton7.Checked || radioButton8.Checked || radioButton15.Checked || radioButton22.Checked || radioButton29.Checked)
            {
                Returndt = Returndt.AddDays(6);
            }
        }
    }
}
