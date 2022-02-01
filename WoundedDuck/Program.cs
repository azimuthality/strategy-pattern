using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLibrary;
using DLibrary.Folder;



namespace WoundedDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            RedheadDuck redheadDuck = new RedheadDuck();
            MallardDuck mallardDuck = new MallardDuck();
            RubberDuck rubberDuck = new RubberDuck();
            DecoyDuck decoyDuck = new DecoyDuck();

            FlyBehavior flynoway = new FlyNoWay();
            FlyBehavior flywithwings = new FlyWithWings();

            QuackBehavior mutequack = new MuteQuack();
            QuackBehavior dquack = new DQuack();
            QuackBehavior squeak = new Squeak();

            redheadDuck.SetFlyBehavior(flywithwings);
            redheadDuck.SetQuackBehavior(dquack);
            rubberDuck.SetFlyBehavior(flynoway);
            rubberDuck.SetQuackBehavior(squeak);
            decoyDuck.SetFlyBehavior(flynoway);
            decoyDuck.SetQuackBehavior(mutequack);
            mallardDuck.SetFlyBehavior(flywithwings);
            mallardDuck.SetQuackBehavior(dquack);

            Duck[] qruack = { redheadDuck, mallardDuck, rubberDuck, decoyDuck };

            foreach (Duck j in qruack)
            {
                Console.WriteLine(j.display());
                Console.WriteLine(j.swim());
                Console.WriteLine(j.PerformFly());
                Console.WriteLine(j.PerformQuack());
            }

            Console.ReadKey();
        }
    }
}
