using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //read
            Console.WriteLine("Please enter student information");
            StudentInformation student = GetStudentInformation();

            //write
            Console.WriteLine("Student info gathered.");
            PrintStudentDetails(student);
            Console.WriteLine("####");

            //read
            Console.WriteLine("Please enter teacher information");
            TeacherInformation teacher = GetTeacherInformation();

            //write
            Console.WriteLine("Teacher info gathered.");
            PrintTeacherDetails(teacher);
            Console.WriteLine("####");

            //wait for Espace
            Console.ReadKey();
        }

        static StudentInformation GetStudentInformation()
        {
            StudentInformation student = new StudentInformation();
            Console.Write("First Name: ");
            student.FirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            student.LastName = Console.ReadLine();
            Console.Write("Birthdate: ");
            student.Birthdate = readDateTime();
            return student;
        }

        static DateTime readDateTime()
        {
            try
            {
                return DateTime.Parse(Console.ReadLine());
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Wrong Format! Please enter correct date.");
                return readDateTime();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Date not entered correctly! Please enter correct date.");
                return readDateTime();
            }
        }

        static void PrintStudentDetails(StudentInformation student)
        {
            Console.WriteLine("First Name: {0}\r\nLast Name: {1}\r\nBirthdate: {2}",
            student.FirstName, student.LastName, student.Birthdate);
        }

        static TeacherInformation GetTeacherInformation()
        {
            TeacherInformation teacher = new TeacherInformation();
            Console.Write("Address Line 1: ");
            teacher.AddressLine1 = Console.ReadLine();
            Console.Write("Address Line 2: ");
            teacher.AddressLine2 = Console.ReadLine();
            Console.Write("City: ");
            teacher.City = Console.ReadLine();
            return teacher;
        }

        static void PrintTeacherDetails(TeacherInformation teacher)
        {
            Console.WriteLine("Address Line 1: {0}\r\nAddress Line 2: {1}\r\nCity: {2}",
            teacher.AddressLine1, teacher.AddressLine2, teacher.City);
        }
    }

    class StudentInformation
    {
        public string FirstName;
        public string LastName;
        public DateTime Birthdate;
        public string AddressLine1;
        public string AddressLine2;
        public string City;
        public string State_Province;
        public string Zip_Postal;
        public string Country;
    }

    class TeacherInformation : StudentInformation { }

    class UProgramInformation
    {
        string ProgramName;
        string DepartmentHead;
        string[] Degrees;
    }

    class DegreeInformation
    {
        string DegreeName;
        Boolean CreditsRequired;
    }

    class CourseInformation
    {
        string CourseName;
        string Credits;
        int DurationInWeeks;
        string Teacher;
    }
}