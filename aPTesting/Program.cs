using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aPTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            char doAgain;
            bool runP = true;

            while (runP == true)
            {
                Console.WriteLine("Please enter the length of the classroom.");
                int cLength = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("You entered: {0}, Please enter the width of the classroom.",
                    cLength);
                int cWidth = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("You entered {0} and {1}, " +
                    "Lets check the perimeter and the area of the classroom.",
                    cLength, cWidth);

                int areaAnswer = (cLength * cWidth);
                Console.WriteLine("The area of the classroom is {0}.", areaAnswer);

                int perimeterAnswer = ((cLength * 2) + (cWidth * 2));
                Console.WriteLine("The perimeter of the classroom is {0}.", perimeterAnswer);

                Console.WriteLine("Would you like to run the application again? (Y or N)");

                doAgain = Convert.ToChar(Console.ReadLine());

                if (doAgain != 'y' && doAgain != 'Y')
                {
                    runP = false;
                }
                else
                    runP = true;
            }
        }
    }
}