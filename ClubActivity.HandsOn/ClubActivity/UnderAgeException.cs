using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClubActivity
{
    class UnderAgeException : Exception
    {
        public UnderAgeException(string message) : base(message)
        {
        }
    }
}
