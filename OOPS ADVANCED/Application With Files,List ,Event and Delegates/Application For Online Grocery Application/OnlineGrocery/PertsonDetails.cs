using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGrocery
{
    public enum  Gender{Default,Male,Female,Others}
    public class PertsonDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long MobileNumber { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }

        //default constructor
        public PertsonDetails()
        {

        }

        public PertsonDetails(string name, string fatherName,Gender gender,long mobile, DateTime dob, string email)
        {
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            MobileNumber = mobile;
            DOB =dob;
            Email = email;

        }
    }
}