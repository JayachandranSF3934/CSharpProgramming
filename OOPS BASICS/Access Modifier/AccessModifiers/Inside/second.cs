using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inside
{
    // inherited first class in second class for sharing protected number
    public class second:First
    {
        public int ProtectedOutput { get {return ProtectedNumber;} }
    }
}