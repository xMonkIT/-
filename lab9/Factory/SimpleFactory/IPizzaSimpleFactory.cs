using System.Collections.Generic;
using lab9.PizzaMenu;

namespace lab9.Factory.SimpleFactory
{
    interface IPizzaSimpleFactory
    {
        Pizza CreatePizza(string name);
        IEnumerable<string> GetMenu();
    }
}