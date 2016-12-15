using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.Business_Layer
{
    class Packages
    {
        string packageName;
        List<string> packageServices;

        public List<string> PackageServices
        {
            get { return packageServices; }
            set { packageServices = value; }
        }
        string PackageDescription;

        public string PackageName
        {
            get { return packageName; }
            set { packageName = value; }
        }
      

        public string PackageDescription1
        {
            get { return PackageDescription; }
            set { PackageDescription = value; }
        }
        public Packages(string PAckageName,string PackageDescription,List<string>PackageServices)
        {
            this.packageName = PAckageName;
            this.PackageDescription = PackageDescription;
            this.packageServices = PackageServices;
        }//will create the package Item
      

       
    }
}
