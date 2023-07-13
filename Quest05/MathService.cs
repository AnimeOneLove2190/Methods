using System;
using System.Collections.Generic;
using System.Text;

namespace Quest05
{
    class MathService
    {
        public double Degrees(double c)
        {
            double f = 1.8 * c + 32;
            return f;
        }
    }
}
