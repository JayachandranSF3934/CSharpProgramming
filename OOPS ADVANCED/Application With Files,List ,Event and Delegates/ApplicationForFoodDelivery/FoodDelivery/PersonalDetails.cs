using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery
{
    // enum for gender
    public enum Gender{Default,Male,Female,Others}
    public class PersonalDetails
    {
        /* : Name, FatherName, Gender, Mobile, DOB, MailID, Location*/
        // Property
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long Mobile { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }

        //contructor
        public PersonalDetails(string name, string fatherName, Gender gender,long mobile,DateTime dob,string email,string location)
        {
            Name = name;
            FatherName = fatherName;
            Gender =gender;
            Mobile =mobile;
            DOB= dob;
            Email=email;
            Location =location;
        }
        public PersonalDetails()
        {
            
        }

    }
}