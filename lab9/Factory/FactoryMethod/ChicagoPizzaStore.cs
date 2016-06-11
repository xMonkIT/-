using System;
using System.Collections.Generic;
using lab9.PizzaMenu;
using lab9.PizzaMenu.ChicagoPizza;

namespace lab9.Factory.FactoryMethod
{
    internal class ChickagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new ChicagoCheesePizza();
                case "veggy":
                    return new ChicagoVeggyPizza();
                default:
                    throw new ArgumentException("отсутствует такой вид пиццки", type);
            }
        }

        public override IEnumerable<string> GetMenu() =>
            new List<string> { "cheese", "veggy" };
    }
}