using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergeyKuzhal_HW_QAC1
{
    class Profession
    {
        public string ProfessionName { get; private set; }
        public string Specialization { get; private set; }
        public Profession (string name, string specialization)
        {
            ProfessionName = name;
            Specialization = specialization;
        }
    }
}
