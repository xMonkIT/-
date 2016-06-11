using System;
using lab9.Factory.FactoryMethod;
using lab9.Factory.SimpleFactory;

namespace lab9
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            //TestSimpleFactory();
            TestFactoryMethod();
        }

        private static void TestFactoryMethod()
        {
            while (true)
            {
                Console.Write("Выберите магазин: New York (1), Chicago (2) [default (1)]: ");
                var input = Console.ReadLine();

                Factory.FactoryMethod.PizzaStore store;

                switch (input)
                {
                    case "":
                    case "1":
                        store = new NYPizzaStore();
                        break;
                    case "2":
                        store = new ChickagoPizzaStore();
                        break;
                    default:
                        continue;
                }

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

        private static void TestSimpleFactory()
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

                var store = new Factory.SimpleFactory.PizzaStore(factory);

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
