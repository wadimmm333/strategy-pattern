using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DucksBibliotek
{
    public class MallardDuck : Duck
    {
        public override string Display()
        {
            return "" + this.GetType() + " " + FlyBehavior.GetType() + " " + QuackBehavior.GetType();
        }

        public MallardDuck(FlyBehavior Fly, QuackBehavior Quack)
        {
            FlyBehavior = Fly;
            QuackBehavior = Quack;
        }
    }
}
