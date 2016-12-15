using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter
{
    class Technition:Staff_Member
    {
        string skills;
        string jobs;

        public void GetJobs() 
        {
        }
        public void GetScheduals() 
        {
        }
        public Technition(string Skills,string Jobs,string PersonName,string PersonSurname,int PersonAge )
            :base(PersonName,PersonSurname,PersonAge)
        {

        }


    }
}
