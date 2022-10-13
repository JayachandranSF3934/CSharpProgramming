using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce
{
    public static class Procedure
    {
        // Creating Empty Object for order =, Customer and Product
        static OrderDetails currentOrder = null;
        static CustomerDetails currentCustomer =null;
       
        // To Store Order, Customer, Product Details in List

        static List<OrderDetails> orderList = new List<OrderDetails>();
        static List<CustomerDetails> customerList = new List<CustomerDetails>();
        static List<ProductDetails> productList = new List<ProductDetails>();


        // MAINMENU
        public static void MainMenu()
        {
            Default();
            System.Console.WriteLine("--------------------------------------------------");
            System.Console.WriteLine("\nAMAZEKART\n");
            System.Console.WriteLine("---------------------------------------------------");
            System.Console.WriteLine("Welcome To AMAZEKART #nSelect anyone of the Given below option to proceed Furthur");
            System.Console.WriteLine("__________________********_________________________");

            string choice ="yes";
            do
            {            
            System.Console.WriteLine("\n\tSelect Options\n1.Customer Registeration\n2.Login and Purchase\n3.Exit");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Customer Registeration\n");
                    CustomerRegisteration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Login and Purchase\n");
                    LoginAndPurchase();
                    break;
                    
                }
                
                case 3:
                {
                    System.Console.WriteLine("Exit\n");
                    choice = "no";
                    break;
                }
            }
            }while(choice == "yes");  
        }

        // Method for CustomerRegistration
        public static void  CustomerRegisteration()
        {
            System.Console.Write("Enter Your Details To Complete registration\n\n");

            System.Console.Write("Enter Your Name:");
            string name = Console.ReadLine();
            
            System.Console.Write("Enter Your City:");
            string city = Console.ReadLine();
            
            System.Console.Write("Enter Your Mobile Number");
            long mobileNumber = Convert.ToInt64(Console.ReadLine());

            System.Console.Write("Enter Your Wallet Balance:");
            double walletBalance = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Enter Your Email Id:");
            string emailId = Console.ReadLine();
            // Add customer Details to Customer List

            CustomerDetails customer = new CustomerDetails(name,city,mobileNumber,walletBalance,emailId);
            customerList.Add(customer);

            

            System.Console.WriteLine("\nYou Details Are Collected: \n \n Have A Nice day!!! \n\n  ");
            System.Console.WriteLine("Your Customer ID is "+ customer.CustomerId); 

        }

        // LoginAndPurchase
        public static void LoginAndPurchase()
       {
        System.Console.WriteLine("Enter Your customer ID");
            string cusId = Console.ReadLine().ToUpper();
            foreach(CustomerDetails item  in customerList)
            {
                if(item.CustomerId == cusId)
                {
                    System.Console.WriteLine("Login Successfully!!!");
                    currentCustomer =item;
                    SubMenu();
                }
                else{
                    System.Console.WriteLine("Invalid ID Enter Again");
                }
            }
       }

        public static void SubMenu()
        {
            System.Console.WriteLine("Welcome to Purchasing");

            string input = "yes";
            do
            {
                System.Console.WriteLine("Select Option \na.Purchase\nb.Order History\nc.Cancel Order\nd.Wallet Balance\ne.Exit Submenu");
                char word = char.Parse(Console.ReadLine().ToLower());
                switch(word)
                {
                    case 'a':
                    {
                        System.Console.WriteLine("Purchase");
                        Purchase();
                        break;
                    }
                    case 'b':
                    {
                        System.Console.WriteLine("Order History");
                        OrderHistory();
                        break;
                    }
                    case 'c':
                    {
                        System.Console.WriteLine("Cancel Order");
                        CancelOrder();
                        break;
                    }
                    case 'd':
                    {
                        System.Console.WriteLine("Wallet Balance");
                        WalletBalance();
                        break;
                    }
                    case 'e':
                    {
                        System.Console.WriteLine("Exit SubMenu");
                        input = "no";
                        break;
                    }
                }
            }while(input == "yes");
        }

        // Purchase Method
        public static void Purchase()
        {
            foreach(ProductDetails product in productList)
            {
                System.Console.WriteLine($"Product Id:{product.ProductId} Product Name:{product.ProductName}  Price:{product.Price} Stock:{product.Stock}  Shipping Duration:{product.ShippingDuration}");
            }

            System.Console.WriteLine("Enter the Product Id To Purchase");
            string prodId = Console.ReadLine();
            System.Console.WriteLine("Enter the Quantity of the Product");
            int count = int.Parse(Console.ReadLine());
            foreach (ProductDetails item in productList)
            {
                if(prodId == item.ProductId)
                {
                    if(item.Stock >=count)
                    {
                        double delivery =50;
                        double totalPrice = (count*item.Price) + delivery;

                        if(currentCustomer.WalletBalance >= totalPrice)
                        {
                            currentCustomer.WalletBalance -=totalPrice;
                            item.Stock -=count;

                           
                            OrderDetails nextOrder =  new OrderDetails(currentCustomer.CustomerId,item.ProductId,totalPrice,DateTime.Now, currentOrder.Quantity,OrderStatus.Ordered);
                            orderList.Add(nextOrder);
                             System.Console.WriteLine($"Order Placed successfully. \n Your Order Will be Delivered on {DateTime.Today}");   // think properly
                        }
                        else{
                            System.Console.WriteLine("Insufficient Wallet Balance . Please Recharge Your Wallet");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Required Amount of Product is not Available");
                        System.Console.WriteLine("Current Availablity is"+item.Stock);
                    }
                }
            }
        }
        public static void OrderHistory()
        {
            foreach (OrderDetails order in orderList)
            {
                if(order.CustomerId == currentCustomer.CustomerId)
                {
                    System.Console.WriteLine($"Your Order ID:{order.OrderId} Your Customer ID:{order.CustomerId} Your Product ID:{order.ProductId}  Your Order Purchase date:{order.PurchaseDate} Quantity:{order.Quantity} Order Staus:{order.OrderStatus}");
                }
            }
        }
        // cancel order
        public static void CancelOrder()
        {
            foreach (OrderDetails cancel in orderList)
            {
                if(currentCustomer.CustomerId == cancel.CustomerId)
                {
                    System.Console.WriteLine($"Your Order ID:{cancel.OrderId} Your Customer ID:{cancel.CustomerId} Your Product ID:{cancel.ProductId}  Your Order Purchase date:{cancel.PurchaseDate} Quantity:{cancel.Quantity} Order Staus:{cancel.OrderStatus}");                }
            }

            System.Console.WriteLine("Enter Your Order Id to  Cancel the Order:");
            string orderId = Console.ReadLine();
            
            foreach(OrderDetails cancelOrder in orderList)
            {
                if(orderId == cancelOrder.OrderId)
                {
                    foreach (ProductDetails item in productList)
                    {
                        if(cancelOrder.ProductId == item.ProductId)
                        {
                            item.Stock +=cancelOrder.Quantity;

                            double deliveryCharge = 50;
                            double returnAmount = (cancelOrder.Quantity *item.Price) - deliveryCharge;
                            currentCustomer.WalletBalance +=returnAmount;

                            System.Console.WriteLine("Your Order Cancelled Successfully");
                            cancelOrder.OrderStatus = OrderStatus.Canceled;
                        }
                    }
                }
            }
        }

        // WalletBalance
        public static void WalletBalance()
        {
            foreach (CustomerDetails customers in customerList)
            {
                if(currentCustomer.CustomerId == customers.CustomerId)
                {
                    System.Console.WriteLine($"Your Wallet Balnce is {customers.WalletBalance}");
                    System.Console.WriteLine("Do you want to recharge the Wallet? Enter Yes? or No?");
                    string yesOrNo = Console.ReadLine().ToLower();
                    if(yesOrNo =="yes")
                    {
                        System.Console.WriteLine("Enter The Amount to recharge: ");
                        double amount =  double.Parse(Console.ReadLine());
                        currentCustomer.WalletBalance += amount;
                        System.Console.WriteLine($"Your wallet Balance is {currentCustomer.WalletBalance}");
                    }
                    
                }
            }
        }

        //Default

        public static void Default()
        {
            // Add  Dafault Customer Details to customerList
           // CustomerDetails customerOne =new CustomerDetails("Ravi","Chennai",9898747489,50000,"ravi@gmail.com");
           // customerList.Add(customerOne);

           // CustomerDetails customerTwo =new CustomerDetails("Baskaran","Chennai",9898747989,60000,"baskaran@gmail.com");
           // customerList.Add(customerOne);

            // Add Default order Details to orderlist
            OrderDetails orderOne = new OrderDetails("CID1001","PID101",20000,DateTime.Now,2,OrderStatus.Ordered);
            orderList.Add(orderOne);
            OrderDetails orderTwo = new OrderDetails("CID1002","PID102",40000,DateTime.Now,2,OrderStatus.Ordered);
            orderList.Add(orderTwo);

            // Add Default product Details to ProductList
            ProductDetails productOne = new ProductDetails("Mobile",10,10000,3);
            productList.Add(productOne);
            ProductDetails productTwo = new ProductDetails("Tablet",5,15000,2);
            productList.Add(productTwo);
            ProductDetails productThree = new ProductDetails("Camera",3,20000,4);
            productList.Add(productThree);
            ProductDetails productFour = new ProductDetails("iPhone",5,50000,6);
            productList.Add(productFour);
            ProductDetails productFive = new ProductDetails("Laptop",3,40000,3);
            productList.Add(productFive);
            
        }


    }
}