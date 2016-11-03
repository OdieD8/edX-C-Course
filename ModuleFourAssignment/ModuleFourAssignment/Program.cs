using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFourAssignment
{
    class Program
    {
        public struct Student
        {
            public string firstName, lastName, addressLine1, addressLine2, city, state, country;
            public DateTime birthDate;
            public int zip;

            public Student(string firstName, string lastName, string birthDate, string addressLine1, string addressLine2, string city, string state, string country, int zip)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.birthDate = DateTime.Parse(birthDate);
                this.addressLine1 = addressLine1;
                this.addressLine2 = addressLine2;
                this.city = city;
                this.state = state;
                this.country = country;
                this.zip = zip;
            }
        }

        public struct Teacher
        {
            public string firstName, lastName, courses;
            public DateTime birthDate;

            public Teacher(string firstName, string lastName, string courses, string birthDate)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.courses = courses;
                this.birthDate = DateTime.Parse(birthDate);
            }
        }

        public struct UProgram
        {
            public string name, preReqRequired, preReqs;
            public int length;

            public UProgram(string name, string preReqRequired, string preReqs, int length)
            {
                this.name = name;
                this.preReqRequired = preReqRequired;
                this.preReqs = preReqs;
                this.length = length;
            }
        }

        public struct Course
        {
            public string course;
            public int credit;
            public DateTime start;

            public Course(string course, int credit, string start)
            {
                this.course = course;
                this.credit = credit;
                this.start = DateTime.Parse(start);
            }
        }

        static void Main(string[] args)
        {
            DateTime studentBD = DateTime.Parse("05/15/1990");
            Student[] studentArr = new Student[5];
            studentArr[0].firstName = "Joseph";
            studentArr[0].lastName = "Doe";
            studentArr[0].addressLine1 = "122 Anywhere Street";
            studentArr[0].addressLine2 = "Apt. 5";
            studentArr[0].city = "New York";
            studentArr[0].state = "NY";
            studentArr[0].zip = 10001;
            studentArr[0].country = "US";
            studentArr[0].birthDate = studentBD;

            Console.WriteLine("Student First Name: " + studentArr[0].firstName);
            Console.WriteLine("Student Last Name: " + studentArr[0].lastName);
            Console.WriteLine("Student Address: " + studentArr[0].addressLine1);
            Console.WriteLine("Student Address Line 2: " + studentArr[0].addressLine2);
            Console.WriteLine("Student City: " + studentArr[0].city);
            Console.WriteLine("Student State: " + studentArr[0].state);
            Console.WriteLine("Student Zip: " + studentArr[0].zip);
            Console.WriteLine("Student Country: " + studentArr[0].country);
            Console.WriteLine("Student Birthday: " + studentArr[0].birthDate.ToString("dd/MM/yyyy"));
        }
    }
}

