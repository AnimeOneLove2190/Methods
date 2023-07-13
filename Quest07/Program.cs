using System;

namespace Quest07
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputWidth = int.Parse(Console.ReadLine());
            int inputLength = int.Parse(Console.ReadLine());
            MathService service = new MathService();
            int result = service.Area(inputLength, inputWidth);
            Console.WriteLine(result);
        }
    }
}
