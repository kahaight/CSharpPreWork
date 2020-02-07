using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            string yourName = "Angie";

            string first = "The cars we sell are ";
            string second = "BMW, Lexus, and Mercedes";
            Console.WriteLine(first + second);
            Console.ReadLine();

            string firstName = "Jenn";
            string lastName = "Williams";
            Console.WriteLine("Her name is {0} {1}", firstName, lastName);
            Console.ReadLine();

            firstName = "Robin";
            lastName = "Holler";

            Console.WriteLine($"Her name is {firstName} {lastName}");
            Console.ReadLine();

        }
    }
}
