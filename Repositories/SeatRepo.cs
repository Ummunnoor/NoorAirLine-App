using System;
using NoorAirLine.Models;
using NoorAirLine.Enums;
namespace NoorAirLine.Repositories
{
    public class SeatRepo
    {
        
        private static int myIndex = 1;  
        public static int count = 1;

        public static Seat[] seats = new Seat[50];
        
        public void CreateSeat(string seatNumber)
        {
            
            var seat = new Seat(count, seatNumber);
            seats[myIndex] = seat;
            Console.WriteLine($"Seat with number {seatNumber} has been added successfully");
            count++;
            myIndex++;
        }
        public Seat GetSeat(int count)
        {
            for (int i = 0; i < myIndex; i++)
            {
                if (seats[i] != null && seats[i].Count == count)
                {
                    return seats[i];
                }
            }
            return null;
        }
    }

}
