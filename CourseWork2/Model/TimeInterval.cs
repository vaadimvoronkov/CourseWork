using System;

namespace CourseWork2.Model
{
    public class TimeInterval
    {
        public DateTime FirstTime { get; set; }
        public DateTime SecondTime { get; set; }
        public TimeInterval(DateTime firstTime, DateTime secondTime)
        {
            FirstTime = firstTime;
            SecondTime = secondTime;
        }
        //public DateTime CalculateInterval()
        //{
        //    return
        //}
    }

  
}
