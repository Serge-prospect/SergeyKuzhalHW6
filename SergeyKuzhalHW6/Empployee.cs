using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergeyKuzhalHW6
{
    class Employee
    {
        public string firstName;
        public string lastName;
        public int age;

        public Employee(string firstNameValue, string lastNameValue, int ageValue)
        {
            firstName = firstNameValue;
            lastName = lastNameValue;
            age = ageValue;
        }
    }
}
