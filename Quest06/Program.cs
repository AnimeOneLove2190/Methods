using System;

namespace Quest06
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCity = Console.ReadLine();
            string inputStreet = Console.ReadLine();
            string inputHouse = Console.ReadLine();
            string inputApart = Console.ReadLine();
            TextService service = new TextService();
            string output = service.GetAddress(inputCity, inputStreet, inputHouse, inputApart);
            Console.WriteLine(output);
        }
    }
}
