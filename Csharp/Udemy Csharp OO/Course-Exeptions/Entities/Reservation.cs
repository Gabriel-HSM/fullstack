using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Exeptions.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            RoomNumber = roomNumber;
            CheckIn = checkin;
            Checkout = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDate(DateTime checkin, DateTime checkout)
        {
            CheckIn = checkin;
            Checkout = checkout;
        }

        public override string ToString()
        {
            return "Room " 
            + RoomNumber 
            + ", check-in: " 
            + CheckIn.ToString("dd/MM/yyyy")
            + ", check-out: "
            + Checkout.ToString("dd/MM/yyyy")
            + ", "
            + Duration()
            + " nights";
        }
    }
}