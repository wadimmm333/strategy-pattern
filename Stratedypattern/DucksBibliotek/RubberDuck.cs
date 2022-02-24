using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DucksBibliotek
{
    public class RubberDuck : Duck
    {
        public override string Display()
        {
            return "" + this.GetType() + " " + FlyWithWings.GetType() + " " + DQuack.GetType();
        }

        public RubberDuck(FlyBehavior Fly, QuackBehavior Quack)
        {
            FlyBehavior = Fly;
            QuackBehavior = Quack;
        }
    }
}
