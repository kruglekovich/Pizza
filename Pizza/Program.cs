using System;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();

            Pizza pizza = nyStore.orderPizza("cheese");

            Console.WriteLine("Nikolay oredered a " + pizza.getName() + "\n");
        }
    }
}
