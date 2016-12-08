using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("c:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("d:");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("e:");
            double e = double.Parse(Console.ReadLine());

            double max = a;

            if (b > max)
                max = b;
            if (c > max)
                max = c;
            if (d > max)
                max = d;
            if (e > max)
                max = e;

            Console.WriteLine("The greatest number is {0}", max);

            Console.ReadLine();

        }
    }
}
