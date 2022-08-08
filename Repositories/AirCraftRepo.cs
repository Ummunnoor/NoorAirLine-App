using System;
using NoorAirLine.Models;
using NoorAirLine.Enums;

namespace NoorAirLine.Repositories
{
    public class AirCraftRepo
    {
        public static int myIndex = 0;
        public static int count = 1;
        public static List<AirCraft> airCrafts = new List<AirCraft>();
        public void CreateAirCraft(int id, string registrationNumber, int capacity,  string name)
        {
            AirCraft airCraft = new AirCraft(count, registrationNumber, capacity,  name);
            airCrafts[myIndex] = airCraft;
            Console.WriteLine("Aircraft created successfully...");
            myIndex++;
            count++;
        }
         public AirCraft GetAirCraft()
        {
            for (int i = 0; i < airCrafts.Count; i++)
            {
                if (airCrafts[i] != null )
                {
                    return airCrafts[i];
                }
            }
            return null;
        }

        public AirCraft GetAirCraft(int seatNumber)
        {
            for (int i = 0; i < airCrafts.Count;i++)
            {
                if (airCrafts[i] != null && airCrafts[i].Capacity == seatNumber)
                {
                    return airCrafts[i];
                }
            }
            return null;
        }
        public static void SeedAirCraft()
        {
            
            var AirCraft1 = new AirCraft(1, "Air/001", 250, "FlyEmirate" );
            var AirCraft2= new AirCraft(2, "Air/002", 250, "FlyEmirate" );
            var AirCraft3 = new AirCraft(3, "Air/003", 250, "FlyEmirate" );
            var AirCraft4 = new AirCraft(4, "Air/004", 250, "FlyEmirate" );
            var AirCraft5 = new AirCraft(5, "Air/005", 250, "FlyEmirate" );
            var AirCraft6 = new AirCraft(6, "Air/006", 250, "FlyEmirate" );
            var AirCraft7 = new AirCraft(7, "Air/007", 250, "FlyEmirate" );
            var AirCraft8 = new AirCraft(8, "Air/008", 250, "FlyEmirate" );
            var AirCraft9 = new AirCraft(9, "Air/009", 250, "FlyEmirate" );
            var AirCraft10 = new AirCraft(10, "Air/010", 250, "FlyEmirate" );
            
            airCrafts.Add(AirCraft1);
            airCrafts.Add(AirCraft2);
            airCrafts.Add(AirCraft3);
            airCrafts.Add(AirCraft4);
            airCrafts.Add(AirCraft5);
            airCrafts.Add(AirCraft6);
            airCrafts.Add(AirCraft7);
            airCrafts.Add(AirCraft8);
            airCrafts.Add(AirCraft9);
            airCrafts.Add(AirCraft10);

        }
    }
}