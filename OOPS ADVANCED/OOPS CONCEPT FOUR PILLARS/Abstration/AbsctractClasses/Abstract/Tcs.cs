using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract
{
    public class Tcs:AbstractBase
    {
         // Abstract Property Defintion
        public override string Name { get{return name;} set{name = value;} }   // define set and get
         // Abstract method defintion
        public override void Salary(int dates)   // override is important for abstract classs
        {
            Display();
            Amounnt = (double)dates*300;
            System.Console.WriteLine(Amounnt);
        }
    }
}