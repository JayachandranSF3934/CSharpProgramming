using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricityBillGenerate
{
    public class CustomerDetails
    {
        private static int s_customerId = 1000;

        public string CustomerId { get; set; }
        public string UserName { get; set; }
        public long MobileNo { get; set; }
        public string  EmailId { get; set; }
        public int UnitsConsumed { get; set; }

        // Constructor

        public CustomerDetails(string userName,long mobileNo,string email, int units)
        {
            s_customerId++;
            CustomerId = "EB-" +s_customerId;
            UserName = userName;
            MobileNo = mobileNo;
            EmailId = email;
            UnitsConsumed =units;
            
        }
        public void ShowDetails()
        {
            System.Console.WriteLine("Electricity Bill.");
            System.Console.WriteLine($"Customer ID:{CustomerId}\nUserNmae: {UserName}\nMobile number: {MobileNo}\nEmail Address:{EmailId}\nUnit Consumed:{UnitsConsumed}");
        }

        public void NoOfUnits()
        {
            int nunit  = UnitsConsumed;
             System.Console.WriteLine($"Number Of Units Consumed: {nunit} ");
        }

        // Method Calculating EB Bill
        public double CalculateAmount()
        {
            double amount=0;
            if(UnitsConsumed < 0)
            {
                System.Console.WriteLine("Free No Need To Pay Any Charages.");
                
            }
            else if(UnitsConsumed>=100 && UnitsConsumed <200)
            {
                amount = UnitsConsumed*3;
            }
            else if(UnitsConsumed>=200 && UnitsConsumed <400)
            {
                amount = UnitsConsumed*5;
            }else if(UnitsConsumed> 400)
            {
                amount = UnitsConsumed*6;
            }
            return amount;
        }

    }
}