using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    abstract class PizzaStore
    {
        /// <summary>
        /// заказывает пиццу 
        /// </summary>
        /// <param name="type">называние требуемой пиццы </param>
        /// <returns>возвращает пиццу, которую приготовит конкретная фабрика</returns>
        public virtual Pizza orderPizza(string type)
        {
            Pizza pizza = createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        /// <summary>
        /// Create the pizza. 
        /// </summary>
        /// <param name="type">называние требуемой пиццы </param>
        /// <returns></returns>
        protected abstract Pizza createPizza(string type);
    }
}
