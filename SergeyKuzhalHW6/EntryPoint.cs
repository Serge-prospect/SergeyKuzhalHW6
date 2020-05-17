using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergeyKuzhal_HW_QAC2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            // Set office rooms
            List<Room> rooms = new List<Room>();
            rooms.Add(new Room(101, 10, 10));
            rooms.Add(new Room(102, 20, 20));
            rooms.Add(new Room(103, 30, 30));
            rooms.Add(new Room(104, 40, 40));
            rooms.Add(new Room(105, 50, 50));
            rooms.Add(new Room(106, 60, 60));
                                   
            //Set professions and specializations
            List<Profession> professions = new List<Profession>();
            professions.Add(new Profession("QA", "Manual"));
            professions.Add(new Profession("QA", "Automation"));
            professions.Add(new Profession("Dev", "Front End"));
            professions.Add(new Profession("Dev", "Back End"));
            professions.Add(new Profession("DevOps", "DBA"));
            professions.Add(new Profession("DevOps", "OPS"));
            professions.Add(new Profession("BA", "Requirements"));
            professions.Add(new Profession("BA", "Functional"));
            
            // Set company employees
            List<Employee> companyEmployees = new List<Employee>();
            companyEmployees.Add(new QA("Ben", "Gun", 21, rooms[0].RoomNumber, professions[0]));
            companyEmployees.Add(new QA("John", "Connor", 22, rooms[1].RoomNumber, professions[1]));
            companyEmployees.Add(new Dev("Sarah", "Connor", 23, rooms[1].RoomNumber, professions[2]));
            companyEmployees.Add(new Dev("Jon", "Snow", 24, rooms[2].RoomNumber, professions[3]));
            companyEmployees.Add(new DevOps("Luke", "Skywalker", 25, rooms[3].RoomNumber, professions[4]));
            companyEmployees.Add(new QA("Forrest", "Gump", 26, rooms[4].RoomNumber, professions[7]));
            companyEmployees.Add(new DevOps("Darth", "Vader", 27, rooms[3].RoomNumber, professions[5]));
            companyEmployees.Add(new Dev("Richard", "Doe", 28, rooms[5].RoomNumber, professions[0]));
            companyEmployees.Add(new DevOps("John", "Doe", 29, rooms[5].RoomNumber, professions[0]));
            companyEmployees.Add(new BA("Jane", "Doe", 30, rooms[5].RoomNumber, professions[6]));

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