using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleEightAssignment
{
    class Student : Person
    {
        private string addressLine1, addressLine2, city, state, country;
        private int zip;
        public static int count = 0;
        public Stack<int> grades = new Stack<int>();

        public Student()
        {
            count = ++count;
        }

        public Student(string firstName, string lastName, DateTime birthDay)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDay;
        }

        public string AddressLine1
        {
            get { return addressLine1; }
            set { addressLine1 = value; }
        }

        public string AddressLine2
        {
            get { return addressLine2; }
            set { addressLine2 = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public int Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        public void ListGrades()
        {
            Console.WriteLine("Grades: ");
            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}