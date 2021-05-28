using System;

namespace LineComparisionProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparision problem");
            CalculateTheLenght calculateLength = new CalculateTheLenght();

            calculateLength.CalculateLength();
            ChecktwoLineEqual checktwoLineEqual = new ChecktwoLineEqual();
            checktwoLineEqual.CalculateLength();
            CheckEqualGreaterLess checkEqualGreaterLess = new CheckEqualGreaterLess();
            checkEqualGreaterLess.CalculateLength();
        }
    }
}
