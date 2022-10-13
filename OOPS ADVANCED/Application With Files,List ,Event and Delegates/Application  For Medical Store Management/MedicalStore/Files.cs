using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace MedicalStore
{
    public static class Files
    {
        // Create Files
        public static void Create()
        {
            if(!Directory.Exists("MedicalStore"))
            {
                System.Console.WriteLine("Creating Folder For MedicalStore, You Can Access  All the List in the Folder");
                Directory.CreateDirectory("MedicalStore");  // Creating New Folder
            }
            // Creating New File for UserDetails
            if(!File.Exists("MedicalStore/UserDetails.csv"))
            {
                System.Console.WriteLine("Creating New File For UserDetails");
                File.Create("MedicalStore/UserDetails.csv");  // Creating New Files For UserDetails
            }
            // creating New File For MedicineDetails
            if(!File.Exists("MedicalStore/MedicineDetails.csv"))
            {
                System.Console.WriteLine("Creating New File For MedicineDetails");
                File.Create("MedicalStore/MedicineDetails.csv");  // created New Files For MedicineDetails.
            }
            // Creating New Files For OrderDetails
            if(!File.Exists("MedicalStore/OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating New File For OrderDetails");
                File.Create("MedicalStore/OrderDetails.csv"); // Created new File for  OrderDetails
            }
        }  

        // Read All Files in a List
        public static void Read()
        {  // use Foreach Loop to Read all the lines in the list
            // Read user Details  

            string[] users = File.ReadAllLines("MedicalStore/UserDetails.csv");
            foreach (var data in users)
            {
                UserDetails user = new UserDetails(data);  // Create Parameterised Constructor in Userdetails to access via single parameter
                Procedure.userList.Add(user);
            }



            // Read Medicine Details // create Parameterized Constructor in Medicine Details to access via single Parameter
            string[] tablets = File.ReadAllLines("MedicalStore/MedicineDetails.csv");
            foreach (var data in tablets)
            {
                MedicineDetails medicine = new MedicineDetails(data);
                Procedure.medicineList.Add(medicine);
            }



            // Read Order Details // Create Parametrized Constructor in OrderDetails To access with single parameter.
            string[] orders = File.ReadAllLines("MedicalStore/OrderDetails.csv");
            foreach (var data in orders)
            {
                OrderDetails newOrder = new OrderDetails(data);
                Procedure.orderList.Add(newOrder);
            }


        }
        // To Write Files
        public static void Write()  // use For loop to write all the lines in the list
        {


            // write in userList
            string[] userDetails =new string[Procedure.userList.Count];  // create new string object with userlist size
            for(int i=0;i<Procedure.userList.Count;i++)
            {
                /* UserID ="UID"+s_userId;UserName = name;Age = age;City = city;PhoneNumber = phoneNumebr;Balance = balance; */
                userDetails[i] = Procedure.userList[i].UserID+","+Procedure.userList[i].UserName+","+Procedure.userList[i].Age+","+Procedure.userList[i].City+","+Procedure.userList[i].PhoneNumber+","+Procedure.userList[i].Balance;
            }
            File.WriteAllLines("MedicalStore/UserDetails.csv",userDetails);



            // Write in medicineList
            string[] medicineDetails = new string[Procedure.medicineList.Count]; // create new string object with medicineList size
            for(int i=0;i<Procedure.medicineList.Count;i++)
            {
                /* MedicineID = "MID"+s_medicineId;MedicineName = medicineName;AvailableCount = availableCount;Price = price;ExpiryDate = expirydate; */
                medicineDetails[i] = Procedure.medicineList[i].MedicineID+","+ Procedure.medicineList[i].MedicineName+","+ Procedure.medicineList[i].AvailableCount+","+ Procedure.medicineList[i].Price+","+ Procedure.medicineList[i].ExpiryDate.ToShortDateString();
            }
            File.WriteAllLines("MedicalStore/MedicineDetails.csv",medicineDetails);



            // Write in OrderDetails

            string[] orderDetails = new string[Procedure.orderList.Count];// create new string object with OrderList size
            for(int i=0;i<Procedure.orderList.Count;i++)
            {
                /*  OrderID ="OID"+s_orderId;UserID = userId;MedicineID = medicineId;MedicineCount = medicineCount;TotalPrice = totalprice;OrderDate = orderDate;OrderStatus = orderStatus; */
                orderDetails[i] = Procedure.orderList[i].OrderID+","+Procedure.orderList[i].UserID +","+Procedure.orderList[i].MedicineID+","+Procedure.orderList[i].MedicineCount+","+Procedure.orderList[i].TotalPrice +","+Procedure.orderList[i].OrderDate.ToString("dd/MM/yyyy")+","+Procedure.orderList[i].OrderStatus;
            }
            File.WriteAllLines("MedicalStore/OrderDetails.csv",orderDetails);
       
       
        }   
    }
}