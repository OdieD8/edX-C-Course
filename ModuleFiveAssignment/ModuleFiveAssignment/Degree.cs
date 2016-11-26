using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFiveAssignment
{
    class Degree
    {
        private string degreeName, type, course;
        private int gradCredits;

        public string DegreeName
        {
            get { return degreeName; }
            set { degreeName = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Course
        {
            get { return course; }
            set { course = value; }
        }

        public int GradCredits
        {
            get { return gradCredits; }
            set { gradCredits = value; }
        }
    }
}
