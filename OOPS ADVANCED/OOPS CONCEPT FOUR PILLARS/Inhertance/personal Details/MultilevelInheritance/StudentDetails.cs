using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public enum Department{Default,EEE,CSE,MECH,ECE}
    public class StudentDetails:PersonalDetails,IMarkDetails // inherited PersonalDetail in StudentDetails  // IMarkdetails  is interface used to 
    {
        private static int s_studentId = 2000;
        public string StudentId { get; set; }
        public Department Department { get; set; }
        public string Year { get; set; }


        public int ChemistryMark { get; set; }    // Property
        public int PhysicsMark { get; set; }
        public int MathsMark { get; set; }
        public int Total { get; set; }
        public double Average { get; set; }


        // Parameterised Contructor

        public StudentDetails(string aid,string name,string fatherName,Gender gender,long mobileNumber,Department department,string year):base(aid,name,fatherName,gender,mobileNumber)  // use base keyword to reusing  // clearly type the order the of base class by means of
        {
            s_studentId++;
            StudentId = "SID"+s_studentId;
            Department = Department;
            Year = year;
        }

        // method for employyementdetails   // 
        public StudentDetails(string studentId,string aid,string name,string fatherName,Gender gender,long mobileNumber,Department department):base(aid,name,fatherName,gender,mobileNumber)  // use base keyword to reusing  // clearly type the order the of base class by means of
        {
            StudentId = studentId;
            Department = Department;   
        }


        // method for Imarkdetails
        public void GetMark(int chemistryMark, int physicsmark, int mathsMark)
        {
            ChemistryMark = chemistryMark;
            PhysicsMark = physicsmark;
            MathsMark = mathsMark;
        }

        public void Calculate()
        {
            Total = ChemistryMark+PhysicsMark+MathsMark;
            Average =(double)Total/3.0;
        }

        public void ShowMark()
        {
            System.Console.WriteLine($"Physics Mark:{PhysicsMark}\nChemistry Mark:{ChemistryMark}\nMaths mark:{MathsMark}\nTotal Mark:{Total}\nAverage:{Average}\n");
        }

        // method

        public void ShowStudent()
        {
        
            System.Console.WriteLine($"StudentID: {StudentId}");
            ShowDetails();
            System.Console.WriteLine($"Department:{Department}\nYear:{Year}");
        }

        public void ShowStudentDetails()
        {
        
            System.Console.WriteLine($"StudentID: {StudentId}");
            ShowDetails();
            System.Console.WriteLine($"Department:{Department}");
        }
    }
}