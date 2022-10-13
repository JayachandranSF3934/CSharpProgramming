using System;
using System.Collections.Generic;
using ElectricityBillLibrary;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricityBill
{
    public class Operations
    {
        public static void MainMenu()
        {
            string input = " ";
        //Creating New List For CustomerDetails
        List<CustomerDetails>  customerBill = new List<CustomerDetails>();
        // Getting Customer Details to Generate Bill

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

            // Details are collected
            System.Console.WriteLine("Customer Details Are Collected");
            System.Console.WriteLine("Do You Want To Generate Next Customer Electricity Bill??");
            input = Console.ReadLine().ToLower();

        }while(input == "yes");

        foreach(CustomerDetails values in customerBill)
        {
            System.Console.WriteLine("Electricity Bill.");
            System.Console.WriteLine($"Customer ID:{values.CustomerId}\nUserNmae: {values.UserName}\nMobile number: {values.MobileNo}\nEmail Address:{values.EmailId}\nUnit Consumed:{values.UnitsConsumed}");
            System.Console.WriteLine($"Electricity Bill Amount To be Paid : {values.CalculateAmount()}");
            System.Console.WriteLine("Pay Bill Amount Before Due Date.");
            System.Console.WriteLine("Thank You for Using this Application to Calculate Electricity Bill...");

        }
        }
    }
}