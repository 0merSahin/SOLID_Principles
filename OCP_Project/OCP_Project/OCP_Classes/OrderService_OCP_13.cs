using System;
namespace SolidProject1_211229013.OCP_Classes
{
	public class OrderService_OCP_13
	{
        public List<int> OrderList = new List<int>();
        public int OrderPrice { get; set; }
        Price_OCP_13 OrderPriceService;
        User_OCP_13 User;
        Products_OCP_13 Products;
		Cargo_OCP_13 Cargo;


		public OrderService_OCP_13(User_OCP_13 User)
		{
			this.User = User;
			Products = new Products_OCP_13();
		}


		public void CreateOrder(int CardPassword)
		{
			if (!User.CardService.CardPasswordCheck(CardPassword)) return;
			CreateOrderList();
			if (!Products.ProductControl(OrderList)) return;
			Cargo = new Cargo_OCP_13(User.CustomerNumber + User.CustomerPoint, User.AdressService.AdressID);
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
            OrderList.Add(105);
            OrderList.Add(105);
        }


        private void CalculateOrderPrice()
        {
            int counter = 0;
            foreach (var item in OrderList) counter++;
            if (counter * 20 <= 150)
            {
                if (counter <= 5)
                {
                    OrderPriceService = new PriceType1_OCP_13();
                    OrderPrice =  OrderPriceService.CalculatePrice(counter);
                }
                else
                {
                    OrderPriceService = new PriceType2_OCP_13();
                    OrderPrice = OrderPriceService.CalculatePrice(counter);
                }
                Console.WriteLine("Number of items in your cart: " + counter);
                Console.WriteLine("Order Price: " + OrderPrice + " TL (30 TL shipping fee added)");
            }
            else
            {
                OrderPriceService = new PriceType3_OCP_13();
                OrderPrice = OrderPriceService.CalculatePrice(counter);
                Console.WriteLine("Number of items in your cart: " + counter);
                Console.WriteLine("Order Price: " + OrderPrice + " TL (Free Shipping)");
            }
        }
    }
}

