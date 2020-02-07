using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            while (number <= 100)
            {
                Console.WriteLine(number);
                number = number + 5;
            }
            Console.ReadLine();

            int number2 = 100;

            for (int i = 1; i <= number2; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            int number3 = 500;

            while (number3 <= 525)
            {
                Console.WriteLine(number3);
                number3 = number3 + 1;
            }
            Console.ReadLine();


        }
    }
}
