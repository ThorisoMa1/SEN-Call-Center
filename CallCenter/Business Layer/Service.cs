using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter
{
    class Service
    {
        string serviceName;
        int serviceLevel;

        public string ServiceName
        {
            get { return serviceName; }
            set { serviceName = value; }
        }
       

        public int ServiceLevel
        {
            get { return serviceLevel; }
            set { serviceLevel = value; }
        }

        public Service(string ServiceName,int ServiceLevel)
        {
            this.serviceName = ServiceName;
            this.serviceLevel = ServiceLevel;
        }
    }
}
