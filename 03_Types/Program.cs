using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isLoggedIn = true;
            Console.WriteLine(isLoggedIn);

            decimal accountBalance = 80000.30m;
            Console.WriteLine(accountBalance);

            Console.ReadLine();

            float f1 = 3_000.5f;
            Console.WriteLine(f1);
            Console.ReadLine();
            float f2 = 1.4567867474738374f;
            Console.WriteLine(f2);
            Console.ReadLine();
            double d1 = 1.4567867474738374d;
            Console.WriteLine(d1);
            Console.ReadLine();
            decimal de1 = 1.4567867474738374m;
            Console.WriteLine(de1);
            Console.ReadLine();
        }
    }
}
