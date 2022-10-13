using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace ECommerce
{
    public static class Files
    {
        // Folder and File Creation
        public static void Create()
        {
            // Create folder for Ecommerce
            if(!Directory.Exists("Ecommerce"))
            {
                System.Console.WriteLine("Creating Folder For Ecommerce Application");
                Directory.CreateDirectory("Ecommerce");
            }
            //Create Files for Customer Details
            if(!File.Exists("Ecommerce/CustomerDetails.csv"))
            {
                System.Console.WriteLine("Creating Files For CustomerDetails");
                File.Create("Ecommerce/CustomerDetails.csv");
            }
            //Create Files for Product  Details
            if(!File.Exists("Ecommerce/ProductDetails.csv"))
            {
                System.Console.WriteLine("Creating Files For Product Details");
                File.Create("Ecommerce/ProductDetails.csv");
            }
            //Create Files for Order  Details
            if(!File.Exists("Ecommerce/OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating Files For OrderDetails ");
                File.Create("Ecommerce/OrderDetails.csv");
            }
        }

        //Read Files
        public static void Read()
        {
            //to read  Customer Details
            string[] customers = File.ReadAllLines("Ecommerce/CustomerDetails.csv");

            foreach (var data in customers)
            {
                CustomerDetails customer = new CustomerDetails(data);
                Procedure.customerList.Add(customer);   
            }
            //To read Product Details
            string[] products = File.ReadAllLines("Ecommerce/ProductDetails.csv");

            foreach (var item in products)
            {
                ProductDetails product = new ProductDetails(item);
                Procedure.productList.Add(product);
            }
            //To Read Order Details
            string[] orders = File.ReadAllLines("Ecommerce/OrderDetails.csv");

            foreach (var booking in orders)
            {
                OrderDetails order = new OrderDetails(booking);
                Procedure.orderList.Add(order);
            }
        }

        //To Write Files
        public static void Write()
        {
            //To Write Customer Details Files
            string[] customerDetails = new string[Procedure.customerList.Count];

            for(int i=0;i<Procedure.customerList.Count;i++)
            {
                customerDetails[i] = Procedure.customerList[i].CustomerId+","+Procedure.customerList[i].CustomerName+","+Procedure.customerList[i].City+","+Procedure.customerList[i].MobileNumber+","+Procedure.customerList[i].WalletBalance+","+Procedure.customerList[i].EmailID;
            }File.WriteAllLines("Ecommerce/CustomerDetails.csv",customerDetails);

            //To write Product Details
            string[] productDetails =  new string[Procedure.productList.Count];

            for(int i=0;i<Procedure.productList.Count;i++)
            {
                productDetails[i] = Procedure.productList[i].ProductId+","+Procedure.productList[i].ProductName+","+Procedure.productList[i].Stock+","+Procedure.productList[i].Price+","+Procedure.productList[i].ShippingDuration;
            }File.WriteAllLines("Ecommerce/ProductDetails.csv",productDetails);

            //To write Order Details
            string[] orderDetails = new string[Procedure.orderList.Count];

            for(int i=0;i<Procedure.orderList.Count;i++)
            {
                orderDetails[i] = Procedure.orderList[i].OrderId+","+Procedure.orderList[i].CustomerId+","+Procedure.orderList[i].ProductId+","+Procedure.orderList[i].TotalPrice+","+Procedure.orderList[i].PurchaseDate.ToString("dd/MM/yyyy")+","+Procedure.orderList[i].Quantity+","+Procedure.orderList[i].OrderStatus;
            }File.WriteAllLines("Ecommerce/OrderDetails.csv",orderDetails);
        }
    }
}