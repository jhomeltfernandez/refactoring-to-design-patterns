using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Data
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza(string dough, string sauce, string veggies)
        {
            this.Dough = dough;
            this.Sauce = sauce;
            this.Veggies = veggies;
        }
        public string Veggies { get; set; }

        public override string GetIngredients()
        {
            return $"Dough: {Dough}, Sauce: {Sauce}, Veggies: {Veggies}";
        }
    }
}
