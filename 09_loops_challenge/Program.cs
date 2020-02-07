using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_loops_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Number bronzeNumber = new Number();
            Number silverNumber = new Number();
            Number goldNumber = new Number();

            bronzeNumber.Value = 525;
            silverNumber.Value = 100;
            goldNumber.Value = 1;

            for (int ii = 500; ii <= bronzeNumber.Value; ii++)
            {
                Console.WriteLine(ii);
            }
            Console.ReadLine();

                        for (int iii = 0; iii <= silverNumber.Value; iii = iii + 5)
            {
                Console.WriteLine(iii);
            }
            Console.ReadLine();

            while (goldNumber.Value <= 100)
            {
                if ((goldNumber.Value % 3 == 0) && (goldNumber.Value % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                    goldNumber.Value = goldNumber.Value + 1;
                }
                else if (goldNumber.Value % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    goldNumber.Value = goldNumber.Value + 1;
                }
                else if (goldNumber.Value % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    goldNumber.Value = goldNumber.Value + 1;
                }
                else
                {
                    Console.WriteLine(goldNumber.Value);
                    goldNumber.Value = goldNumber.Value + 1;
                }
            }
            Console.ReadLine();
        }
    }
}
