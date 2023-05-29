using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2.Model
{
    public class Interval
    {
        public int IntervalId { get; set; }
        public int FirstTimeHour { get; set; }
        public int FirstTimeMinute { get; set; }
        public int LastTimeHour { get; set; }
        public int LastTimeMinute { get; set; }

        public Interval(int firstTimeHour,int firstTimeMinute,int secondTimeHour,int secondTimeMinute)
        {
            FirstTimeHour = firstTimeHour;
            FirstTimeMinute = firstTimeMinute;
            LastTimeHour = secondTimeHour;
            LastTimeMinute = secondTimeMinute;
        }
        public Interval()
        {

        }
    }
}
