using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter
{
    class Call:CalIinterface
    {
        
        private DateTime dateOfCall;
        private decimal durition;
        private int staffId;
        private string startTime;
        private DateTime endTime;

        private string clientName;

        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }
        

        public string StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }
      
        public DateTime DateOfCall
        {
            get { return dateOfCall; }
            set { dateOfCall = value; }
        }
        

        public decimal Durition
        {
            get { return durition; }
            set { durition = value; }
        }
       

        public int StaffId
        {
            get { return staffId; }
            set { staffId =value; }//will make  the id the datase ID
        }
        

        

       public Call(string phoneNumber)
        {
            this.dateOfCall=DateTime.Now;
            //nned to call interface method;
            this.startTime = DateTime.Now.ToLocalTime().ToShortTimeString();
            this.staffId = DataHandler.GetAvailableEmployeeID();
            this.clientName = DataHandler.GetClientName(phoneNumber);


        }
     

       int CalIinterface.GetClientID()
       {
           //will return a datebase id according to the number;
           return 0;
       }
       public void EndCall() { }
       public void SetStaffID(int staffID)//will  change the staffMembersID once they are engaged in a call
    
    {
        DataHandler.SetStaffStatusToFalse(staffID);
    }

    }
}
