using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter angleA: ");
            int angleA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter angleB: ");
            int angleB = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter angleC: ");
            int angleC = int.Parse(Console.ReadLine());

            int sum = angleA + angleB + angleC;

            if(sum == 180)
            {
                Console.WriteLine("The triangle is valid");   
            }
            else
            {
                Console.WriteLine("The triangle is not valid");
            }
        }
    }
}
