using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DLibrary
{
    public abstract class Duck 
    {
        protected FlyBehavior flybehavior;
        protected QuackBehavior quackbehavior;
        public string swim()
        {
            return "Буль буль буль";
        }      
        public abstract string display();
        public string PerformFly()
        {
            return flybehavior.fly();
        }

        public string PerformQuack()
        {
            return quackbehavior.quack();
        }

        public void SetFlyBehavior(FlyBehavior flyable)
        {
            flybehavior = flyable;
        }
        public void SetQuackBehavior(QuackBehavior quackable)
        {
            quackbehavior = quackable;
        }
    }
}
