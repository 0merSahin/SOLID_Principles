using System;
namespace SolidProject1_211229013.LSP_Classes
{
	public class OrderService_LSP_13
	{
        public List<int> OrderList = new List<int>();
        public int OrderPrice { get; set; }
        IPrice_LSP_13 OrderPriceService;
        User_LSP_13 User;
        Products_LSP_13 Products;
		CargoService_LSP_13 Cargo;

		public OrderService_LSP_13(User_LSP_13 User)
		{
			this.User = User;
			Products = new Products_LSP_13();
		}


		public void CreateOrder(int CardPassword)
		{
			if (!User.CardService.CardPasswordCheck(CardPassword)) return;
			CreateOrderList();
			if (!Products.ProductControl(OrderList)) return;
			Cargo = new CargoService_LSP_13(User.CustomerNumber + User.CustomerPoint, User.AdressService.AdressID);
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
        }


        private void CalculateOrderPrice()
        {
            int counter = 0;
            foreach (var item in OrderList) counter++;
            if (counter * 20 <= 150)
            {
                if (counter <= 5)
                {
                    OrderPriceService = new PriceType1_LSP_13();
                    OrderPrice = OrderPriceService.CalculatePrice(counter);
                }
                else
                {
                    OrderPriceService = new PriceType2_LSP_13();
                    OrderPrice = OrderPriceService.CalculatePrice(counter);
                }
                Console.WriteLine("Number of items in your cart: " + counter);
                Console.WriteLine("Order Price: " + OrderPrice + " TL (" + counter * 10 + " TL shipping fee added)");
            }
            else
            {
                OrderPriceService = new PriceType3_LSP_13();
                OrderPrice = OrderPriceService.CalculatePrice(counter);
                Console.WriteLine("Number of items in your cart: " + counter);
                Console.WriteLine("Order Price: " + OrderPrice + " TL (Free Shipping)");
            }
        }
    }
}

