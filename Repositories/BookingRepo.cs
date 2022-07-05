using System;
using NoorAirLine.Enums;
using NoorAirLine.Models;
namespace NoorAirLine.Repositories
{
    public class BookingRepo
    {
        public static int myIndex = 1;
        public static int count = 1;
        private readonly FlightRepo flightRepo;
        private readonly AirCraftRepo airCraftRepo;
        private readonly PassengerRepo passengerRepo;
        public List<Booking> Bookings = new List<Booking>();
        public static Passenger[] passengers = new Passenger[40];
        public BookingRepo()
        {

        }
        public BookingRepo(FlightRepo _flightRepo, AirCraftRepo _airCraftRepo, PassengerRepo _passengerRepo)
        {
            flightRepo = _flightRepo;
            airCraftRepo = _airCraftRepo;
            passengerRepo = _passengerRepo;
        }

        public void BookFlight()
        {
            FlightRepo flightRepo = new FlightRepo();
            PassengerRepo passengerRepo = new PassengerRepo();
            Console.WriteLine("Enter your Email to Login: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();
            var log = passengerRepo.Login(email, password);
            if (log != null)
            {
                var name = log.FullName;
                int psId = log.Id;
                Console.WriteLine($"Dear {name} , you are welcome, continue to book your flight ");
                System.Console.WriteLine("Enter your takeOff time, format:dd-mm-yyyy");
                DateTime takeOffTime = DateTime.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter your Destination point");
                string destination = Console.ReadLine();
                System.Console.WriteLine("Enter your takeOff point");
                string takeOffPoint = Console.ReadLine();
                System.Console.WriteLine("How many seat do you want to book");
                int seat = int.Parse(Console.ReadLine());
                var flights = flightRepo.GetAvailableFlighht(takeOffTime, takeOffPoint, destination);
                if (flights != null)
                {
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
                        h -= seat;
                    }
                    System.Console.WriteLine("Enter the id of the flight you want to book");
                    int bookId = int.Parse(Console.ReadLine());
                    int id = Bookings.Count+1;
                    var bookings = new Booking(id,log.FirstName, psId,takeOffTime);
                    var bookref = bookings.BookingReference;
                    Bookings.Add(bookings);
                    System.Console.WriteLine("Flight Sucessfully Booked");
                    System.Console.WriteLine($"Your booking Ref is {bookref}");
                }
                else
                {
                    System.Console.WriteLine("This particular flight is not available, please book another flight");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid details");
                return;
            }
        }
    }
}