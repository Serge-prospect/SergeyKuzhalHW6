using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergeyKuzhal_HW_QAC1
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
                                   
            //Set professions and specializations
            Profession[] professions = new Profession[8];
            professions[0] = new Profession("QA", "Manual");
            professions[1] = new Profession("QA", "Automation");
            professions[2] = new Profession("Dev", "Front End");
            professions[3] = new Profession("Dev", "Back End");
            professions[4] = new Profession("DevOps", "DBA");
            professions[5] = new Profession("DevOps", "OPS");
            professions[6] = new Profession("BA", "Requirements");
            professions[7] = new Profession("BA", "Functional");

            // Set company employees
            Employee[] companyEmployees = new Employee[10];
            companyEmployees[0] = new QA("Ben", "Gun", 21, rooms[0].RoomNumber, professions[0]);
            companyEmployees[1] = new QA("John", "Connor", 22, rooms[1].RoomNumber, professions[1]);
            companyEmployees[2] = new Dev("Sarah", "Connor", 23, rooms[1].RoomNumber, professions[2]);
            companyEmployees[3] = new Dev("Jon", "Snow", 24, rooms[2].RoomNumber, professions[3]);
            companyEmployees[4] = new DevOps("Luke", "Skywalker", 25, rooms[3].RoomNumber, professions[4]);
            companyEmployees[5] = new QA("Forrest", "Gump", 26, rooms[4].RoomNumber, professions[7]);
            companyEmployees[6] = new DevOps("Darth", "Vader", 27, rooms[3].RoomNumber, professions[5]);
            companyEmployees[7] = new Dev("Richard", "Doe", 28, rooms[5].RoomNumber, professions[0]);
            companyEmployees[8] = new DevOps("John", "Doe", 29, rooms[5].RoomNumber, professions[0]);
            companyEmployees[9] = new BA("Jane", "Doe", 30, rooms[5].RoomNumber, professions[6]);

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