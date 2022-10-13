using System;
namespace OnlineGrocery
{
    public class CustomerRegistration:PertsonDetails,IBalance
    {
        //Field
        private static int s_customerID = 1000;
        public double WalletBalance { get; set; }
        public string CustomerID { get; set; }


        // Constructor
        public CustomerRegistration(string name, string fatherName,Gender gender,long mobile, DateTime dob, string email):base(name, fatherName,gender,mobile, dob,email)
        {
            s_customerID ++;
            CustomerID = "CID"+s_customerID;
            
        }

        public CustomerRegistration(string data)
        {
            string[] values = data.Split(",");
            s_customerID = int.Parse(values[0].Remove(0,3));
            CustomerID = values[0];
            WalletBalance = double.Parse(values[1]);
            Name = values[2];
            FatherName = values[3];
            Gender = Enum.Parse<Gender>(values[4]);
            MobileNumber = long.Parse(values[5]);
            DOB = DateTime.ParseExact(values[6],"dd/MM/yyyy",null);
            Email = values[7];
        }
        // 
        public void ShowCustomerDetails()
        {
            System.Console.WriteLine($"Customer ID: {CustomerID}");
            System.Console.WriteLine($"Customer Name:{Name}\nFatherName:{FatherName}\nGender:{Gender}\nMobile: {MobileNumber}\nDOB:{DOB.ToString("d")}\nMailID:{Email}");   
        }


        public void WalletRecharge()
        {
            System.Console.WriteLine("Enter Amount To be Added In Your Wallet");
            WalletBalance = double.Parse(Console.ReadLine());
        }
    }
}