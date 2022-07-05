using System;
using NoorAirLine.Enums;
using NoorAirLine.Models;

namespace NoorAirLine.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string PassengerName { get; set; }
        public string BookingReference { get; set; }
        public int PassengerId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime BookedDate { get; set; }
        public Status Status { get; set; } 
        public DateTime BoardDate { get; set; }
        

        public Booking(int id, string passengerName,  int passengerId,DateTime departureTime
        )
        {
            Id = id;
            PassengerName = passengerName;
            BookingReference = $"{Guid.NewGuid().ToString().Replace("-", "").Substring(0, 6).ToUpper()}";
            DepartureTime = departureTime;
            BookedDate = DateTime.UtcNow;
            Status = Status.Default;
        }
 
    }
}