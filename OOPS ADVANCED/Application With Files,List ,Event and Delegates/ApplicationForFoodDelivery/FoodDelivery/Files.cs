using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace FoodDelivery
{
    public static class Files
    {
        //create
        public static void Create()
        {
            //folder
            if(!Directory.Exists("FoodApp"))
            {
                System.Console.WriteLine("Creating FoodApp Folder");
                Directory.CreateDirectory("FoodApp");
            }
            //Files 
            if(!File.Exists("FoodApp/CustomerRegistration.csv"))
            {
                System.Console.WriteLine("Creating CustomerRegistration File");
                File.Create("FoodApp/CustomerRegistration.csv");
            }
            if(!File.Exists("FoodApp/FoodDetails.csv"))
            {
                System.Console.WriteLine("Creating FoodDetails File");
                File.Create("FoodApp/FoodDetails.csv");
            }
             if(!File.Exists("FoodApp/BookingDetails.csv"))
            {
                System.Console.WriteLine("Creating BookingDetails File");
                File.Create("FoodApp/BookingDetails.csv");
            }
            
             if(!File.Exists("FoodApp/OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating OrderDetails File");
                File.Create("FoodApp/OrderDetails.csv");
            }  
        }
        //read
        public static void Read()
        {
            //To Read CustomerRegistration
            string[] customersRegistration = File.ReadAllLines("FoodApp/CustomerRegistration.csv");

            foreach(var data in customersRegistration)
            {
                CustomerRegistration customerRegistration = new CustomerRegistration(data); // create onstructor for files in CustomerRegistration
                Procedure.customerList.Add(customerRegistration);
            }
            //TO Read FoodDetails
            string[] foodsDetail = File.ReadAllLines("FoodApp/FoodDetails.csv");

            foreach (var item in foodsDetail)
            {
                FoodDetails food = new FoodDetails(item);
                Procedure.foodList.Add(food);
            }
            // To Read BookingDetails
            string[] bookings = File.ReadAllLines("FoodApp/BookingDetails.csv");

            foreach (var book in bookings)
            {
                BookingDetails books = new BookingDetails(book);
                Procedure.bookingList.Add(books);
            }

            //To read OrderDetails
            string[] orders = File.ReadAllLines("FoodApp/OrderDetails.csv");

            foreach (var note in orders)
            {
                OrderDetails order = new OrderDetails(note);
                Procedure.orderList.Add(order);
            }
        }
        //write

        public static void Write()
        {
            // to write in Customer Registeration Files
            string[] customerDetails = new string[Procedure.customerList.Count];

            for(int i=0;i<Procedure.customerList.Count;i++)
            {
                /* CustomerID = values[0];
            WalletBalance = double.Parse(values[1]);
            Name = values[2];
            FatherName = values[3];
            Gender = Enum.Parse<Gender>(values[4]);
            Mobile = long.Parse(values[5]);
            DOB = DateTime.ParseExact(values[6],"dd/MM/yyyy",null);
            Email = values[7];
            Location = values[8]; */
                customerDetails[i] = Procedure.customerList[i].CustomerID+","+Procedure.customerList[i].WalletBalance+","+Procedure.customerList[i].Name+","+Procedure.customerList[i].FatherName+","+Procedure.customerList[i].Gender+","+Procedure.customerList[i].Mobile+","+Procedure.customerList[i].DOB.ToString("dd/MM/yyyy")+","+Procedure.customerList[i].Email+","+Procedure.customerList[i].Location;
            }
            File.WriteAllLines("FoodApp/CustomerRegistration.csv",customerDetails);

            //To Write Files inn FoodDetails
            string [] foodDetails = new string[Procedure.foodList.Count];

            for(int i=0;i<Procedure.foodList.Count;i++)
            {
                foodDetails[i] = Procedure.foodList[i].FoodID+","+Procedure.foodList[i].FoodName+","+Procedure.foodList[i].PricePerQuantity;
                /*  FoodID = values[0];
            FoodName = values[1];
            PricePerQuantity */
            }
            File.WriteAllLines("FoodApp/FoodDetails.csv",foodDetails);

            //To Write File in BookingDEtails

            string[] bookingDetails = new string[Procedure.bookingList.Count];

            for(int i=0;i<Procedure.bookingList.Count;i++)
            {
                /*  BookingID = values[0];
            CustomerID = values[1];
            TotalPrice = double.Parse(values[2]);
            DateOfBooking = DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            Status*/
                bookingDetails[i] = Procedure.bookingList[i].BookingID+","+Procedure.bookingList[i].CustomerID+","+Procedure.bookingList[i].TotalPrice+","+Procedure.bookingList[i].DateOfBooking.ToString("dd/MM/yyyy")+","+Procedure.bookingList[i].Status;
            }
            File.WriteAllLines("FoodApp/BookingDetails.csv",bookingDetails);

            //Write files for OrderDetails

            string[] orderDetails = new string[Procedure.orderList.Count];

            for(int i=0;i<Procedure.orderList.Count;i++)
            {
                /* s_orderID = int.Parse(values[0].Remove(0,3));
            OrderID = values[0];
            BookingID = values[1];
            FoodID = values[2];
            PurchaseCount = int.Parse(values[3]);
            PriceOfOrder = */
                orderDetails[i] = Procedure.orderList[i].OrderID+","+Procedure.orderList[i].BookingID+","+Procedure.orderList[i].FoodID+","+Procedure.orderList[i].PurchaseCount+","+Procedure.orderList[i].PriceOfOrder;
            }
            File.WriteAllLines("FoodApp/OrderDetails.csv",orderDetails);
        }
       
    }
}