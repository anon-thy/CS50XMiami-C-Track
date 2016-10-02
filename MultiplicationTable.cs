using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= input; i++)
                {
                    for (int j = 1; j <= input; j++)
                    {
                    Console.Write("{0}", j * i);
                    }
                Console.Write("\n");
                }
            Console.ReadLine();
        }
    }
}
