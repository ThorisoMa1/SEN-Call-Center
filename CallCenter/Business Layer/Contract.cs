using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter
{
    class Contract
    {

        string contractName;
        
        Decimal contractPrice;
        

        public string ContractName
        {
            get { return contractName; }
            set { contractName = value; }
        }
        

    

        public Decimal ContractPrice
        {
            get { return contractPrice; }
            set { contractPrice = value; }
        }


      
        public Contract(string ContractName,Decimal ContractPrice)
        {
            this.contractName = ContractName;
            this.contractPrice = ContractPrice;
                
        }
        public Contract()
        {
             DataHandler.GetAllcontracts();
        }

    }
}
