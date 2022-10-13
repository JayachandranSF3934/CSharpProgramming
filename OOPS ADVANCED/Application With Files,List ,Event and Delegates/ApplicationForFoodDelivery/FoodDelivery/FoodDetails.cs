using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery
{
    public class FoodDetails
    {
        // field
        private static int s_foodID = 100;
        //propeerty
        public string FoodID { get; set; }
        public string FoodName { get; set; }
        public double PricePerQuantity { get; set; }

        //Constructor
        public FoodDetails(string foodName,double pricePerQuantity)
        {
            s_foodID++;
            FoodID = "FID"+s_foodID;
            FoodName = foodName;
            PricePerQuantity =pricePerQuantity;
        }
        //Files Comstructor
        public FoodDetails(string item)
        {
            string[] values = item.Split(",");
            s_foodID = int.Parse(values[0].Remove(0,3));
            FoodID = values[0];
            FoodName = values[1];
            PricePerQuantity = double.Parse(values[2]);
        }

        
    }
}