﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2.Exceptions
{
    internal class AreEqualTimesException:Exception
    {
        public AreEqualTimesException(string message) : base(message) { }
    }
}
