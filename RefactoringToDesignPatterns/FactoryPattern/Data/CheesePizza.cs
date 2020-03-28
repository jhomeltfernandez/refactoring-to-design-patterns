using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Data
{
    public sealed class CheesePizza : Pizza
    {
        public CheesePizza(string dough, string cheese, string sauce, string veggies)
        {
            this.Dough = dough;
            this.Cheese = cheese;
            this.Sauce = sauce;
            this.Veggies = veggies;
        }

        public string Cheese { get; set; }
        public string Veggies { get; set; }

        public override string GetIngredients()
        {
            return $"Dough: {Dough}, Cheese: {Cheese}, Sauce: {Sauce}, Veggies: {Veggies}";
        }
    }
}
