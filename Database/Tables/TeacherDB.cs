using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Database.Tables
{
    public class TeacherDB
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public virtual List<LessonDB> Lessons { get; set; }

    }
}
