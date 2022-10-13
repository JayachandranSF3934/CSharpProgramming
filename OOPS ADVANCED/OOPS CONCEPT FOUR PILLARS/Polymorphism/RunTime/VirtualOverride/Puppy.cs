using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedMethods
{
    public class Puppy:Animal
    {
         public override void MakeSound()   //method overloading
        {
            System.Console.WriteLine("Puppy Sound");
        }
    }
}