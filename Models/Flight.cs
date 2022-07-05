using System;
using NoorAirLine.Enums;
using NoorAirLine.Models;
namespace NoorAirLine.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string TakeOffPoint { get; set;}
        public string LandingPoint { get; set;}
        public DateTime TakeOffTime { get; set;}
        public DateTime LandingTime { get; set;}
        public DateTime TakeOffDate { get; set; }
        public int AvailableNumberOfSeat { get; set; }

        public Flight(int id, decimal price, string takeOffPoint, string landingPoint, DateTime takeOffTime,
        DateTime landingTime, DateTime takeOffDate, int availableNumberOfSeat)
        {
            Id =id;
            Price = price;
            TakeOffPoint = takeOffPoint;
            LandingPoint = landingPoint;
            TakeOffTime = takeOffTime;
            LandingTime = landingTime;
            TakeOffDate = takeOffDate;
            AvailableNumberOfSeat = availableNumberOfSeat;
        }
    }
}