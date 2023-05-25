using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2.Model
{
    public class Interval
    {
        public DateTime FirstTime { get; set; }
        public DateTime LastTime { get; set; }
        public Interval(DateTime firstTime, DateTime secondTime) 
        {
            FirstTime= firstTime;
            LastTime= secondTime;
        }
    }
}
