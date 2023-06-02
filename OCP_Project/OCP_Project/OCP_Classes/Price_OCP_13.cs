using System;

namespace SolidProject1_211229013.OCP_Classes
{
	public abstract class Price_OCP_13
	{
		public int Price { get; set; }
		public int CargoPrice { get; set; }
		public abstract int CalculatePrice(int counter);
		public abstract int AddCargoPrice(int Price, int counter);
	}
}

