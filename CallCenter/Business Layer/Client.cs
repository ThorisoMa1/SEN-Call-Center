using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter
{
    class Client:Person
    {
        string clientLocation;
        string clientIssue;

        public string ClientLocation
        {
            get { return clientLocation; }
            set { clientLocation = value; }
        }
       

        public string ClientIssue
        {
            get { return clientIssue; }
            set { clientIssue = value; }
        }

        public Client(string PersonName,string PersonSurname,int PersonAge,string ClientLocaction,string ClientIssue,int ClientContract):
            base(PersonName,PersonSurname,PersonAge)
        {

        }
        public override void Information()
        {
            
        }
        public void InsertClient(string ClientName,string ClientSurname,int ClientAge,string ClientPhone,string clientContract,string ClientIssu) //calls dataAccess in order to insert client
        {
            DataHandler.InsertClientInforation(ClientName,ClientSurname,ClientAge,ClientPhone,clientContract,ClientIssu);
            

        }
        public  static void Inserted() 
        {
            Presentation.InsertNewClient.Succesfullinsert();//will activate the messagebox to say that clients inserted
        }
        public static void FailedInsert()
        {
            Presentation.InsertNewClient.Succesfullinsert();//will activate the messagebox to say that clients inserted
        }
        public Client()
        {

        }
        

    }
}
