using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class StudentDetails
    {
        // Parameterised Constructor
        public StudentDetails(string name, string fatherName, DateTime dob, Gender gender, int chemistryMark, int physicsMark , int mathsMark)
        {
            s_studentId++;
            StudentId = "SF-"+ s_studentId;
            Name = name;
            FatherName = fatherName;
            DOB = dob;
            Gender = gender;
            ChemistryMark = chemistryMark;
            PhysicsMark = physicsMark;
            MathsMark = mathsMark;  
        }
    }
}