using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeCalculator;
using System;

namespace unitTest_2D_shape_calc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Rect_Area()
        {
            Shape shape;
            shape = new Rectangle(2, 3);//Arange
            var result = shape.GetArea();//Act
            Assert.AreEqual(6, result); //Assert
        }
        [TestMethod]
        public void Rect_Area1()
        {
            Shape shape;
            shape = new Rectangle(-15, -14);//Arange
            double expect = 0;
            var result = shape.GetArea();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Rect_Area2()
        {
            Shape shape;
            shape = new Rectangle(-0.01, -0.02);//Arange
            double expect = 0;
            var result = shape.GetArea();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Rect_Area3()
        {
            Shape shape;
            shape = new Rectangle(0, 0);//Arange
            double expect = 0;
            var result = shape.GetArea();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Rect_Area4()
        {
            Shape shape;
            shape = new Rectangle(0.01, 0.02);//Arange
            double expect = 0.0002;
            var result = shape.GetArea();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Rect_Area5()
        {
            Shape shape;
            shape = new Rectangle(20, 25);//Arange
            double expect = 500;
            var result = shape.GetArea();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Rect_Perimeter()
        {
            Shape shape;
            shape = new Rectangle(2, 3);//Arange
            var result = shape.GetPerimeter();//Act
            Assert.AreEqual(10, result); //Assert
        }
        [TestMethod]
        public void Rect_Perimeter1()
        {
            Shape shape;
            shape = new Rectangle(-15, -14);//Arange
            double expect = 0;
            var result = shape.GetPerimeter();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Rect_Perimeter2()
        {
            Shape shape;
            shape = new Rectangle(-0.0001, -0.0002);//Arange
            double expect = 0;
            var result = shape.GetPerimeter();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Rect_Perimeter3()
        {
            Shape shape;
            shape = new Rectangle(0, 0);//Arange
            double expect = 0;
            var result = shape.GetPerimeter();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Rect_Perimeter4()
        {
            Shape shape;
            shape = new Rectangle(0.0001, 0.0002);//Arange
            double expect = 0.0006;
            var result = shape.GetPerimeter();//Act
            Assert.AreEqual(result, expect,0.0001); //Assert
        }
        [TestMethod]
        public void Rect_Perimeter5()
        {
            Shape shape;
            shape = new Rectangle(20, 25);//Arange
            double expect = 90;
            var result = shape.GetPerimeter();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Circle_Area()
        {
            Shape shape;
            shape = new Circle(3);//Arange
            var result = shape.GetArea();//Act
            Assert.AreEqual(9*Math.PI, result); //Assert
        }
        [TestMethod]
        public void Circle_Area1()
        {
            Shape shape;
            shape = new Circle(-15);//Arange
            double expect = 0;
            var result = shape.GetArea();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Circle_Area2()
        {
            Shape shape;
            shape = new Circle(-0.0001);//Arange
            double expect = 0;
            var result = shape.GetArea();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Circle_Area3()
        {
            Shape shape;
            shape = new Circle(0);//Arange
            double expect = 0;
            var result = shape.GetArea();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Circle_Area4()
        {
            Shape shape;
            shape = new Circle(0.01);//Arange
            double expect = 0.000314;
            var result = shape.GetArea();//Act
            Assert.AreEqual(result, expect,0.000001); //Assert
        }
        [TestMethod]
        public void Circle_Area5()
        {
            Shape shape;
            shape = new Circle(20);//Arange
            double expect = 1256.63706144;
            var result = shape.GetArea();//Act
            Assert.AreEqual(result, expect,0.00000001); //Assert
        }
        [TestMethod]
        public void Circle_Perimeter()
        {
            Shape shape;
            shape = new Circle(3);//Arange
            var result = shape.GetPerimeter();//Act
            Assert.AreEqual(6*Math.PI, result); //Assert
        }
        [TestMethod]
        public void Circle_Perimeter1()
        {
            Shape shape;
            shape = new Circle(-15);//Arange
            double expect = 0;
            var result = shape.GetPerimeter();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Circle_Perimeter2()
        {
            Shape shape;
            shape = new Circle(-0.0001);//Arange
            double expect = 0;
            var result = shape.GetPerimeter();//Act
            Assert.AreEqual(result, expect); //Assert
        }

        [TestMethod]
        public void Circle_Perimeter3()
        {
            Shape shape;
            shape = new Circle(0);//Arange
            double expect = 0;
            var result = shape.GetPerimeter();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Circle_Perimeter4()
        {
            Shape shape;
            shape = new Circle(0.0001);//Arange
            double expect = 0.000628;
            var result = shape.GetPerimeter();//Act
            Assert.AreEqual(result, expect, 0.000001); //Assert
        }

        [TestMethod]
        public void Circle_Perimeter5()
        {
            Shape shape;
            shape = new Circle(20);//Arange
            double expect = 125.66;
            var result = shape.GetPerimeter();//Act
            Assert.AreEqual(result, expect, 0.01); //Assert
        }

        [TestMethod]
        public void Trapezoid_Area()
        {
            Shape shape;
            shape = new Trapezoid(3, 6, 5, 9, 4);//Arange
            var result = shape.GetArea();//Act
            Assert.AreEqual(28, result); //Assert
        }
        [TestMethod]
        public void Trapezoid_Area1()
        {
            Shape shape;
            shape = new Trapezoid(-8, -16, -12, -20, -10);//Arange
            double expect = 0;
            var result = shape.GetArea();//Act
            Assert.AreEqual(result,expect); //Assert
        }
        [TestMethod]
        public void Trapezoid_Area2()
        {
            Shape shape;
            shape = new Trapezoid(-0.09, -0.011, -0.012, -0.016, -0.07);//Arange
            double expect = 0;
            var result = shape.GetArea();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Trapezoid_Area3()
        {
            Shape shape;
            shape = new Trapezoid(0,0,0,0,0);//Arange
            double expect = 0;
            var result = shape.GetArea();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Trapezoid_Area4()
        {
            Shape shape;
            shape = new Trapezoid(0.09, 0.011, 0.012, 0.016, 0.07);//Arange
            double expect = 0.00098;
            var result = shape.GetArea();//Act
            Assert.AreEqual(result, expect,0.00001); //Assert
        }
        [TestMethod]
        public void Trapezoid_Area5()
        {
            Shape shape;
            shape = new Trapezoid(8, 16, 12, 20, 10);//Arange
            double expect = 160;
            var result = shape.GetArea();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Trapezoid_Perimeter()
        {
            Shape shape;
            shape = new Trapezoid(3, 6, 5, 9, 4);//Arange
            var result = shape.GetPerimeter();//Act
            Assert.AreEqual(23, result); //Assert
        }
        [TestMethod]
        public void Trapezoid_Perimeter1()
        {
            Shape shape;
            shape = new Trapezoid(-8, -16, -12, -20, -10);//Arange
            double expect = 0;
            var result = shape.GetPerimeter();//Act
            Assert.AreEqual(result,expect); //Assert
        }
        [TestMethod]
        public void Trapezoid_Perimeter2()
        {
            Shape shape;
            shape = new Trapezoid(-0.09, -0.011, -0.012, -0.016, -0.07);//Arange
            double expect = 0;
            var result = shape.GetPerimeter();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Trapezoid_Perimeter3()
        {
            Shape shape;
            shape = new Trapezoid(0, 0, 0, 0, 0);//Arange
            double expect = 0;
            var result = shape.GetPerimeter();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Trapezoid_Perimeter4()
        {
            Shape shape;
            shape = new Trapezoid(0.09, 0.011, 0.012, 0.016, 0.07);//Arange
            double expect = 0.129;
            var result = shape.GetPerimeter();//Act
            Assert.AreEqual(result, expect, 0.001); //Assert
        }
        [TestMethod]
        public void Trapezoid_Perimeter5()
        {
            Shape shape;
            shape = new Trapezoid(8,16,12,20,10);//Arange
            double expect = 56;
            var result = shape.GetPerimeter();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Square_Area()
        {
            Shape shape;
            shape = new Square(3);//Arange
            var result = shape.GetArea();//Act
            Assert.AreEqual(9, result); //Assert
        }

        [TestMethod]
        public void Square_Area1()
        {
            Shape shape;
            shape = new Square(-15);//Arange
            double expect = 0;
            var result = shape.GetArea();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Square_Area2()
        {
            Shape shape;
            shape = new Square(-0.0001);//Arange
            double expect = 0;
            var result = shape.GetArea();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Square_Area3()
        {
            Shape shape;
            shape = new Square(0);//Arange
            double expect = 0;
            var result = shape.GetArea();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Square_Area4()
        {
            Shape shape;
            shape = new Square(0.001);//Arange
            double expect = 0.000001;
            var result = shape.GetArea();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Square_Area5()
        {
            Shape shape;
            shape = new Square(20);//Arange
            double expect = 400;
            var result = shape.GetArea();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Square_Perimeter()
        {
            Shape shape;
            shape = new Square(3);//Arange
            var result = shape.GetPerimeter();//Act
            Assert.AreEqual(12, result); //Assert
        }
        [TestMethod]
        public void Square_Perimeter1()
        {
            Shape shape;
            shape = new Square(-15);//Arange
            double expect = 0;
            var result = shape.GetPerimeter();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Square_Perimeter2()
        {
            Shape shape;
            shape = new Square(-0.0001);//Arange
            double expect = 0;
            var result = shape.GetPerimeter();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Square_Perimeter3()
        {
            Shape shape;
            shape = new Square(0);//Arange
            double expect = 0;
            var result = shape.GetPerimeter();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Square_Perimeter4()
        {
            Shape shape;
            shape = new Square(0.0001);//Arange
            double expect = 0.0004;
            var result = shape.GetPerimeter();//Act
            Assert.AreEqual(result, expect); //Assert
        }
        [TestMethod]
        public void Square_Perimeter5()
        {
            Shape shape;
            shape = new Square(20);//Arange
            double expect = 80;
            var result = shape.GetPerimeter();//Act
            Assert.AreEqual(result, expect); //Assert
        }


    }
}
