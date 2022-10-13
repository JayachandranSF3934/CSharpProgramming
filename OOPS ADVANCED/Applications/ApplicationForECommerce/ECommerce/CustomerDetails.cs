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

    }
}