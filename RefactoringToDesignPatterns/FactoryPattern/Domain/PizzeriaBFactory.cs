using FactoryPattern.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Domain
{
    public class PizzeriaBFactory : PizzeriaFactory
    {
        public PizzeriaBFactory()
        {
            this.Pizzeria = new Pizzeria() {
                CheesePizza = new CheesePizza("Deep Dish", "Parmesan", "Plum Tomato", "Cucumber, Onions, Pepper"),
                ClamPizza = new ClamPizza("Deep Dish", "Parmesan", "Plum Tomato", "Fresh Clam"),
                VeggiePizza = new VeggiePizza("Deep Dish", "Plum Tomato", "Cucumber, Onions, Pepper"),

                BakingTemp = 135,
                BakingTime = 25,
                BoxColor = "Green",
                CuttingStyle = "Diagonal"
            };
        }

        public override string Prepare()
        {
            string response = string.Empty;
            switch (Orderque)
            {
                case OrderParamConst.Cheese:
                    response = Pizzeria.CheesePizza.GetIngredients();
                    break;
                case OrderParamConst.Clam:
                    response = Pizzeria.ClamPizza.GetIngredients();
                    break;
                case OrderParamConst.Veggie:
                    response = Pizzeria.VeggiePizza.GetIngredients();
                    break;
                default:
                    break;
            }
            return response;
        }
    }
}
