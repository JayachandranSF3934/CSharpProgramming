using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public enum OrderStatus{Default, Purchased, Cancelled}
    public class OrderDetails
    {
        //Felid
        private static int s_orderId = 2000;

        // Property
        public string OrderID { get; set; }
        public string UserID { get;}
        public string MedicineID { get; }
        public int MedicineCount { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }

        // Constructor
        public OrderDetails(string userId, string medicineId, int medicineCount, double totalprice, DateTime orderDate, OrderStatus orderStatus)
        {
            s_orderId++;
            OrderID ="OID"+s_orderId;
            UserID = userId;
            MedicineID = medicineId;
            MedicineCount = medicineCount;
            TotalPrice = totalprice;
            OrderDate = orderDate;
            OrderStatus = orderStatus;
        }

        // Constructor for Files
        public OrderDetails(string data)
        {
            string[] values = data.Split(",");
            s_orderId = int.Parse(values[0].Remove(0,3));
            OrderID = values[0];
            UserID = values[1];
            MedicineID = values[2];
            MedicineCount= int.Parse(values[3]);
            TotalPrice = double.Parse(values[4]);
            OrderDate = DateTime.ParseExact(values[5],"dd/MM/yyyy",null);
            OrderStatus = Enum.Parse<OrderStatus>(values[6]);
        }


    }
}