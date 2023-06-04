using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public int LessonId { get; set; }
        public virtual List<Lesson> Lesson { get; set; }

        public Teacher(string firstName,string secondName, string surname)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            SecondName = secondName ?? throw new ArgumentNullException(nameof(secondName));
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
        }


    }
}
