using System;

namespace MovieTicket
{
    /// <summary>
    /// Userdetails class inherit Personal Details and Interafe Wallet
    /// </summary>
    public class UserDetails:PersonalDetails,IWallet
    {
        private static int s_userID =1000;

        public string UserID { get; set; }
        public double WalletBalance { get; set; }
        //constructor
        /// <summary>
        /// User Details Constructor Perform some Autoincreamnet operation
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public UserDetails(string  name, int age, long phoneNumber):base( name, age, phoneNumber)
        {
            s_userID++;
            UserID = "UID"+s_userID;
            
            
        }
        /// <summary>
        /// Constructor for User Details
        /// </summary>
        /// <param name="data"></param>
        public UserDetails(string data)
        {
            string[]values =data.Split(",");
            s_userID = int.Parse(values[0].Remove(0,3));
            UserID = values[0];
            Name = values[1];
            Age = int.Parse(values[2]);
            PhoneNumber = long.Parse(values[3]);
            WalletBalance = double.Parse(values[4]);


        }

        //Method for wallet Balance
        /// <summary>
        /// /// Recharge wallet MEthod Declaration which was initialized in Iwallet and declaration are done here
        /// </summary>
        public  void RechargeWallet()
        {
            System.Console.WriteLine("\nEnter Amount to be recharged to your Account:");
            
            WalletBalance  = double.Parse(Console.ReadLine());
        }


    }
}