using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergeyKuzhalHW6
{
    class WriteCompanyEmployees
    {
        static void Main(string[] args)
        {
            string company = Company.GetCompanyName();
            Employee[] employees = Company.GetCompanyEmployees();


            Console.WriteLine(company);

            foreach (Employee employee in employees)
            {
                Console.WriteLine("Name: {0} {1}, Age: {2};",
                                    employee.firstName,
                                    employee.lastName,
                                    employee.age);
            }
        }
    }
}
