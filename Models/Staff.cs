using System;
using NoorAirLine.Enums;
namespace NoorAirLine.Models
{
    public class Staff: Person
    {
        public string staffNumber { get; set; }
        public Role Role { get; set; } 
        public Staff(int id, string firstName, string lastName, string email, Gender gender,
         DateTime dateOfBirth, string Password, string PhoneNumber, string address, string nextOfKin,Role role
         ): base(id, firstName,lastName,email, PhoneNumber, Password, nextOfKin, gender, 
         address,dateOfBirth)
        {
            staffNumber = $"ST{Guid.NewGuid().ToString().Replace("-","").Substring(0,5).ToUpper()}";
        }
    }
}