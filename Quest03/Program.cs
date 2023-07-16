using System;

namespace Quest03
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.x = int.Parse(Console.ReadLine());
            point.y = int.Parse(Console.ReadLine());
            if (point.x >= point.y)
            {
                MathService service = new MathService();
                int resultOne = service.GetDistance(point.y, point.x);
                Console.WriteLine(resultOne);
            }
            if (point.x < point.y)
            {
                MathService service = new MathService();
                int resultOne = service.GetDistance(point.x, point.y);
                Console.WriteLine(resultOne);
            }
        }
    }
}
