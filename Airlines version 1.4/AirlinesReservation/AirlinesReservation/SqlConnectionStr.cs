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
        //Sql connection link
        SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-HAMUMM9;Initial Catalog=dbAirlinesReservation;Integrated Security=True");

        //Sql Inset Query for Accont table
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
        //Sql Update Query for Accont table
        public void UpdateAccount(string name, string address, string email, bool cender, string username, string pass,string UserId)
        {


            sql.Open();
            SqlCommand command = new SqlCommand("Update tbUser Set NameSurname=@NameSurname,Addres=@Addres,Email=@Email,Cender=@Cender,UserName=@UserName,UserPassword=@UserPassword where Id=@Id", sql);
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.AddWithValue("@NameSurname", name);
            command.Parameters.AddWithValue("@Addres", address);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Cender", cender);
            command.Parameters.AddWithValue("@UserName", username);
            command.Parameters.AddWithValue("@UserPassword", pass);
            command.Parameters.AddWithValue("@Id", UserId);
            command.ExecuteNonQuery();
            sql.Close();
        }
        //Sql Select Query for User table
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
        //Sql Select Query for UserId 
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
        //Sql Select Query for City, Insert to CityId
        public int CityId(string name)
        {
            try
            {
                sql.Open();
                SqlCommand command = new SqlCommand("Select * from tbCountry Where CountryName=@name", sql);
                command.Parameters.AddWithValue("@name", name);
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    return Convert.ToInt32(dr[0].ToString());
                }
                else
                {
                    return Convert.ToInt32(dr[0].ToString());
                }
            }
            catch
            {
                sql.Close();
                return 0;
            }

        }
        //Sql Select Query for City, Insert to CityId
        public int ReturnCityId(string name)
        {
            sql.Close();
            try
            {
                sql.Open();
                SqlCommand command = new SqlCommand("Select * from tbCountry Where CountryName=@name", sql);
                command.Parameters.AddWithValue("@name", name);
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    return Convert.ToInt32(dr[0].ToString());
                }
                else
                {
                    return Convert.ToInt32(dr[0].ToString());
                }
            }
            catch
            {
                sql.Close();
                return 0;
            }

        }
        //Empty or Full Seat Number Control
        public string[] CheckSeatNumber(int fromcity, int tocity,string date,string rtDate,string cbn)
        {
            sql.Close();
            string[] number=new string[60];
            int i = 0;
            try
            {
                sql.Open();
                SqlCommand command = new SqlCommand("Select * from tbReservation where FromCity=@fromcity and ToCity=@tocity and DepartureDateTime=@date and ReturnDateTime=@rtDate and Cabin=@Cabin", sql);
                command.Parameters.AddWithValue("@fromcity", fromcity);
                command.Parameters.AddWithValue("@tocity", tocity);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@rtDate", rtDate);
                command.Parameters.AddWithValue("@Cabin", cbn);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    number[i] = dr[8].ToString();
                    i++;
                }
                return number;
            }
            catch
            {
                sql.Close();
                return number;
            }

        }
        //Sql Insert Query for Reservation table
        public void CreateReservation(int id, int fromCity, int toCity, int cender, string cabin, DateTime date,DateTime dtReturn,string seatNumber,string total)
        {


            sql.Open();
            SqlCommand command = new SqlCommand("INSERT tbReservation VALUES(@UserId,@FromCity,@ToCity,@Cender,@Cabin,@Dep,@Retn,@Seat,@Price)", sql);
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.AddWithValue("@UserId", id);
            command.Parameters.AddWithValue("@FromCity", fromCity);
            command.Parameters.AddWithValue("@ToCity", toCity);
            command.Parameters.AddWithValue("@Cender", cender);
            command.Parameters.AddWithValue("@Cabin", cabin);
            command.Parameters.AddWithValue("@Dep", date.ToShortDateString().ToString());
            command.Parameters.AddWithValue("@Retn", dtReturn.ToShortDateString().ToString());
            command.Parameters.AddWithValue("@Seat", seatNumber);
            command.Parameters.AddWithValue("@Price", total);
            command.ExecuteNonQuery();
            sql.Close();
        }
    }
}
