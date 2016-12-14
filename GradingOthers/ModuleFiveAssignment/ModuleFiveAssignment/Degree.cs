using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Degree
    {

        private string _DegreeName;
        private int _CreditsRequired;
        private Course _course;

        public string DegreeName
        {
            get { return _DegreeName; }
            set { _DegreeName = value; }
        }

        public int CreditsRequired
        {
            get { return _CreditsRequired; }
            set { _CreditsRequired = value; }
        }

        public Course course
        {
            get { return _course; }
            set { _course = value; }
        }

        public Degree(string DegreeName)
        {

            this._DegreeName = DegreeName;
        }

    }
}