using System;

namespace Quest02
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService service = new MathService();
            service.Interval(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }
    }
}
