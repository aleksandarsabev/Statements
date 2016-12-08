using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            
            if ((x >= 1 && x <= 3))
            {
                x = x * 10;
                Console.WriteLine(x);
            }
            else if((x >= 4 && x <= 6))
            {
                x = x * 100;
                Console.WriteLine(x);
            }
            else if ((x >= 7 && x <= 9))
            {
                x = x * 1000;
                Console.WriteLine(x);
            }
            else if (x == 0)
            {
                Console.WriteLine("Error");
            }
            else
            
                
            
        }
    }
}
