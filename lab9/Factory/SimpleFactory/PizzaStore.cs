using System.Collections.Generic;
using lab9.PizzaMenu;

namespace lab9.Factory.SimpleFactory
{
    class PizzaStore
    {
        readonly IPizzaSimpleFactory _factory;

        public PizzaStore(IPizzaSimpleFactory factory)
        {
            _factory = factory;
        }

        public Pizza OrderPizza(string name)
        {
            var pizza = _factory.CreatePizza(name);

            pizza.Make();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        public IEnumerable<string> GetMenu() => _factory.GetMenu();
    }
}