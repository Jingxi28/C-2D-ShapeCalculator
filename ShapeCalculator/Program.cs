using System;

namespace ShapeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape;
            bool flag = true;
            while (flag)
            {
                
                //This is user friendly input which you can select the options
                Console.WriteLine("Select a shape: ");
                Console.WriteLine("1. Rectangle");
                Console.WriteLine("2. Circle");
                Console.WriteLine("3. Trapezoid");
                Console.WriteLine("4. Square");
                Console.WriteLine("5. Exit");
                // Create a string variable and get user input from the keyboard and store it in the variable
                string type = Console.ReadLine();

                //This is swith statemnet of type
                switch (type)
                {
                    case "1":
                        //This is user input of rectangle length
                        Console.WriteLine("Set rectangle length: ");
                        //Create a double l variable and store value of rectangle length
                        double l = Double.Parse(Console.ReadLine());
                        //This is user input of rectangle height
                        Console.WriteLine("Set rectangle height: ");
                        //Create a double h variable and store value of rectangle height
                        double h = Double.Parse(Console.ReadLine());
                        // Create a Rectangle object with the specified length (l) and height (h)
                        shape = new Rectangle(l, h);
                        break;

                    case "2":
                        //This is user input of circle radius
                        Console.WriteLine("Set circle radius: ");
                        //Create a double r variable and store value of circle radius
                        double r = Double.Parse(Console.ReadLine());
                        //Create a Circle object with the specified circle(r)
                        shape = new Circle(r);
                        break;
                    case "3":
                        //This is user input of trapezoid side A
                        Console.WriteLine("Set trapezoid side A: ");
                        //Create a double sideA variable and store value of trapezoid side A
                        double sideA = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Set trapezoid side B: ");
                        double sideB = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Set trapezoid base A: ");
                        double baseA = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Set trapezoud base B: ");
                        double baseB = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Set trapezoid height: ");
                        double Th = double.Parse(Console.ReadLine());
                        //Create a Trapezoid object with the specified 5 values
                        shape = new Trapezoid(sideA, sideB, baseA, baseB, Th);
                        break;
                    case "4":
                        //This is user input of square length
                        Console.WriteLine("Set square length: ");
                        //Create a double sl variable and store value of square length
                        double sl = Double.Parse(Console.ReadLine());
                        //Create a Square object with specified square(sl)
                        shape = new Square(sl);
                        break;
                    case "5":
                        Console.WriteLine("Thank for using this app");
                        flag = false;
                        Console.ReadLine();
                        return;
                    // If none of the case statements are matched, this default case will be executed
                    default:
                        //Display the output
                        Console.WriteLine("Wrong selection, try again.");
                        // Return control to the calling method
                        Console.ReadLine();
                        continue;
                }

                //This is another user friendly input which you can select the options
                Console.WriteLine("Solve for");
                Console.WriteLine("1. Area");
                Console.WriteLine("2. Perimeter");
                // Create a string variable and get user input from the keyboard and store it in the variable
                string operation = Console.ReadLine();

                switch (operation)//Another switch statemnet of operation
                {
                    //If 'operation' is "1", calculate and display the area of the shape
                    case "1":
                        Console.WriteLine("Area is: " + shape.GetArea());
                        break;
                    //If 'operation' is "2", calculate and display the perimeter of the shape
                    case "2":
                        Console.WriteLine("Perimeter is: " + shape.GetPerimeter());
                        break;
                    //if you type the other things, it will display an error message
                    default:
                        Console.WriteLine("Wrong selection, bye.");
                        continue; 
                }
                // Wait for the user to press a key before exiting the program
               
            }
        }
    }
}
