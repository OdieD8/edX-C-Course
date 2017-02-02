using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSevenAssignment
{
    public class Program
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
        }
    }

    class Course
    {
        private ArrayList students = new ArrayList();
        private Teacher[] teachers = new Teacher[3];
        private string name, start;
        private int credit;

        public ArrayList Students
        {
            get { return students; }
            set { students = value; }
        }

        public void ListStudents()
        {
            foreach (object student in students)
            {
                Console.WriteLine($"Student's Name: {((Student)student).FirstName} {((Student)student).LastName}");
                Console.WriteLine();
            }
        }

        public Teacher[] Teachers
        {
            get { return teachers; }
            set { teachers = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Start
        {
            get { return start; }
            set { start = value; }
        }

        public int Credit
        {
            get { return credit; }
            set { credit = value; }
        }
    }

    class Student : Person
    {
        private string addressLine1, addressLine2, city, state, country;
        private int zip;
        public static int count = 0;
        public Stack Grades = new Stack();

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
    }

    class Person
    {
        private string firstName, lastName;
        private DateTime birthDate;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
    }

    class Degree
    {
        private string degreeName, type;
        private Course course = new Course();
        private int gradCredits;

        public string DegreeName
        {
            get { return degreeName; }
            set { degreeName = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public Course Course
        {
            get { return course; }
            set { course = value; }
        }

        public int GradCredits
        {
            get { return gradCredits; }
            set { gradCredits = value; }
        }
    }

    class Teacher : Person
    {
        private string courses;

        public Teacher() { }

        public Teacher(string firstName, string lastName, DateTime birthDay)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDay;
        }

        public string Course
        {
            get { return courses; }
            set { courses = value; }
        }
    }

    class UProgram
    {
        private string name, preReqs;
        private Degree degree = new Degree();
        private int months;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string PreReqs
        {
            get { return preReqs; }
            set { preReqs = value; }
        }

        public Degree Degree
        {
            get { return degree; }
            set { degree = value; }
        }

        public int Months
        {
            get { return months; }
            set { months = value; }
        }
    }
}
