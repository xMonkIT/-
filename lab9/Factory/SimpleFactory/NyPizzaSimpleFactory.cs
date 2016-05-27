using System;
using System.Collections.Generic;
using lab9.PizzaMenu;
using lab9.PizzaMenu.NYPizza;

namespace lab9.Factory.SimpleFactory
{
    class NYPizzaSimpleFactory : IPizzaSimpleFactory
    {
        public Pizza CreatePizza(string name)
        {
            switch (name)
            {
                case "cheese":
                    return new NYCheesePizza();
                case "veggy":
                    return new NYVeggyPizza();
                case "valodka":
                    return new NYValodkaPizza();
                default:
                    throw new ArgumentException("отсутствует такой вид пиццки", name);
            }
        }

        public IEnumerable<string> GetMenu() => new List<string> { "cheese", "veggy", "valodka" };
    }
}