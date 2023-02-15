using System;
using System.Collections.Generic;
using System.Text;

namespace pizza
{
    class NYPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string type)
        {
            if (type == "cheese")
            {
                return new NYStyleCheesePizza();
            }
            else if (type == "veggie")
            {
                return new NYStyleVeggiePizza();
            }
            return null;
        }

    }
}
