using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2.Exceptions
{
    public class UncorrectInputStringException: Exception
    {
        public UncorrectInputStringException(string message): base(message) { }
    }
}
