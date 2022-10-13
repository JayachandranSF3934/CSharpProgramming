using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce
{
    public class ProductDetails
    {
        private static int s_productId = 100;

        public string ProductId { get; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public int  ShippingDuration { get; set; }

        // constructor

        public ProductDetails(string productName ,int stock,double price,  int shippingDuration)
        {
            s_productId++;
            ProductId ="PID"+s_productId;
            ProductName = productName;
            Stock = stock;
            Price = price;
            ShippingDuration = shippingDuration;
        }
        
    }
}