using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_boolean_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            float value = 101f / 2f;
            Console.WriteLine(value);
            if (value == 50f)
            {
                Console.WriteLine(true);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(false);
                Console.ReadLine();
            }

            Random rnd = new Random();
            int number = rnd.Next(1, 100);


            Console.WriteLine("Guess a number between 1 and 100: ");
            int x;
            bool valid = false;
            while (!valid)
                if (int.TryParse(Console.ReadLine(), out x))
                {
                    if (x == number)
                    {
                        Console.WriteLine("Correct!");
                        Console.ReadLine();
                        valid = true;
                    }
                    else
                    {

                        if (x < 1 || x > 100)
                        {
                            Console.WriteLine("Number guessed was not between 1 and 100, try again:");
                        }
                        else
                        {
                            if (number > x)
                            {
                                Console.WriteLine("Guess higher:");
                            }
                            else
                            {

                                Console.WriteLine("Guess lower:");
    

                        }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Not an integer, try again:");
                }






        }
    }
}
