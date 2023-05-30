using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Tables
{
    public class Room
    {
        public int RoomId { get; set; }
        public int Number { get; set; }
        public virtual List<Lesson> Lessons { get; set; }
    }
}
