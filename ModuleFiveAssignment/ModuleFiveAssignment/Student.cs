using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFiveAssignment
{
    class Student
    {
        private string firstName, lastName, addressLine1, addressLine2, city, state, country;
        private DateTime birthDate;
        private int zip;

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

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public int Zip
        {
            get { return zip; }
            set { zip = value; }
        }
    }
}
