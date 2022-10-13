using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public interface IMarkDetails   // NO Constructor No Objects No Fields
    {
      int ChemistryMark { get; set; }    // Property
      int PhysicsMark { get; set; }
      int MathsMark { get; set; }
      int Total { get; set; }
      double Average { get; set; }
          
     

      void GetMark(int chemistryMark,int physicsmark, int mathsMark);
      void Calculate();   // Method Decalartion
      void ShowMark();


    }
}