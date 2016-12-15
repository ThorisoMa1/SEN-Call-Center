using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CallCenter
{
    class Call_Assistant:Staff_Member
    {


        public Call_Assistant(string PersonName,string PersonSurname,int PersonAge)
            :base(PersonName,PersonSurname,PersonAge)
        {

        }

        public void ReceveCall() 
        {

        }
        public void GetClientDetails() { }
        public void LogClientDetails() { }
        public void SubmitWorkRequest() { }
        public void ClientPreviuseCall() { }
    }
}
