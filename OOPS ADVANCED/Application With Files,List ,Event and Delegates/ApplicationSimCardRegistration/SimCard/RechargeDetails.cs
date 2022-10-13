using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimCard
{
    public enum RechargeStatus {Default, PaymentPending, NoActivePlan}
    public class RechargeDetails
    {
      
        public long Mobile { get; set; }
        public string PlanId { get; set; }
        public DateTime RechargeDate { get; set; }
        public RechargeStatus Status { get; set; }

        //constructor
        public RechargeDetails(long mobile, string planid,DateTime date, RechargeStatus status)
        {
           
            Mobile = mobile;
            PlanId = planid;
            RechargeDate = date;
            Status = status;
        }

        // construcor for files
        public RechargeDetails(string item)
        {
            string[] values = item.Split(',');
            Mobile = long.Parse(values[0]);
            PlanId = values[1];
            RechargeDate =DateTime.ParseExact(values[2],"dd/MM/yyyy",null);
            Status =Enum.Parse<RechargeStatus>(values[3]);
        }
    }
}