using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergeyKuzhal_HW_QAC1
{
    class Company
    {
        public string CompanyName { get; private set; }
        public Employee[] CompanyEmployees { get; private set; }
        public Office CompanyOffice { get; private set; }

        public Company(string companyName, Employee[] companyEmployees, Office companyOffice)
        {
            CompanyName = companyName;
            CompanyEmployees = companyEmployees;
            CompanyOffice = companyOffice;
        }
        
        public string GetCompanyInfo()
        {
            string companyInfo = CompanyName + "\n\n"
                               + "Office addres:\n"
                               + CompanyOffice.Address + "\n\n"
                               + "Total office room square: " + CompanyOffice.GetOfficeRoomsSquare().ToString() + " sq. m\n\n";

            foreach (Employee employee in CompanyEmployees)
            {
                companyInfo += employee.GetEmployeeInfo() + "\n";
            }

            return companyInfo;
        }
    }
}
