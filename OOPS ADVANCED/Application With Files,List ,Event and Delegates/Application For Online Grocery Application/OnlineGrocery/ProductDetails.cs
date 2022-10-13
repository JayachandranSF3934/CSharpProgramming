

namespace OnlineGrocery
{
    public class ProductDetails
    {
        private static int s_productID =100;
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double PricePerQuantity { get; set; }

        //Constructor
        public ProductDetails(string productName,int quantity,double pricePerQuantity)
        {
            s_productID++;
            ProductID = "PID"+s_productID;
            ProductName = productName;
            Quantity = quantity;
            PricePerQuantity = pricePerQuantity;
        }

        public ProductDetails(string item)
        {
            string[] values = item.Split(",");
            s_productID = int.Parse(values[0].Remove(0,3));
            ProductID = values[0];
            ProductName = values[1];
            Quantity = int.Parse(values[2]);
            PricePerQuantity = double.Parse(values[3]);

        }

        public void ShowProductDetails()
        {
          
        }
    }
}