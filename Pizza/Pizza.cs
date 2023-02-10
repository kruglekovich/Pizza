using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new();

        /// <summary>
        /// готовит пиццу 
        /// </summary
        public virtual void prepare()
        {
            Console.WriteLine(" Preparing" + name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sause...");
            Console.WriteLine("Adding topings:");

            for (int i = 0; i < toppings.Count; i++)
            {
                Console.WriteLine("\t" + toppings[i]);
            }
        }

        ///<summary>
        ///запекает пиццу 
        ///</summary>
        
        public virtual void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350C ");
        }

        ///<summary>
        ///разрезает пиццу на треугольные кусочки
        ///</summary>

        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
            ///<summary>
            ///запекает пиццу 
            ///</summary>
            
        public virtual void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
        ///<summary>
        ///Gets the name .
        ///запекает пиццу 
        ///</summary>
        ///<returns>значение переменной name</returns>
        
        public virtual string getName()
        {
            return name;

        }
    }
}

