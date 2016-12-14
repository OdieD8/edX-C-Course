using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{


    class myMain
    {


        static void Main(string[] args)
        {
            int i;
            Student[] students = new Student[10];
            students[0] = new Student("Ana", "Maria", "123 street", "London", "England");
            students[1] = new Student("Gica", "Lulu", "456 street", "London", "England");
            students[2] = new Student("Randi", "Har", "789 street", "London", "England");

            Teacher[] teachers = new Teacher[3];
            teachers[0] = new Teacher("Ana", "Maria", "123 street", "London", "England");
            teachers[1] = new Teacher("Gica", "Lulu", "456 street", "London", "England");
            teachers[2] = new Teacher("Randi", "Har", "789 street", "London", "England");

            Course c = new Course("Programming with C#");

            for (i = 0; i < Student.numberOfStudents; i++)
                c.student[i] = students[i];

            c.teacher[0] = teachers[0];

            Degree d = new Degree("Bachelor");

            d.course = c;

            UProgram prog = new UProgram("Information Technology");

            prog.Degrees = d;

            Console.WriteLine("The " + prog.ProgramName + " program contrains the " + d.DegreeName + " degree");
            Console.WriteLine("The " + d.DegreeName + " degree contains the course " + c.CourseName);
            Console.WriteLine("The " + c.CourseName + " course contains " + Student.numberOfStudents + " students");
            Console.WriteLine($"{c.student[0].FirstName} + {c.student[1].FirstName} + {c.student[2].FirstName}");
        }
    }
}