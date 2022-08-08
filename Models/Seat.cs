using System;
using NoorAirLine.Models;
using NoorAirLine.Enums;
namespace NoorAirLine.Models
{
    public class Seat
    {
        public int Count{ get; set; }
        public int SeatNumber{ get; set; }
        Random random = new Random();
        public Seat(int count, string seatNumber)
        {
            Count = count;
            SeatNumber = random.Next(3,20);
        }
    }
}