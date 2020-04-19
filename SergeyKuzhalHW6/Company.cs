using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergeyKuzhalHW6
{
    class Company
    {
        public string companyName;
        public Employee companyEmployees;
        public Company(string companyNameValue, Employee employeeValues)
        {
            companyName = companyNameValue;
            companyEmployees = employeeValues;
        }
        

        // Return company name
        public static string GetCompanyName()
        {
            string companyNameValue = "Boston Dynamics";
            return companyNameValue;
        }
        

        // Return list of employees
        public static Employee[] GetCompanyEmployees()
        {
            Employee[] employeeValues = new Employee[10];

            employeeValues[0] = new Employee("Ben", "Gun", 21);
            employeeValues[1] = new Employee("John", "Connor", 22);
            employeeValues[2] = new Employee("Sarah", "Connor", 23);
            employeeValues[3] = new Employee("Jon", "Snow", 24);
            employeeValues[4] = new Employee("Luke", "Skywalker", 25);
            employeeValues[5] = new Employee("Forrest", "Gump", 26);
            employeeValues[6] = new Employee("Darth", "Vader", 27);
            employeeValues[7] = new Employee("Richard", "Doe", 28);
            employeeValues[8] = new Employee("John", "Doe", 29);
            employeeValues[9] = new Employee("Jane", "Doe", 30);

            return employeeValues;
        }
    }
}
