using System;
namespace SolidProject1_211229013.DIP_Classes
{
	public interface ICargo_DIP_13
	{
		public int CargoPrice { get; set; }
		public int AddCargoPrice(int Price, int counter);
	}
}

