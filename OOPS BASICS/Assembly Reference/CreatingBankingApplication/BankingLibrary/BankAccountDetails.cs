using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  BankingLibrary
{
  // Enum for Gender
  public enum  Gender{Default ,Male,Female,Transgender}

  //Enum for Account Type
  public enum Account {Default,Savings,Fd,Rd}
    public class BankAccountDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public DateTime Dob { get; set; }
        public Account AccountType { get; set; }
        public double Balance { get; set; }
    // Parameterised Constructor
      public BankAccountDetails(string name, string fatherName, Gender gender, DateTime dob, Account accountType)
      {
        Name = name;
        FatherName = fatherName;
        Gender = gender;
        Dob =dob;
        AccountType = accountType;
      }

      // METHOD FOR BALANCE

      public void Deposit()
      {
        System.Console.WriteLine("Enter Amount To be Deposited In Your Account");
        double depoist = double.Parse(Console.ReadLine());
        Balance = Balance+depoist;
        
      }

      public void Withdraw()
      {
        System.Console.WriteLine("Enter Amount To be Withdrawn From Your Account");
        int withdraw = int.Parse(Console.ReadLine());
        if(withdraw >Balance)
        {
          Balance = withdraw-Balance;
        }
        else
        {
          System.Console.WriteLine("Insufficient Balance");
        } 
      }

      public void ShowBalance ()
      {

      }
    }
}