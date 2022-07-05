using System;
using NoorAirLine.Enums;
namespace NoorAirLine.Models
{
    public class Passenger: Person
    {
      public string PassengerNumber { get; set; }
      public decimal Wallet { get; set; }
       

        public Passenger(int id, string firstName, string lastName, string email, Gender gender,
         DateTime dateOfBirth, string Password, string PhoneNumber, string address, string nextOfKin):base
         (id, firstName,lastName,email, PhoneNumber,Password,nextOfKin, gender, address,  dateOfBirth)
         {
            PassengerNumber = $"CU{Guid.NewGuid().ToString().Replace("-","").Substring(0,5).ToUpper()}";
            Wallet = 0.00m;
         }
         

    }
}