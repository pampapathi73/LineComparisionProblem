using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisionProblem
{
    class CalculateTheLenght
    {
        public void CalculateLength()
        {
            Console.WriteLine("... Welcome to Line Comparison Computation ... ");

            Console.WriteLine("Enter a, b coordinates of the line 1::");

            Console.WriteLine("a1");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a2");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b1");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b2");
            int b2 = Convert.ToInt32(Console.ReadLine());

            double Length = new double();
            Length = Math.Sqrt(Math.Pow((a2 - b1), 2) + Math.Pow((b2 - b1), 2));
            Console.WriteLine("Length of line 1 is:: " + Length);
            Console.ReadKey();
        }
    }
}
