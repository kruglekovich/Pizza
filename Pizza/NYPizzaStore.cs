using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class NYPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string type)
        {
            if (type == "cheese")
            {
                return new NYStyleCheesePizza();
            }

            return null;
        }
    }
}
