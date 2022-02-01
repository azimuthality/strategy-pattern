using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLibrary;



namespace WoundedDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            RedheadDuck redheadDuck = new RedheadDuck();
            MallardDuck mallardDuck = new MallardDuck();
            RubberDuck rubberDuck = new DLibrary.RubberDuck();
            DecoyDuck decoyDuck = new DecoyDuck();

            Duck[] qruck = { redheadDuck, mallardDuck, rubberDuck, decoyDuck };

            foreach (Duck j in qruck)
            {
                Console.WriteLine(j.display());
                Console.WriteLine(j.swim());
                if (j is Quackable)
                {
                    Console.WriteLine((j as Quackable).quack());
                }
                if (j is Flyable)
                {
                    Console.WriteLine((j as Flyable).fly());
                }
            }

            Console.ReadKey();
        }
    }
}
