using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DucksRealisation
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck1 = new MallardDuck();
            Duck duck2 = new RedheadDuck();

            Duck[] ducks = new Duck[] { duck1, duck2 };

            for (int i = 0; i < ducks.Length; i++)
            {
                Console.WriteLine(ducks[i].Display());
                Console.WriteLine(ducks[i].Swim());
                Console.WriteLine(ducks[i].Quaсk());
            }

            Console.ReadKey();
        }
    }
}
