using System;
using System.Runtime.Intrinsics.X86;

namespace SRP_Project.SRP_Classes
{
	public class User_SRP_13
	{
        public string Name { get; set; }
        public int CustomerNumber { get; set; }
        public int CustomerPoint { get; set; }
        public CardService_SRP_13 CardService = new CardService_SRP_13();
        public AdressService_SRP_13 AdressService = new AdressService_SRP_13();
        public OrderService_SRP_13 OrderService;
        public User_SRP_13 User;


        public User_SRP_13(string Name, int CustomerNumber, int CustomerPoint, int CardNo, int CardPassword, int AdressID)
		{
			this.Name = Name;
			this.CustomerNumber = CustomerNumber;
			this.CustomerPoint = CustomerPoint;
			CardService.CardNo = CardNo;
			CardService.CardPassword = CardPassword;
			AdressService.AdressID = AdressID;
        }


        public void SetUserAndStartOrderService(User_SRP_13 User)
        {
            this.User = User;
            OrderService = new OrderService_SRP_13(User);
        }


        public void PointCalculation()
        {
            int counter = 0;
            foreach (var item in OrderService.OrderList) counter++;
            Console.WriteLine("Your customer rating has increased: " + (this.CustomerPoint += counter * 10));
        }
    }
}

