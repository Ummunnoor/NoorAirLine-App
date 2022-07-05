using System;
using NoorAirLine.Models;
using NoorAirLine.Enums;

namespace NoorAirLine.Repositories
{
    public class AirCraftRepo
    {
        public AirCraftRepo airCraftRepo = new AirCraftRepo(); 
        public static int myIndex = 1;
        public static int count = 1;
        public static AirCraft[] airCrafts = new AirCraft[8];
        public void CreateAirCraft(int id, string registrationNumber,int capacity, string name)
        {
            AirCraft airCraft = new AirCraft(id, registrationNumber, capacity, name);
            airCrafts[myIndex] = airCraft;
            Console.WriteLine("Aircraft created successfully...");
            myIndex++;
            count++;
        }
         public AirCraft GetAirCraft(string name)
        {
            for (int i = 0; i < myIndex; i++)
            {
                if (airCrafts[i] != null && airCrafts[i].Name == name)
                {
                    return airCrafts[i];
                }
            }
            return null;
        }
        public AirCraft GetAirCraft(int seatNumber)
        {
            for (int i = 0; i < myIndex;i++)
            {
                if (airCrafts[i] != null && airCrafts[i].Capacity == seatNumber)
                {
                    return airCrafts[i];
                }
            }
            return null;
        }
    }
}