using System;
using System.Collections.Generic;
using System.Text;

namespace pizza
{
    abstract class PizzaStore
    {
        public virtual Pizza orderPizza(string type)
        {
            Pizza pizza = createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            return pizza;
        }



        protected abstract Pizza createPizza(string type);

    }
}