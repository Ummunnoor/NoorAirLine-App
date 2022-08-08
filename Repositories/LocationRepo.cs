using System;
using NoorAirLine.Models;
using NoorAirLine.Enums;
namespace NoorAirLine.Repositories
{
    public class LocationRepo
    {
        public static int myIndex = 1;
        private static int id = 1;
        public Location[] locations = new Location[20];

        public void  CreateLocation()
        {
            System.Console.WriteLine("Enter Location Name");
            string locationName = Console.ReadLine(); 
            System.Console.WriteLine("Enter Take off point Location ");
            string takeOffPointLocationName = Console.ReadLine();
            System.Console.WriteLine("Enter Landing point Location Name");
            string landingPointLocationName = Console.ReadLine();
            var location = new Location(id, takeOffPointLocationName,landingPointLocationName);
            locations[myIndex] = location;
            Console.WriteLine("Location has been added successfully");
            myIndex++;
            id++;
        }

        public Location GetTakeOffPointLocation(string takeOffPointLocation)
        {
            for (int i = 0; i < myIndex;i++)
            {
                if (locations[i] != null && locations[i].TakeOffPointLocation == takeOffPointLocation)
                {
                    return locations[i];
                }
                
            }
            return null;
        }

        public Location GetLandingPointLocation(string landingPointLocation)
        {
            for (int i = 0; i < myIndex;i++)
            {
                if (locations[i] != null && locations[i].LandingPointLocation == landingPointLocation)
                {
                    return locations[i];
                }
                
            }
            return null;
        }

        
    }
    
}

