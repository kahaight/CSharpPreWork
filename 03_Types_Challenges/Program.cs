using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Types_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int intOne = 23;
            int intTwo;
            intTwo = 46;

            string stringOne = "Konrad";
            string stringTwo;
            stringTwo = "Haight";

            bool boolOne = true;
            bool boolTwo;
            boolTwo = false;

            float floatOne = 3.14159f;
            float floatTwo;
            floatTwo = 3.14159e2f;

            double doubleOne = 3.1415926535d;
            double doubleTwo;
            doubleTwo = 3.1415926535e3d;

            decimal decimalOne = 3.1415926535897932384626m;
            decimal decimalTwo;
            decimalTwo = 3.1415926535897932384626e6m;

            stringOne = "My";
            stringTwo = "name";
            string stringThree = "is";
            string stringFour = "Konrad";
            string stringFive = ".";
            string stringSix = " ";

            string sentence = stringOne + stringSix + stringTwo + stringSix + stringThree + stringSix + stringFour + stringFive;

            intOne = 1;
            intTwo = 9;
            int intThree = 8;
            int intFour = 7;

            string birthyear = intOne.ToString() + intTwo.ToString() + intThree.ToString() + intFour.ToString();

            int birthyear2 = 1987;
            Console.WriteLine("I was born in {0}", birthyear2);

            Console.WriteLine(birthyear);
            Console.ReadLine();
            Console.WriteLine(sentence);
            Console.ReadLine();

            Console.WriteLine(intTwo);
            Console.WriteLine(stringTwo);
            Console.WriteLine(boolTwo);
            Console.WriteLine(floatTwo);
            Console.WriteLine(doubleTwo);
            Console.WriteLine(decimalTwo);
            Console.ReadLine();


        }
    }
}
