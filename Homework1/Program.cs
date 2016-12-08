using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a: ");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("b: ");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("c: ");
            double c = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("This is not an quadratic equation!");
            }
            else
            {
                double discriminant = (b * b) - (4 * a * c);
                if (discriminant > 0)
                {
                    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine("The equation roots are: nX1: {0} nX2: {1}",x1,x2);
                }
            else if (discriminant == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("The equation has only one root : {0}", x);    
                }
            else if (discriminant < 0)
                {
                    Console.WriteLine("This equation doesn't have solution!");
                }
                Console.ReadLine();
            }

        }
    }
}
