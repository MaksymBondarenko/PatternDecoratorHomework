﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Components;

namespace WindowsFormsApp1.Conditions
{
    public class Tomatoes : ConditionDecorator
    {
        public Tomatoes(Pizza pizza) : base(pizza)
        {

        }

        public override double cost()
        {
            return 1.5 + pizza.cost();
        }

        public override string getDescription()
        {
            return pizza.getDescription() + " | Tomatoes";
        }
    }
}
