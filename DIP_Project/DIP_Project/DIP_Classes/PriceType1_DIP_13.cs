using System;

namespace SolidProject1_211229013.DIP_Classes
{
	public class PriceType1_DIP_13 : IPrice_DIP_13, ICargo_DIP_13
    {
        public int Price { get; set; }
        public int CargoPrice { get; set; }

        public int CalculatePrice(int counter)
        {
            Price = counter * 30;
            Price = AddCargoPrice(Price, counter);
            Console.WriteLine("Each product is 30 TL");
            return Price;
        }

        public int AddCargoPrice(int Price, int counter)
        {
            return Price + (10 * counter);
        }
    }
}

