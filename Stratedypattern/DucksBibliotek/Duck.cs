using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DucksBibliotek
{
    public abstract class Duck
    {
        public string Swim()
        {
            return "Буль буль буль";
        }

        public abstract string Display();

        public FlyBehavior FlyBehavior {  get; set; }
        protected QuackBehavior QuackBehavior {  get; set; }

        public string performFly()
        {
            return FlyBehavior.Fly();
        }

        public string performQuack()
        {
            return QuackBehavior.Quack();
        }
    }
}
