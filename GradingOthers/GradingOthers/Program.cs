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
            for (int i = 0; i < 8; i++)
            {
                bool isEven = i % 2 == 0 ? true : false;
                switch (isEven)
                {
                    case true:
                        Console.WriteLine("XOXOXOXO");
                        break;
                    case false:
                        Console.WriteLine("OXOXOXOX");
                        break;
                    default:
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
