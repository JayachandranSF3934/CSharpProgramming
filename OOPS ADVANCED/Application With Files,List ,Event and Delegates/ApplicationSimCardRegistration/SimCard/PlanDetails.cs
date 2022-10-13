using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimCard
{
    public class PlanDetails
    {
        public string PlanId { get; set; }
        public int PlanAmount { get; set; }
        public string PlanName { get; set; }
        public string Benefit { get; set; }
        public string Validity { get; set; }

        // constructor

        public PlanDetails(string planid,int amount, string name, string benefit, string validity)
        {
            
            PlanId = planid;
            PlanAmount = amount;
            PlanName = name;
            Benefit = benefit;
            Validity = validity;
        }

        public PlanDetails(string item)
        {
            string[] values = item.Split(',');
            
            PlanId = values[0];
            PlanAmount = int.Parse(values[1]);
            PlanName = values[2];
            Benefit = values[3];
            Validity = values[4];
        }

        public void ShowPlanDetails()
        {
            System.Console.WriteLine($"Plan Id:{PlanId}\tPlan Amount:{PlanAmount}\tPlan Name:{PlanName}\tBenefits:{Benefit}\tValidity:{Validity} ");
        }
    }
}