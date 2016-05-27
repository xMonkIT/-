using System;
using lab9.Factory.SimpleFactory;

namespace lab9
{
    static class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Выберите магазин: New York (1), Chicago (2) [default (1)]: ");
                var input = Console.ReadLine();

                IPizzaSimpleFactory factory;

                switch (input)
                {
                    case "":
                    case "1":
                        factory = new NYPizzaSimpleFactory();
                        break;
                    case "2":
                        factory = new ChickagoPizzaSimpleFactory();
                        break;
                    default:
                        continue;
                }

                var store = new PizzaStore(factory);

                Console.WriteLine($"Доступные виды пиццы:\n{string.Join("\n", store.GetMenu())}\n");

                Console.Write("Введите название пиццы: ");
                input = Console.ReadLine();

                try
                {
                    store.OrderPizza(input);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine();
            }
        }
    }
}
