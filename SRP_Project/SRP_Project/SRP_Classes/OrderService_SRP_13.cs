using System;

namespace SRP_Project.SRP_Classes
{
	public class OrderService_SRP_13
    {
        public List<int> OrderList = new List<int>();
		public int OrderPrice { get; set; }
        User_SRP_13 User;
		Products_SRP_13 Products;
        Cargo_SRP_13 Cargo;

		public OrderService_SRP_13(User_SRP_13 User)
		{
			this.User = User;
			Products = new Products_SRP_13();
		}


		public void CreateOrder(int CardPassword)
		{
			if (!User.CardService.CardPasswordCheck(CardPassword)) return;
			CreateOrderList();
			if (!Products.ProductControl(OrderList)) return;
			Cargo = new Cargo_SRP_13(User.CustomerNumber + User.CustomerPoint, User.AdressService.AdressID);
			User.PointCalculation();
            CalculateOrderPrice();
            Console.WriteLine("Your order is complete.\n\n\n");
        }


        private void CreateOrderList()
        {
            OrderList.Add(112);
            OrderList.Add(143);
            OrderList.Add(144);
            OrderList.Add(132);
            OrderList.Add(105);
            OrderList.Add(150);
            OrderList.Add(101);
            OrderList.Add(132);
            OrderList.Add(138);
        }


        private void CalculateOrderPrice()
        {
            int counter = 0;
            foreach (var item in OrderList) counter++;
            if (counter * 20 <= 150)
            {
                if (counter <= 5) OrderPrice = counter * 30 + 30;
                else OrderPrice = counter * 20 + 30;
                Console.WriteLine("Number of items in your cart: " + counter);
                Console.WriteLine("Order Price: " + OrderPrice + " TL (30 TL shipping fee added)");
            }
            else
            {
                OrderPrice = counter * 20;
                Console.WriteLine("Number of items in your cart: " + counter);
                Console.WriteLine("Order Price: " + OrderPrice + " TL (Free Shipping)");
            }
        }
    }
}

