﻿using System;

namespace Quest10
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumberOne = int.Parse(Console.ReadLine());
            int inputNumberTwo = int.Parse(Console.ReadLine());
            MathService service = new MathService();
            service.Swap(ref inputNumberOne, ref inputNumberTwo);
        }
    }
}
