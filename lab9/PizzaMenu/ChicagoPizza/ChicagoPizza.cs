using System;

namespace lab9.PizzaMenu.ChicagoPizza
{
    internal abstract class ChicagoPizza : Pizza
    {
        public override void Make()
        {
            Console.WriteLine("Используем толстое тесто");
            base.Make();
        }

        public override void Bake()
        {
            Console.WriteLine("Запекаем в духовке в течение 30 минут при 350 градусах...");
        }

        public override void Cut()
        {
            Console.WriteLine("Режем квдратными кусочками...");
        }
    }
}