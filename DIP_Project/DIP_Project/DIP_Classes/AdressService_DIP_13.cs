using System;

namespace SolidProject1_211229013.DIP_Classes
{
	public class AdressService_DIP_13
	{
        public int AdressID { get; set; }

		public AdressService_DIP_13(int AdressID)
		{
			this.AdressID = AdressID;
		}

		public AdressService_DIP_13()
		{
			this.AdressID = 0;
		}
	}
}

