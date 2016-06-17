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
    public partial class MainProgram : Form
    {
        string UserId;
        public MainProgram(string id)
        {
            UserId = id;
            InitializeComponent();
        }

        private void MainProgram_Load(object sender, EventArgs e)
        {
            Text = UserId;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flightSeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main m = new Main(UserId);
            m.ShowDialog();
        }
    }
}
