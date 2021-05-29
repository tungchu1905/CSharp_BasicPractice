using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_1
{
   public class Circle
    {
        // private instance variable, not accessible from outside this class
        public double radius;
        public string color;

        // Constructors (overloaded)
        /** Constructs a Circle instance with default value for radius and color */
        public Circle()
        {  // 1st (default) constructor
            radius = 1d;
            color = "red";
        }

        /** Constructs a Circle instance with the given radius and default color */
        public Circle(double r)
        {  // 2nd constructor
            radius = r;
            color = "red";
        }

        /** Returns the radius */
        public double getRadius()
        {
            return radius;
        }

        /** Returns the area of this Circle instance */
        public double getArea()
        {
            return radius * radius * Math.PI;
        }

        public Circle(double radius, string color) 
        {
            this.radius = radius;
            this.color = color;
        }


        public string getColor()
        {
            return color;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public void setColor(string newColor)
        {
            color = newColor;
        }
    }
}
