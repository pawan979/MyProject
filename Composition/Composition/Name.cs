using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Name
    {
        public string sName;
        private string _sLastName;
        private string _sFirstName;

        public Name(string sFirstName, string sLastName)
        {
            _sFirstName = sFirstName;
            _sLastName = sLastName;
            sName = _sFirstName + " " + _sLastName;
        }

    }

    class Address
    {
        public string sAddress;
        private string _sRoadName;
        private string _sCity;

        public Address(string sRoadName, string sCity)
        {
            _sRoadName = sRoadName;
            _sCity = sCity;
            sAddress=  _sRoadName + ", " + _sCity;
        }
       
    }

    class Person 
    {
        private Name _objName;
        private Address _objAddress;

        /*Composition --> Name lifecycle depends on the person.
                          Normally when the person object is destroyed, the object Name should be as well. */
        
       public Person(string sFirstName,string sLastName)
        {
            _objName = new Name(sFirstName, sLastName);
        }

        //Aggregation --> its more like uses-a relationship
        public void SetAddress(Address objAdress)
       {
           _objAddress = objAdress;
       }

       public void Print()
       {
           if (_objAddress == null)
           {
               System.Console.WriteLine(string.Format("The person's name is {0}.", _objName.sName));

           }
               else
           {
               System.Console.WriteLine(string.Format("{0} is from {1}.", _objName.sName, _objAddress.sAddress));

           }



       }
    }
   
}
