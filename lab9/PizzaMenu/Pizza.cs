using System;
using System.Collections.Generic;

namespace lab9.PizzaMenu
{
    abstract class Pizza
    {
        protected List<string> Ingredients = new List<string>();

        public virtual void Make()
        {
            Console.WriteLine("Готовим основу, размещаем ингридиенты:");
            foreach (var s in Ingredients)
            {
                Console.WriteLine(s);
            }
        }
        
        public virtual void Bake()
        {
            Console.WriteLine("Запекаем в духовке в течение 25 минут при 350 градусах...");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Разрезаем диагонально на 8 кусочков...");
        }

        public virtual void Box()
        {
            Console.WriteLine("Кладем пиццу в коробку, запечатываем контрольной пломбой.");
        }
    }
}
