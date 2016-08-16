using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleOneAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentInformation();

            GetTeacherInformation();

            GetCourseInformation();

        }

        static void GetStudentInformation()
        {
            Console.WriteLine("Press any key to enter student information... ");
            Console.ReadLine();

            Console.WriteLine("First Name");
            string studentFirstName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Last Name");
            string studentLastName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Birth Date");
            string studentBirthDate = Console.ReadLine();

            DateTime studentBD = DateTime.Parse(studentBirthDate);

            Console.WriteLine();

            Console.WriteLine("Address Line 1");
            string studentAddressLine1 = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Suite or Apartment Number (Enter for none)");
            string studentAddressLine2 = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("City");
            string studentCity = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("State");
            string studentState = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Zip Code");
            int studentZip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Country");
            string studentCountry = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Press Any Key to Output Student Information Captured");
            Console.ReadKey();

            PrintStudentDetails(studentFirstName, studentLastName, studentBD, studentAddressLine1, studentAddressLine2, studentCity, studentState, studentZip, studentCountry);
        }

        static void PrintStudentDetails(string first, string last, DateTime birthday, string address1, string suiteApt, string city, string state, int zipcode, string country)
        {
            Console.WriteLine("{0} {1} was born on {2} and lives on {3} {4}" + System.Environment.NewLine + "{5}, {6} {7}" + System.Environment.NewLine + "{8}", first, last, birthday.ToString("MM/dd/yyyy"), address1, suiteApt, city, state, zipcode, country);

            Console.WriteLine();
            Console.WriteLine("Press any key to go to the teacher section");
            Console.ReadKey();
        }

        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter teacher information... ");
            Console.WriteLine();

            Console.WriteLine("First Name");
            string teacherFirstName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Last Name");
            string teacherLastName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Birth Date");
            string teacherBirthDate = Console.ReadLine();

            DateTime teacherBD = DateTime.Parse(teacherBirthDate);

            Console.WriteLine();

            Console.WriteLine("Courses Taught");
            string teacherCourses = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Press Any Key to Output Teacher Information Captured");
            Console.ReadKey();

            PrintTeacherDetails(teacherFirstName, teacherLastName, teacherBD, teacherCourses);
        }

        static void PrintTeacherDetails(string first, string last, DateTime birthday, string courses)
        {
            Console.WriteLine("{0} {1} was born on {2} and teaches {3}", first, last, birthday.ToString("MM/dd/yyyy"), courses);

            Console.WriteLine();
            Console.WriteLine("Press any key to go to the course section");
            Console.ReadKey();
        }

        static void GetCourseInformation()
        {
            Console.WriteLine("Enter course information... ");
            Console.WriteLine();

            Console.WriteLine("Course Name");
            string courseName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Number of Credits");
            int credit = Convert.ToInt16(Console.ReadLine());
 
            Console.WriteLine();

            Console.WriteLine("Course Start Date");
            string courseDate = Console.ReadLine();

            DateTime courseStart = DateTime.Parse(courseDate);

            Console.WriteLine();
            Console.WriteLine("Press Any Key to Output Teacher Information Captured");
            Console.ReadKey();

            PrintCourseInformation(courseName, credit, courseStart);
        }

        static void PrintCourseInformation(string course, int credit, DateTime start)
        {
            Console.WriteLine("{0} is worth {1} credit(s) and starts on {2}", course, credit, start.ToString("MM/dd/yyyy"));
        }
    }
}
