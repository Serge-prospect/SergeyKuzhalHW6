using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergeyKuzhal_HW_QAC3.EmployeeTypes
{
    class QAAutomationLead: QAAutomation, ITaskAssigner
    {
        public QAAutomationLead(string firstName, string lastName, int age, int room, Profession profession) : base(firstName, lastName, age, room, profession)
        {
        }

        // ITaskAssigner methods
        public void AssignTask()
        {
            Console.WriteLine("Assign a task");
        }
    }
}
