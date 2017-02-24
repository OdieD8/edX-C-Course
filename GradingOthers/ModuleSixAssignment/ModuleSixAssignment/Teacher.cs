using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSixAssignment
{
    class Teacher : Person
    {
        private string courses;

        public Teacher() { }

        public Teacher(string firstName, string lastName, DateTime birthDay)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDay;
        }

        public string Course
        {
            get { return courses; }
            set { courses = value; }
        }
    }
}
