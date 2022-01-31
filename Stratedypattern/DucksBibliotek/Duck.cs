﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DucksBibliotek
{
    public abstract class Duck
    {
        public string Quaсk()
        {
            return "Quack " + this.GetType();
        }

        public string Swim()
        {
            return "Swim " + this.GetType();
        }

        public abstract string Display();
    }
}
