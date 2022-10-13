using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public class Draw:IRectangle
    {
        public int Area { get; set; }
        public int Length { get; set; }
        public int Breadth { get; set; }

        public void GetData(int length, int breadth)
        {
            Length = length;
            Breadth = breadth;
        }


        public void CalulateArea()
        {
            Area = Length*Breadth;
            System.Console.WriteLine("Area:  "+Area);
        }
    }
    
}