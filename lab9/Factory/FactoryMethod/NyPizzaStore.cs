using System;
using System.Collections.Generic;
using lab9.PizzaMenu;
using lab9.PizzaMenu.NYPizza;

namespace lab9.Factory.FactoryMethod
{
    internal class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new NYCheesePizza();
                case "veggy":
                    return new NYVeggyPizza();
                case "valodka":
                    return new NYValodkaPizza();
                default:
                    throw new ArgumentException("отсутствует такой вид пиццки", type);
            }
        }

        public override IEnumerable<string> GetMenu() =>
            new List<string> { "cheese", "veggy", "valodka" };
    }
}