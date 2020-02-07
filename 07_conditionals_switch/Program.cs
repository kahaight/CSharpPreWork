using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_conditionals_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string inputName = Console.ReadLine().ToLower();

            switch (inputName)
            {
                case "fred":
                    Console.WriteLine("Hey Fred, let's go golfing.");
                    Console.ReadLine();
                    break;
                case "karl":
                    Console.WriteLine("Let's hang.");
                    Console.ReadLine();
                    break;
                case "john":
                    Console.WriteLine("Sorry, I'm busy right now.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Hey " + inputName + ", can I call you back in a minute?");
                    Console.ReadLine();
                    break;
            }
            Console.WriteLine("What's your name?");
            string inputName2 = Console.ReadLine().ToLower();

            switch (inputName2)
            {
                case "will":
                    Console.WriteLine("I am good at videogames");
                    Console.ReadLine();
                    break;
                case "ty":
                    Console.WriteLine("I am good at saving money");
                    Console.ReadLine();
                    break;
                case "matt":
                    Console.WriteLine("I like magic and whiskey");
                    Console.ReadLine();
                    break;
                case "erik":
                    Console.WriteLine("I'm better than all of you at games");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("We are not friends, " + inputName2);
                    Console.ReadLine();
                    break;
            }
        }
    }
}
