using System;

namespace Quest11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            MathService serviceMaxNumOfTwo = new MathService();
            int numMax = serviceMaxNumOfTwo.GetMaxNumberOfTwo(numOne, numTwo);
            Console.WriteLine(numMax);
        }
    }
}
