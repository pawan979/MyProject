using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Factory_Pattern
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Document[] d1 = new Document[2];

            d1[0] = new report();
            d1[1] = new biography();

            foreach (Document d in d1)
            {
                System.Diagnostics.Debug.Write(d.GetType().Name + "\n");
                foreach (Page p in d.Pages)
                {
                    System.Diagnostics.Debug.Write("---> " + p.GetType().Name + "\n");
                }
            }

        }
    }
}