using System;

namespace ClubActivity
{
   
        public class Input
        {
            public void Data(ref PersonName name, ref Dob dob)
            {
                string fname = Asking("Enter your first name");
                string mname = Asking("Enter your midddle name");
                string lname = Asking("Enter your last name");
                string date = Asking("enter your date of birth (yyyy/mm/dd)");
                string[] db = date.Split('/');
                name = new PersonName(fname, mname, lname);
                dob = new Dob(Convert.ToInt32(db[0]), Convert.ToInt32(db[1]), Convert.ToInt32(db[2]));
            }

            public string Asking(string statement)
            {
                Console.WriteLine(statement);
                return Console.ReadLine();
            }
        }

    
}
