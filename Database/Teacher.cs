using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public virtual List<Lesson> Lessons { get; set; }
        public Teacher(string firstName,string secondName, string surname)
        {
            FirstName = firstName;
            SecondName = secondName;
            Surname = surname;
        }


    }
}
