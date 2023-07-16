using System;

namespace Quest03
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pointOne = new Point();
            pointOne.x = int.Parse(Console.ReadLine());
            pointOne.y = int.Parse(Console.ReadLine());
            Point pointTwo = new Point();
            pointTwo.x = int.Parse(Console.ReadLine());
            pointTwo.y = int.Parse(Console.ReadLine());
            int CatheusX = 0;
            int CatheusY = 0;
            if (pointOne.x > pointTwo.x)
            {
                MathService service = new MathService();
                int resultOne = service.GetCathetus(pointTwo.y, pointOne.x);
                CatheusX = resultOne;
            }
            if (pointOne.x < pointTwo.x)
            {
                MathService service = new MathService();
                int resultOne = service.GetCathetus(pointOne.x, pointTwo.y);
                CatheusX = resultOne;
            }
            if (pointOne.y > pointTwo.y)
            {
                MathService service = new MathService();
                int resultOne = service.GetCathetus(pointTwo.y, pointOne.x);
                CatheusY = resultOne;
            }
            if (pointOne.y < pointTwo.y)
            {
                MathService service = new MathService();
                int resultOne = service.GetCathetus(pointOne.x, pointTwo.y);
                CatheusY = resultOne;
            }
            MathService serviceOne = new MathService();
            double Hypotenuse = serviceOne.GetHypotenuse(CatheusX, CatheusY);
            Console.WriteLine(Hypotenuse);
        }
    }
}
