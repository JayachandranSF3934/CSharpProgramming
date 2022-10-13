using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedMethods
{
    public class Animal  // base class
    {
        public  virtual void MakeSound()  // method
        {
            System.Console.WriteLine("Animal Sound");
        }
    }
}