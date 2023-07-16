using System;

namespace Quest02
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService service = new MathService();
            bool result = service.IsInsideInterval(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine(result);
        }
    }
}
