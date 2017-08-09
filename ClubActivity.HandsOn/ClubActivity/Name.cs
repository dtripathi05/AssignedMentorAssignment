﻿namespace ClubActivity
{
    public class Name
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Name(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return (FirstName + " " + MiddleName + " " + LastName);
        }
    }
}
