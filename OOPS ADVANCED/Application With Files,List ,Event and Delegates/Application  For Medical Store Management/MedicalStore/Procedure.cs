using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public static class Procedure
    {
        // Creating list for Userdetails
        public static List<UserDetails> userList = new List<UserDetails>();
        // Creating list for Medicine Details
        public static List<MedicineDetails> medicineList = new List<MedicineDetails>();
        // Creating list for OrderDetails
        public static List<OrderDetails> orderList = new List<OrderDetails>();

        // Creating Empty Object For User
        static UserDetails  currentUser  = null;
       
        // mainMenu
         public static void ManiMenu()
         {
            System.Console.WriteLine(" __________________________________________________________________________________");
            System.Console.WriteLine("|__________________________________________________________________________________|");
            System.Console.WriteLine("|                            Welcome to Online Medical Store                       |");
            System.Console.WriteLine("|__________________________________________________________________________________|");
            System.Console.WriteLine("|__________________________________________________________________________________|");
            string input = "yes";
            do
            {
                System.Console.WriteLine("\n\t\tSelect Options To Proceed Further");
                System.Console.Write("\n1.User Registration \n2.User Login \n3.Order Histroy \n4.Exit");
                System.Console.WriteLine("\n\nEnter Your Option");
                int choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Welcome To Resitration Process\n");
                        // Call Registration Method
                        Registeration();
                        break;   
                    }
                    case 2:
                    {
                        System.Console.WriteLine("\nWelcome To User Login \n\nEnter Correct Details to Proceed Furthur");
                        // Call User Login Method
                        UserLogin();
                        break;
                    }
                     case 3:
                    {
                        System.Console.WriteLine("Now Your Are In Order Histroy Page");
                        // Call User Login Method
                        OrderHistory();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("|--------------------------------------------------- |");
                        System.Console.WriteLine("| You're Closed Our Application Thanks For Your Time |");
                        System.Console.WriteLine("|--------------------------------------------------- |");
                        input = "no";
                        break;
                    }
                }
            }while(input == "yes" );
         }

         // Registration Method
         public static void Registeration()
         {
            System.Console.WriteLine("Enter Your Correct Infomation To Proceed Further");

            System.Console.WriteLine("Enter Your Name :");
            string name = Console.ReadLine();
            
            System.Console.WriteLine("Enter Your Age:");
            int age = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter Your City:");
            string city = Console.ReadLine();
            
            System.Console.WriteLine("Enter Your Phone Number:");
            long phone = long.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter Your Amount To be Added To Your Wallet balance");
            double balance = double.Parse(Console.ReadLine());

            // Add Collected details from the user to list created for Users.
            UserDetails user = new UserDetails(name,age,city,phone,balance);
            userList.Add(user);
            // Registration proceess ended

            System.Console.WriteLine("\n\nYour User Registration was SuccessFully Completed !!!!\n");
            System.Console.WriteLine("\t\tYour User ID is "+ user.UserID +"\n\nRemember and Save it For Futhur Use!!!!");
             }
         // Login Method
         public static void UserLogin()
         {
            System.Console.WriteLine("---------------------------------------------");
            System.Console.WriteLine("Enter Your User ID To Login:");
            string loginID = Console.ReadLine().ToUpper();

            foreach (UserDetails user in userList)
            {
                if(user.UserID == loginID)
                {
                    System.Console.WriteLine("|--------------------------------------------------- |");
                    System.Console.WriteLine("|          You Are SucessFully Logged In !!!         |");
                    System.Console.WriteLine("|--------------------------------------------------- |");
                    currentUser = user;
                    // Show Sub Menu For Furthur Operation
                    SubMenu();
                }        
            }
         }
         // Order History Method
         public static void OrderHistory()
         {
            System.Console.WriteLine("Enter your User ID");
            string user = Console.ReadLine().ToUpper()
;           foreach (UserDetails item in userList)
            {
                if(user == item.UserID)
                {
                    foreach (OrderDetails type in orderList)
                    { 
                        if(type.UserID == user)
                        {
                            System.Console.WriteLine($"User ID: {type.UserID} Medicine ID: {type.MedicineID} MedicineCount : {type.MedicineCount} TotalPrice : {type.TotalPrice} OrderDate: {type.OrderDate} OrderStatus : {type.OrderStatus}"); 
                        }
                    }
                    
                }
            }        
         }
         // SubMenu Method
         public static void SubMenu()
         {
            string option= "yes";
            do
            {
                System.Console.WriteLine("\n\nWelceome To Online Medical store");
                System.Console.WriteLine("----------------------------------------------------------");
                System.Console.WriteLine("\t\tSelect Options\n\na.Show Medcine List\nb.Purchase Medicine\nc.Cancel Purchase\nd.Show Purchase History\ne.Recharge\nf.Exit SubMenu");
                char word = char.Parse(Console.ReadLine().ToLower());
                System.Console.WriteLine("----------------------------------------------------------");
                
                switch(word)
                {
                    case 'a':
                    {
                        System.Console.WriteLine("Showing medicine Details");
                        MedicineDetails();
                        break;
                    }
                    case 'b':
                    {
                        System.Console.WriteLine("/nPurchase Medcine for Youself and And Your family/n");
                        PurchaseMedicine();
                        break;
                    }
                    case 'c':
                    {
                        System.Console.WriteLine("Do You Want To Cancel Medicine??");
                        CancelPurchase();
                        break;
                    }
                    case 'd':
                    {
                        System.Console.WriteLine("Showing Your Purcharse History\n\n ");
                        PurchaseHistroy();
                        break;
                    }
                    case 'e':
                    {
                        System.Console.WriteLine("Do You Want To Recharge You Wallet");
                        Recharge();
                        break;
                    }
                    case 'f':
                    {
                        System.Console.WriteLine("Exit From SubMenu");
                        option ="no";
                        break;
                    }
                }
            }while(option == "yes");
            
         }
         // Submenu operations
         // a show medicine list
         public static void MedicineDetails()
         {
            foreach(MedicineDetails  medicines in medicineList)
            {
                System.Console.WriteLine($"Medicine Id:{medicines.MedicineID} Medicine Name:  {medicines.MedicineName} Count Available:  {medicines.AvailableCount} Price:  {medicines.Price} Expiry Data:  {medicines.ExpiryDate.ToShortDateString()}");
            }
         }
         // b . Purchase Medicine
         public static void PurchaseMedicine()
         {
            // 1.	Show the List of medicine details by traversing the medicine details list.
            MedicineDetails();

            //2.	Ask the user about which medicine he want to buy.
            //3.	Ask the number of counts of that medicine he want to buy.
            System.Console.WriteLine("\nEnter Medicine ID To Purchase");
            string medID = Console.ReadLine().ToUpper();
            System.Console.WriteLine("Enter the Number Of Count of Medicine You Want To Buy:");
            int count = int.Parse(Console.ReadLine());

            //4.  Check the Medicine list whether the Medicine ID was available If it is available, 
            //then check the asked count is available. If it is available, 
            //then check User has enough balance to purchase that medicine. 
            //Check the medicine was not expired.

            foreach (MedicineDetails medicine in medicineList)
            {
                if(medicine.MedicineID == medID)
                {
                    if(count <= medicine.AvailableCount)
                    {
                        //// 5.	If all the conditions specified in step 4 are true then calculate total amount of purchased medicines,
                        double total = count*medicine.Price;

                        if(total <= currentUser.Balance)
                        {
                            if(medicine.ExpiryDate >= DateTime.Today)
                            {
                                // 7.	Deduct the total amount from user’s balance amount.
                                currentUser.Balance -= total;
                               //  6.	Reduce the number of count of that medicine in MedicineDetails List. 
                                medicine.AvailableCount -= count;
                                //8.	Create Object for OrderDetails class and add it to list. 
                                // OrderDate is Now, Put OrderStatus as “Purchased”.

                                OrderDetails order = new OrderDetails(currentUser.UserID,medID,count,total,DateTime.Now,OrderStatus.Purchased);
                                orderList.Add(order);
                                // 9.	Finally show “Medicine was purchased successfully”.   
                                System.Console.WriteLine("\n\nYour Medicine Was Purchased Susscessfully\n\n");

                                System.Console.WriteLine($"Your Order ID is {order.OrderID}");
                            }else
                            {
                                System.Console.WriteLine("\nMedicine Expiried Chosse Any Other Medicine to buy\n");
                                PurchaseMedicine();
                            }
                        }else{
                            System.Console.WriteLine("\nInsufficient Balance Recharge Your Account\n");
                           
                        }
                    }else{
                        System.Console.WriteLine("\nEntered Count of Available Medicine is not Available\n");
                    }
                }
            }
        }
        // c. Cancel Purchase     
        public static void CancelPurchase()
        {
            //1. Show the order details of current logged in user who’s order status in “Purchased”.
            foreach (OrderDetails item in orderList)
            {
                if(currentUser.UserID == item.UserID)
                {
                    if(item.OrderStatus == OrderStatus.Purchased)
                    {
                        System.Console.WriteLine($"User ID: {item.UserID} Medicine ID: {item.MedicineID} MedicineCount : {item.MedicineCount} TotalPrice : {item.TotalPrice} OrderDate: {item.OrderDate} OrderStatus : {item.OrderStatus}");
                    }
                }
            }
            // 2.	Get the OrderID information from user and check the OrderID present in list and also check it’s OrderStatus is Purchased.
            System.Console.WriteLine("Enter Your Order Id To Cancel Purchase");
            string orderId = Console.ReadLine().ToUpper();

            foreach (OrderDetails cancel in orderList)
            {
                if(orderId == cancel.OrderID)
                {
                    if(cancel.OrderStatus == OrderStatus.Purchased)
                    {
                        foreach (MedicineDetails item in medicineList)
                        {
                            if(cancel.MedicineID == item.MedicineID)
                            {
                                // 3.	If the OrderID matched increase the count of that Medicine in medicine details, Return the amount to user.  Change the Status of order to “Cancelled”.
                                item.AvailableCount  += cancel.MedicineCount;
                                double returnAmount = cancel.MedicineCount * item.Price;
                                currentUser.Balance +=returnAmount;
                                cancel.OrderStatus = OrderStatus.Cancelled;
                                //  4.	Show user that the “OrderID101 was cancelled successfully”.
                                System.Console.WriteLine($"Your {orderId} was Cancelled Successfully");  
                            }
                        }
                    }   
                }  
            }
        }   
        // d.Purchase Histroy
        public static void PurchaseHistroy()
        {
            foreach (OrderDetails history in orderList)
            {
                if(history.UserID == currentUser.UserID)
                {
                    System.Console.WriteLine($"User ID: {history.UserID} Medicine ID: {history.MedicineID} MedicineCount : {history.MedicineCount} TotalPrice : {history.TotalPrice} OrderDate: {history.OrderDate.ToShortDateString()} OrderStatus : {history.OrderStatus}");
                }
            }
        }
        // e.Recharge
        public static void Recharge()
        {
            foreach (UserDetails userOne in userList)
            {
                if(currentUser.UserID == userOne.UserID)
                {
                    System.Console.WriteLine("Enter Recharge Amounnt to be Added in your Balance");
                    double amountOne = double.Parse(Console.ReadLine());
                    currentUser.Balance +=amountOne;
                    System.Console.WriteLine($"Your Balance Amount is {currentUser.Balance}");
                }
            }
        }
}
}
