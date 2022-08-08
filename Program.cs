using System;
using NoorAirLine.Enums;
using NoorAirLine.Menus;
using NoorAirLine.Models;
using NoorAirLine.Repositories;
using MySql.Data.MySqlClient;
using NoorAirLine.Repositories;
namespace NoorAirLine
{
    class program
    {
        MySqlConnection connection;
        string connectionString = "server=localhost;user=root;database=airlineapp;port=3306;password=@nooruraheem02;";
        public static void Main(string[] args)
        { 
            // FlightRepo.SeedFlight();
            // MainMenu.Menu();
            new program().CreaateTable();
        }
        
        public void CreaateTable()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand("Create table AirlineTable(Id int not null auto_increment primary key,Email varchar(200),Passwords varchar(200))",connection);
                connection.Open();
                command.ExecuteNonQuery();
             System.Console.WriteLine("Table created successfully...");
            }
            catch (System.Exception e)
            {
                
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
        
                
        
    
    






