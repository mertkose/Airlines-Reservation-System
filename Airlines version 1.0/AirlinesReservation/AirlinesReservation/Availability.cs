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
    public partial class Availability : Form
    {
        DateTime dt;
        DateTime dtReturn;
        string Departure, Return,Cabin;

        public Availability(DateTime date, DateTime dateReturn,string dep,string retrn,string cbn)
        {
            dt = date;
            dtReturn = dateReturn;
            Departure = dep;
            Return = retrn;
            Cabin = cbn;
            InitializeComponent();
        }

        private void Availability_Load(object sender, EventArgs e)
        {
            Random rnd=new Random();
            Location = new Point(3, 370);
            label15.Text = Departure;
            label2.Text = dt.ToShortDateString();
            label9.Text = dt.AddDays(1).ToShortDateString();
            label10.Text = dt.AddDays(2).ToShortDateString();
            label11.Text = dt.AddDays(3).ToShortDateString();
            label12.Text = dt.AddDays(4).ToShortDateString();
            label13.Text = dt.AddDays(5).ToShortDateString();
            label14.Text = dt.AddDays(6).ToShortDateString();
            radioButton1.Text = rnd.Next(50, 250).ToString()+"$";
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked || radioButton5.Checked || radioButton6.Checked || radioButton7.Checked || radioButton8.Checked || radioButton9.Checked || radioButton10.Checked || radioButton11.Checked || radioButton12.Checked || radioButton13.Checked || radioButton14.Checked || radioButton15.Checked || radioButton16.Checked || radioButton17.Checked || radioButton18.Checked || radioButton19.Checked || radioButton20.Checked || radioButton21.Checked || radioButton22.Checked || radioButton23.Checked || radioButton24.Checked || radioButton25.Checked || radioButton26.Checked || radioButton27.Checked || radioButton28.Checked || radioButton29.Checked || radioButton30.Checked || radioButton31.Checked || radioButton32.Checked || radioButton33.Checked || radioButton34.Checked || radioButton35.Checked)
            {
                ReturnAvailability rtn = new ReturnAvailability(dtReturn, Return,Cabin);
                rtn.ShowDialog();
            }
            else MessageBox.Show("Please Select Departure Time and CLock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
