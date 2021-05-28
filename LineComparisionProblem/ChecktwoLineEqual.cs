using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisionProblem
{
    class ChecktwoLineEqual
    {
        public void CalculateLength()
        {
            Console.WriteLine("... Welcome to Line Comparison Computation ... ");
            //Coodinates 1
            Console.WriteLine("Enter a, b co ordinates of the line 1 :");

            Console.WriteLine("Enter value a1");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale a2");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale b1");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale b2");
            int b2 = Convert.ToInt32(Console.ReadLine());

            //Coodinates 2

            Console.WriteLine("Enter a, b co ordinates of the line 2 :");

            Console.WriteLine("Enter value of S1");
            int S1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of S2");
            int S2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale R1");
            int R1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale R2");
            int R2 = Convert.ToInt32(Console.ReadLine());

            //Calculating value of XY

            double LengthOfXY = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
            Console.WriteLine("Length of Value 1 is:: " + LengthOfXY);

            //Calculating value of SR


            double LengthOfSR = Math.Sqrt(Math.Pow((S2 - S1), 2) + Math.Pow((R2 - R1), 2));
            Console.WriteLine("Length of Value 2 is: " + LengthOfSR);

            //Check LengthOfXY = LengthOfSR


            bool equalToResult = LengthOfXY.Equals(LengthOfSR);

            if (equalToResult == false)
            {
                Console.WriteLine("Therefore, Lines LengthOfXY and LengthOfSR are NOT Equal.");
            }
            else
            {
                Console.WriteLine("Therefore, Lines LengthOfXY and LengthOfSR are Equal.");
            }
            Console.ReadKey();
        }
    }
}