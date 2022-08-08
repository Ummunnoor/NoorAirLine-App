using System;
using NoorAirLine.Models;
using NoorAirLine.Enums;
namespace NoorAirLine.Repositories
{
    public class StaffRepo
    {
        
        public static List<Staff> Staffs = new List<Staff>();
        private static int count = 1;
        LocationRepo locationRepo = new LocationRepo();
        public StaffRepo()
        {
            var staff1 = new Staff(1, "Sherif", "Akinyemi", "ashraff2007@gmail.com", Gender.Male,
             DateTime.Parse("1990-01-02"), "noorthelight", "08132972088",
             "Ilori villa,Apata,Ibadan", "Khaleelah Uthman", Role.Admin);
            var staff2 = new Staff(2, "Azeemah", "Hamzat", "azeemah@gmail.com", Gender.Female,
           DateTime.Parse("2001-02-18"), "lucifer", "08123456789",
           "Ilori villa,Apata,Ibadan", "Mazeedah Hamzat", Role.AirHostess);
            var staff3 = new Staff(3, "Masturah", "Omolola", "masturah07@gmail.com", Gender.Female,
           DateTime.Parse("2000-01-02"), "noor", "08132972088",
           "Ilori villa,Apata,Ibadan", "Ajiun", Role.pilots);
            var staff4 = new Staff(4, "Sherif", "Akinyemi", "sak@gmail.com", Gender.Male,
           DateTime.Parse("1990-01-02"), "noorthelight", "08132972088",
           "Ilori villa,Apata,Ibadan", "Khaleelah Uthman", Role.pilots);
            var staff5 = new Staff(5, "Khaleelah", "Uthman", "abim2@gmail.com", Gender.Female,
           DateTime.Parse("1999-01-02"), "friend", "09035459984",
           "Ilori villa,Apata,Ibadan", "Nooruraheem", Role.HospitalityHost);
            Staffs.Add(staff1);
            Staffs.Add(staff2);
            Staffs.Add(staff3);
            Staffs.Add(staff4);
            Staffs.Add(staff5);
            Console.WriteLine("Staffs has been created successfully");
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
            while (!DateTime.TryParse(Console.ReadLine(), out dateOfBirth))
            {
                Console.WriteLine("Invalid input");
            }
            Console.WriteLine("Enter Your Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Your Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Your next of kin: ");
            string nextOfKin = Console.ReadLine();
            Console.WriteLine("Enter your role: 1. Pilots 2.Air Hostess 3.Admin 4.Hospitality Host");
            Role role;
            while (!Role.TryParse(Console.ReadLine(), out role))
            {
                Console.WriteLine("Invalid input");
            }

            int id = count;
            Staff staff = new Staff(id, fName, lName, email, (Gender)gender, dateOfBirth, address, phoneNumber, password,
            nextOfKin, role);
            Staffs.Add(staff);
            
            
        }
        public Staff LogIn(Role role)
        {
            for (int i = 0; i < Staffs.Count; i++)
            {
                if (Staffs[i] != null)
                {

                    return Staffs[i];
                }
            }
            return null;

        }


        public Staff GetStaff(string email, string password)
        {
            for (int i = 0; i < Staffs.Count; i++)
            {
                if (Staffs[i] != null && Staffs[i].Email == email && Staffs[i].Password == password)
                {
                    return Staffs[i];
                }
            }
            return null;
        }
    }
}
