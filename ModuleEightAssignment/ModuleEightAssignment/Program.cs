using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleEightAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studentOne = new Student()
            {
                FirstName = "John",
                LastName = "Smith",
            };
            Student studentTwo = new Student()
            {
                FirstName = "Joseph",
                LastName = "Doe"
            };
            Student studentThree = new Student()
            {
                FirstName = "Eric",
                LastName = "Williams"
            };
            Teacher teacherOne = new Teacher();

            studentOne.grades.Push(55);
            studentOne.grades.Push(65);
            studentOne.grades.Push(95);
            studentOne.grades.Push(30);
            studentOne.grades.Push(99);

            studentTwo.grades.Push(85);
            studentTwo.grades.Push(88);
            studentTwo.grades.Push(72);
            studentTwo.grades.Push(95);
            studentTwo.grades.Push(100);

            studentThree.grades.Push(90);
            studentThree.grades.Push(82);
            studentThree.grades.Push(66);
            studentThree.grades.Push(77);
            studentThree.grades.Push(99);

            Teacher[] teachers = new Teacher[3];
            teachers[0] = teacherOne;

            Course course = new Course
            {
                Name = "Programming with C#",
                Teachers = teachers
            };

            course.Students.Add(studentOne);
            course.Students.Add(studentTwo);
            course.Students.Add(studentThree);

            course.ListStudents();

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
            Console.WriteLine(Environment.NewLine + $"The {course.Name} course contains {Student.count} student(s)");
            Console.WriteLine();

            studentOne.ListGrades();
        }
    }
}
