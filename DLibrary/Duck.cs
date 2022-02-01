using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DLibrary
{
    public abstract class Duck 
    {     
        public string swim()
        {
            return "swim" + this.GetType();
        }      
        public abstract string display();
    }
}
