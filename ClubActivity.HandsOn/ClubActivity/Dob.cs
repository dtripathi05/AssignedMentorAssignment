using System;

namespace ClubActivity
{
    public class Dob
    {
        public string DateOfBirth { get; private set; }
        public int Year { get; private set; }
        public Dob(int year, int mm, int dd)
        {
            DateTime dob = new DateTime(year, mm, dd);
            Year = dob.Year;
            this.DateOfBirth = dob.ToShortDateString();
        }

        public override string ToString()
        {
            return DateOfBirth;
        }
    }
}
