/*
 * Author: Derek Leung
 * Description: Represents a point in a 2D plane. Encapsulates all necessary
 * info and methods to perform transformations
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Point
    {
        private double x;
        private double y;

        /*
         *  Constructs a Point object with an x and y coordinate
         *  
         *  Paramaters:
         *  x (double) - the x-coordinate
         *  y (double) - the y-coordinate
         */
        public Point(double x, double y)
        {            
            this.x = x;
            this.y = y;
            Console.WriteLine("Point created at (" + x + ", " + y + ")\n");
        }

        /*
         * Offsets the x and y coordinates by a given amount.
         * Translate by (a, b)
         * 
         * Parameters:
         *  a (double) - x offset
         *  b (double) - y offset
         */ 
        public void translate(double a, double b)
        {
            //Console.WriteLine("translate command called with (" + a + ", " + b + ")");
            this.x += a;
            this.y += b;
        }

        /*
         * Rotate around (a, b) by the angle (in radians) clockwise
         * 
         * Parameters:
         *  a (double) - the reference Point's x coorindate
         *  b (double) - the reference Point's y coordinate
         *  angle (double) - the rotation angle in radians
         */ 
        public void rotate(double a, double b, double angle)
        {
            double temp_x = this.x;
            double temp_y = this.y;
            this.x = Math.Cos(angle) * (temp_x - a) + Math.Sin(angle) * (temp_y - b) + a;
            this.y = -Math.Sin(angle) * (temp_x - a) + Math.Cos(angle) * (temp_y - b) + b;
        }

        /*
         * scale relative to (a, b) with scale-factor C
         * 
         * Parameters:
         * a (double) - the relative Point's x coordinate
         * b (double) - the relative Point's y coordinate
         * c (double) - the scale factor
         */ 
        public void scale(double a, double b, double c)
        {
            //Console.WriteLine("scale command called with (" + a + ", " + b + ", " + c + ")");
            double x2 = x - a;
            double y2 = y - b;
            this.x = a + (x2 * c);
            this.y = b + (y2 * c);
        }

        /*
         * reflect over the given axis
         * 
         * Parameters:
         *  axis (char) - the axis to reflect over
         */ 
        public void reflect(char axis)
        {
            //Console.WriteLine("reflect command called for " + axis + " axis");
            if (axis == 'x')
            {
                this.y = -this.y;
            }
            else if (axis == 'y')
            {
                this.x = -this.x;
            }
        }

        /*
         * returns the x coordinate of this Point
         */ 
        public double getX()
        {
            return this.x;
        }

        /*
         * returns the y coordinate of this Point
         */ 
        public double getY()
        {
            return this.y;
        }
    }
}
