using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
///   collegeadmission
/// </summary>
namespace CollegeAdmission
{
    public enum  Gender{Default ,Male,Female,Transgender}
       public class StudentDetails
    {
        //private string _name; //   field
        private static int s_studentId =3000;
        //public String Name { get{return _name;} set{_name = value;} }

        public string StudentId { get; } // Read Only Property
        public string Name { get; set; }  // Auto property
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public int ChemistryMark { get; set; }
        public int MathsMark { get; set; }
        public int PhysicsMark { get; set; }


    
        
       // Parameterised Constructor
        public StudentDetails(string name, string fatherName, DateTime dob, Gender gender, int chemistryMark, int physicsMark , int mathsMark)
        {
            s_studentId++;
            StudentId ="SF"+ s_studentId;
            Name = name;
            FatherName = fatherName;
            DOB = dob;
            Gender = gender;
            ChemistryMark = chemistryMark;
            PhysicsMark = physicsMark;
            MathsMark = mathsMark;  
        }

        // for files constructor
        public StudentDetails(string data)
        {
            string[] values = data.Split(',');
            s_studentId = int.Parse(values[0].Remove(0,2));  // to remove two string from SF3003 / you have CID4444 remove(0,3);
            StudentId = values[0];
            Name = values[1];
            FatherName = values[2];
            DOB = DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            Gender = Enum.Parse<Gender>(values[4]);
            ChemistryMark = int.Parse(values[5]);
            PhysicsMark = int.Parse(values[6]);
            MathsMark = int.Parse(values[7]);
        }
        public void ShowDetails()
        {
          System.Console.WriteLine($"Register Number: {StudentId}");
          System.Console.WriteLine($"Student Name:{Name}\nFather Name:{FatherName}\nDate of birth: {DOB.ToString("d")}\nGender: {Gender}\nChemistry mark: {ChemistryMark}\nPhysics Mark: {PhysicsMark}\nMaths Mark :{MathsMark}");
        }
        
        // To Create Method  for check eligiblity
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