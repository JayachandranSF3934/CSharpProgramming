using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public class StudentDetails
    {
        private static int s_registerNumber =3000;
        public string RegisterNumber { get; } // Read Only Property
        public string Name { get; set; }  // Auto property
        public String FatherName { get; set; }
        public string MotherName { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public long MobileNo { get; set; }
        public string Mail { get; set; }
        public int ChemistryMark { get; set; }
        public int MathsMark { get; set; }
        public int PhysicsMark { get; set; }


       // Parameterised Constructor
        public StudentDetails(string name, string fatherName, string motherName, DateTime dob, string gender, long mobileNo , string mail, int chemistryMark, int physicsMark , int mathsMark)
        {
            s_registerNumber++;
            RegisterNumber = "SF"+ s_registerNumber;
            Name = name;
            FatherName = fatherName;
            MotherName =motherName;
            DOB = dob;
            Gender = gender;
            MobileNo = mobileNo;
            Mail = mail;
            ChemistryMark = chemistryMark;
            PhysicsMark = physicsMark;
            MathsMark = mathsMark;  
        }

        // To Create Method 

        public bool CheckEligible(double cutOff)
        {
            double average = (double)(ChemistryMark+PhysicsMark+MathsMark)/3.0;
            if(average >=cutOff)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

    }
}