using System;
using System.Collections.Generic;
using System.Text;

namespace Quest04
{
    class MathService
    {
        public void Check(int number)
        {
            int resultOne = number % 2;
            bool resuktTwo = resultOne == 0;
            Console.WriteLine(resuktTwo);
        }
    }
}
