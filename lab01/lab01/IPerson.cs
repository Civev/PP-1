using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab01.Person;

namespace lab01
{
    public interface IPerson
    {

        
        string Hair { get; set ; }

        
        string this[int ind]
        {
            get; set;
        }

         void CheckBirthdatDate(DateTime date);
        //public delegate void SendHandler(string m);
        //public event SendHandler SendSomthing;
    }
}
