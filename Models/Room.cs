using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Room
    {
        public int RoomId { get; private set; }
        public int Number { get; set; }
        public  List<Lesson> Lessons { get; private set; }
        public Room(int number)
        {
            Number = number;
        }
    }
}
