using System;
namespace SolidProject1_211229013.DIP_Classes
{
	public interface IPrice_DIP_13
	{
		public int Price { get; set; }
		public abstract int CalculatePrice(int counter);
	}
}

