using System;

namespace OnlineGrocery
{
    public interface IBalance
    {
        // Property
         double WalletBalance { get; set; }

         //Method
         void WalletRecharge();
    }
}