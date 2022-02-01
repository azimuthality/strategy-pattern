using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLibrary.Folder;


namespace DLibrary
{
    
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flybehavior = new FlyWithWings();
            quackbehavior = new DQuack();
        }
        public override string display()
        {
            return "display" + this.GetType();
        }
     
    }
}
