using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchyInhertiance
{
    public class CustomerDetails:PersonalDetails
    {
        private static int s_customerId = 12300;

        public string CustomerId { get; set; }
        public double Balance { get; set; }


        // contructor

        public CustomerDetails(string aid,string name, string fatherName, Gender gender, long mobileNumbe):base(aid, name,fatherName, gender, mobileNumbe)
        {
            s_customerId++;
            CustomerId= "CID"+s_customerId;
        }

        // method
        public void Recharge()
        {
            System.Console.WriteLine("Enter Amount to be Reacharge");
            Balance =double.Parse(Console.ReadLine());
        }

        public void ShowCustomer()
        {
           
            System.Console.WriteLine($"Customer ID:{CustomerId}");
            ShowDetails();   // show personal Details from the method ShowDetails of the person
            System.Console.WriteLine($"Balance:{Balance}");
        }
    }
}