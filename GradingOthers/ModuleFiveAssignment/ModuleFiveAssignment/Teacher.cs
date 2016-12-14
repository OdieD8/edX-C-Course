using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    public class Teacher
    {
        private string _FirstName, _LastName;
        private string _Address, _City, _Country;

        public static int numberOfStudents = 0;
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public string City
        {
            get { return _City; }
            set { _City = value; }
        }

        public string Country
        {
            get { return _Country; }
            set { _Country = value; }
        }

        public Teacher()
        {
            _FirstName = "Jon";
            _LastName = "Doe";
            _Address = "";
            _City = "";
            _Country = "";
        }
        public Teacher(string firstName, string lastName, string address, string city, string country)
        {

            this._FirstName = firstName;
            this._LastName = lastName;
            this.City = city;
            this.Address = address;
            this.Country = country;
        }

    }
}