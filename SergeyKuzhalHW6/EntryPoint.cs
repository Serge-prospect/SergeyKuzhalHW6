using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergeyKuzhalHW7
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            // Set office rooms
            Room[] rooms = new Room[6];
            rooms[0] = new Room(101, 10, 10);
            rooms[1] = new Room(102, 20, 20);
            rooms[2] = new Room(103, 30, 30);
            rooms[3] = new Room(104, 40, 40);
            rooms[4] = new Room(105, 50, 50);
            rooms[5] = new Room(106, 60, 60);

            // Set company employees
            Employee[] companyEmployees = new Employee[10];
            companyEmployees[0] = new Employee("Ben", "Gun", 21, rooms[0].RoomNumber);
            companyEmployees[1] = new Employee("John", "Connor", 22, rooms[1].RoomNumber);
            companyEmployees[2] = new Employee("Sarah", "Connor", 23, rooms[1].RoomNumber);
            companyEmployees[3] = new Employee("Jon", "Snow", 24, rooms[2].RoomNumber);
            companyEmployees[4] = new Employee("Luke", "Skywalker", 25, rooms[3].RoomNumber);
            companyEmployees[5] = new Employee("Forrest", "Gump", 26, rooms[4].RoomNumber);
            companyEmployees[6] = new Employee("Darth", "Vader", 27, rooms[3].RoomNumber);
            companyEmployees[7] = new Employee("Richard", "Doe", 28, rooms[5].RoomNumber);
            companyEmployees[8] = new Employee("John", "Doe", 29, rooms[5].RoomNumber);
            companyEmployees[9] = new Employee("Jane", "Doe", 30, rooms[5].RoomNumber);

            // Set office
            string officeAddress = "78 Fourth Avenue\n"
                                 + "Waltham\n"
                                 + "MA, 02451 - 7507\n"
                                 + "United States";
            Office companyOffice = new Office(officeAddress, rooms);            

            // Set company name
            string companyName = "Boston Dynamics";
            Company company = new Company(companyName, companyEmployees, companyOffice);

            // Get full info about company
            Console.WriteLine(company.GetCompanyInfo());
        }
    }
}