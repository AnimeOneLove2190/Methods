using System;
using System.Collections.Generic;
using System.Text;

namespace Quest11
{
    class MathService
    {
        public int GetMaxNumberOfTwo(int numOne, int numTwo)
        {
            if (numOne >= numTwo)
            {
                int numMin = numTwo;
                numTwo = numOne;
                numOne = numMin;
            }
            int numMax = numTwo;
            return numMax;
        }
    }
}
