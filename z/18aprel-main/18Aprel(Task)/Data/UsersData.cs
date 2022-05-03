using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using _18Aprel_Task_.Models;

namespace _18Aprel_Task_.Data
{
    public class UsersData
    {
        public void InsertUser()
        {

            Console.WriteLine("FullName:");
            string fullname = Console.ReadLine();
            Console.WriteLine("Email:");
            string email = Console.ReadLine();
            using (SqlConnection con = new SqlConnection(SqlServer.ConnectionString))
            {
                con.Open();
                string query = $"INSERT INTO Users(FullName,Email) VALUES('{fullname}',{email})";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
        }
        public void SelectUser()
        {
            using (SqlConnection con = new SqlConnection(SqlServer.ConnectionString))
            {
                con.Open();
                string query = $"SELECT * FROM Users";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine($"Id:{dr.GetInt32(0)},FullName:{dr.GetString(1)},Email:{dr.GetString(2)}");
                }

            }
        }

        static List<User> GetAllUser()
        {
            List<User> users = new List<User>();
            using (SqlConnection con = new SqlConnection(SqlServer.ConnectionString))
            {
                con.Open();
                string query = "SELECT * FROM Users";
                SqlCommand cmd = new SqlCommand(query, con);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        User user = new User
                        {
                            Id = dr.GetInt32(0),
                            FullName = dr.GetString(1),
                            Email = dr.GetString(2),
                        };
                        users.Add(user);

                    }
                    return users;
                }
            }


        }

    }    
}
