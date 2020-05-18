using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergeyKuzhal_HW_QAC3.EmployeeTypes
{
    class Dev : Employee, IDeveloper
    {
        public Profession Profession { get; private set; }
        public Dev (string firstName, string lastName, int age, int room, Profession profession) : base(firstName, lastName, age, room)
        {
            Profession = profession;
        }
        public override string GetEmployeeInfo()
        {
            string checkProfession = "Dev";
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

        // IDeveloper methods
        public void WriteCode()
        {
            Console.WriteLine("Write code");
        }

        public void FixBug()
        {
            Console.WriteLine("Fix a bug");
        }

        public void MaskBug()
        {
            Console.WriteLine("Mask a bug");
        }
    }
}
