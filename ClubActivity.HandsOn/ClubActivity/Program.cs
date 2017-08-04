using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                BikersClub club = new BikersClub();
            }
            catch (UnderAgeException e)
            {
                Console.WriteLine("UnderAgeException: {0}", e.Message);
            }
            Console.ReadKey();
        }

    }
}
