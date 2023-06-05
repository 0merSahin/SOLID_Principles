using System;
namespace SolidProject1_211229013.ISP_Classes
{
	public interface IPriceAndCargo_NonISP_13
	{
        public int CargoPrice { get; set; }
        public int Price { get; set; }
        public int AddCargoPrice(int Price, int counter);
        public abstract int CalculatePrice(int counter);
    }
}

