using System;
using System.Collections.Generic;
using System.Text;

namespace pizza
{
    class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            name = "Chicago deep desh veggie Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
            toppings.Add("Black Olives");
            toppings.Add("Spinach");
            toppings.Add("Eggplant");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting pizza into square slices");
        }
    }
}
