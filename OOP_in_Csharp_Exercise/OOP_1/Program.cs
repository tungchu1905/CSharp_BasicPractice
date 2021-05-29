using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare an instance of Circle class called c1.
            // Construct the instance c1 by invoking the "default" constructor
            // which sets its radius and color to their default value.
            Circle c1 = new Circle();
            // Invoke public methods on instance c1, via dot operator.
            Console.WriteLine("The circle has radius of "
               + c1.getRadius() + " and area of " + c1.getArea());
            //The circle has radius of 1.0 and area of 3.141592653589793

            // Declare an instance of class circle called c2.
            // Construct the instance c2 by invoking the second constructor
            // with the given radius and default color.
            Circle c2 = new Circle(2.0);
            // Invoke public methods on instance c2, via dot operator.
            Console.WriteLine("The circle has radius of "
               + c2.getRadius() + " and area of " + c2.getArea());
            //The circle has radius of 2.0 and area of 12.566370614359172


            // C3 
            Circle c3 = new Circle(3, "blue");
            Console.WriteLine("The circle has radius of "
               + c3.getRadius() + " and area of " + c3.getArea());

            // C4
            Circle c4 = new Circle();   // construct an instance of Circle
            c4.setRadius(5.5);          // change radius
            Console.WriteLine("radius is: " + c4.getRadius()); // Print radius via getter
            c4.setColor("green");       // Change color
            Console.WriteLine("color is: " + c4.getColor());   // Print color via getter
            
        }
    }
}
