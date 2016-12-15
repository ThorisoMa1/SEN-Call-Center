using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.Business_Layer
{
    class Issues
    {

        string issue;

        public string Issue
        {
            get { return issue; }
            set { issue = value; }
        }
        public Issues(string Issue)
        {
            this.issue = Issue;
        }
        public Issues()//
        {
            DataHandler.GetIssues();//will create the list of issues for the box
        }

    }
}
