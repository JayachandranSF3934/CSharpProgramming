using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class StudentDetails
    {
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
    }
}