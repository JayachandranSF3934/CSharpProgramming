using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student
{
    public enum Branch{Default,Science,Arts}
    public class StudentDetails:PersonDetails
    {
        private static int s_registerNumber = 123000;
        public int RegisterNumber { get; set; }
        public string Standard { get; set; }
        public Branch Branch { get; set; }
        

        // Contrucotr

        public StudentDetails(string name, string fatherName,long phoneNumber,string email, DateTime dob,Gender gender,string standard,Branch branch):base(name,fatherName,phoneNumber,email,dob,gender)
        {
            s_registerNumber++;
            RegisterNumber =s_registerNumber;
            Standard = standard;
            Branch = branch;
           
        }

        public void ShowStudentDetails()
        {
            System.Console.WriteLine($"Register Number:{RegisterNumber}");
            ShowPersonDetail();
            System.Console.WriteLine($"Standard:{Standard}\nBranch:{Branch}");
        }
        
    }
}