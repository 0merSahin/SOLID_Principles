using System;
namespace SolidProject1_211229013.OCP_Classes
{
	public class Cargo_OCP_13
	{
        public int CargoNo { get; set; }
        private AdressService_OCP_13 CargoAdress = new AdressService_OCP_13();
        public int CargoDistance { get; set; }
        public int CargoDeliveryTime { get; set; }


        public Cargo_OCP_13(int CargoNo, int CargoDeliveryAddressID)
        {
            this.CargoNo = CargoNo;
            CargoAdress.AdressID = CargoDeliveryAddressID;
            CalculateShippingDistance();
            CalculateDeliveryTime();
        }

        public Cargo_OCP_13()
        {
            this.CargoNo = 0;
        }


        public void SetCargoAdress(int CargoDeliveryAddressID)
        {
            CargoAdress.AdressID = CargoDeliveryAddressID;
        }


        public int CalculateShippingDistance()
        {
            CargoDistance = CargoAdress.AdressID * 10;
            Console.WriteLine("Cargo Distance: " + CargoDistance + " km");
            return CargoDistance;
        }


        private int CalculateDeliveryTime()
        {
            CargoDeliveryTime = CargoDistance / 100;
            Console.WriteLine("Estimated Time of Arrival: " + CargoDeliveryTime + " day");
            return CargoDeliveryTime;
        }
    }
}

