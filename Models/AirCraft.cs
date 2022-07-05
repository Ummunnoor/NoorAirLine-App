using System;
using NoorAirLine.Enums;
using NoorAirLine.Repositories;
namespace NoorAirLine.Models
{
    public class AirCraft
    {
        public int Id;
        public string RegistrationNumber;
        public int Capacity;
        public string Name;
        
        public AirCraft(int id, string registrationNumber, int capacity, string name)
        {
            Id = id;
            RegistrationNumber = $"RN{Guid.NewGuid().ToString().Replace("-","").Substring(0,7).ToUpper()}";
            Capacity = capacity;
            Name = name;
            
            
            
        }
    }
}