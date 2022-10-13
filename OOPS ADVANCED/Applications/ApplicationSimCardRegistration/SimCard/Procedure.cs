using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimCard
{
    public static class Procedure
    {

        static CustomerDetails curentCustomer =null;
       

        public static List<CustomerDetails> customList = new List<CustomerDetails>();
        public static List<PlanDetails> planList = new List<PlanDetails>();
        public static List<RechargeDetails> rechargeList = new List<RechargeDetails>();

        
        public static void MainMenu()
        {
            //Default();
            System.Console.WriteLine("---------------------------------------------------------------------------");
            System.Console.WriteLine("\t\tWelcome to Synctel Communication\n");
            System.Console.WriteLine("Select Any One Option To Proceed Furthur");
            System.Console.WriteLine("To Get A Sim Card To Connect With EveryOne ");
            System.Console.WriteLine("---------------------------------------------------------------------------");
            string choice ="yes";
            do
            {            
            System.Console.WriteLine("\n\tSelect Options\n1.Register\n2.User Login\n3.Plandetails\n4.Exit");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Registeration");
                    Registration();
                    
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("User Login");
                    UserLogin();
                    break;
                    
                }
                case 3:
                {
                    System.Console.WriteLine("Plan Details");
                    PlanDetails();
                
                    break;
                    
                }
                case 4:
                {
                    System.Console.WriteLine("Exit");
                    choice = "no";
                    break;
                }
            }
            }while(choice == "yes");  
        }
    // registration
        public static void Registration()
        {
            System.Console.WriteLine("---------------------------------------------------------------------------");
            System.Console.WriteLine("WELCOME TO REGISTRATION PROCESS");
            System.Console.WriteLine("---------------------------------------------------------------------------");


            System.Console.WriteLine("Enter your Name:");
            string name = Console.ReadLine();
            
            System.Console.WriteLine("Enter your Aadhar Number:");
            long aadtharNumber = Convert.ToInt64(Console.ReadLine());

            System.Console.WriteLine("Enter Your Age:");
            int age = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter Your Gender: Male , Female, Transgender");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);

            System.Console.WriteLine("Enter Your Address:");
            string address = Console.ReadLine();

            CustomerDetails customer = new CustomerDetails(name,aadtharNumber,age,gender,address);
            customList.Add(customer);

            System.Console.WriteLine("Thanks For Providing Your Information ,YOur Details are Collected\n\n");
            System.Console.WriteLine("---------------------------------------------------------------------------");

            System.Console.WriteLine($"Your Customer ID is {customer.CustomerID}");
            System.Console.WriteLine("---------------------------------------------------------------------------");

        }
        // UserLOgin
        public  static void UserLogin()
        {
                System.Console.WriteLine("\nEnter Your CustomerId To proceed Furthur");
                string cusId = Console.ReadLine().ToUpper();
                foreach (CustomerDetails customer in customList)
                {
                    if(customer.CustomerID == cusId)
                    {
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        System.Console.WriteLine("\nLogin Successfully!!!");
                        System.Console.WriteLine("---------------------------------------------------------------------------\n\n");
                        curentCustomer =customer;
                        AfterLogin();    
                    }else{
                        System.Console.WriteLine("Invalid Data!!");
                    }
                }
        }

        //  Plan Details
        public static void PlanDetails()
        {
            System.Console.WriteLine(" Paln Details Are Listed Below  ");
            System.Console.WriteLine("---------------------------------------------------------------------------");

            foreach (PlanDetails item in planList)
            {
                System.Console.WriteLine($"Plan Id:{ item.PlanId}\tPlan Amount:{ item.PlanAmount}\tPlan Type:{item.PlanName}\tBenefits:{item.Benefit}\tValidity:{item.Validity} ");
            }
            System.Console.WriteLine("---------------------------------------------------------------------------");


        }

        /* public static void Default()
        {
            PlanDetails plan = new PlanDetails("PLAN-10023",239,"Monthly","Unlimted calls,1.5GB Data/day and 100 SMS/Day","28 Days");
            planList.Add(plan);
            PlanDetails planOne = new PlanDetails("PLAN-10123",279,"Monthly","Unlimted calls,2GB Data/day and 100 SMS/Day","28 Days");
            planList.Add(planOne);
            PlanDetails planTwo = new PlanDetails("PLAN-10033",299,"Monthly","Unlimted calls,3GB Data/day and 100 SMS/Day","28 Days");
            planList.Add(planTwo);
            PlanDetails planThree = new PlanDetails("PLAN-10043",399,"Quartly","Unlimted calls,1GB Data/day and 100 SMS/Day","84 Days");
            planList.Add(planThree);
            PlanDetails planFour = new PlanDetails("PLAN-10025",459,"Quartly","Unlimted calls,1.5GB Data/day and 100 SMS/Day","84 Days");
            planList.Add(planFour);
            PlanDetails planFive = new PlanDetails("PLAN-10022",659,"Quartly","Unlimted calls,2GB Data/day and 100 SMS/Day","84 Days");
            planList.Add(planFive);
            PlanDetails planNine = new PlanDetails("PLAN-10053",59,"DATA-ADD-ON","Unlimted calls,1.5GB Data/day and 100 SMS/Day","3 Days");
            planList.Add(planNine);
            PlanDetails planTen = new PlanDetails("PLAN-10028",79,"DATA-ADD-ON","Unlimted calls,1.5GB Data/day and 100 SMS/Day","5 Days");
            planList.Add(planTen);
            PlanDetails planzz = new PlanDetails("PLAN-10034",109,"DATA-ADD-ON","Unlimted calls,1.5GB Data/day and 100 SMS/Day","7 Days");
            planList.Add(planzz);
            PlanDetails planSix = new PlanDetails("PLAN-10045",799,"Yearly","Unlimted calls,1GB Data/day and 100 SMS/Day","332 Days");
            planList.Add(planSix);
            PlanDetails planSeven = new PlanDetails("PLAN-10398",899,"Yearly","Unlimted calls,1.5GB Data/day and 100 SMS/Day","332 Days");
            planList.Add(planSeven);
            PlanDetails planEight = new PlanDetails("PLAN-10278",999,"Yearly","Unlimted calls,3GB Data/day and 100 SMS/Day","332 Days");
            planList.Add(planEight);
            
        } */
        // Submenu
        public static void AfterLogin()
        {
            System.Console.WriteLine("---------------------------------------------------------------------------\n\n");
            System.Console.WriteLine("---------------------------------------------------------------------------");
            System.Console.WriteLine("\t\tWelcome to SYncteL Commnuications\n");
            System.Console.WriteLine("Select Any One Option To Proceed Furthur");
            System.Console.WriteLine("To Get A Sim Card To Connect With EveryOne ");
            System.Console.WriteLine("---------------------------------------------------------------------------");
            System.Console.WriteLine("---------------------------------------------------------------------------");
            string input = "yes";
            do
            {
                System.Console.WriteLine("Select Option\n1.Check Eligible\n2.Show My Details\n3.Get Mobile Number\n4.Recharge\n5.Recharge Details\n6.MainMenu");
                int option = int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Your Eligiblity to get sim card/Mobile Number");
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        curentCustomer.Eligible();

                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Showing Your Details For Your Refernce\n\n");
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        curentCustomer.ShowDetails();
                        

                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("---------------------------------------------------------------------------"); 
                        System.Console.WriteLine("Get Your New Mobile Number of a SYNCTEL Sim Card \n");
                        GetMobileNumber();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        System.Console.WriteLine("Recharge Your Mobile Number With Reasonable Pack");
                        Recharge();
                        
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        System.Console.WriteLine("Plan status");
                        RechargeDetails();
                        
                        break;
                    }
                    case 6:
                    {
                        System.Console.WriteLine("Back To MainMenu");
                        input ="no";
                        break;
                    }
                }
                
            } while (input == "yes");
        }

        // Get Mobile for Sim Card
        public static void GetMobileNumber()
        {
            if(curentCustomer.Age >18)
            {
                System.Console.WriteLine("You Are Eligible to Get New SYNCTEL Sim Card\n");
                System.Console.WriteLine($"Your 10 Digit Mobile Number are:{ curentCustomer.Mobile}");
               
                //Random mobileNumber = new Random();
                //System.Console.WriteLine(mobileNumber.Next());
                //int mobileNumber = 0009404445;
                System.Console.WriteLine("\nYour Online  Paperless Registration Process are Completed, \n\tTo Get a Sim Card Visit nearby stores!! \n");
               // customList.Add();
                
            }else{
                System.Console.WriteLine("Your Not Eligible for this Process");
            }
        }
      // Recharge
        public static void Recharge()
        {
            // Show Plan details to select a plan for 
            System.Console.WriteLine("---------------------------------------------------------------------------");
            foreach (PlanDetails item in planList)
            {
                System.Console.WriteLine($"Plan Id:{item.PlanId}\tPlan Amount:{item.PlanAmount}\tPlan Name:{item.PlanName}\tBenefits:{item.Benefit}\tValidity:{item.Validity} ");
            }
            System.Console.WriteLine("---------------------------------------------------------------------------");
            // get Mobile Number from user

            System.Console.WriteLine("Enter your Mobile Number");
            long num = Convert.ToInt64(Console.ReadLine());
            if(num == curentCustomer.Mobile)
            {    // get planId from user
                System.Console.WriteLine("Enter Plan Id to Selct plan and Recharge!!");
                string id = Console.ReadLine().ToUpper();

                RechargeDetails recharge = new RechargeDetails(curentCustomer.Mobile,id,DateTime.Now,RechargeStatus.PaymentPending);
                rechargeList.Add(recharge);
                System.Console.WriteLine("Your Recharge option was Selected \n Please pay us through UPI or visit store .Your Selected paln options are locked untill your payment was done. ");
                
            }else{
                System.Console.WriteLine("Invalid number!");
            }
        }

        // Show recharge details
        public static void RechargeDetails()
        {
            System.Console.WriteLine("---------------------------------------------------------------------------");
            System.Console.WriteLine("Your Recharge details are listed below");
            System.Console.WriteLine("---------------------------------------------------------------------------");

            foreach (RechargeDetails item in rechargeList)
            {
                if(curentCustomer.Mobile == item.Mobile)
                {
                    System.Console.WriteLine($"\nMobile number:{item.Mobile}\nPlanID:{item.PlanId}\nRechrgeDate:{item.RechargeDate}\nRechargeStatus:{item.Status}");
                }
            }   
        }
    }
    
}