using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public class UserDetails
    {
        // Felid
        private static int s_userId = 1000;

        // Property
        public string UserID { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public long PhoneNumber { get; set; }
        public double Balance { get; set; }

        // Constructor

        public UserDetails(string name, int age, string city, long phoneNumebr, double balance)
        {
            s_userId++;
            UserID ="UID"+s_userId;
            UserName = name;
            Age = age;
            City = city;
            PhoneNumber = phoneNumebr;
            Balance = balance;
        }

        // Constructor for files

        public UserDetails(string data)
        {
            string[] values = data.Split(",");
            s_userId = int.Parse(values[0].Remove(0,3));
            UserID = values[0];
            UserName = values[1];
            Age = int.Parse(values[2]);
            City = values[3];
            PhoneNumber = long.Parse(values[4]);
            Balance = double.Parse(values[5]);
        }

        //
    }
}