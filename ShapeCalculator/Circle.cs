using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    public class Circle : Shape//derived class which inherited from Shape class
    {
        //A Circle Class is defined by a radius value
        public double Radius;

        public Circle() //create a constructor for Circle class
        {
            //set the initial value of radius equals to 0
            Radius = 0;
        }
        public Circle( double radius)//create another constructor with one parameters
        {
            Radius= radius;
        }
        public override double GetArea()//this is override method
        {
            //the body of GetArea() is provied here
            return Math.PI * Math.Pow(Radius,2);
        }
        public override double GetPerimeter()//this is another override method
        {
            //the body of GetPerimeter() is provied here
            return 2 * Math.PI * Radius;
        }
    }
}
