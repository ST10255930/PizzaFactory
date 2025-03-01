using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    public class PlainPizza : IPizza
    {

        public string getBase()
        {
            return "Thin";
        }

        public string getToping()
        {
            return "Mozzarella";
        }

        public string getSauce() 
        {
            return "Tomato";
        }



    }
}
