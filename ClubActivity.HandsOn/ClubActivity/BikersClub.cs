using System;
using System.Collections.Generic;


namespace ClubActivity
{
    public class BikersClub : Club
    {
        List<PersonInfo> ridersList=new List<PersonInfo>();
        public BikersClub()
        {
           // RegestrationForClub();
            Regestration();
        }
        private void Regestration()
        {
            foreach(PersonInfo info in listOfPersons)
            {
                if(info.Age.PersonAge>18)
                {
                    ridersList.Add(info);
                }
                else
                {
                    throw (new UnderAgeException("Your Age is Below 18 ,So Not Allowed to Join the RidersClub"));
                }
            }
        }
    }
}