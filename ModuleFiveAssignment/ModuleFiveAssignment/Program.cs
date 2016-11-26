using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFiveAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.firstName = "Sarah";
            Console.WriteLine(teacher.firstName);
        }
    }
}
