using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Components;

namespace WindowsFormsApp1.Conditions
{
   public class Chicken : ConditionDecorator
    {
        public Chicken(Pizza pizza) : base(pizza)
        {

        }

        public override double cost()
        {
            return 3.8 + pizza.cost();
        }

        public override string getDescription()
        {
            return pizza.getDescription() + " | Chicken";
        }
    }
    
}
