using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery
{
    public class CustomerRegistration:PersonalDetails
    {
        private static int s_customerID = 1000;
        public string CustomerID { get; }
        public double WalletBalance { get; set; }

        // Constructor
        public CustomerRegistration(string name, string fatherName, Gender gender,long mobile,DateTime dob,string email,string location):base(name,fatherName, gender,mobile,dob,email,location)  // inherited PersonalDetails calss and using base keyword
        {
            s_customerID++;
            CustomerID ="CID"+s_customerID;
        }

        //Files Constructor
        public CustomerRegistration(string data)
        {
            string[] values = data.Split(",");
            s_customerID = int.Parse(values[0].Remove(0,3));
            CustomerID = values[0];
            WalletBalance = double.Parse(values[1]);
            Name = values[2];
            FatherName = values[3];
            Gender = Enum.Parse<Gender>(values[4]);
            Mobile = long.Parse(values[5]);
            DOB = DateTime.ParseExact(values[6],"dd/MM/yyyy",null);
            Email = values[7];
            Location = values[8];
        }

        // Method for IBalance
        public void WalletRecharge()
        {
            System.Console.WriteLine("Enter Amount To be Added In Your Wallet/n");
            WalletBalance = double.Parse(Console.ReadLine());
        }

    }
}