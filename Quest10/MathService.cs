using System;
using System.Collections.Generic;
using System.Text;

namespace Quest10
{
    class MathService
    {
        public void Swap(ref int numberOne, ref int numberTwo)
        {
            int numberIntermediate = numberOne;
            numberOne = numberTwo;
            numberTwo = numberIntermediate;
            Console.WriteLine($"{numberOne} {numberTwo}");
        }
    }
}
