using System;
using System.Collections.Generic;
namespace OnlineGrocery{
    //delegate
    public delegate  void EvenManager();
public static class Operation{
    public static event  EvenManager link = null;

   
    public static List<CustomerRegistration> customerList = new List<CustomerRegistration>();
    public static List<ProductDetails> productList = new List<ProductDetails>();
    public static List<BookingDetails> bookingList = new List<BookingDetails>();
    public static List<OrderDetails> orderList = new List<OrderDetails>();
    //Current Loggin In Customer
    static CustomerRegistration currentUser ;

    public static void Subscribe()
    {
        link += new EvenManager(Files.Create);
        link += new EvenManager(Files.ReadFiles);
        link += new EvenManager(Operation.MainMenu);
        link += new EvenManager(Files.WriteToFiles);
    }

    public static void EventStarter()
    {
        Subscribe();
        link();
    }
    public static void MainMenu()
    {
       //AddDefaultData();
       // Mainmenu
       

      
       string input = "yes";
       do
       {
        System.Console.WriteLine("<<<<<<<<--------------------------------------->>>>>>>>");
        System.Console.WriteLine("<<<<<<<<-----Welcome to Online Grocery Shop----->>>>>>>>");
        System.Console.WriteLine("<<<<<<<<--------------------------------------->>>>>>>>");
        
        System.Console.WriteLine("\n\tSelect Your Choices \n1.Customer Registration\n2.Customer Login\n3.Exit");
        int option = int.Parse(Console.ReadLine());

       switch(option)
       {
        case 1:
        {
            CustomerRegistration();
            break;
        }
         case 2:
        {
            CustomerLogin();
            break;
        }
         case 3:
        {
            System.Console.WriteLine("Exit From MainMenu\n");
            input ="no";
            break;
        }
       }
       }while(input =="yes");
  
    }

    public static void CustomerRegistration()
    {
        System.Console.WriteLine("<<<<<<<<--------------------------------------->>>>>>>>");
        System.Console.WriteLine("<<<<<<<<-----Welcome to Customer Registration----->>>>>>>>");
        System.Console.WriteLine("<<<<<<<<--------------------------------------->>>>>>>>");

        System.Console.WriteLine("Enter Your Name:");
        string name = Console.ReadLine();

        System.Console.WriteLine("Enter Your Father Name:");
        string fatherName = Console.ReadLine();

        System.Console.WriteLine("Enter Your Gender:  Male,Female,Others");
        Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);

        System.Console.WriteLine("Enter Your Mobile Number:");
        long mobileNumber =long.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter Your Date Of Birth:");
        DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        System.Console.WriteLine("Enter Your Email Id:");
        string eMail = Console.ReadLine();

        CustomerRegistration customer = new CustomerRegistration(name,fatherName,gender,mobileNumber,dob,eMail);
        customerList.Add(customer);
        System.Console.WriteLine("<<<<<<<<--------------------------------------->>>>>>>>");
        System.Console.WriteLine("Your registeration Was SuccessFul");
        System.Console.WriteLine("<<<<<<<<--------------------------------------->>>>>>>>");
        System.Console.WriteLine("<<<<<<<<--------------------------------------->>>>>>>>");
        System.Console.WriteLine($"Your CustomerId Is : {customer.CustomerID}");
        System.Console.WriteLine("<<<<<<<<--------------------------------------->>>>>>>>");

    }

    public static void CustomerLogin()
    {
        System.Console.WriteLine("Enter Your Customer ID To Login!!");
        string loginID = Console.ReadLine().ToUpper();
        bool flag = true;
        foreach (CustomerRegistration customer in customerList)
        {
            if(customer.CustomerID == loginID)
            {
                currentUser = customer;
                System.Console.WriteLine("<<<<<<<<--------------------------------------->>>>>>>>");
                System.Console.WriteLine("You Are SuccessFully Logged IN");
                System.Console.WriteLine("<<<<<<<<--------------------------------------->>>>>>>>");
                SubMenu();
                flag = false;
            }
        }
        if(flag == true)
        {
            System.Console.WriteLine("Invalid Customer ID\n ");
            CustomerLogin();
        }    
    }

    //SubMenu

