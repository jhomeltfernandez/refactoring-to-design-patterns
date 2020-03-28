using FactoryPattern.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Domain
{
    public class PizzeriaAFactory : PizzeriaFactory
    {
        public PizzeriaAFactory()
        {
            this.Pizzeria = new Pizzeria() {
                CheesePizza = new CheesePizza("Thin Crust", "Mozzarella", "Cherry Tomato", "Olives, Onions, Pepper"),
                ClamPizza = new ClamPizza("Thin Crust", "Mozzarella", "Cherry Tomato", "Frozen Clam"),
                VeggiePizza = new VeggiePizza("Thin Crust", "Cherry Tomato", "Olives, Onions, Pepper"),

                BakingTemp = 135,
                BakingTime = 25,
                BoxColor = "Red",
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
