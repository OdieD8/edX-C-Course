using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            string sFirst;
            string sLast;
            string sAddress1;
            string sAddress2;
            string sCity;
            string sState;
            int sZip;
            string sCountry;
            string sBirthdate;

            //I know i could assign the values above instead. I decided to take the time to type it out.
            sFirst = "Sven";
            sLast = "Drogon";
            sAddress1 = "123 Elm Street";
            sAddress2 = "Suite 501";
            sCity = "Atlanta";
            sState = "GA";
            sZip = 30008;
            sCountry = "USA";
            sBirthdate = "03/05/1985";

            Console.WriteLine("Fisrt name: " + sFirst + " Last name: " + sLast);
            Console.WriteLine("Students Birthday: " + sBirthdate);
            Console.WriteLine("Address Line 1: " + sAddress1);
            Console.WriteLine("Address line 2: " + sAddress2);
            Console.WriteLine("City, State Zipcode country: " + sCity + ", " + sState + " " + sZip + " " + sCountry);
            Console.ReadKey();
        }
    }
}
