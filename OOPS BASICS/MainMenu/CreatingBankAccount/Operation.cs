using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreatingBankAccount
{
    public  static class Operation
    {
        // creating submenu object 
       static BankAccountDetails  currentdetails =null;
        // creating  new list for bankaccountdetails
       static List<BankAccountDetails> bankAccountDetails = new List<BankAccountDetails>();   

       // creating main menu
       public static void Mainmenu() 
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
       public static void Register ()
       {
            System.Console.WriteLine("Enter Your Details for Opening New Account...");

            System.Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();

            System.Console.WriteLine("Enter Your  Father Name:");
            string fatherName = Console.ReadLine();
           //
            System.Console.WriteLine("Enter Your Gender: Male , Female, Transgender");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);

            System.Console.WriteLine("Enter Your Date Of Birth:");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null );

            System.Console.WriteLine("Enter Account Type  : Savings, Fd, Rd");
            Account accountType = Enum.Parse<Account>(Console.ReadLine(),true);
            

            // To Add Account Details in list
            BankAccountDetails accountDetails = new BankAccountDetails(name,fatherName,gender,dob,accountType);
            bankAccountDetails.Add(accountDetails);

            System.Console.WriteLine("\nYour Account Has Been Created Sucessfully\n  \n \n Next Please!! ");
            System.Console.WriteLine("Your Account Number is "+ accountDetails.AccountNumber);
       }

       public static void Login()
       {
        System.Console.WriteLine("Enter Your Account Number");
            string accNumber = Console.ReadLine().ToUpper();
            foreach(BankAccountDetails accountholder  in bankAccountDetails)
            {
                if(accountholder.AccountNumber == accNumber)
                {
                    System.Console.WriteLine("Login Successfully!!!");
                    currentdetails =accountholder;
                    SubMenu();
                }
            }
       }
       public static void SubMenu()
       {
            string choice ="yes";
            do
            {            
            System.Console.WriteLine("Select Options 1.Show Details 2.Deposit 3.Withdraw 4.Show Balance 5.Exit SubMenu");
            int option = int.Parse(Console.ReadLine());
            

            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Show Details");
                    currentdetails.ShowDetails(); 
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Deposit");
                    currentdetails.Deposit();
                   

                    break;
                    
                }
                case 3:
                {
                    System.Console.WriteLine("Withdraw");
                    currentdetails.Withdraw();
                   

                    break;
                    
                }
                case 4:
                {
                    System.Console.WriteLine("Show Balance");
                    currentdetails.ShowBalance();
                   

                    break;
                    
                }
                case 5:
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