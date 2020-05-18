using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergeyKuzhal_HW_QAC3.EmployeeTypes
{
    class DevOps : Employee
    {
        public Profession Profession { get; private set; }
        public DevOps (string firstName, string lastName, int age, int room, Profession profession) : base(firstName, lastName, age, room)
        {
            Profession = profession;
        }
        public override string GetEmployeeInfo()
        {
            string checkProfession = "DevOps";
            if (Profession.ProfessionName == checkProfession)
            {
                string employeeInfo = base.GetEmployeeInfo() + ", " + "Profession: " + Profession.ProfessionName + " - " + Profession.Specialization;
                return employeeInfo;
            }
            else
            {
                string employeeInfo = $"Error!--- Employee's profession mismatches for: \"{checkProfession}\" {FirstName} {LastName}.";
                return employeeInfo;
            }
        }
    }
}
