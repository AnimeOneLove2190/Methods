using System;

namespace Quest05
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputC = double.Parse(Console.ReadLine());
            MathService service = new MathService();
            double outputF = service.GetDegrees(inputC);
            Console.WriteLine(outputF);
        }
    }
}
