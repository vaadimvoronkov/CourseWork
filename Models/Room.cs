using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public int Number { get; set; }
        public int LessonId { get; set; }
        public virtual List<Lesson> Lesson { get; set; }
        public Room(int number)
        {
            Number = number;
        }
    }
}
