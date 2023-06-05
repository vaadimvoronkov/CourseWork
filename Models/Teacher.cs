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
        public int TeacherId { get; private set; }
        public string FirstName { get; private set; }
        public string SecondName { get; private set; }
        public string Surname { get; private set; }
        public virtual List<Lesson> Lesson { get; private set; }

        public Teacher(string firstName,string secondName, string surname)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            SecondName = secondName ?? throw new ArgumentNullException(nameof(secondName));
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
        }


    }
}
