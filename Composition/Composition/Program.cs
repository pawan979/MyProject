using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Composition
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
            //Application.Run(new Form1());

            // Aggregation --> Both class person and address have their own lifecycle. They are independent.
            Person p1 = new Person("toto", "titi");

            p1.Print();

            Address a1 = new Address("Royal road", "Rhill");
            p1.SetAddress(a1);

            p1.Print();

            System.Threading.Thread.Sleep(10000);

        }
    }
}
