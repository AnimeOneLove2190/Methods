using System;

namespace Quest08
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputWidth = int.Parse(Console.ReadLine());
            int inputLength = int.Parse(Console.ReadLine());
            int inputHeight = int.Parse(Console.ReadLine());
            MathService service = new MathService();
            int result = service.GetCapacity(inputLength, inputWidth, inputHeight);
            Console.WriteLine(result);
        }
    }
}
