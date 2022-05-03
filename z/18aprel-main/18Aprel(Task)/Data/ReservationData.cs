using _18Aprel_Task_.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace _18Aprel_Task_.Data
{
    internal class ReservationData
    {
        public void InsertReservation()
        {
            Console.WriteLine("Baslama tarixi yazin:");
            string startdate = Console.ReadLine();
            Console.WriteLine("Bitirme tarixi yazin");
            string enddate = Console.ReadLine();
            Console.WriteLine("StadionId:");
            string stadionid = Console.ReadLine();
            Console.WriteLine("UserId:");
            string userid = Console.ReadLine();
            using (SqlConnection con = new SqlConnection(SqlServer.ConnectionString))
            {
                con.Open();
                string query = $"INSERT INTO Reservations(StartDate,EndDate,StadionId,UserId) VALUES({startdate},{enddate},{userid},{stadionid})";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }

        }
        public void SelectReservation()
        {
            using (SqlConnection con = new SqlConnection(SqlServer.ConnectionString))
            {
                con.Open();
                string query = $"SELECT * FROM Reservations";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine($"Id:{dr.GetInt32(0)},StartDate:{dr.GetDateTime(1)},EndDate{dr.GetDateTime(2)},SationId{dr.GetInt32(3)},UserId{dr.GetInt32(4)}");
                }
            }
        }

        static List<Reservation> GetAllReservation()
        {
            List<Reservation> reservations = new List<Reservation>();
            using (SqlConnection con = new SqlConnection(SqlServer.ConnectionString))
            {
                con.Open();
                string query = "SELECT * FROM Reservations";
                SqlCommand cmd = new SqlCommand(query, con);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Reservation reservation = new Reservation
                        {
                            Id = dr.GetInt32(0),
                            StartDate = dr.GetDateTime(1),
                            EndDate = dr.GetDateTime(2),
                            StadionId = dr.GetInt32(3),
                            UserId = dr.GetInt32(4),
                        };
                        reservations.Add(reservation);
                    }
                    return reservations;
                }
            }
        }

        public List<Reservation> GetByIdStadions(int StadionId)
        {
            List<Reservation> reservations = new List<Reservation>();
            using (SqlConnection con = new SqlConnection(SqlServer.ConnectionString))
            {
                con.Open();
                string query = "SELECT * FROM Reservations WHERE StadionId=@StadionId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("StadionId", StadionId);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                Reservation reservation1 = new Reservation();
                                reservation1.Id = dr.GetInt32(0);
                                reservation1.StartDate = dr.GetDateTime(1);
                                reservation1.EndDate = dr.GetDateTime(2);
                                reservation1.StadionId = dr.GetInt32(3);
                                reservation1.UserId = dr.GetInt32(4);
                                reservations.Add(reservation1);
                            }
                        }
                        else
                        {
                            return null;
                        }
                    }
                }

                
            }
            return reservations;



        }
        public List<Reservation> GetByUserId(int UserId)
        {
            List<Reservation> reservations1=new List<Reservation>();
            using (SqlConnection con = new SqlConnection(SqlServer.ConnectionString))
            {
                con.Open();
                string query = "SELECT * FROM Reservations WHERE UserId=@UserId";
                using(SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("UserId", UserId);
                    using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                Reservation reservation=new Reservation();
                                reservation.Id = dr.GetInt32(0);
                                reservation.StartDate = dr.GetDateTime(1);
                                reservation.EndDate = dr.GetDateTime(2);                              
                                reservation.StadionId= dr.GetInt32(3);
                                reservation.UserId = dr.GetInt32(4);
                                reservations1.Add(reservation);
                            }
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            return reservations1 ;
        }
    }
}
