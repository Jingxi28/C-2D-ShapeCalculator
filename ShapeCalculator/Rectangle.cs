using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    public class Rectangle : Shape//derived class which inherited from Shape class
    {
        //A Rectangle is defined by a length and height values
        public double Length;
        public double Height;

        public Rectangle()//create a constructor for Rectangle class
        {
            //set the initial value of length and height equal to 0
            Length = 0;
            Height = 0;

        }
        //create another constructor with two parameters
        public Rectangle(double length, double height)
        {
            Length = length;
            Height = height; 
        }
        public override double GetArea()//this is override method
        {
            //the body of GetArea() is provied here
            return Length * Height;
        }

        public override double GetPerimeter()//this is another override method
        {
            //the body of GetPerimeter() is provied here
            return 2 * (Length + Height);
        }
    }
}
