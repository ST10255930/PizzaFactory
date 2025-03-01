using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    public class PizzaFactory
    {

        public IPizza returnInstance;

        public IPizza GetPizza(String PizzaType)
        {

            if (PizzaType.ToLower().Equals("pepperoni"))

                returnInstance = new PepperoniPizza();


            else if (PizzaType.ToLower().Equals("chicken"))
            {
                returnInstance = new ChickenPizza();



            } else
            {
                returnInstance = new BBQPizza();
            }
            
            return returnInstance;
        }
    }
}



