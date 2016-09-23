using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structs_e_enums
{
    class Program
    {
        public struct Student
        {
            public string name;
            public string major;
            public int age;
        }
        public enum Days
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        };

        public enum Months
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        };

        static void Main(string[] args)
        {
            Student student = new Student();
            student.name = "Joe";
            student.major = "Science";
            student.age = 22;

            Console.WriteLine("Student's Information:");
            Console.WriteLine("Name: {0}, Major: {1}, Age: {2}", student.name, student.major, student.age);

            Days churchDay = Days.Sunday;
            Console.WriteLine("The day to go to church is: " + churchDay);

            Months birthdayMonth = Months.March;
            Console.WriteLine("My birthday month is: " + birthdayMonth);

            int[] intArray = new int[5];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i;
            }

            int counter = 0;
            while (counter < intArray.Length)
            {
                Console.WriteLine(intArray[counter]);
                counter++;
            }

            string[] weekDays = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            Console.WriteLine("Today is: " + weekDays[4]);
        }
    }
}
