using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank
{
    public enum Gender{Male,Female,Others}
    public class PersonDetails
    {
        // property
        public string Name { get; set; }   
        public string FatherName { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }

        // constructor
        public PersonDetails(string name, string fatherName,long phoneNumber,string email, DateTime dob,Gender gender)
        {
            Name = name;
            FatherName = fatherName;
            PhoneNumber = phoneNumber;
            Email = email;
            DOB = dob;
            Gender = gender;
        }  
        
        public void ShowPersonDetail()
        {
            System.Console.WriteLine($"\nName:{Name}\nFatherName: {FatherName}\nPhoneNumber: {PhoneNumber}\nEmail: {Email}\nDate of birth: {DOB.ToString("d")}\nGender: {Gender}");
        }  //Date of birth: {DOB.ToString("d")}
    }
}