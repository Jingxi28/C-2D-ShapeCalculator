using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    public class Square : Shape//derived class which inherited from Shape class
    {
        //A Square Class is defined by Length value
        public double Length;

        public Square() //create a constructor for Square class
        {
            //set the initial value of Length equals to 0
            Length = 0;
        }

        //create another constructor with one parameters
        public Square(double length)
        { 
            Length= length;
        }

        public override double GetArea()//this is override method
        {
            //the body of GetArea() is provied here
            return Length * Length;
        }

        public override double GetPerimeter()//this is another override method
        {
            //the body of GetPerimeter() is provied here
            return 4 * Length; 
        }

    }
}
