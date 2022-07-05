using System;
using NoorAirLine.Enums;
using NoorAirLine.Models;
using NoorAirLine.Repositories;
using NoorAirLine.Repositories;

namespace NoorAirLine.Menus
{
    public class StaffMenu
    {
        StaffRepo staffRepo = new StaffRepo();
        FlightRepo flightRepo = new FlightRepo();
        LocationRepo locationRepo = new LocationRepo();


        public StaffMenu()
        {

        }
        public void StaffOption()
        {
            Console.WriteLine("WELCOME TO OUR STAFF PAGE");
            Console.WriteLine("Enter 1 to Login. \tEnter 0 to Main Menu.");
            int option;
            while (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid input, Enter 1 or 0: ");
            }
            switch (option)
            {
                case 1:
                    LogIn();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Invalid input ");
                    break;;
            }
        }
        public void LogIn()
        {
            Console.WriteLine("Enter your Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            var staff = staffRepo.GetStaff(email,password);
            if (staff != null && staff.Email == email)
            {
               Console.WriteLine("succesfully loged in");
                locationRepo.CreateLocation();
            }
            else if(staff != null && staff.Role == Enums.Role.Admin)
            {
                PrintSubMenu();
            }
            
            else
            {
                Console.WriteLine("YOU DO NOT HAVE AN ACCOUNT YET");
            }
        }

        // public void Login()
        // {
        //     var loginSuccessful = staffRepo.LogIn();
        //     if (loginSuccessful != null && loginSuccessful.Role == Role.Admin)
        //     {
        //         PrintSubMenu();
        //     }
        //     else if (loginSuccessful == null)
        //     {
        //         Console.WriteLine("Invalid username or password");
        //     }
        // }
        public void PrintSubMenu()
        {
            Console.WriteLine("Enter 1 to add new staff. \n Enter 2 to add location \n Enter 3 to add flight");
            int option;
            while (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Please enter a valid input ");
            }
            switch (option)
            {
                case 1:
                    staffRepo.AddNewStaff();
                    break;
                case 2:
                    locationRepo.CreateLocation();
                    break;
                case 3:
                    flightRepo.CreateFlight();
                    break;
                default:
                    Console.WriteLine("Enter 1 or 0: ");
                    return;
            }
        }
    }
}
// I want to live a life of impact\\\\\\\\\


