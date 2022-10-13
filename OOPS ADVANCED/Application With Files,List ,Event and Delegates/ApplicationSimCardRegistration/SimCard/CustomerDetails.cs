using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimCard
{
    public enum  Gender{Default ,Male,Female,Transgender}
    public class CustomerDetails
    { 
        // Field
        private static int s_customerId = 2300;
        private static long s_mobileNUmber = 7840450000;
        // Property
        public string CustomerID { get; set; }
        public string Name { get; set; }
        public long AadtharNumber { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
       public long Mobile { get; set; }

        //Constructor

        public CustomerDetails(string name, long aadtharNumber, int age ,Gender gender, string address)
        {
            s_customerId++;
            CustomerID = "CID"+s_customerId;
            Name = name;
            AadtharNumber = aadtharNumber;
            Age = age;
            Gender = gender;
            Address = address;
            s_mobileNUmber++;
            Mobile = s_mobileNUmber;
            
        }

        // constructor for files
        public CustomerDetails(string item)
        {
            string [] values = item.Split(',');
            s_customerId = int.Parse(values[0].Remove(0,3));
            CustomerID = values[0];
            Name = values[1];
            AadtharNumber = long.Parse(values[2]);
            Age = int.Parse(values[3]);
            Gender= Enum.Parse<Gender>(values[4]);
            Address = values[5];
            Mobile = long.Parse(values[6]);

        }
     // Method
        public void ShowDetails()
        {
            System.Console.WriteLine($"Customer ID:{CustomerID}");
            System.Console.WriteLine($"Customer Name:{Name}\nAadtharNumber: {AadtharNumber}\nAge:{Age}\nGender:{Gender}\nAddress:{Address}\n\n");
        }

        public void Eligible()
        {
            if(Age > 18)
            {
                System.Console.WriteLine("You Are Eligible\n\n");
            }
            else{
                System.Console.WriteLine("Your Are Not Elligible\n\n");
            }
        }
    }
}