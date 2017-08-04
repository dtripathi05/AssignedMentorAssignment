using System.Collections.Generic;


namespace ClubActivity
{
    public partial class Club
    {
        public List<PersonInfo> listOfPersons;
        public Club()
        {
            RegestrationForClub();
        }
        public void RegestrationForClub()
        {
            Input input = new Input();
            listOfPersons = new List<PersonInfo>();
            PersonName name = null;
            Dob dob = null;
            input.Data(ref name, ref dob);
            PersonInfo info = new PersonInfo(name, dob);
            listOfPersons.Add(info);
        }
    }
}