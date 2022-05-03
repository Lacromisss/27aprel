using _18Aprel_Task_.Data;
using _18Aprel_Task_.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace _18Aprel_Task_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            StadionData stadionData = new StadionData();
            UsersData usersData = new UsersData();
            ReservationData reservationData = new ReservationData();

            string choise;
            bool check = true;
            do
            {
                
                Console.WriteLine(" 1. Stadion əlavə et");
                Console.WriteLine(" 2. Stadionları göstər");
                Console.WriteLine(" 3. İstifadəçi əlavə et");
                Console.WriteLine(" 4. İstifadəçiləri göstər");
                Console.WriteLine(" 5. Rezervasiyaları göstər");
                Console.WriteLine(" 6. Rezervasiya yarat");
                Console.WriteLine(" 7. Verilmiş id-li stadionun rezervasiyalarını göstər");
                Console.WriteLine(" 8. Verilmiş id-li userin rezervasiyalarını göstər");
                Console.WriteLine(" 9. Verilmiş id-li rezervasiyanı sil");
                choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        stadionData.InsertStadion();
                        break;
                        case "2":
                        stadionData.SelectStadions();
                        break;
                        case"3":
                        usersData.InsertUser();
                        break;
                        case"4":
                        usersData.SelectUser();
                        break;
                        case"5":
                        reservationData.SelectReservation();
                        break;
                        case"6":
                        reservationData.SelectReservation();
                        break;
                    case "7":
                        Console.WriteLine("Id :");
                        int id = int.Parse(Console.ReadLine());
                        List<Reservation> reservations = reservationData.GetByIdStadions(id);
                        foreach (var reservation in reservations)
                        {
                            reservation.ShowInfoReservation();
                        }
                        break;
                    case "8":
                        Console.WriteLine("Id:");
                        int Id =int.Parse(Console.ReadLine());
                        List<Reservation> reservations1 = reservationData.GetByUserId(Id);
                        foreach (var reservation in reservations1)
                        {
                            reservation.ShowInfoReservationUser();
                        }

                        break;

                    default:
                        break;
                }


            } while (check);

            


        }
       
    }

}

