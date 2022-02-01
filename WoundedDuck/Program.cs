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

            Duck[] qruck = { redheadDuck, mallardDuck };

            foreach (Duck j in qruck)
            {
                Console.WriteLine(j.display());
                Console.WriteLine(j.quack());
                Console.WriteLine(j.swim());
            }

            Console.ReadKey();
        }
    }
}
