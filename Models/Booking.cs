using System;
using NoorAirLine.Enums;
using NoorAirLine.Models;

namespace NoorAirLine.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string CreatorName { get; set; }
        public List<Passenger> Passengers { get; set; }
        public int FlightId {get; set;}
        public string BookingReference { get; set; }
        public int CreatorId { get; set; }
        public int SeatNumber{get; set;}
        public DateTime DepartureTime { get; set; }
        public DateTime BookedDate { get; set; }
        public Status Status { get; set; } 
        public DateTime BoardDate { get; set; }
        

        public Booking(int id, string creatorName, List<Passenger> passengerss,  int flightId, int creatorId, int seatNumber, DateTime departureTime
        )
        {
            Id = id;
            CreatorName = creatorName;
            Passengers = passengerss;
            FlightId = flightId;
            CreatorId = creatorId;
            SeatNumber = seatNumber;
            BookingReference = $"{Guid.NewGuid().ToString().Replace("-", "").Substring(0, 6).ToUpper()}";
            DepartureTime = departureTime;
            BookedDate = DateTime.UtcNow;
            Status = Status.Default;
        }
 
    }
}