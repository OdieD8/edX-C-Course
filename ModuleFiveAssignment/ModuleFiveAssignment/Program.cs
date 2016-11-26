using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFiveAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studentOne = new Student();
            Student studentTwo = new Student();
            Student studentThree = new Student();
            Teacher teacherOne = new Teacher();

            Student[] students = new Student[3];
            students[0] = studentOne;
            students[1] = studentTwo;
            students[2] = studentThree;

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
        }
    }
}

