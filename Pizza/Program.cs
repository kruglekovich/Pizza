using System;

namespace pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicStore = new ChicagoPizzaStore();
            Pizza pizza;

            pizza = nyStore.orderPizza("cheese");
            Console.WriteLine("Semen ordered pizza " + pizza.getName() + "\n");

            pizza = nyStore.orderPizza("veggie");
            Console.WriteLine("Semen ordered pizza " + pizza.getName() + "\n");

            pizza = chicStore.orderPizza("cheese");
            Console.WriteLine("Semen ordered pizza " + pizza.getName() + "\n");

            pizza = chicStore.orderPizza("veggie");
            Console.WriteLine("Semen ordered pizza " + pizza.getName() + "\n");

        }
    }
}
