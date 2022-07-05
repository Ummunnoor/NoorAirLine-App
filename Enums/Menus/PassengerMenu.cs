using System;
using NoorAirLine.Enums;
using NoorAirLine.Models;
using NoorAirLine.Repositories;

namespace NoorAirLine.Menus
{
    public class PassengerMenu
    {
        PassengerRepo passengerRepo = new PassengerRepo();
        public void Menu()
        {
            bool exit = false;
            do
            {
                Console.WriteLine("Enter 1 to Register");
                Console.WriteLine("Enter 2 to Login");
                Console.WriteLine("Enter 3 to book a flight");
                Console.WriteLine("Enter 0 to exit");

                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Register();
                        break;
                    case 2:
                        LogIn();
                        break;
                    case 3:
                        BookFlight();
                        break;
                    case 0:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine($"Invalid credentials...\nEnter any key to try again");
                        Console.ReadKey();
                        break;
                }
            } while (!exit);
        }

        public void Register()
        {
            Console.WriteLine("Enter your first name: ");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter your Last name: ");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter Your Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Enter your gender:1. for Male 2. for Female 3.Others  ");
            int gender;
            while (!int.TryParse(Console.ReadLine(), out gender))
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine("Re-enter your gender");
            }
            Console.WriteLine("Enter your Date of Birth in this format:dd-mm-yyyy ");
            DateTime dateOfBirth;
            while (!DateTime.TryParse(Console.ReadLine(), out dateOfBirth))
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine("Re-enter date of Birth: ");
            }

            Console.WriteLine("Enter Your Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Your Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Your next of kin: ");
            string nextOfKin = Console.ReadLine();
            passengerRepo.Register(fName, lName, email, (Gender)gender, dateOfBirth, address,
             phoneNumber, password, nextOfKin);
        }
        public void LogIn()
        {
            Console.WriteLine("Enter Your Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();
            var loginSuccessful = passengerRepo.Login(email, password);

            Console.WriteLine(loginSuccessful != null ? "Login Successful" : "Invalid Credentials");
        }



        public void ListAllFlights()
        {
            FlightRepo flightRepo = new FlightRepo();

            Console.WriteLine("YOU ARE WELCOME TO NOOR AIRLINE");
            Console.WriteLine("Enter 1 to get available flight\t ENTER 2 to go back to main menu");
            int option;
            while (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid Input, Enter 1 or 0");
            }
            switch (option)
            {
                case 1:
                    flightRepo.PrintAllFlights();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    return;

            }
        }
        public void BookFlight()
        {

        }
    }
}