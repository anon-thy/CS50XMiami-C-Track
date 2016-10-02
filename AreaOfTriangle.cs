using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base of triangle.");
            int triBase = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter height of triangle.");
            int triHeight = Convert.ToInt32(Console.ReadLine());

            int area = (triBase * triHeight) / 2;
            Console.WriteLine("The area of your triangle is {0}.", area);
            Console.ReadLine();
        }
    }
}
