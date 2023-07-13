using System;

namespace Quest04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            MathService service = new MathService();
            service.Check(numberOne);
        }
    }
}
