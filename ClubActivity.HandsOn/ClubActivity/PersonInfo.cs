using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubActivity
{
    public class PersonInfo
    {
        public PersonName Name { get; private set; }
        public Dob DateOfBirth { get; private set; }
        public Age Age { get; private set; }

        public PersonInfo(PersonName name,Dob dob)
        {
            Name = name;
            DateOfBirth = dob;
            Age = new Age(dob);
        }

        public override string ToString()
        {
            return "Name:\n" + Name.ToString() + "\nDate of Birth: " + DateOfBirth.ToString() + "\nAge: " + Age.ToString();
        }
    }
}
