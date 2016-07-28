using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTwoAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int x = 0; x < 4; x++)
                {
                    if(i % 2 > 0)
                    {
                        Console.Write("O");
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("X");
                        Console.Write("O");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
