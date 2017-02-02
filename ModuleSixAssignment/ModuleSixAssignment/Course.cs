﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSixAssignment
{
    class Course
    {
        private ArrayList students = new ArrayList();
        private Teacher[] teachers = new Teacher[3];
        private string name, start;
        private int credit;

        public ArrayList Students
        {
            get { return students; }
            set { students = value; }
        }

        public Teacher[] Teachers
        {
            get { return teachers; }
            set { teachers = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Start
        {
            get { return start; }
            set { start = value; }
        }

        public int Credit
        {
            get { return credit; }
            set { credit = value; }
        }
    }
}
