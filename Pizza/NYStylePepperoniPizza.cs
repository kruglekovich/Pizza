using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class NYStylePepperoniPizza : Pizza
    {
        ///<summary>
        ///Inirializes a new instance of  the <see cref="NYStyleCheesePizza "/> class.
        ///</summary>

        public NYStylePepperoniPizza()
        {
            name = "NYStyle Saunce and Cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara saunce";

            toppings.Add("Crated Reggiano Chesse");
        }
    }
}
