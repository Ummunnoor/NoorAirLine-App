using System;
using NoorAirLine.Enums;
using NoorAirLine.Models;
namespace NoorAirLine.Repositories
{
    public class BookingRepo
    {
        public static int count = 1;
        AirCraftRepo airCraftRepo = new AirCraftRepo();
        static PassengerRepo passengerRepo = new PassengerRepo();
        Passenger passenger = new Passenger();
        public List<Booking> Bookings = new List<Booking>();
        public static List<Passenger> passengers = new List<Passenger>();
        FlightRepo flightRepo = new FlightRepo();

        public void BookFlight(string userEmail)
        {
            Random rand = new Random();
            Flight flight = null;
            Console.WriteLine($"Dear passenger, you are welcome, continue to book your flight ");
            System.Console.WriteLine("Enter your takeOff time, format:dd-mm-yyyy");
            DateTime takeOffTime;
            while (!DateTime.TryParse(Console.ReadLine(), out takeOffTime))
            {
                Console.WriteLine("Invalid input,Re-enter your takeoff time ");
            }
            System.Console.WriteLine("Enter your Destination point");
            string destination = Console.ReadLine();
            System.Console.WriteLine("Enter your takeOff point");
            string takeOffPoint = Console.ReadLine();
            System.Console.WriteLine("How many seat do you want to book");
            int seat;
            while (!int.TryParse(Console.ReadLine(), out seat))
            {
                Console.WriteLine("Invalid input");

            }

            flight = flightRepo.GetFlight(seat);
            if(flight == null)
            {
                Console.WriteLine("No Match found");
                return;
                
            }
           
            
            int noOfBookings = 0;
            foreach (var item in Bookings)
            {
                if (item.FlightId == flight.Id)
                {
                    noOfBookings++;
                }
            }
            if (seat > 1)
            {
                for (int i = 1; i <= seat; i++)
                {
                    System.Console.Write($"Enter name for passenger{i} First Name");
                    string passengersfName = Console.ReadLine();
                    System.Console.Write($"Enter name for passenger{i} Last Name");
                    string passengersLastName = Console.ReadLine();
                    System.Console.Write($"Enter passenger{i} Email");
                    string email = Console.ReadLine();
                    System.Console.Write($"Enter name for passenger{i} Gender 1 for male 2 for female");
                    var gender = (Gender)int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Enter passenger{i} Date of birth, format:dd-mm-yyyy");
                    DateTime dob;
                    while (!DateTime.TryParse(Console.ReadLine(), out dob))
                    {
                        Console.WriteLine("Invalid input,Re-enter your takeoff time ");
                    }
                    System.Console.Write($"Enter phone number for passenger{i}");
                    string phone = Console.ReadLine();
                    System.Console.Write($"Enter name for passenger{i}");
                    string passengersName = Console.ReadLine();
                    System.Console.Write($"Enter address for passenger{i}");
                    string address = Console.ReadLine();
                    System.Console.Write($"Enter next Of Kin for passenger{i}");
                    string nextOfKin = Console.ReadLine();
                    var SeatNumber = noOfBookings + i;
                    Passenger passenger = new Passenger(count, passengersfName, passengersLastName, email, gender, dob, "pass", phone,address,nextOfKin);
                    passengers.Add(passenger);
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    
                }
                System.Console.WriteLine($"The total amout to be paid is {flight.Price * seat}");
            }
            System.Console.WriteLine($"The total amout to be paid is {flight.Price}");
            if (passenger.Wallet < flight.Price)
            {
                Console.WriteLine("Your balance is too low, press 1 to fund wallet or any other key to cancel");
                int option = int.Parse(Console.ReadLine());
                bool exit = false;
                {
                    while(!exit)
                    {
                        if(option == 1)
                        {
                            passengerRepo.FundWallet(passenger);
                            Console.WriteLine($"Transaction successful, your new balance is {passenger.Wallet}");
                            passenger.Wallet -= flight.Price;
                            Console.WriteLine($"Payment successful, thanks for your patronage. Your new balance is {passenger.Wallet}");
                            exit = true;
                        }
                        else
                        {
                            {
                                exit = true;
                            }
                        }
                    }
                }
            }
            else if(passenger.Wallet > flight.Price )
            {
                 passenger.Wallet -= flight.Price;
                 Console.WriteLine($"Payment successful, thanks for your patronage. Your new balance is {passenger.Wallet-flight.Price}");
                          
            }
            var booking = new Booking(count, passenger.FullName(), passengers, passenger.FlightId, passenger.Id, rand.Next(1,7), DateTime.Now);
            Bookings.Add(booking);
            Console.WriteLine($"You have successfully booked a flight. Your booking reference is {booking.BookingReference} and your seat number is {booking.SeatNumber}");
        }
        // public static void Pay(decimal price,string Email)
        // {
        //     var passenger = passengerRepo.GetPassenger(Email);
            
        // }

    }
}