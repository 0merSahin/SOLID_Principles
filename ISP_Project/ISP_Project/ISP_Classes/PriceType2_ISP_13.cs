using System;

namespace SolidProject1_211229013.ISP_Classes
{
	public class PriceType2_ISP_13 : IPrice_DIP_13, ICargo_ISP_13
    {
        public int Price { get; set; }
        public int CargoPrice { get; set; }

        public int CalculatePrice(int counter)
        {
            Price = counter * 20;
            Price = AddCargoPrice(Price, counter);
            Console.WriteLine("Each product is 20 TL");
            return Price;
        }

        public int AddCargoPrice(int Price, int counter)
        {
            return Price + (10 * counter);
        }
    }
}

