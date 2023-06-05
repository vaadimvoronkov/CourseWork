using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Database.Tables
{
    [PrimaryKey("TeacherId")]
    public class TeacherDB
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public virtual List<LessonDB> Lesson { get; set; } = new();

    }
}
