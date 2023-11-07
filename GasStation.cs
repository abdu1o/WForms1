using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class GasStation
    {
        private double as95_value { get; set; } = 1.69;
        private double as94_value { get; set; } = 1.01;
        private double euro_value { get; set; } = 1.07;

        private double burger { get; set; } = 4;
        private double sandwich { get; set; } = 3;
        private double kebab { get; set; } = 99.99;

        public double CountGas(int numeric, double numericValue)
        {
            double price;

            switch (numeric)
            {
                case 1:
                    price = as95_value * numericValue;
                    break;
                case 2:
                    price = as94_value * numericValue;
                    break;
                case 3:
                    price = euro_value * numericValue;
                    break;
                default:
                    price = 0;
                    break;
            }

            return Math.Round(price, 2);
        }

        public double CountBurgerPrice(double numericValue)
        {
            return Math.Round(burger * numericValue, 2);
        }

        public double CountSandwichPrice(double numericValue)
        {
            return Math.Round(sandwich * numericValue, 2);
        }

        public double CountKebabPrice(double numericValue)
        {
            return Math.Round(kebab * numericValue, 2);
        }
    }
}
