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

            studentArr[1] = new Student("John", "Doe", "03/03/88", "122 Anywhere Street", "Apt. 6", "New York", "NY", "US", 10001);

            Console.WriteLine("Student First Name: " + studentArr[0].firstName);
            Console.WriteLine("Student Last Name: " + studentArr[0].lastName);
            Console.WriteLine("Student Address: " + studentArr[0].addressLine1);
            Console.WriteLine("Student Address Line 2: " + studentArr[0].addressLine2);
            Console.WriteLine("Student City: " + studentArr[0].city);
            Console.WriteLine("Student State: " + studentArr[0].state);
            Console.WriteLine("Student Zip: " + studentArr[0].zip);
            Console.WriteLine("Student Country: " + studentArr[0].country);
            Console.WriteLine("Student Birthday: " + studentArr[0].birthDate.ToString("dd/MM/yyyy"));

            for (int i = 0; i < studentArr.Length; i++)
            {
                Console.WriteLine("Please enter student {0}'s first name", i + 1);
                studentArr[i].firstName = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Please enter student {0}'s last name", i + 1);
                studentArr[i].lastName = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Please enter student {0}'s birthday", i + 1);
                string bd = Console.ReadLine();
                DateTime birthday = DateTime.Parse(bd);
                studentArr[i].birthDate = birthday;
                Console.WriteLine();

                Console.WriteLine("Please enter student {0}'s address", i + 1);
                studentArr[i].addressLine1 = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Please enter student {0}'s address line 2", i + 1);
                studentArr[i].addressLine2 = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Please enter student {0}'s city", i + 1);
                studentArr[i].city = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Please enter student {0}'s state", i + 1);
                studentArr[i].state = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Please enter student {0}'s country", i + 1);
                studentArr[i].country = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Please enter student {0}'s zip", i + 1);
                studentArr[i].zip = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            for (int x = 0; x < studentArr.Length; x++)
            {
                Console.WriteLine("Student {0}'s first name is '{1}'", x + 1, studentArr[x].firstName);
                Console.WriteLine("Student {0}'s last name is '{1}'", x + 1, studentArr[x].lastName);
                Console.WriteLine("Student {0}'s birthday is '{1}'", x + 1, studentArr[x].birthDate.ToString("dd/MM/yyyy"));
                Console.WriteLine("Student {0}'s address is '{1}'", x + 1, studentArr[x].addressLine1);
                Console.WriteLine("Student {0}'s address line 2 is '{1}'", x + 1, studentArr[x].addressLine2);
                Console.WriteLine("Student {0}'s city is '{1}'", x + 1, studentArr[x].city);
                Console.WriteLine("Student {0}'s state is '{1}'", x + 1, studentArr[x].state);
                Console.WriteLine("Student {0}'s country is '{1}'", x + 1, studentArr[x].country);
                Console.WriteLine("Student {0}'s zip code is '{1}'", x + 1, studentArr[x].zip);
                Console.WriteLine();
            }
        }
    }
}

