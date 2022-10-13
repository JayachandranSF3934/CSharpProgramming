using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace SimCard
{
    public static class Files   // class  must be static to used in procedure class
    {
        // Create File and folder
        public static void Create()
        {  
            // New Folder
            if(!Directory.Exists("SimCardDetails"))
            {
                System.Console.WriteLine("Creating SimCard Registeration Details Folder");
                Directory.CreateDirectory("SimCardDetails");    // Folder Created
            }
            // New Plan File
            if(!File.Exists("SimCardDetails/PlanDetails.csv"))
            {
                System.Console.WriteLine("Creating New  Plan Details File");
                File.Create("SimCardDetails/PlanDetails.csv");
            }
            // New Customer Files
            if(!File.Exists("SimCardDetails/CustomerDetails.csv"))
            {
                System.Console.WriteLine("Creating New Customer Details File");
                File.Create("SimCardDetails/CustomerDetails.csv");
            }
            // New Recharge Files
            if(!File.Exists("SimCardDetails/RechargeDetails.csv"))
            {
                System.Console.WriteLine("Creating New Recharge File");
                File.Create("SimCardDetails/RechargeDetails.csv");
            }  
        }

        // Read file
        public static void Read()
        {
            // Plan details Read
            string[] plans = File.ReadAllLines("SimCardDetails/PlanDetails.csv");
            foreach (var item in plans)
            {
                PlanDetails plan = new PlanDetails(item);
                Procedure.planList.Add(plan);
            }
            // Customer details Read
            string [] customers = File.ReadAllLines("SimCardDetails/CustomerDetails.csv");
            foreach (var item in customers)
            {
                CustomerDetails customer = new CustomerDetails(item);
                Procedure.customList.Add(customer);
            }

            // Recharge Detail Read
            string[] recharges = File.ReadAllLines("SimCardDetails/RechargeDetails.csv");
            foreach (var item in recharges)
            {
                RechargeDetails recharge = new RechargeDetails(item);
                Procedure.rechargeList.Add(recharge);
            }
        }

        // Write File

        public static void Write()
        {
            // write plandetails
            string [] planDetails = new string[Procedure.planList.Count];
            for(int i=0;i<Procedure.planList.Count;i++)
            {
                planDetails[i] = Procedure.planList[i].PlanId+","+Procedure.planList[i].PlanAmount+","+Procedure.planList[i].PlanName+","+Procedure.planList[i].Benefit+","+Procedure.planList[i].Validity;
            }
            File.WriteAllLines("SimCardDetails/PlanDetails.csv",planDetails);

            // Customerdetils
            string [] customerDetails = new string[Procedure.customList.Count];
            for(int i=0;i<Procedure.customList.Count;i++)
            {
                customerDetails[i] = Procedure.customList[i].CustomerID+","+Procedure.customList[i].Name+","+Procedure.customList[i].AadtharNumber+","+Procedure.customList[i].Age+","+Procedure.customList[i].Gender+","+Procedure.customList[i].Address+","+Procedure.customList[i].Mobile;
            }
            File.WriteAllLines("SimCardDetails/CustomerDetails.csv",customerDetails);

            // Recharge Details
            string[] rechargeDetails = new string[Procedure.rechargeList.Count];
            for(int i=0;i<Procedure.rechargeList.Count;i++)
            {
                rechargeDetails[i] = Procedure.rechargeList[i].Mobile+","+Procedure.rechargeList[i].PlanId+","+Procedure.rechargeList[i].RechargeDate.ToString("dd/MM/yyyy")+","+Procedure.rechargeList[i].Status;
            }
            File.WriteAllLines("SimCardDetails/RechargeDetails.csv",rechargeDetails);

        }

       
    }
}