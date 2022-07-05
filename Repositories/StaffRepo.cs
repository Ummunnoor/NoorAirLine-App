using System;
using NoorAirLine.Models;
using NoorAirLine.Enums;
namespace NoorAirLine.Repositories
{
    public class StaffRepo
    {
        public static int count = 1;
        public static Staff[] staffs = new Staff[20];
         private static int myIndex = 1;
         LocationRepo locationRepo = new LocationRepo();
        public StaffRepo()
        {
            var staff = new Staff(1, "Sherif", "Akinyemi", "ashraff2007@gmail.com", Gender.Male,
             DateTime.Parse("1990-01-02"), "Ilori villa,Apata,Ibadan", "08132972088",
             "noorthelight", "Khaleelah Uthman");

            staffs[myIndex] = staff;
        }
        public void AddNewStaff()
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
            }
            Console.WriteLine("Enter your Date of Birth in this format:dd-mm-yyyy ");
            DateTime dateOfBirth;
            while (!DateTime.TryParse(Console.ReadLine(), out dateOfBirth)) ;
            {
                Console.WriteLine("Invalid input");
            }
            Console.WriteLine("Enter Your Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Your Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Your next of kin: ");
            string nextOfKin = Console.ReadLine();
            int id = count;
            Staff staff = new Staff(id, fName, lName, email, (Gender)gender, dateOfBirth, address, phoneNumber, password,
            nextOfKin);
            staffs[myIndex] = staff;
            myIndex++;
            count++;
        }

        
        public Staff GetStaff(string email,string password)
        {
            for (int i = 0; i < myIndex; i++)
            {
                if (staffs[i] != null && staffs[i].Password == password)
                {
                    return staffs[i];
                }
            }
            return null;
        }
    }
}
