using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery
{
    public interface IBalance
    {
        // Property
         double WalletBalance { get; set; }

         //Method
         void WalletRecharge();
    }
}