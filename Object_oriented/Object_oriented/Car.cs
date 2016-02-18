using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented
{
    // Inheritance
    class Car : Vehicle
    {

        // Encapsulation is implemented by using access specifiers
        // Public, Private, Protected

        private string _sMake;
        private string _sColor;

        
        // Information Hiding
        public string sMake 
        {
            get { return _sMake; }
            set { _sMake = value; } 
        }

        public string sColor
        {
            get { return _sColor;  }
            set { _sColor = value; }
        }


        // Default constructor
        public Car()
        { 
        }

        // Constructor with 2 parameters
        public Car(string sMake, string sColor)
        {
            _sMake = sMake;
            _sColor = sColor;
        }



        // method overriding --> Polymorphism
        public override void Print()
        {
            System.Console.WriteLine(string.Format("The make of the {0} car is {1}", _sColor, _sMake));
        }

        // method overloading
        public void PrintWheels()
        {
            System.Console.WriteLine("wheels.");
        }

        public void PrintWheels(int iWheels)
        {
            System.Console.WriteLine(string.Format("The {0} {1} car has {2} wheels.", _sMake, _sColor, iWheels));
        }

    }
}
