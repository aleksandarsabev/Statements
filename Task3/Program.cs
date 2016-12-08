using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for integer, 2 for double and 3 for string:");
            byte choice = byte.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    int intChoice = int.Parse(Console.ReadLine());
                    Console.WriteLine(intChoice + 1);
                    break;
                case 2:
                    double dChoice = double.Parse(Console.ReadLine());
                    Console.WriteLine(dChoice + 1);
                    break;
                case 3:
                    string strChoice = Console.ReadLine();
                    Console.WriteLine(strChoice + "*");
                    break;
            }
        }
    }
}
