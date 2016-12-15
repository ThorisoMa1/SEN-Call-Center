using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter
{
    class Business:Client
    {

        public Business(string PersonName, string PersonSurname,int PersonAge, string ClientLocation, string ClientIssue, int ClientContract)
            :base(PersonName,PersonSurname,PersonAge,ClientLocation,ClientIssue,ClientContract)
        {

        }
    }
}
