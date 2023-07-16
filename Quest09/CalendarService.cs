using System;
using System.Collections.Generic;
using System.Text;

namespace Quest09
{
    class CalendarService
    {
        public int GetHoursInMinutes(int hours)
        {
            int minutes = hours * 60;
            return minutes;
        }
    }
}