    public static void SubMenu()
    {
        string input = "yes";
        do
        {
            System.Console.WriteLine("<<<<<<<<--------------------------------------->>>>>>>>");
            System.Console.WriteLine("<<<<<<<<----- Welcome to Grocery Shop App ----->>>>>>>>");
            System.Console.WriteLine("<<<<<<<<--------------------------------------->>>>>>>>");
            System.Console.WriteLine("Select Options Given Below\na.ShowCustomerDetails\nb.ShowProductDetails\nc.Wallet Recharge\nd.Take Order\ne.Modify Order\nf.Cancel Booking\ng.Exit SubMenu");
            char option = char.Parse(Console.ReadLine().ToLower());

            switch(option)
            {
                case 'a':
                {
                    System.Console.WriteLine("Now You're on ShowCustomerDetails ");
                    currentUser.ShowCustomerDetails();
                    break;
                }
                case 'b':
                {
                    System.Console.WriteLine("Now You're on ShowProductDetails");
                    ShowProductDetails();
                    break;
                }
                case 'c':
                {
                    System.Console.WriteLine("Now You're on Wallet Recharge ");
                    currentUser.WalletRecharge();
                    break;
                }
                case 'd':
                {
                    System.Console.WriteLine("Now You're on Take Order  ");
                    TakeOrder();
                    break;
                }
                case 'e':
                {
                    System.Console.WriteLine("Now You're on Modify Order");
                    ModifyOrder();
                    break;
                }
                case 'f':
                {
                    System.Console.WriteLine("Now You're on Cancel Booking");
                    CancelOrder();
                    break;
                }
                case 'g':
                {
                    System.Console.WriteLine("Now You're on Exit SubMenu");
                    input = "no";
                    break;
                }
            }

        }while(input =="yes");
    }


    //Add Default Data

 
    public static void AddDefaultData()
    {
        // CustomerRegistration object Data
            CustomerRegistration customreOne =new CustomerRegistration("ravi","Ettaparajan",Gender.Male,974774646,new DateTime(1999,07,11),"ravi@gmail.com");
            customerList.Add(customreOne);
            CustomerRegistration customreTwo =new CustomerRegistration("Baskaran","Sethu",Gender.Male,974474646,new DateTime(1999,07,11),"baskaran@gmail.com");
            customerList.Add(customreTwo);

        // ProductDetails Objects Data
            ProductDetails product1 = new ProductDetails("Sugar",20,40);
            
            ProductDetails product2 = new ProductDetails("Rice",100,50);
            
            ProductDetails product3 = new ProductDetails("Milk",10,40);
            
            ProductDetails product4 = new ProductDetails("Coffee",10,10);
          
            ProductDetails product5 = new ProductDetails("Tea",10,10);
            
            ProductDetails product6 = new ProductDetails("Masala Powder",10,20);
            
            ProductDetails product7 = new ProductDetails("Salt",10,10);
            
            ProductDetails product8 = new ProductDetails("Turmeric Powder",10,25);
            
            ProductDetails product9 = new ProductDetails("Chill Powder",10,20);
           
            ProductDetails product10 = new ProductDetails("Oil",10,140);  

               // Adding to list

            productList.Add(product1);
            productList.Add(product2);
            productList.Add(product3);
            productList.Add(product4);
            productList.Add(product5);
            productList.Add(product6);
            productList.Add(product7);
            productList.Add(product8);
            productList.Add(product9);
            productList.Add(product10);  


             // OrderDetails Object Data

            OrderDetails order1 = new OrderDetails("BID3001","PID101",2,80);

            OrderDetails order2 = new OrderDetails("BID3001","PID102",2,100);

            OrderDetails order3 = new OrderDetails("BID3001","PID103",1,40);

            OrderDetails order4 = new OrderDetails("BID3002","PID101",1,40);

            OrderDetails order5 = new OrderDetails("BID3002","PID102",4,200);

            OrderDetails order6 = new OrderDetails("BID3002","PID110",1,140);

            OrderDetails order7 = new OrderDetails("BID3002","PID109",1,20);
            
            OrderDetails order8 = new OrderDetails("BID3003","PID102",2,100);

            OrderDetails order9 = new OrderDetails("BID3003","PID108",4,100);

            OrderDetails order10 = new OrderDetails("BID3003","PID101",2,80);


            // Adding order object to list
            orderList.Add(order1);
            orderList.Add(order2);
            orderList.Add(order3);
            orderList.Add(order4);
            orderList.Add(order5);
            orderList.Add(order6);
            orderList.Add(order7);
            orderList.Add(order8);
            orderList.Add(order9);
            orderList.Add(order10);

            //Booking Object Data
            
            BookingDetails booking1 = new BookingDetails("CID3001",220,new DateTime(2022,07,26),BookingStatus.Booked);

            BookingDetails booking2 = new BookingDetails("CID3002",400,new DateTime(2022,07,26),BookingStatus.Booked);

            BookingDetails booking3 = new BookingDetails("CID3001",280,new DateTime(2022,07,26),BookingStatus.Cancelled);

            BookingDetails booking4 = new BookingDetails("CID3002",0,new DateTime(2022,07,26),BookingStatus.Initiated);

            //Adding object to list
            bookingList.Add(booking1);
            bookingList.Add(booking2);
            bookingList.Add(booking3);
            bookingList.Add(booking4);
    }
    
