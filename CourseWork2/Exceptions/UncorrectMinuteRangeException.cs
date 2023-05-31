using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2.Exceptions
{
    public class UncorrectMinuteRangeException: Exception
    {
        public UncorrectMinuteRangeException(string message) : base(message) { }
    }
}
