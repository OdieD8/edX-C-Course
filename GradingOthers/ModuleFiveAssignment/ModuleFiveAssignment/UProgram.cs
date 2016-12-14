using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class UProgram
    {

        private string _ProgramName;
        private Teacher _DepartmentHead;
        private Degree _Degrees;

        public string ProgramName
        {
            get { return _ProgramName; }
            set { _ProgramName = value; }
        }

        public Teacher DepartmentHead
        {
            get { return DepartmentHead; }
            set { _DepartmentHead = value; }
        }

        public Degree Degrees
        {
            get { return _Degrees; }
            set { _Degrees = value; }
        }

        public UProgram(string name)
        {
            ProgramName = name;

        }

    }
}