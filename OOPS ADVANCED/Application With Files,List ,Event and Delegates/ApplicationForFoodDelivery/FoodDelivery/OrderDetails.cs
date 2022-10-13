using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery
{
    public class OrderDetails
    {
        /*Properties: OrderID, BookingID, FoodID, PurchaseCount, PriceOfOrder
        Method: ShowOrderDetails*/
        //field
        private static int s_orderID =100;
        //Property
        public string  OrderID { get; set; }
        public string BookingID { get; set; }
        public string FoodID { get; set; }
        public int PurchaseCount { get; set; }
        public double PriceOfOrder { get; set; }
        // Constructor
        public OrderDetails(string bookingID,string foodID, int purchaseCount,double priceOfOrder)
        {
            s_orderID++;
            OrderID = "OID"+s_orderID;
            BookingID= bookingID;
            FoodID=foodID;
            PurchaseCount = purchaseCount;
            PriceOfOrder = priceOfOrder;
        }
        //Constructor fo rfiles

        public OrderDetails(string note)
        {
            string[] values = note.Split(",");
            s_orderID = int.Parse(values[0].Remove(0,3));
            OrderID = values[0];
            BookingID = values[1];
            FoodID = values[2];
            PurchaseCount = int.Parse(values[3]);
            PriceOfOrder = double.Parse(values[4]);
                
        }




    }
}