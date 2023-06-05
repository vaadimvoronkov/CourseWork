using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Interval
    {
        public int IntervalId { get; private set; }
        public int FirstTimeHour { get; private set; }
        public int FirstTimeMinute { get; private set; }
        public int LastTimeHour { get; private set; }
        public int LastTimeMinute { get; private set; }
        public virtual List<Lesson> Lesson { get;  private set; }

        public Interval(int firstTimeHour,int firstTimeMinute,int secondTimeHour,int secondTimeMinute)
        {
            FirstTimeHour = firstTimeHour;
            FirstTimeMinute = firstTimeMinute;
            LastTimeHour = secondTimeHour;
            LastTimeMinute = secondTimeMinute;
        }
    }
}
