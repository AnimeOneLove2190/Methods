using System;
using System.Collections.Generic;
using System.Text;

namespace Quest02
{
    class MathService
    {
        public bool IsInsideInterval(int numberMin, int numberMax, int numberInput)
        {
            bool result = (numberInput > numberMin) && (numberInput < numberMax);
            return result;
        }
    }
}
