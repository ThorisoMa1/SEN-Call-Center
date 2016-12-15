using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter
{
    abstract class Person
    {
        private  string personName;
        private string personSurname;
        private int personAge;

      

        public string PersonName
        {
            get { return personName; }
            set { personName = value; }
        }
        

        public string PersonSurname
        {
            get { return personSurname; }
            set { personSurname = value; }
        }
        

        public int PersonAge
        {
            get { return personAge; }
            set { personAge = value; }
        }



        public Person(string PersonName, string PersonSurname, int PersonAge)
        {
            this.personName = PersonName;
            this.personSurname = PersonSurname;
            this.personAge = PersonAge;
        }
        public Person()
        {

        }
        public abstract void Information();//willl change it later to return a  value


    }
}
