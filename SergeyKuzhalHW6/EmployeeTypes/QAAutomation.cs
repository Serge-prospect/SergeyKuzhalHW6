using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergeyKuzhal_HW_QAC3.EmployeeTypes
{
    class QAAutomation: QA, IDeveloper
    {
        public QAAutomation(string firstName, string lastName, int age, int room, Profession profession) : base(firstName, lastName, age, room, profession)
        {
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
