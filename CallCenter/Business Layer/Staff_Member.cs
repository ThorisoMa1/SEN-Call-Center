using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter
{
    class Staff_Member:Person
    {
        public Staff_Member(string PersonName,string PersonSurname ,int PersonAge):
            base(PersonName,PersonSurname,PersonAge)
        {
                
        }
        public override void Information()
        {
            throw new NotImplementedException();
        }
        

    }
}