    //Subbmenu Methods

    
    public static void ShowProductDetails()
    {
        foreach (ProductDetails products in productList)
        {
            System.Console.WriteLine($"ProductID:{products.ProductID} ProductName:{products.ProductName}	QuantityAvailable:{products.Quantity}	PricePerQuantity:{products.PricePerQuantity}");
        }
    }
    public static void TakeOrder()
    {
        // Create a Booking Objects
        BookingDetails booking = new BookingDetails(currentUser.CustomerID,0,DateTime.Now,BookingStatus.Initiated);
        //temp  local orderlist for  
        List<OrderDetails> tempOrderList = new List<OrderDetails>();
        double totalPrice =0;
        string input ="yes";
        do
        {
            System.Console.WriteLine("Showing Product Details Lsit\n");  
            // Show Product Details
            ShowProductDetails();
            //Get a Product ID from User and Compare with Product ID if it is available then proceed next
            System.Console.WriteLine("\nEnter Product ID From the Above List");
            string prodID = Console.ReadLine().ToUpper();

            bool flag =true;
            foreach (ProductDetails product in productList)
            {
                if(product.ProductID == prodID)
                {
                    //get the Quantity from user and compare with available quantity 
                    System.Console.WriteLine("Enter The Quantity of Selected Product:");
                    int quantity = int.Parse(Console.ReadLine()); 
                    //Check whether the selected ProductID and Purchase quantity is available in stock.
                    if(product.Quantity >= quantity)
                    {
                        double total = product.PricePerQuantity*quantity;
                        totalPrice+=total;
                        OrderDetails order = new OrderDetails(booking.BookingID,product.ProductID,quantity,total);
                        // add order to temp order list
                        tempOrderList.Add(order);
                        product.Quantity -=quantity;
                        System.Console.WriteLine("Your Order is Moved To Cart ,\nPurchase More??? ");
                        flag = false;
                    }
                    else
                    {
                        System.Console.WriteLine("Invalid Quantity!!");
                    }
                }
            }
            if(flag == true)
            {
                System.Console.WriteLine("Invalid ProductID");
            }
            System.Console.WriteLine("Do You Want to Continue  Yes? or No?");
            input = Console.ReadLine().ToLower();
        }while(input =="yes");
        
       //ask user to order or cancel    //yes means order ,no means cancel
       System.Console.WriteLine("Do You Want Confrom Your Order Yes?? or No??");
       string proceeed  = Console.ReadLine().ToLower();
        bool temp = true;
       while(proceeed == "yes")
       {
                if(currentUser.WalletBalance >= totalPrice)
                {
                    currentUser.WalletBalance -=totalPrice;
                    booking.Status = BookingStatus.Booked;
                    booking.TotalPrice = totalPrice;
                    bookingList.Add(booking);
                    orderList.AddRange(tempOrderList);  //  AddRange is used to add number details in golbal order
                    temp =false;
                    break;
                    

                    
                }
                else
                {
                    System.Console.WriteLine($"Your Current Wallet Balance is{currentUser.WalletBalance}");
                    System.Console.WriteLine("Your Wallet Balance is Low Please Recharge!!");
                    currentUser.WalletRecharge();
                }
       }
       if(temp == false)
       {
            System.Console.WriteLine("Booking Successfull ");
            System.Console.WriteLine($"Your Booking ID is {booking.BookingID}");
       }
       if(proceeed == "no")
       {
        foreach (OrderDetails orders in tempOrderList)
        {
            foreach (ProductDetails product in productList)
            {
                if(product.ProductID==orders.ProductID)
                {
                    product.Quantity += orders.PurchaseCount;
                    System.Console.WriteLine("Your Cart is removed Successfully");
                }
            }
        }
       }

    }
    public static void ModifyOrder()
    {
        System.Console.WriteLine("Now You're in ModifyOrder");
    }
    public static void CancelOrder()
    {
        System.Console.WriteLine("Now You're in CancelOrder");
    }

}
}
