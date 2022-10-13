using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public class MedicineDetails
    {
        //Feild
        private static int s_medicineId = 100;

        // Property
        public string MedicineID { get; set; }
        public string MedicineName { get; set; }
        public int AvailableCount { get; set; }
        public double Price { get; set; }
        public DateTime ExpiryDate { get; set; }

        // Constructor

        public MedicineDetails(string medicineName,int availableCount,double price, DateTime expirydate)
        {
            s_medicineId++;
            MedicineID = "MID"+s_medicineId;
            MedicineName = medicineName;
            AvailableCount = availableCount;
            Price = price;
            ExpiryDate = expirydate;
        } 
        // Constructor For Files

        public MedicineDetails(string data)
        {
            string [] values = data.Split(",");
            s_medicineId = int.Parse(values[0].Remove(0,3));
            MedicineID = values[0];
            MedicineName = values[1];
            AvailableCount = int.Parse(values[2]);
            Price = double.Parse(values[3]);
            ExpiryDate = DateTime.ParseExact(values[4],"dd/MM/yyyy",null);
        }
    }
}