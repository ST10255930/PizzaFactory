using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    public class PepperoniPizza : IPizza
    {
        public string getBase()
        {
            return "Thick";
        }
        public string getToping()
        {
            return "Pepperoni";
        }
        public string getSauce()
        {
            return "Tomato";
        }
    }
}
