﻿using System;
namespace SolidProject1_211229013.ISP_Classes
{
	public class Products_ISP_13
    {
        public List<int> ProductsIDList = new List<int>();
		
		public Products_ISP_13()
		{
			if (!FileService_ISP_13.FileControl("ProductsIDList.txt")) return;
			ProductsIDList = FileService_ISP_13.ReadingFile("ProductsIDList.txt");

		}

        public bool ProductControl(List<int> OrderList)
        {
            foreach (var item1 in OrderList)
            {
                bool control = false;
                foreach (var item2 in ProductsIDList)
                {
                    if (item1 == item2)
                    {
                        control = true;
                        break;
                    }
                }
                if (control == false)
                {
                    Console.WriteLine("The product in your product list was not found! \nTransaction Canceled!");
                    return false;
                }
            }
            return true;
        }
    }
}

