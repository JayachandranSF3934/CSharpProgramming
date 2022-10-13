using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// HierarchyInheritance
namespace HierarchyInhertiance
{
    public enum  Gender{Default ,Male,Female,Others}
    public class PersonalDetails
    {
        private static int s_aatharId = 10010;
        public string AatharId { get; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long MobileNumber { get; set; }

        //  Parameterized constructor 
        public PersonalDetails(string name, string fatherName, Gender gender, long mobileNumber)
        {
            s_aatharId++;
            AatharId ="AID"+s_aatharId;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            MobileNumber = mobileNumber;

        }

        // another paramterised constructor for inheritance
         public PersonalDetails(string aid,string name, string fatherName, Gender gender, long mobileNumber)  // used for inheritance // in the inherited class wwe want aadthar id
        {
            AatharId =aid;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            MobileNumber = mobileNumber;

        }

        // show Details method
        public  void ShowDetails()
        {
        System.Console.WriteLine($"Aathar Id: {AatharId}\n\nName:{Name}\nFatherName: {FatherName}\nGender: {Gender}\nMobile numer:{MobileNumber}");          
        }
    }
}