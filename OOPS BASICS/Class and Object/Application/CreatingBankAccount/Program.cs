using System;
using System.Collections.Generic;
namespace CreatingBankAccount {
class Program{
    public static void Main(string[] args)
    {
        string input = " ";
        // creating  new list for bankaccountdetails
        List<BankAccountDetails> bankAccountDetails = new List<BankAccountDetails>();

        do
        {
            System.Console.WriteLine("Enter Your Details for Opening New Account...");

            System.Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();

            System.Console.WriteLine("Enter Your  Father Name:");
            string fatherName = Console.ReadLine();
           //
            System.Console.WriteLine("Enter Your Gender:");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);

            System.Console.WriteLine("Enter Your Date Of Birth:");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null );

            System.Console.WriteLine("Enter Account Type");
            Account accountType = Enum.Parse<Account>(Console.ReadLine(),true);
            

            // To Add Account Details in list
            BankAccountDetails accountDetails = new BankAccountDetails(name,fatherName,gender,dob,accountType);
            System.Console.WriteLine("You Details Are Collected: \n \n Next Please!! ");
            System.Console.WriteLine("Your Register Number is "+ accountDetails.AccountNumber);

            bankAccountDetails.Add(accountDetails);

           System.Console.WriteLine("Your Details Have Been Collected ");
           System.Console.WriteLine(" \n \n \nDo You Want To Open New Bank Account ");
           input = Console.ReadLine().ToLower(); 
        }while(input == "yes");

        System.Console.WriteLine("Your Account Has Been Created Sucessfully");
        System.Console.WriteLine("Enter Amount To Deposit in your Account");
        double Balance = Convert.ToDouble(Console.ReadLine());

        foreach(BankAccountDetails values in bankAccountDetails)
        {
             System.Console.WriteLine("\nThe Account Holder Details are \n" );
             System.Console.WriteLine($"Name:{values.Name}\nFather Name:{values.FatherName}\nGender:{values.Gender} \nDob:{values.Dob.ToShortDateString()} \nAccount Type:{values.AccountType}");
             
        }

        System.Console.WriteLine($"Your Account Current Balance is {Balance}");
    }
}
}
