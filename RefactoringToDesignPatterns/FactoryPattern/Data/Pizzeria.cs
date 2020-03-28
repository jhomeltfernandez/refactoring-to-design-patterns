using FactoryPattern.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Data
{
    public class Pizzeria
    {
        //public Pizzeria(Pizza cheesePizza, Pizza clamPizza, Pizza veggiePizza, double bakingTemp, double bakingTime, string cuttingStyle, string boxColor)
        //{
        //    CheesePizza = cheesePizza;
        //    ClamPizza = clamPizza;
        //    VeggiePizza = veggiePizza;

        //    BakingTemp = bakingTemp;
        //    BakingTime = bakingTime;
        //    CuttingStyle = cuttingStyle;
        //    boxColor = BoxColor;
        //}

        public double BakingTemp { get; set; }
        public double BakingTime { get; set; }
        public string CuttingStyle { get; set; }
        public string BoxColor { get; set; }

        public Pizza CheesePizza { get; set; }
        public Pizza ClamPizza { get; set; }
        public Pizza VeggiePizza { get; set; }
    }
}
