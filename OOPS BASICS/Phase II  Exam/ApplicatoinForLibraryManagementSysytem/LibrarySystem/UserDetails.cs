using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem
{
     public enum  Gender{Default ,Male,Female,Transgender}
    public enum Department{Default, ECE,EEE,CSE}
    public class UserDetails
    {
        private static int s_registerId = 3000;  // field

        public string Name { get; set; }  // property
        public string RegisterId { get; set; }
        public Gender Gender { get; set; }
        public Department DepartmentName { get; set; }
        public long MobileNumber { get; set; }
        public string EmailId { get; set; }

        // constructor

        public UserDetails (string name, Gender gender, Department departmentName,long mobileNumber,string emailId)
        {
            s_registerId++;
            RegisterId = "SF"+s_registerId;
            Name = name;
            Gender = gender;
            DepartmentName = departmentName;
            MobileNumber = mobileNumber;
            EmailId = emailId;

        }
        
    }
}