using System;
using System.Collections.Generic;
using System.Text;

namespace Quest02
{
    class MathService
    {
        public void Interval(int numberMin, int numberMax, int numberInput)
        {
            bool result = (numberInput > numberMin) && (numberInput < numberMax);
            Console.WriteLine(result);
        }
    }
}
