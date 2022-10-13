using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
///  Namespace is common for all Creating BankAccount
/// </summary>
namespace CreatingBankAccount
{
  // Enum for Gender

  /// <summary>
  /// Enum Gender is used to Select particular option from the chioces
  /// </summary>
  public enum  Gender{Default ,Male,Female,Transgender}

  //Enum for Account Type
  /// <summary>
  /// Enum Account is used to select particular option from the chioces
  /// </summary>
  public enum Account {Default,Savings,Fd,Rd}
     /// <summary>
     /// This class contains the details of Bank Account Details. 
     /// </summary>
    public class BankAccountDetails
    {
      /// <summary>
      ///   Account number is  automatically Generated with incremnet of 1 
      /// </summary>
      private static int s_accountNumber =40000;
      /// <summary>
      /// Account number property is only have get 
      /// </summary>
      /// <value></value>
      public string AccountNumber {get;}
      /// <summary>
      /// Name is used to 
      /// </summary>
      /// <value></value>
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public DateTime Dob { get; set; }
        public Account AccountType { get; set; }
        public double Balance { get; set; }

    // Parameterised Constructor
    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"> Name Property is used to store name of the account holder </param>
    /// <param name="fatherName">fatherName Property is used to store Father name of the account holder</param>
    /// <param name="gender">Gender is used to store gender of the account holder</param>
    /// <param name="dob"></param>
    /// <param name="accountType"></param>
      public BankAccountDetails(string name, string fatherName, Gender gender, DateTime dob, Account accountType)
      {
        s_accountNumber++;
        AccountNumber = "SBI-"+s_accountNumber;
        Name = name;
        FatherName = fatherName;
        Gender = gender;
        Dob =dob;
        AccountType = accountType;
      }  


     /// <summary>
     /// Show detail method is used to Print the details provided by the user during registration
     /// </summary>
      public void ShowDetails()
      {
        System.Console.WriteLine("\nThe Account Holder Details are \n" );
             System.Console.WriteLine($"Name:{Name}\nFather Name:{FatherName}\nGender:{Gender} \nDob:{Dob.ToShortDateString()} \nAccount Type:{AccountType}");
      }

      // METHOD FOR Deposit
       /// <summary>
       /// Deposit method is used to get the amount 
       /// </summary>
      public void Deposit()
      {
        System.Console.WriteLine("Enter Amount To be Deposited In Your Account");
        double depoist = double.Parse(Console.ReadLine());
        Balance = Balance+depoist;
        System.Console.WriteLine("Deposited Amount :"+depoist);
        
      }
    // Methos for withdraw
      public void Withdraw()
      {
        System.Console.WriteLine("Enter Amount To be Withdrawn From Your Account");
        int withdraw = int.Parse(Console.ReadLine());
        if(withdraw<Balance)
        {
          Balance = Balance-withdraw;
        }
        else
        {
          System.Console.WriteLine("Insufficient Balance");
        } 
      }
     // method for show balance
      public void ShowBalance ()
      {
          Console.WriteLine("Your Account Balance is  "+Balance);
      }
    }
}