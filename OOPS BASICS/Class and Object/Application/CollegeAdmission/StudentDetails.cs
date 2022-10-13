using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public class StudentDetails
    {
        //private string _name; //   field

        private static int s_registerNumber =3000;

        //public String Name { get{return _name;} set{_name = value;} }

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


        // Default Constructor

        public StudentDetails()
        {
            Name = "Your Name";   // name should in pascal case
            FatherName = "Your Father Name";
        }
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
        public void ShowDetails()
        {
            System.Console.WriteLine($"Register Number: {RegisterNumber}");
          System.Console.WriteLine($"Student Name:{Name} \n Father Name:{FatherName} \n Mother Name:{MotherName} \n Date of birth: {DOB} \n Gender: {Gender} \n Mobile No: {MobileNo} \n Mail Id: {Mail} \n Chemistry mark: {ChemistryMark} \n Physics Mark: {PhysicsMark} \n Maths Mark :{MathsMark}");
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