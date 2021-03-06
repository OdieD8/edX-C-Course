﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSixAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studentOne = new Student();
            Student studentTwo = new Student();
            Student studentThree = new Student();
            Teacher teacherOne = new Teacher();

            studentOne.Grades.Push(55);
            studentOne.Grades.Push(65);
            studentOne.Grades.Push(95);
            studentOne.Grades.Push(30);
            studentOne.Grades.Push(99);

            studentTwo.Grades.Push(85);
            studentTwo.Grades.Push(88);
            studentTwo.Grades.Push(72);
            studentTwo.Grades.Push(95);
            studentTwo.Grades.Push(100);

            studentThree.Grades.Push(90);
            studentThree.Grades.Push(82);
            studentThree.Grades.Push(66);
            studentThree.Grades.Push(77);
            studentThree.Grades.Push(99);

            ArrayList students = new ArrayList()
            {
                studentOne,
                studentTwo,
                studentThree
            };

            Teacher[] teachers = new Teacher[3];
            teachers[0] = teacherOne;

            Course course = new Course
            {
                Name = "Programming with C#",
                Students = students,
                Teachers = teachers
            };

            Degree bachelor = new Degree
            {
                DegreeName = "Bachelor of Science",
                Course = course
            };

            UProgram uProgram = new UProgram
            {
                Name = "Information Technology",
                Degree = bachelor
            };

            Console.WriteLine($"The {uProgram.Name} program contains the {bachelor.DegreeName} degree");
            Console.WriteLine(Environment.NewLine + $"The {bachelor.DegreeName} degree contains the course {course.Name}");
            Console.WriteLine(Environment.NewLine + $"the {course.Name} course contains {Student.count} student(s)");

            Person person = new Person();
            Student personStudent = new Student();
            person.Equals(personStudent);

            string firstName = person.FirstName;
            string lastName = person.LastName;
            DateTime x = person.BirthDate;
        }
    }
}

