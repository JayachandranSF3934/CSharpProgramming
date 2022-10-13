using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Box
    {
        // felids
        private double length;
        private double breadth;
        private double height;

        // Constructor

        public Box()
        {
            
        }
        public Box(double lengthOne,double breadthOne, double heightOne)
        {
            length = lengthOne;
            breadth =breadthOne;
            height = heightOne;

        }

        public double CalculateVolume()
        {
            return length*breadth*height;
        }


// overload +operator to add two Box objects  // not more than two objects to be taken
        public static Box operator+(Box box1,Box box2)
        {
            Box box = new Box();
            box.length = box1.length + box2.length;
            box.breadth = box1.breadth+box2.breadth;
            box.height = box1.height+box2.height;
            return box;
        }

    }
}