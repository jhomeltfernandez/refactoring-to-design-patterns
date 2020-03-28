using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Data
{
    public sealed class ClamPizza : Pizza
    {
        public ClamPizza(string dough, string cheese, string sauce, string clam)
        {
            this.Dough = dough;
            this.Cheese = cheese;
            this.Sauce = sauce;
            this.Clam = clam;
        }

        public string Cheese { get; set; }
        public string Clam { get; set; }

        public override string GetIngredients()
        {
            return $"Dough: {Dough}, Clam: {Clam}, Sauce: {Sauce}, Cheese: {Cheese}";
        }
    }
}
