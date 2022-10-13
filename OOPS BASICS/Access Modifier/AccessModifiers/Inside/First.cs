using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Outside;

namespace Inside
{
    public class First:Third
    {
        public int PublicNumber =10;

        private int PrivateNumber =20;

        //  use property to get private element
        public int PrivateNumber2 { get{return PrivateNumber;} }

        internal int InternalNumber = 21;
        protected int ProtectedNumber = 31;
         
         // Use Property to get  Protected internal element
        public int ProtectedInternal2 {get{return ProctectedInternalNumber;}}
    }
}