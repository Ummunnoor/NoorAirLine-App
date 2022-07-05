using System;
using NoorAirLine.Enums;
using NoorAirLine.Models;
namespace NoorAirLine.Repositories
{
    public class FlightRepo
    {
        public static int myIndex = 1;
        public static int count = 1;
        public List<Flight> Flights = new List<Flight>();
        public void SeedFlight(int id, decimal price, string takeOffPoint, string landingPoint, DateTime takeOffTime,
         DateTime landingTime, DateTime takeOffDate, int availableNumberOfSeat)
        {
            var flight1 = new Flight(id = 1, price = 20000, takeOffPoint = "Ibadan", landingPoint = "Lagos", takeOffTime = new DateTime(2008, 4, 10, 6, 30, 0), landingTime = new DateTime(2008, 4, 10, 7, 20, 0), takeOffDate = new DateTime(2008, 4, 10, 6, 30, 0), availableNumberOfSeat = 200);
            var flight2 = new Flight(id = 2, price = 30000, takeOffPoint = "Kano", landingPoint = "Ibadan", takeOffTime = new DateTime(2008, 4, 10, 7, 00, 0), landingTime = new DateTime(2008, 4, 10, 8, 30, 0), takeOffDate = new DateTime(2008, 4, 10, 6, 30, 0), availableNumberOfSeat = 250);
            var flight3 = new Flight(id = 3, price = 40000, takeOffPoint = "Abuja", landingPoint = "Lagos", takeOffTime = new DateTime(2008, 4, 10, 7, 30, 0), landingTime = new DateTime(2008, 4, 10, 8, 30, 0), takeOffDate = new DateTime(2008, 4, 10, 6, 30, 0), availableNumberOfSeat = 250);
            var flight4 = new Flight(id = 4, price = 50000, takeOffPoint = "Lagos", landingPoint = "Kaduna", takeOffTime = new DateTime(2008, 4, 10, 8, 00, 0), landingTime = new DateTime(2008, 4, 10, 9, 30, 0), takeOffDate = new DateTime(2008, 4, 10, 6, 30, 0), availableNumberOfSeat = 350);
            var flight5 = new Flight(id = 5, price = 60000, takeOffPoint = "Nassarawa", landingPoint = "Plateau", takeOffTime = new DateTime(2008, 4, 10, 8, 30, 0), landingTime = new DateTime(2008, 4, 10, 9, 15, 05), takeOffDate = new DateTime(2008, 4, 10, 6, 30, 0), availableNumberOfSeat = 200);
            var flight6 = new Flight(id = 6, price = 20000, takeOffPoint = "Ibadan", landingPoint = "Lagos", takeOffTime = new DateTime(2008, 4, 10, 6, 30, 0), landingTime = new DateTime(2008, 4, 10, 7, 20, 0), takeOffDate = new DateTime(2008, 4, 10, 6, 30, 0), availableNumberOfSeat = 300);
            var flight7 = new Flight(id = 7, price = 30000, takeOffPoint = "Kano", landingPoint = "Ibadan", takeOffTime = new DateTime(2008, 4, 10, 7, 00, 0), landingTime = new DateTime(2008, 4, 10, 8, 30, 0), takeOffDate = new DateTime(2008, 4, 10, 6, 30, 0), availableNumberOfSeat = 250);
            var flight8 = new Flight(id = 8, price = 45000, takeOffPoint = "Abuja", landingPoint = "Lagos", takeOffTime = new DateTime(2008, 4, 10, 7, 30, 0), landingTime = new DateTime(2008, 4, 10, 8, 30, 0), takeOffDate = new DateTime(2008, 4, 10, 6, 30, 0), availableNumberOfSeat = 400);
            var flight9 = new Flight(id = 9, price = 40000, takeOffPoint = "Lagos", landingPoint = "Kaduna", takeOffTime = new DateTime(2008, 4, 10, 8, 00, 0), landingTime = new DateTime(2008, 4, 10, 9, 30, 0), takeOffDate = new DateTime(2008, 4, 10, 6, 30, 0), availableNumberOfSeat = 300);
            var flight10 = new Flight(id = 10, price = 50000, takeOffPoint = "Nassarawa", landingPoint = "Borno", takeOffTime = new DateTime(2008, 4, 10, 8, 30, 0), landingTime = new DateTime(2008, 4, 10, 8, 45, 0), takeOffDate = new DateTime(2008, 4, 10, 6, 30, 0), availableNumberOfSeat = 300);

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
            myIndex++;
            count++;
            GetAvailableFlighht(takeOffTime, landingPoint, takeOffPoint);

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
            while (!DateTime.TryParse(Console.ReadLine(), out takeOffTime)) ;
            {
                Console.WriteLine("Invalid input");
            }
            Console.WriteLine("Enter your Landing Time in this format:dd-mm-yyyy ");
            DateTime landingTime;
            while (!DateTime.TryParse(Console.ReadLine(), out landingTime)) ;
            {
                Console.WriteLine("Invalid input");
            }
            Console.WriteLine("Enter your Take-Off Date in this format:dd-mm-yyyy ");
            DateTime takeOffDate;
            while (!DateTime.TryParse(Console.ReadLine(), out takeOffDate)) ;
            {
                Console.WriteLine("Invalid input");
            } 
            Console.WriteLine("Enter Available Number Of Seats");
            int availableNumberOfSeat = int.Parse(Console.ReadLine());
            int id = Flights.Count+1;
            var flight = new Flight(id, price, takeOffPoint, landingPoint, takeOffTime,
            landingTime, takeOffDate, availableNumberOfSeat);
            Flights.Add(flight);
            Console.WriteLine("Flights has been created successfully");
        }

        public Flight EditFlight(int id)
        {
            for (int i = 0; i < myIndex; i++)
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
            for (int i = 0; i < myIndex; i++)
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
            for (int i = 0; i < myIndex; i++)
            {
                Flights.ToList();
            }
            return Flights;
        }
        public void PrintAllFlights()
        {
            var flights = GetAvailableFlights();
            foreach(var flight in flights)
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

        public List<Flight> GetAvailableFlighht(DateTime takeOffTime, string landingPoint, string takeOffPoint)
        {
            for (int i = 0; i < myIndex; i++)
            {
                if (Flights[i] != null && Flights[i].TakeOffTime == takeOffTime)
                {
                    if (Flights[i].LandingPoint == landingPoint && Flights[i].TakeOffPoint == takeOffPoint)
                    {
                        var allAvailableFlights = Flights.ToList();
                        return allAvailableFlights;
                    }
                }
            }
            return null;

        }



    }
}