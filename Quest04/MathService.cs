using System;
using System.Collections.Generic;
using System.Text;

namespace Quest04
{
    class MathService
    {
        public bool IsEven(int number)
        {
            int resultOne = number % 2;
            bool resuktTwo = resultOne == 0;
            return resuktTwo;
        }
    }
}
