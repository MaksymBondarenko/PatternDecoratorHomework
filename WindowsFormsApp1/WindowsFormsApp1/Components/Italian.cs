using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Components
{
    public class Italian : Pizza
    {
        public Italian()
        {
            description = "Italian pizza";
        }
        public override double cost()
        {
            return 5.5;
        }
    }
}
