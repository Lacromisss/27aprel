using _18Aprel_Task_.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using _18Aprel_Task_.Models;

namespace _18Aprel_Task_.Data
{
    public class StadionData
    {
        public void InsertStadion()
        {
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("HourPrice:");
            string hourPrice = Console.ReadLine();
            Console.WriteLine("Capacity:");
            string capacity = Console.ReadLine();

            using (SqlConnection con = new SqlConnection(SqlServer.ConnectionString))
            {
                con.Open();
                string query = $"INSERT INTO Stadions(Name,HourPrice,Capacity) VALUES('{name}',{hourPrice},{capacity})";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
        }
        public void SelectStadions()
        {
            using (SqlConnection con = new SqlConnection(SqlServer.ConnectionString))
            {
                con.Open();
                string query = $"SELECT * FROM Stadions";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine($"Id:{dr.GetInt32(0)},Name:{dr.GetString(1)},Price:{dr.GetDecimal(2)},Capacity:{dr.GetInt32(3)}");
                }
            } 
        }
        static List<Stadion> GetAllStadion()
        {
            List<Stadion> stadions = new List<Stadion>();
            using (SqlConnection con = new SqlConnection(SqlServer.ConnectionString))
            {
                con.Open();
                string query = "SELECT * FROM Stadions";
                SqlCommand cmd = new SqlCommand(query, con);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Stadion stadion = new Stadion
                        {
                            Id = dr.GetInt32(0),
                            Name = dr.GetString(1),
                            HourPrice = dr.GetDecimal(2),
                            Capacity = dr.GetInt32(3)
                        };
                        stadions.Add(stadion);
                    }
                }

                return stadions;
            }
        }
        
       

    }
}
