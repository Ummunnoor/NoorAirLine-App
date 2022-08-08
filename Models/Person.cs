using System;
using NoorAirLine.Enums;
using NoorAirLine.Models;
namespace NoorAirLine.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string NextOfKin { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person()
        {
            
        }
        public Person(int id, string firstName, string lastName, string email, string phoneNumber,
        string password, string nextOfKin, Gender gender, string address, DateTime dateOfBirth)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Password = password;
            NextOfKin = nextOfKin;
            Gender = gender;
            Address = address;
            DateOfBirth = dateOfBirth;
        }
        public string FullName()
        {
            return $"{FirstName}  {LastName}";
        }

    }


}

