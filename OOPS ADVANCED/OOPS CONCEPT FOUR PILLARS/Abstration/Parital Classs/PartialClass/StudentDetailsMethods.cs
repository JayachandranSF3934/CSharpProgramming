using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass 
{
    public partial class StudentDetails
    {
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