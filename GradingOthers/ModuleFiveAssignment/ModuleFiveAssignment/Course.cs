using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Course
    {

        private string _CourseName;
        private int _credits, _duration;
        private Teacher[] _teacher = new Teacher[5];
        private Student[] _students = new Student[5];


        public string CourseName
        {
            get { return _CourseName; }
            set { _CourseName = value; }
        }

        public int credits
        {
            get { return _credits; }
            set { _credits = value; }
        }

        public int duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public Teacher[] teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }

        public Student[] student
        {
            get { return _students; }
            set { _students = value; }
        }

        public Course(string CourseName)
        {

            this._CourseName = CourseName;

        }
    }
}