using System;
using System.Collections.Generic;
using System.Text;

namespace _18Aprel_Task_.Models
{
    internal class Reservation
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StadionId { get; set; }  
        public int UserId { get; set; }
        List<Reservation> Reservations { get; set; }
        public void ShowInfoReservation()
        {
            Console.WriteLine($"Stadion Id:{StadionId}, StartDate:{StartDate},EndDate:{EndDate}");
        }
        public void ShowInfoReservationUser()
        {
            Console.WriteLine($"User Id:{UserId},StarDate:{StartDate},EndDate:{EndDate}");
        }
    }
}
