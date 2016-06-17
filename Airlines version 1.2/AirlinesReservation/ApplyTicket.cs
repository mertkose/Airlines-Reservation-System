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
    public partial class ApplyTicket : Form
    {
        //Construction gets other form attributes
        string UserId;
        public ApplyTicket(string id)
        {
            UserId = id;
            InitializeComponent();
        }

        private void ApplyTicket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbAirlinesReservationDataSet.tbReservation' table. 
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HAMUMM9;Initial Catalog=dbAirlinesReservation;Integrated Security=True");


            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = con;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT        tbCountry_1.CountryName, dbo.tbCountry.CountryName AS Expr1, dbo.tbReservation.AdultChild, dbo.tbReservation.Cabin, dbo.tbReservation.DepartureDateTime, dbo.tbReservation.ReturnDateTime, dbo.tbReservation.SeatNumber, dbo.tbReservation.TotalPrice FROM dbo.tbReservation INNER JOIN dbo.tbCountry ON dbo.tbReservation.ToCity = dbo.tbCountry.Id INNER JOIN dbo.tbCountry AS tbCountry_1 ON dbo.tbReservation.FromCity = tbCountry_1.Id WHERE dbo.tbReservation.UserId ="+UserId;
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;

        }
    }
}
