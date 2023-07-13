using System;

namespace Quest09
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputMinutes = int.Parse(Console.ReadLine());
            CalendarService service = new CalendarService();
            int result = service.HoursInMinutes(inputMinutes);
            Console.WriteLine(result);
        }
    }
}
