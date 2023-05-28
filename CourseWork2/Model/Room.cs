using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2.Model
{
    public class Room
    {
        public int RoomId { get; set; }
        public int Number { get; set; }
        List<Lesson> Lessons { get; set; }
    }
}
