using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract
{
    public class Syncfusion:AbstractBase
    {
        // Abstract Property Defintion
        public override string Name { get{return name;} set{name = value;} }
         // Abstract method defintion
        public override void Salary(int dates)
        {
            Display();
            Amounnt = (double)dates*500;
            System.Console.WriteLine(Amounnt);
        }
    }
}