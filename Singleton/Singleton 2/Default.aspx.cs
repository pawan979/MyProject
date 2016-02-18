using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    protected void Page_Init(object sender, EventArgs e)
    {
        Singleton SingletonObject = Singleton.GetObject();
        SingletonObject.Name = "Hello World";
        SingletonObject.Print();
        lblText.Text = SingletonObject.Name;
      
    }


     protected void Page_Load(object sender, EventArgs e)
    {
       
    }


    protected  void txtText_TextChanged(object sender, EventArgs e)
    {
       
    }


}