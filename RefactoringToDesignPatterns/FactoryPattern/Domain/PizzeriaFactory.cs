using FactoryPattern.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Domain
{
    public abstract class PizzeriaFactory
    {
        public string Orderque { get; private set; }

        public Pizzeria Pizzeria { get; set; }

        public abstract string Prepare();

        public string Bake()
        {
            return $"Baking at {Pizzeria.BakingTemp} degree Celsius for {Pizzeria.BakingTime} minute/s";
        }
        public string Cut()
        {
            return $"Cutting into {Pizzeria.CuttingStyle} pieces";
        }
        public string Box()
        {
            return $"Putting pizza in {Pizzeria.BoxColor} coloured box";
        }

        public void Order(string orderParam)
        {
            this.Orderque = orderParam;
        }
    }
}
