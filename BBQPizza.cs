using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    public class BBQPizza : IPizza
    {
        public string getBase()
        {
            return "Thin";
        }
        public string getToping()
        {
            return "Mince";
        }
        public string getSauce()
        {
            return "BBQ";
        }
    }
}
