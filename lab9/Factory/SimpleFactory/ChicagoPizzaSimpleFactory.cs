using System;
using System.Collections.Generic;
using lab9.PizzaMenu;
using lab9.PizzaMenu.ChicagoPizza;

namespace lab9.Factory.SimpleFactory
{
    class ChickagoPizzaSimpleFactory : IPizzaSimpleFactory
    {
        public Pizza CreatePizza(string name)
        {
            switch (name)
            {
                case "cheese":
                    return new ChicagoCheesePizza();
                case "veggy":
                    return new ChicagoVeggyPizza();
                default:
                    throw new ArgumentException("отсутствует такой вид пиццки", name);
            }
        }

        public IEnumerable<string> GetMenu() => new List<string> { "cheese", "veggy" };
    }
}