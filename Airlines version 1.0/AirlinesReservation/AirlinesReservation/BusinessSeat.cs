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
    public partial class BusinessSeat : Form
    {
        public BusinessSeat()
        {
            InitializeComponent();
        }

        private void BusinessSeat_Load(object sender, EventArgs e)
        {
            Location = new Point(400, 60);
        }
    }
}
