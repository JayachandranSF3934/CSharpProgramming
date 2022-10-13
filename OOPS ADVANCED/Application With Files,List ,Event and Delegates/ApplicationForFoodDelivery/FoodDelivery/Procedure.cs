using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery
{
    //Delegates
    public delegate void EventManager();
    public static class Procedure
    {
        // Event Field  Event is A filed
        public static event EventManager eventlink = null;  // user Defined Event

        // Object
        static CustomerRegistration currentCustomer = null;
        // list 
        public static List<CustomerRegistration>  customerList = new List<CustomerRegistration>();
        public static List<FoodDetails>  foodList = new List<FoodDetails>();
        public static List<BookingDetails>  bookingList = new List<BookingDetails>();
        public static List<OrderDetails>  orderList = new List<OrderDetails>();


         // Method Subscribe  for Event

       public static void Subscribe()
       {
         
        eventlink += new EventManager(Files.Create);
        eventlink += new EventManager(Files.Read);
        eventlink += new EventManager(Procedure.MainMenu);
        eventlink += new EventManager(Files.Write);
        //eventlink += new EventManager(Files.Update);
        
       }

        public static void StartEvent()   // to start event
       {
        Subscribe();
        eventlink();
       }
        
        // Mainmenu
        public static void MainMenu()
        {
           
            System.Console.WriteLine("--------------------------------------------------");
            System.Console.WriteLine("\nFood Delivery Application\n");
            System.Console.WriteLine("---------------------------------------------------");
            System.Console.WriteLine("--------------------------------------------------");
            System.Console.WriteLine("\nSelect anyone option to proceed Furthur");
            System.Console.WriteLine("--------------------------------------------------");

            string choice ="yes";
            do
            {            
            System.Console.WriteLine("\n\tSelect Options\n1.Customer registration\n2.Customer Login \n3.Exit");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Welcome To Registration Process  \n");
                    CustomerRegistration();    
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Welcome To Customer Login Page  \n");
                    CustomerLogin();   
                    break;
                    
                }
                case 3:
                {
                    System.Console.WriteLine("Now You're Exited From Our Application\n\n\tThank you for the Visit\n\tHopes You Enjoy our Foods ");
                    choice = "no";
                    break;
                }
                default :
                {
                    System.Console.WriteLine("fgh");
                    break;
                }
            }
            }while(choice == "yes");  
        }

        // Customer Registration
        public static void CustomerRegistration()
        { 
            System.Console.WriteLine("--------------------------------------------------");
            System.Console.WriteLine("\n Enter Your Personal Details To Register With Us");
            System.Console.WriteLine("--------------------------------------------------");
            /*string name, string fatherName, Gender gender,long mobile,DateTime dob,string email,string location*/

            System.Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();

            System.Console.WriteLine("Enter Your Father Name:");
            string fatherName = Console.ReadLine();

            System.Console.WriteLine("Mention Your Gender? Male, Female, Others");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);

            System.Console.WriteLine("Enter Your Mobile Number");
            long mobile = long.Parse(Console.ReadLine());

            System.Console.WriteLine("Mention your Date Of Birth in this format (dd/MM/yyyy)");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",null);

            System.Console.WriteLine("Enter Your Email ID:");
            string email = Console.ReadLine();

            System.Console.WriteLine("Enter Your Location:");
            string location = Console.ReadLine();

            

            CustomerRegistration customer = new CustomerRegistration(name,fatherName,gender,mobile,dob,email,location);
            customerList.Add(customer);

            System.Console.WriteLine("--------------------------------------------------");
            System.Console.WriteLine("You are Now Successfully Registered");
            System.Console.WriteLine("--------------------------------------------------");
            System.Console.WriteLine($"Your Customer ID is {customer.CustomerID}");  
            System.Console.WriteLine("--------------------------------------------------");

        }

        //Coustomer Login
        public static void CustomerLogin()
        {
            System.Console.WriteLine("--------------------------------------------------");
            System.Console.WriteLine(" Hello Customer!!\n Have a Nice day\n");
            System.Console.WriteLine("--------------------------------------------------");

            System.Console.WriteLine("Enter Your Customer ID to Login!!:");
            string cusID = Console.ReadLine();
            
           // int flag =0;
            foreach(CustomerRegistration customers in customerList)
            {
                if(customers.CustomerID == cusID)
                {
                    currentCustomer = customers;
                    //flag = 1;
                    System.Console.WriteLine("--------------------------------------------------");
                    System.Console.WriteLine("You Are Succesfully Logged In");
                    System.Console.WriteLine("--------------------------------------------------");
                    SubMenu();
                }
            }   
           /* if(flag ==o)
            {
                CustomerLogin();
            }*/
        }

        //SubMenu
        public static void SubMenu()
        {
            System.Console.WriteLine("Now You Are in Sub Menu  \nSelect Any One of the Option Given Below To Proceed Furthur\n ");
            string inp= "yes";
            do
            {
                System.Console.WriteLine("\na.Show Food Item Details\nb.Order Food\nc.Cancel Order\nd.Cancel Booking\ne.Order History\nf.Recharge Wallet\ng.Exit\n ");
                char option = char.Parse(Console.ReadLine().ToLower());

            switch(option)
            {
                case 'a':
                {
                    System.Console.WriteLine("Now You're on Food Item Details Page");
                    ShowFoodItemDetails();
                    break;
                }
                case 'b':
                {
                    System.Console.WriteLine("Now You're On Order Food Page");
                    OrderFood();
                    break;
                }
                case 'c':
                {
                    System.Console.WriteLine("Now You're on Cancel Order Page");
                    CancelOrder();
                    break;
                }
                case 'd':
                {
                    System.Console.WriteLine("Now You're on Cancel Booking page");
                    CancelBooking();
                    break;
                }
                case 'e':
                {
                    System.Console.WriteLine("Now You're On Order History Page");
                    OrderHistory();
                    break;
                }
                case 'f':
                {
                    System.Console.WriteLine("Now You're on Recharge Wallet Page");
                    RechargeWallet();
                    break;
                }
                case 'g':
                {
                    System.Console.WriteLine("Now You are Exit from the Submenu\n");
                    inp = "no";
                    break;
                }
            }
            }while(inp == "yes");
        }
        // ShowFoodItemDetails method
        public static void ShowFoodItemDetails()
        {
            System.Console.WriteLine("--------------------------------------------------");
            System.Console.WriteLine("Food Details are Listed Below");
            System.Console.WriteLine("--------------------------------------------------");
            foreach (FoodDetails item in foodList)
            {
                System.Console.WriteLine($"  FoodID: {item.FoodID}  FoodName: {item.FoodName}  Price:  {item.PricePerQuantity}");
            }
        }
        // OrderFood Method
        public static void OrderFood()
        {
            //Ask user that whether he want to purchase / not. If “Yes” means Create booking details object with Customer id, Total price =0, Booking status = Initiated.
            System.Console.WriteLine("--------------------------------------------------");
            System.Console.WriteLine("Hello Customer!!\nDo you want To Purchase?? Yes or No");
            System.Console.WriteLine("--------------------------------------------------");
            string yOn = Console.ReadLine().ToLower();
            if(yOn =="yes")
            {
                
                BookingDetails newBooking = new BookingDetails(currentCustomer.CustomerID,0,DateTime.Now,BookingStatus.Initiated);
                bookingList.Add(newBooking);
                string input = "yes";
                double totalAmount = 0;
                do
                {
                //Show food item details and ask the user to select a Food item by using FoodID and ask Purchase quantity.
                System.Console.WriteLine("--------------------------------------------------");
                System.Console.WriteLine("Food Details are Listed Below");
                System.Console.WriteLine("--------------------------------------------------");
                foreach (FoodDetails foods in foodList)
                {
                    System.Console.WriteLine($"{foods.FoodID}  {foods.FoodName}  {foods.PricePerQuantity}");
                }
                System.Console.WriteLine("\nSelect FoodID To Choose Your Food");
                string fID = Console.ReadLine().ToUpper();
                System.Console.WriteLine("\nEnter the Quantity of Food To Order Your Food:");
                int pcount = int.Parse(Console.ReadLine());
                // Check whether the selected food ID is available.
                foreach (FoodDetails item in foodList)
                {
                    if(item.FoodID == fID)
                    {
                        //Calculate the Order Price of the current order.
                        double total = pcount*item.PricePerQuantity;
                        totalAmount +=total;
                        // e.	Check if the Customer Wallet Balance is sufficient for purchase.
                        if(total<=currentCustomer.WalletBalance)
                        {
                            //f.	If it is available means create order object with created BookingID, ProductID, Quantity and price of order and store in order details. Deduct the purchase count from product details and amount from Wallet.
                            currentCustomer.WalletBalance -= total;
                            OrderDetails newOrder = new OrderDetails(newBooking.BookingID,item.FoodID,pcount,total);
                            orderList.Add(newOrder);

                            //g.	Ask the user whether he want to order more. If “yes” means again show food details and repeat step “b” to create new order object. Repeat this process until he presses “No”.
                            System.Console.WriteLine("Do you want To Order More Items:  Yes? or No?");
                            input = Console.ReadLine().ToLower();
                            //h.	If user select “No” then calculate total order prices of recently selected orders and update the in current Booking details and change the status of booking to “Booked”.
                        }
                    }
                }
                }while(input =="yes");
                foreach(BookingDetails book in bookingList)
                {
                    if(currentCustomer.CustomerID== book.CustomerID)
                    {
                        book.TotalPrice = totalAmount;
                        book.Status = BookingStatus.Booked;
                    }
                }                                    
            }                   
        }
        //CancelOrder Method
        public static void CancelOrder()
        {
            //a.	Show the booking details of current logged in user to pick a booking detail by using BookingID and whose status is “Booked”. Check whether the booking details is present. If yes then,

            foreach(BookingDetails booking in bookingList)
            {
                if(booking.CustomerID == currentCustomer.CustomerID)
                {    
                    if(booking.Status == BookingStatus.Booked ) 
                    {
                       System.Console.WriteLine($"BookingID:{booking.BookingID} CustomerID:{booking.CustomerID} TotalPrice:{booking.TotalPrice} DateOfBooking:{booking.DateOfBooking}	BookingStatus: {booking.Status}");
                    }     
                }
            }
            //b.	Show list of order details and ask the user to pick an order id.
            foreach (OrderDetails item in orderList)
            {
                //OrderID	BookingID	FoodID	PurchaseCount	PriceOfOrder
                System.Console.WriteLine($"OrderID;{item.OrderID}	BookingID:{item.BookingID}	FoodID:{item.Equals}	PurchaseCount:{item.PurchaseCount}	PriceOfOrder:{item.PriceOfOrder}");
            }
            //c.	Ensure the order ID is available. 
               // d.	If yes, then Change the order’s purchase count to 0. Update the order’s purchase amount to 0.  and refund the balance amount to the customer.
            System.Console.WriteLine("Enter Order ID to Cancel Your Order");
            string oID = Console.ReadLine().ToUpper();

            foreach (OrderDetails item in orderList)
            {
                if(item.OrderID == oID)
                {
                    //Calculate the total price of current booking ID
                    double total = item.PriceOfOrder*item.PurchaseCount;
                    item.PurchaseCount = 0;
                    item.PriceOfOrder = 0;
                    currentCustomer.WalletBalance += total;
                }
                BookingDetails newbook = new BookingDetails(currentCustomer.CustomerID,0,DateTime.Now,BookingStatus.Cancelled);
                bookingList.Add(newbook);
            }      
        } 
        //CancelBooking
        public static void CancelBooking()
        {
                /*a.	Show the list of Bookings placed by current logged in user whose status is “Booked”.    Normal cancel Booking..
                b.	Ask the user to pick a booking id. If booking id is present, then change the order status to “Cancelled”. Refund the total price amount of current order to user. */
            foreach(BookingDetails booking in bookingList)
            {
                if(booking.CustomerID == currentCustomer.CustomerID)
                {    
                    if(booking.Status == BookingStatus.Booked ) 
                    {
                       System.Console.WriteLine($"BookingID:{booking.BookingID} CustomerID:{booking.CustomerID} TotalPrice:{booking.TotalPrice} DateOfBooking:{booking.DateOfBooking}	BookingStatus: {booking.Status}");
                    }     
                }
            }
            System.Console.WriteLine("Enter Booking ID To Cancel Your Booking");
            string cb = Console.ReadLine().ToUpper();

            foreach(BookingDetails cancel in bookingList)
            {
                if(cancel.BookingID==cb)
                {    
                    cancel.Status = BookingStatus.Cancelled;
                    double total = cancel.TotalPrice;
                    currentCustomer.WalletBalance += total;
                }
            }       
        }    
        // Order History MEthod 
        public static void OrderHistory()
        {
            System.Console.WriteLine("Your Order History Are:");
            foreach (BookingDetails book in bookingList)
            {
                if(currentCustomer.CustomerID == book.CustomerID)
                {
                    foreach (OrderDetails item in orderList)
                    {
                        if(item.BookingID ==book.BookingID)
                        {
                            //OrderID	BookingID	FoodID	PurchaseCount	PriceOfOrder
                            System.Console.WriteLine($"OrderID:{item.OrderID}	BookingID:{item.BookingID}	FoodID:{item.FoodID}	PurchaseCount:{item.PurchaseCount}	PriceOfOrder:{item.PriceOfOrder}");
                        }
                    }
                }
            }



            

        } 

        //RechargeWallet Method
        public static void RechargeWallet()
        {
            currentCustomer.WalletRecharge();
        }
    }
}