using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Room
    {
        public int RoomId { get; set; }
        public int Number { get; set; }
        public virtual List<Lesson> Lessons { get; set; }
        public Room(int number)
        {
            Number = number;
        }
    }
}
