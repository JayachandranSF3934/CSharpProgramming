using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricityBillGenerate
{
    public static class Operations
    {
        // for creating submenu new object
        static CustomerDetails currentCustomer =null;
       //Creating New List For CustomerDetails
        static List<CustomerDetails>  customerBill = new List<CustomerDetails>();

        public static void MainMenu()
        {

            {  
            string choice ="yes";
            do
            {            
            System.Console.WriteLine("Select Options 1.Register 2.Login 3.Exit");
            int option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Register");
                    Register();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Login");
                    Login();
                    break;
                    
                }
                case 3:
                {
                    System.Console.WriteLine("Exit");
                    choice = "no";
                    break;
                }
            }
            }while(choice == "yes");  
        }
        }

        public static void Register()
        {
            string input = " ";
            do
           {
            System.Console.WriteLine("Enter Customer Details to Generate Electricity Bill.");

            //Get Customer Details.
            System.Console.WriteLine("Enter Customer Name:");
            string userName= Console.ReadLine();
            
            System.Console.WriteLine("Enter Customer Phone No:");
            long mobileNo = Convert.ToInt64(Console.ReadLine());

            System.Console.WriteLine("Enter Customer Email ID:");
            string email = Console.ReadLine();

            System.Console.WriteLine("Enter Unit Used In this Month");
            int units = Convert.ToInt32(Console.ReadLine());
            
            // Add Customer Details in List customerBill

            CustomerDetails customer = new CustomerDetails(userName,mobileNo,email,units);
            customerBill.Add(customer);
            System.Console.WriteLine("Customer Details Are Collected. \n \n Next Please!! ");
            System.Console.WriteLine("Your User Id  is "+ customer.CustomerId);
            System.Console.WriteLine("Do You Want To Generate Next Customer Electricity Bill??");
            input = Console.ReadLine().ToLower();
            }while(input == "yes");
        }

        public static void Login()
        {
            System.Console.WriteLine("Enter Your Customer Id  To Login");
            string idCustomer = Console.ReadLine().ToUpper();
            foreach(CustomerDetails customer2 in customerBill)
            {
                if(customer2.CustomerId == idCustomer)
                {
                    System.Console.WriteLine("Login Successfully!!!");
                    currentCustomer =customer2;
                    SubMenu();
                }
            }
        }

        public static void SubMenu()
        {
            string choice ="yes";
            do
            {            
            System.Console.WriteLine("Select Options 1.Show Details 2.Get Number of Units 3.Calculate Traiffs 4.Exit SubMenu");
            int option = int.Parse(Console.ReadLine());
        
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Show Details");
                    currentCustomer.ShowDetails();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Get NUmber of Units Conusumed");
                    currentCustomer.NoOfUnits();
                    break;
                    
                }
                case 3:
                {
                    System.Console.WriteLine("Calculate Traiffs");
                    currentCustomer.CalculateAmount();
                    break;
                    
                }
                case 4:
                {
                    System.Console.WriteLine("Exit SubMenu");
                    choice = "no";
                    break;
                }
            }
            }while(choice == "yes");
        }
    }
}