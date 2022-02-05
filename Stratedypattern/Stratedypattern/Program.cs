using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DucksBibliotek;

namespace Stratedypattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck duck1 = new MallardDuck();
            RedheadDuck duck2 = new RedheadDuck();
            DecoyDuck duck3 = new DecoyDuck();
            RubberDuck duck4 = new RubberDuck();

            Duck[] ducks = new Duck[] { duck1, duck2, duck3, duck4};

            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck.Display());
                Console.WriteLine(duck.Swim());

                if (duck is Quackable)
                {
                    Console.WriteLine((duck as Quackable).Quack());
                }

                if (duck is Flyable)
                {
                    Console.WriteLine((duck as Flyable).Fly());
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
