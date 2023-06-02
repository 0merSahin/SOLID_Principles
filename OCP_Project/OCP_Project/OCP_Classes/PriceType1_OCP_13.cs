using System;
namespace SolidProject1_211229013.OCP_Classes
{
	public class PriceType1_OCP_13 : Price_OCP_13
    {
        public int Price { get; set; }
		public int CargoPrice { get; set; }

        public override int CalculatePrice(int counter)
        {
            Price = counter * 30;
            Price = AddCargoPrice(Price, counter);
            return Price;
        }

        public override int AddCargoPrice(int Price, int counter)
        {
            CargoPrice = 30;
            return Price + CargoPrice;
        }
    }
}

