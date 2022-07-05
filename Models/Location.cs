using System;
using NoorAirLine.Models;
using NoorAirLine.Enums;
namespace NoorAirLine.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string TakeOffPointLocation { get; set; }
        public string LandingPointLocation { get; set; }

        public Location(int id,string takeOffPointLocation, string landingPointLocation)
        {
            Id = id;
            TakeOffPointLocation = takeOffPointLocation;
            LandingPointLocation = landingPointLocation;
        }
    }
}