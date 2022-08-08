using System;
using NoorAirLine.Enums;
using MySql.Data.MySqlClient;
using NoorAirLine.Models;
namespace NoorAirLine.Repositories
{
    public class FlightRepo
    {
        public static List<Flight> Flights = new List<Flight>();
        public static void SeedFlight()
        {
            var flight1 = new Flight(1, 20000, "Ibadan", 1, "Lagos", new DateTime(2008, 4, 10, 6, 30, 0), new DateTime(2008, 4, 10, 7, 20, 0), new DateTime(2008, 4, 10, 6, 30, 0), 200);
            var flight2 = new Flight(2, 30000, "Kano", 2, "Ibadan", new DateTime(2008, 4, 10, 7, 00, 0), new DateTime(2008, 4, 10, 8, 30, 0), new DateTime(2008, 4, 10, 6, 30, 0), 250);
            var flight3 = new Flight(3, 40000, "Abuja", 3, "Lagos", new DateTime(2008, 4, 10, 7, 30, 0), new DateTime(2008, 4, 10, 8, 30, 0), new DateTime(2008, 4, 10, 6, 30, 0), 250);
            var flight4 = new Flight(4, 50000, "Lagos", 2, "Kaduna", new DateTime(2008, 4, 10, 8, 00, 0), new DateTime(2008, 4, 10, 9, 30, 0), new DateTime(2008, 4, 10, 6, 30, 0), 350);
            var flight5 = new Flight(5, 60000, "Nassarawa", 4, "Plateau", new DateTime(2008, 4, 10, 8, 30, 0), new DateTime(2008, 4, 10, 9, 15, 05), new DateTime(2008, 4, 10, 6, 30, 0), 200);
            var flight6 = new Flight(6, 20000, "Ibadan", 1, "Lagos", new DateTime(2008, 4, 10, 6, 30, 0), new DateTime(2008, 4, 10, 7, 20, 0), new DateTime(2008, 4, 10, 6, 30, 0), 300);
            var flight7 = new Flight(7, 30000, "Kano", 2, "Ibadan", new DateTime(2008, 4, 10, 7, 00, 0), new DateTime(2008, 4, 10, 8, 30, 0), new DateTime(2008, 4, 10, 6, 30, 0), 250);
            var flight8 = new Flight(8, 45000, "Abuja", 5, "Lagos", new DateTime(2008, 4, 10, 7, 30, 0), new DateTime(2008, 4, 10, 8, 30, 0), new DateTime(2008, 4, 10, 6, 30, 0), 400);
            var flight9 = new Flight(9, 40000, "Lagos", 6, "Kaduna", new DateTime(2008, 4, 10, 8, 00, 0), new DateTime(2008, 4, 10, 9, 30, 0), new DateTime(2008, 4, 10, 6, 30, 0), 300);
            var flight10 = new Flight(10, 50000, "Nassarawa", 4, "Borno", new DateTime(2008, 4, 10, 8, 30, 0), new DateTime(2008, 4, 10, 8, 45, 0), new DateTime(2008, 4, 10, 6, 30, 0), 300);

            Flights.Add(flight1);
            Flights.Add(flight2);
            Flights.Add(flight3);
            Flights.Add(flight4);
            Flights.Add(flight5);
            Flights.Add(flight6);
            Flights.Add(flight7);
            Flights.Add(flight8);
            Flights.Add(flight9);
            Flights.Add(flight10);

            Console.WriteLine("Flights has been created successfully");

        }
        public void CreateFlight()
        {
            System.Console.WriteLine("Enter Flight Price");
            decimal price = decimal.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Take-Off Point");
            string takeOffPoint = Console.ReadLine();
            System.Console.WriteLine("Enter Landing Point");
            string landingPoint = Console.ReadLine();
            Console.WriteLine("Enter your Take-Off Time in this format:dd-mm-yyyy ");
            DateTime takeOffTime;
            while (!DateTime.TryParse(Console.ReadLine(), out takeOffTime))
            {
                Console.WriteLine("Invalid input");
            }
            Console.WriteLine("Enter your Landing Time in this format:dd-mm-yyyy ");
            DateTime landingTime;
            while (!DateTime.TryParse(Console.ReadLine(), out landingTime))
            {
                Console.WriteLine("Invalid input");
            }
            Console.WriteLine("Enter your Take-Off Date in this format:dd-mm-yyyy ");
            DateTime takeOffDate;

            while (!DateTime.TryParse(Console.ReadLine(), out takeOffDate))
            {
                Console.WriteLine("Invalid input");
            }
            Console.WriteLine("Enter Available Number Of Seats");
            int availableNumberOfSeat = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the aircraft Id");
            int airCraftId = int.Parse(Console.ReadLine());
            int id = Flights.Count + 1;
            var flight = new Flight(id, price, takeOffPoint, airCraftId, landingPoint, takeOffTime,
            landingTime, takeOffDate, availableNumberOfSeat);
            Flights.Add(flight);
            Console.WriteLine("Flights has been created successfully");
        }

        public Flight EditFlight(int id)
        {
            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i] != null && Flights[i].Id == id)
                {
                    Flights.Remove(Flights[i]);
                }
            }
            return null;
        }


        public Flight DeleteFlight(int id)
        {
            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i] != null && Flights[i].Id == id)
                {
                    return Flights[i];
                }
            }
            return null;
        }
        public List<Flight> GetAvailableFlights()
        {
            for (int i = 0; i < Flights.Count; i++)
            {
                Flights.ToList();
            }
            return Flights;
        }
        public void PrintAllFlights()
        {
            var flights = GetAvailableFlights();
            foreach (var flight in flights)
            {
                var a = flight.Id;
                var b = flight.LandingPoint;
                var c = flight.LandingTime;
                var d = flight.Price;
                var e = flight.TakeOffDate;
                var f = flight.TakeOffPoint;
                var g = flight.TakeOffTime;
                var h = flight.AvailableNumberOfSeat;

                Console.WriteLine($"Id ={a}\t LandingPoint ={b}\t LandingTime = {c}\t Price = {d}\t TakeOffDate ={e}\t TakeOffPoint ={f}\t TakeOffTime ={g}\t AvailableNumberOfSeat = {h}");
            }
        }

        public void Tet()
        {
            Console.WriteLine("Teting...");
        }

        public Flight GetAvailableFlighht(DateTime takeOffTime, string landingPoint, string takeOffPoint)
        {
            foreach (var flight in Flights)
            {
                if (flight.LandingPoint == landingPoint && flight.TakeOffPoint == takeOffPoint)
                {
                    return flight;
                }
            }
            return null;

        }
        public Flight GetFlight(int id)
        {
            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i] != null && Flights[i].Id == id)
                {
                    return Flights[i];

                }
            }
            return null;

        }



    }
}