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
            
            
            MallardDuck duck1 = new MallardDuck(new FlyWithWings(), new DQuack());
            RedheadDuck duck2 = new RedheadDuck(new FlyWithWings(), new DQuack());
            DecoyDuck duck3 = new DecoyDuck(new FlyNoWay(), new DQuack());
            RubberDuck duck4 = new RubberDuck(new FlyNoWay(), new Squeak()) ;

            Duck[] ducks = new Duck[] { duck1, duck2, duck3, duck4};

            foreach (var x in ducks)
            {
                Console.WriteLine(x.Swim());
                Console.WriteLine(x.Display());
                Console.WriteLine(x.performQuack());
                Console.WriteLine(x.performFly());
            }
            
            Console.ReadKey();
        }
    }
}
