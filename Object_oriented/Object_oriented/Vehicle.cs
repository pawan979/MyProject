using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented
{
    class Vehicle
    {
        private int _iNoWheels;

        public int iNoWheels 
        {
            get { return _iNoWheels; }

            set {  _iNoWheels = value; } 

        }

        public virtual void Print()
        {
            System.Console.WriteLine("No of wheels: " + _iNoWheels);
        }
    }
}
