using System;
using NoorAirLine.Enums;
using NoorAirLine.Menus;
using NoorAirLine.Models;
using NoorAirLine.Repositories;
using NoorAirLine.Repositories;

namespace NoorAirLine.Menus
{
    public class MainMenu
    {
        static StaffMenu staffMenu = new StaffMenu();
        static PassengerMenu passengerMenu = new PassengerMenu();

        public static void Menu()
        {
           

           

                Console.WriteLine("WELCOME TO Noor AIRLINE");
                Console.WriteLine("Enter 1 to Passenger Menu. \nEnter 2 to Staff Menu. \nEnter 0 to Exit.");
                int option;
                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid input, Enter 1 or 0: ");
                }
                switch (option)
                {
                    case 0:

                        break;
                    case 1:
                        passengerMenu.Menu();
                        break;
                    case 2:
                        staffMenu.StaffOption();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Invalid input ");
                        break;
                }
           
        }
    }
}


