using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank
{
    public class AccountInfo:PersonDetails
    {
        //: AccountNumber, Branchname, IFSCCode, Balance
        private static int s_accountNumber = 600500200;
        private static int s_ifscCode = 0004505;

        public int  AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public double Balance { get; set; }

        //constructor
        public AccountInfo(string name, string fatherName,long phoneNumber,string email, DateTime dob,Gender gender,string branchName , double balance):base(name,fatherName,phoneNumber,email,dob,gender)
        {
            s_accountNumber++;
            AccountNumber = s_accountNumber;
            BranchName = branchName;
            IFSCCode = "SBI"+s_ifscCode;
            Balance = balance;
        }

        // Show Account Info
        public void ShowAccountInfo()
        {
            System.Console.WriteLine($"\nAccountNumber: {AccountNumber}");
            ShowPersonDetail();
            System.Console.WriteLine($"Branchname:{BranchName}\nIFSCCode:{IFSCCode}\nBalance:{Balance}");
        }


        
    }
}