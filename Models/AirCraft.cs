using System;
using NoorAirLine.Enums;
using NoorAirLine.Repositories;
namespace NoorAirLine.Models
{
    public class AirCraft
    {
        public int Id {get; set;}
        public string RegistrationNumber {get; set;}
        public int Capacity {get; set;}
        
        public string Name {get; set;}
        
        public AirCraft(int id, string registrationNumber,  int capacity,  string name)
        {
            Id = id;
            RegistrationNumber = $"RN{Guid.NewGuid().ToString().Replace("-","").Substring(0,7).ToUpper()}";
            Capacity = capacity;
            
            Name = name;
        }
        public AirCraft()
        {  
        }
    }
}