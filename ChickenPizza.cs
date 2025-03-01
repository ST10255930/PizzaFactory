using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    public class ChickenPizza : IPizza
    {
        public string getBase()
        {
            return "Thick";
        }
        public string getToping()
        {
            return "Chicken";
        }
        public string getSauce()
        {
            return "Mayo";
        }
    }
}
