using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter
{
    class Individual:Client
    {
       

        public Individual(string PersonName,string PersonSurname,int PersoneAge,string ClientLocation ,string ClientIssue ,int ClientContract)
            :base(PersonName,PersonSurname,PersoneAge,ClientLocation,ClientIssue,ClientContract)
        {

        }
    }
}
