using System;
using System.Collections.Generic;
using System.Text;

namespace Quest10
{
    class MathService
    {
        public string Swap(ref int numberOne, ref int numberTwo)
        {
            int numberIntermediate = numberOne;
            numberOne = numberTwo;
            numberTwo = numberIntermediate;
            string result = $"{numberOne} {numberTwo}";
            return result;
        }
    }
}
