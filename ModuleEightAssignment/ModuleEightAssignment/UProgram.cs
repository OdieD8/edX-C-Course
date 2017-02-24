using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleEightAssignment
{
    class UProgram
    {
        private string name, preReqs;
        private Degree degree = new Degree();
        private int months;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string PreReqs
        {
            get { return preReqs; }
            set { preReqs = value; }
        }

        public Degree Degree
        {
            get { return degree; }
            set { degree = value; }
        }

        public int Months
        {
            get { return months; }
            set { months = value; }
        }
    }
}
