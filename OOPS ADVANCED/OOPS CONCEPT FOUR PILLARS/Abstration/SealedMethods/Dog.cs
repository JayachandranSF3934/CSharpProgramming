using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedMethods
{
    public class Dog:Animal
    {
        // to seal a method  new keyword is used to 
        public new void MakeSound()   //method overloading   // new keyword is used to sealed the method  
        {
            System.Console.WriteLine("Dog Sound");
        }
    }
}