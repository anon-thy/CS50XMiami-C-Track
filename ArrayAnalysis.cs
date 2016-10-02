using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total length of array for analysis.");
            int x = Convert.ToInt32(Console.ReadLine());

            var numbers = new int[x];

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Enter element: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int minimum = numbers.Min();
            int maximum = numbers.Max();
            double average = numbers.Average();

            Console.WriteLine("Array minimum: {0}", minimum);
            Console.WriteLine("Array maximum: {0}", maximum);
            Console.WriteLine("Array average: {0}", average);

            Console.ReadLine();

        }

        private int Min(int[] numbers)
        {
            int m = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (m < numbers[i])
                    m = numbers[i];
            }

            return m;
        }

        private int Max(int[] numbers)
        {
            int m = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (m > numbers[i])
                    m = numbers[i];
            }

            return m;
        }

        private double Average(int[] numbers)
        {
            double m = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                m += (double)numbers[i];
            }

            double n = m / (double)numbers.Length;

            return n;
        }
    }
}
