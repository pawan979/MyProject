using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_oriented
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          //  Application.Run(new Form1());


            // creation of objects
            Car objCar1 = new Car(); // default constructor
            objCar1.sMake = "Toyota";
            objCar1.sColor = "Red";
            objCar1.iNoWheels = 5;


            Car objCar2 = new Car("BMW", "Blue"); // constructor with 2 parameters
            objCar1.Print();
            objCar2.Print();

            objCar2.PrintWheels(4);

            System.Threading.Thread.Sleep(10000);
        }
    }
}
