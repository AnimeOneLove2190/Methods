﻿using System;

namespace Quest01
{
    class Program
    {
        static void Main(string[] args)
        {
            TextService service = new TextService();
            string inputNameOne = Console.ReadLine();
            string resultOne = service.Greetings(inputNameOne);
            Console.WriteLine(resultOne);
        }
    }
}
