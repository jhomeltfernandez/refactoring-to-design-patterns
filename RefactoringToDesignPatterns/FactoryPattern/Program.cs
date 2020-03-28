using FactoryPattern.Data;
using FactoryPattern.Domain;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PIZZERIA A");
            PizzeriaFactory pizzeriaA = new PizzeriaAFactory();

            Console.WriteLine($"ORDER: {OrderParamConst.Cheese}");
            pizzeriaA.Order(OrderParamConst.Cheese);
            Console.WriteLine(pizzeriaA.Prepare());
            Console.WriteLine(pizzeriaA.Bake());
            Console.WriteLine(pizzeriaA.Cut());
            Console.WriteLine(pizzeriaA.Box());

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine($"ORDER: {OrderParamConst.Clam}");
            pizzeriaA.Order(OrderParamConst.Clam);
            Console.WriteLine(pizzeriaA.Prepare());
            Console.WriteLine(pizzeriaA.Bake());
            Console.WriteLine(pizzeriaA.Cut());
            Console.WriteLine(pizzeriaA.Box());

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine($"ORDER: {OrderParamConst.Veggie}");
            pizzeriaA.Order(OrderParamConst.Veggie);
            Console.WriteLine(pizzeriaA.Prepare());
            Console.WriteLine(pizzeriaA.Bake());
            Console.WriteLine(pizzeriaA.Cut());
            Console.WriteLine(pizzeriaA.Box());


            Console.WriteLine("===========================================================================");


            Console.WriteLine("PIZZERIA B");
            PizzeriaFactory pizzeriaB = new PizzeriaBFactory();

            Console.WriteLine($"ORDER: {OrderParamConst.Cheese}");
            pizzeriaB.Order(OrderParamConst.Cheese);
            Console.WriteLine(pizzeriaB.Prepare());
            Console.WriteLine(pizzeriaB.Bake());
            Console.WriteLine(pizzeriaB.Cut());
            Console.WriteLine(pizzeriaB.Box());

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine($"ORDER: {OrderParamConst.Clam}");
            pizzeriaB.Order(OrderParamConst.Clam);
            Console.WriteLine(pizzeriaB.Prepare());
            Console.WriteLine(pizzeriaB.Bake());
            Console.WriteLine(pizzeriaB.Cut());
            Console.WriteLine(pizzeriaB.Box());

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine($"ORDER: {OrderParamConst.Veggie}");
            pizzeriaB.Order(OrderParamConst.Veggie);
            Console.WriteLine(pizzeriaB.Prepare());
            Console.WriteLine(pizzeriaB.Bake());
            Console.WriteLine(pizzeriaB.Cut());
            Console.WriteLine(pizzeriaB.Box());

            Console.ReadLine();
        }
    }
}
