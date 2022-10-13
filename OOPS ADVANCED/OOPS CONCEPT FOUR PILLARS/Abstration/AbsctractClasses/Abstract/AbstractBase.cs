using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract
{  
    public  abstract class AbstractBase  // add anstract
    {
        // Filed not present in Abstract classes
        protected string name;  // Normal Feild

        public abstract string Name { get; set; } // Abstract Property
        public double  Amounnt { get; set; } // Normal Property
        
        // method
        public void Display()  // Normal Method
        {
            System.Console.WriteLine(name);   // display normal field in this method
        }
        // Abstract method // no defintion are there bcoz its abstrat method
        public abstract void Salary(int dates);  // In Abstract Method no defintion are Takes Places only
    }
}