using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesReservation
{
    class SqlConnectionStr
    {
        SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-HAMUMM9;Initial Catalog=dbAirlinesReservation;Integrated Security=True");
        public void CreateAccount(string name,string address,string email,bool cender,string username,string pass)
        {

            
            sql.Open();
            SqlCommand command = new SqlCommand("INSERT tbUser VALUES(@NameSurname,@Addres,@Email,@Cender,@UserName,@UserPassword)", sql);
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.AddWithValue("@NameSurname", name);
            command.Parameters.AddWithValue("@Addres", address);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Cender", cender);
            command.Parameters.AddWithValue("@UserName", username);
            command.Parameters.AddWithValue("@UserPassword", pass);
            command.ExecuteNonQuery();
            sql.Close();
        }
        public int Login(string username, string pass)
        {
            try
            {
sql.Open();
SqlCommand command = new SqlCommand("Select * from tbUser Where UserName=@UserName and UserPassword=@UserPassword", sql);
            command.Parameters.AddWithValue("@UserName", username);
            command.Parameters.AddWithValue("@UserPassword", pass);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                sql.Close();
                return 1;
            }
            else
            {
                sql.Close();
                return 0;
            }
            }
            catch 
            {
                sql.Close();
                return 0;
            }
            
        }

        public string CheckUserId(string username, string pass)
        {
            try
            {
                sql.Open();
                SqlCommand command = new SqlCommand("Select * from tbUser Where UserName=@UserName and UserPassword=@UserPassword", sql);
                command.Parameters.AddWithValue("@UserName", username);
                command.Parameters.AddWithValue("@UserPassword", pass);
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    
                    return dr[0].ToString();
                }
                else
                {
                   
                    return dr[0].ToString();
                }
            }
            catch
            {
                sql.Close();
                return "0";
            }

        }
    }
}
