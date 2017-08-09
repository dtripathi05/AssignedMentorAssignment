using System;

namespace ClubActivity
{
    public class Age
    {
        public int PersonAge { get; private set; }
        public Age(Dob dateOfBirth)
        {
            int birthYear = dateOfBirth.Year;
            var today = DateTime.Today;
            var age = today.Year - birthYear;
            PersonAge = age;
        }

        public override string ToString()
        {
            return PersonAge.ToString();
        }
    }
}
