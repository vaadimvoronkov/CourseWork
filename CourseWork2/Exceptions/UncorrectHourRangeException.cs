using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2.Exceptions
{
    public class UncorrectHourRangeException:Exception
    {
        public UncorrectHourRangeException(string message) : base(message) { }
    }
}
