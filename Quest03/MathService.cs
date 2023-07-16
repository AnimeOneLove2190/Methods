using System;
using System.Collections.Generic;
using System.Text;

namespace Quest03
{
    class MathService
    {
        public int GetCathetus(int numberMin, int numberMax)
        {
            int result = numberMax - numberMin;
            return result;
        }
        public double GetHypotenuse(double sideOne, double sideTwo)
        {
            double resOne = (sideOne) * (sideOne) + (sideTwo) * (sideTwo);
            double resTwo = Math.Sqrt(resOne);
            return resTwo;
        }
    }
}
