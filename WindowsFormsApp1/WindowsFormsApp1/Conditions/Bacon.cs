using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Components;

namespace WindowsFormsApp1.Conditions
{
   public class Bacon : ConditionDecorator
    {
        public Bacon(Pizza pizza) : base(pizza)
        {

        }

        public override double cost()
        {
            return 3.5 + pizza.cost();
        }

        public override string getDescription()
        {
            return pizza.getDescription() + " | Bacon";
        }
    }
    
}
