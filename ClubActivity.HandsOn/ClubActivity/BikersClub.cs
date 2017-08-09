using System;
using System.Collections.Generic;


namespace ClubActivity
{
    public class BikersClub : Club
    {
        public override void Enroll(Person person)
        {
            if (CheckEligiblity(person.Age))
            {
                base.Enroll(person);
            }

        }

        public bool CheckEligiblity(int age)
        {
            if (age < 18)
            {
                return false;
            }
            else
                return true;
        }

    }

}