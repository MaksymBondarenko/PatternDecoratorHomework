using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Components
{
    public class Margarita : Pizza
    {
        public Margarita()
        {
            description = "Margarita pizza";
        }
        public override double cost()
        {
            return 6.3;
        }
    }
}
