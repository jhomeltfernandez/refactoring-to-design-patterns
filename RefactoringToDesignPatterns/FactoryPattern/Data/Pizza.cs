using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Data
{
    public abstract class Pizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }

        public abstract string GetIngredients();
    }
}
