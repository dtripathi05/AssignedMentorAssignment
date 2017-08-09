using System.Collections.Generic;


namespace ClubActivity
{
    public partial class Club
    {
        public List<Person> GetMembers()
        {
            return listOfPersons;
        }
        private List<Person> listOfPersons=new List<Person>();
        
        public virtual void Enroll(Person person)
        {
            listOfPersons.Add(person);
        }
    }
}