using System.IO;

namespace OnlineGrocery
{
    public  static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("OnlineGrocery"))
            {
                System.Console.WriteLine("Creating Online Grocery Folder");
                Directory.CreateDirectory("OnlineGrocery");
            }

            //creating files for lLIST
            if(!File.Exists("OnlineGrocery/CustomerRegistration.csv"))
            {
                System.Console.WriteLine("Creating CustomerRegistration File ");
                File.Create("OnlineGrocery/CustomerRegistration.csv");
            }

            if(!File.Exists("OnlineGrocery/ProductDetails.csv"))
            {
                System.Console.WriteLine("Creating ProductDetails File ");
                File.Create("OnlineGrocery/ProductDetails.csv");
            }

            if(!File.Exists("OnlineGrocery/BookingDetails.csv"))
            {
                System.Console.WriteLine("Creating BookingDetails File ");
                File.Create("OnlineGrocery/BookingDetails.csv");
            }

            if(!File.Exists("OnlineGrocery/OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating OrderDetails File ");
                File.Create("OnlineGrocery/OrderDetails.csv");
            }

        }

        // To read files

        public static void ReadFiles()
        {
            string[] customers = File.ReadAllLines("OnlineGrocery/CustomerRegistration.csv");

            foreach (var data in customers)
            {
                CustomerRegistration customer = new CustomerRegistration(data);
                Operation.customerList.Add(customer);
            }

            string[] products = File.ReadAllLines("OnlineGrocery/ProductDetails.csv");
            foreach (var item in products)
            {
                ProductDetails product = new ProductDetails(item);
                Operation.productList.Add(product);
            }

            string[] books = File.ReadAllLines("OnlineGrocery/BookingDetails.csv");
            foreach (var item in books)
            {
                BookingDetails book =  new BookingDetails(item);
                Operation.bookingList.Add(book);
            }

            string[] orders = File.ReadAllLines("OnlineGrocery/OrderDetails.csv");
            foreach (var item in orders)
            {
                OrderDetails order = new OrderDetails(item);
                Operation.orderList.Add(order);
            }  
        }

        //To write Files

        public static void WriteToFiles()
        {
            //customer
            string [] customerRegistration = new string[Operation.customerList.Count];

            for(int i=0;i<Operation.customerList.Count;i++)
            {
                customerRegistration[i]  = Operation.customerList[i].CustomerID+","+Operation.customerList[i].WalletBalance+","+Operation.customerList[i].Name+","+Operation.customerList[i].FatherName+","+Operation.customerList[i].Gender+","+Operation.customerList[i].MobileNumber+","+Operation.customerList[i].DOB.ToString("dd/MM/yyyy") +","+Operation.customerList[i].Email;
            }
            File.WriteAllLines("OnlineGrocery/CustomerRegistration.csv",customerRegistration);
            
            //Product
            string[] productDetails = new string[Operation.productList.Count];
            for(int i=0;i<Operation.productList.Count;i++)
            {
                productDetails[i] = Operation.productList[i].ProductID+","+Operation.productList[i].ProductName+","+Operation.productList[i].Quantity+","+Operation.productList[i].PricePerQuantity;
            }File.WriteAllLines("OnlineGrocery/ProductDetails.csv",productDetails);

            //Booking 
            string[] bookingDetails = new string[Operation.bookingList.Count];
            for(int i=0;i<Operation.bookingList.Count;i++)
            {
                bookingDetails[i] =Operation.bookingList[i].BookingID+","+Operation.bookingList[i].CustomerID+","+Operation.bookingList[i].TotalPrice+","+Operation.bookingList[i].DateOfBooking.ToString("dd/MM/yyyy")+","+Operation.bookingList[i].Status;
            }File.WriteAllLines("OnlineGrocery/BookingDetails.csv",bookingDetails);
            
            //Order
            string[] orderDetails = new string[Operation.orderList.Count];
            for(int i=0;i<Operation.orderList.Count;i++)
            {
               
                orderDetails[i] = Operation.orderList[i].OrderID+","+Operation.orderList[i].BookingID+","+Operation.orderList[i].ProductID+","+Operation.orderList[i].PurchaseCount+","+Operation.orderList[i].PriceOfOrder;
            }File.WriteAllLines("OnlineGrocery/OrderDetails.csv",orderDetails);
            
        }
        
    }
}