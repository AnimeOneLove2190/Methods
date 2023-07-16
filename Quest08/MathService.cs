using System;
using System.Collections.Generic;
using System.Text;

namespace Quest08
{
    class MathService
    {
        public int GetCapacity(int length, int width, int height)
        {
            int result = length * width * height;
            return result;
        }
    }
}
