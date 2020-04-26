using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergeyKuzhalHW7
{
    class Employee
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public int Room { get; private set; }

        public Employee(string firstName, string lastName, int age, int room)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Room = room;
        }

        public string GetEmployeeInfo()
        {
            string employeeInfo = "Full name: " + FirstName + " " + LastName + ", Age: " + Age.ToString() + ", " + "Room: " + Room.ToString() + "\n";

            return employeeInfo;
        }
    }
}
