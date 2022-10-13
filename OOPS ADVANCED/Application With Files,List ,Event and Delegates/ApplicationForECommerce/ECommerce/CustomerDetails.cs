using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce
{
    public class CustomerDetails
    {
        private static int s_customerId =1000;

        public string CustomerId { get;  }
        public string CustomerName { get; set; }
        public string City { get; set; }
        public long MobileNumber { get; set; }
        public double WalletBalance { get; set; }
        public string EmailID { get; set; }

        // Constructor

        public CustomerDetails( string customerName, string city, long mobileNumber,double walletBalance,string emailId)
        {
            s_customerId++;
            CustomerId = "CID"+s_customerId;
            CustomerName = customerName;
            City = city;
            MobileNumber =mobileNumber;
            WalletBalance = walletBalance;
            EmailID = emailId;
        }

        //constructor for Files

        public CustomerDetails(string data)
        {
            string[] values = data.Split(",");
            s_customerId = int.Parse(values[0].Remove(0,3));
            CustomerId = values[0];
            CustomerName = values[1];
            City = values[2];
            MobileNumber = long.Parse(values[3]);
            WalletBalance = double.Parse(values[4]);
            EmailID = values[5];
        }

    }
}