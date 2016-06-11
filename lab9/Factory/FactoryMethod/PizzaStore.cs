using System.Collections.Generic;
using lab9.PizzaMenu;

namespace lab9.Factory.FactoryMethod
{
    internal abstract class PizzaStore
    {
        public Pizza OrderPizza(string name)
        {
            var pizza = CreatePizza(name);

            pizza.Make();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);

        public abstract IEnumerable<string> GetMenu();
    }
}