using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public enum Department{Default,EEE,CSE,MECH,ECE}
    public class StudentDetails:PersonalDetails  // inherited PersonalDetail in StudentDetails
    {
        private static int s_studentId = 2000;
        public string StudentId { get; set; }
        public Department Department { get; set; }
        public string Year { get; set; }


        // Parameterised Contructor

        public StudentDetails(string aid,string name,string fatherName,Gender gender,long mobileNumber,Department department,string year):base(aid,name,fatherName,gender,mobileNumber)  // use base keyword to reusing  // clearly type the order the of base class by means of
        {
            s_studentId++;
            StudentId = "SID"+s_studentId;
            Department = department;
            Year = year;
        }

        // method

        public void ShowStudent()
        {
        
            System.Console.WriteLine($"StudentID: {StudentId}");
            ShowDetails();
            System.Console.WriteLine($"Department:{Department}\nYear:{Year}");
        }
    }
}