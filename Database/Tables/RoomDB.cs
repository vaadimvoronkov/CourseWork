using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Tables
{
    public class RoomDB
    {
        public int RoomId { get; set; }
        public int Number { get; set; }
        public int LessonId { get;  set; }
        public virtual List<LessonDB> Lesson { get; set; }
    }
}
