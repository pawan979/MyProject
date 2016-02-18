using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Singleton
/// </summary>
public class Singleton
{
   
    protected static Singleton _obj;
    private string _Name;

 public string Name 
 { 
     get { return _Name; }

     set { _Name = value; }
 }

    private Singleton()
    {

    }

    public static Singleton GetObject()
    {
        if (_obj == null)
        {
            _obj = new Singleton();

        }
        return _obj;
    }
    public void Print()
    {
       System.Diagnostics.Debug.Write(_Name);
    }

}
