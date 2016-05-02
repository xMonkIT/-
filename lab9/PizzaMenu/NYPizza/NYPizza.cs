using System;

namespace lab9.PizzaMenu.NYPizza
{
    internal abstract class NYPizza : Pizza
    {
        public override void Bake()
        {
            Console.WriteLine("Запекаем в духовке в течение 20 минут при 350 градусах...");
        }

        public override void Make()
        {
            Console.WriteLine("Используем тонкое тесто");
            base.Make();
        }
    }
}