using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    public class Trapezoid : Shape//derived class which inherited from Shape class
    {
        //A Trapezoid class is defined by 5 values
        public double SideA;
        public double SideB;
        public double BaseA;
        public double BaseB;
        public double Height;

        public Trapezoid()//create a constructor for Trapezoid class
        {
            //set the initial value of SideA, SideB, BaseA, BaseB, Height equal to 0
            SideA = 0;
            SideB= 0;
            BaseA= 0;
            BaseB= 0;
            Height= 0;
        }
        //create another constructor with multiple parameters
        public Trapezoid(double sideA, double sideB, double baseA, double baseB, double height)
        {
            SideA= sideA;
            SideB= sideB;
            BaseA= baseA;
            BaseB= baseB;
            Height= height;
        }
        public override double GetArea()//this is override method
        {
            //the body of GetArea() is provied here
            return Height *(BaseA+BaseB)/2;
        }
        public override double GetPerimeter()//this is another override method
        {
            //the body of GetPerimeter() is provied here
            return SideA + SideB + BaseA + BaseB; 
        }
    }
}
