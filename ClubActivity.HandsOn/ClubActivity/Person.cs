using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubActivity
{
    public class Person
    {
        public Name Name { get;  set; }
        public DateTime DateOfBirth { get;  set; }
        public int Age
        {
            get
            {
                int age = DateTime.Today.Year - DateOfBirth.Year;
                if (DateTime.Today.DayOfYear > DateOfBirth.DayOfYear)
                    age += 1;
                return age;
            }
        }

        public override string ToString()
        {
            return "Name:\n" + Name.ToString() + "\nDate of Birth: " + DateOfBirth.ToString() + "\nAge: " + Age.ToString();
        }
    }
}
