using NoorAirLine.Models;
using NoorAirLine.Enums;
using System;
namespace NoorAirLine.Repositories
{
    public class PassengerRepo
    {
        public static int myIndex = 0;
        private static int count = 1;
        public  Passenger[] passengers = new Passenger[40];

        public void Register(string fName, string lName, string email, Gender gender, DateTime dateOfBirth,
         string address, string PhoneNumber,string password, string nextOfKin)
        {
            var passenger = new Passenger(count, fName, lName, email, gender, dateOfBirth, password, PhoneNumber,
             address, nextOfKin);
             passengers[myIndex] = passenger;
             Console.WriteLine($"You have successfully created an account and your passenger number is{passenger.PassengerNumber}");
             count++;
             myIndex++;
        }
        
        public Passenger Login(string email, string password)
        {
            var Passenger = GetPassenger(email);
            if (Passenger != null && Passenger.Password == password)
            {
                return Passenger;
            }
            return null;
        }

        private Passenger GetPassenger(string email)
        {
            for (int i = 0; i < myIndex;i++)
            {
                if (passengers[i] != null && passengers[i].Email == email)
                {
                    return passengers[i];
                }
            }
            return null;
        }
        public void FundWallet(Passenger passenger)
        {
            Console.WriteLine("Enter amount to credit your wallet");
            decimal amount = decimal.Parse(Console.ReadLine());
            passenger.Wallet += amount;

        }
    }
}