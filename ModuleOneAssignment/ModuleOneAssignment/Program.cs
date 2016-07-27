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
            string firstName;
            string lastName;
            string birthDate;
            string addressLine1;
            string addressLine2;
            string city;
            string state;
            int zip;
            string country;

            firstName = "Joseph";
            lastName = "Doe";
            birthDate = "Feb 10 1900";
            addressLine1 = "122 Anywhere Street";
            addressLine2 = "Suite 500";
            city = "New York";
            state = "New York";
            zip = 10001;
            country = "US";

            DateTime myBirthDate = DateTime.Parse(birthDate);

            Console.WriteLine("{0} {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}", firstName, lastName, myBirthDate.ToString("MM/dd/yyyy"), addressLine1, addressLine2, city, state, zip, country);

            Console.WriteLine("Now press any key to enter your own student information... ");
            Console.ReadLine();

            Console.WriteLine("First Name");
            string userFirstName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Last Name");
            string userLastName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Birth Date");
            string userBirthDate = Console.ReadLine();

            DateTime userBirthDay = DateTime.Parse(userBirthDate);

            Console.WriteLine();

            Console.WriteLine("Address Line 1");
            string userAddressLine1 = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Address Line 2 (Enter for none)");
            string userAddressLine2 = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("City");
            string userCity = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("State");
            string userState = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Zip Code");
            string userZip = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Country");
            string userCountry = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("{0} {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}", userFirstName, userLastName, userBirthDay.ToString("MM/dd/yyyy"), userAddressLine1, userAddressLine2, userCity, userState, userZip, userCountry);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
