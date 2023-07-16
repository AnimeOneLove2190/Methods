using System;

namespace Quest04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            MathService service = new MathService();
            bool result = service.IsEven(numberOne);
            Console.WriteLine(result);
        }
    }
}
