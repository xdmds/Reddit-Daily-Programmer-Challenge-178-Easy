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
        private int x;
        private int y;

        /*
         *  Constructs a point object with an x and y coordinate
         *  
         *  Paramaters:
         *  x (int) - the x-coordinate
         *  y (int) - the y-coordinate
         */
        public Point(int x, int y)
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
         *  a (int) - x offset
         *  b (int) - y offset
         */ 
        public void translate(int a, int b)
        {
            this.x = x + a;
            this.y = y + b;
        }

        /*
         * Rotate around (a, b) by the angle (in radians) clockwise
         * 
         * Parameters:
         *  a (int) - the reference point's x coorindate
         *  b (int) - the reference point's y coordinate
         *  angle (int) - the rotation angle in radians
         */ 
        public void rotate(int a, int b, int angle)
        {
            Console.WriteLine("rotate command called with (" + a + ", " + b + ", " + angle + ")");
            double s = Math.Sin((double)angle);
            double c = Math.Cos(angle);

            // translate point back to origin:
            this.x -= a;
            this.y -= b;

            // rotate point
            double xnew = this.x * c - this.y * s;
            double ynew = this.x * s + this.y * c;

            // translate point back:
            this.x = (int)xnew + a;
            this.y = (int)ynew + b;

        }

        /*
         * scale relative to (a, b) with scale-factor C
         * 
         * Parameters:
         * a (int) - the relative point's x coordinate
         * b (int) - the relative point's y coordinate
         * c (int) - the scale factor
         */ 
        public void scale(int a, int b, int c)
        {
            Console.WriteLine("scale command called with (" + a + ", " + b + ", " + c + ")");
        }

        /*
         * reflect over the given axis
         * 
         * Parameters:
         *  axis (char) - the axis to reflect over
         */ 
        public void reflect(char axis)
        {
            Console.WriteLine("reflect command called for " + axis + " axis");
        }

        /*
         * returns the x coordinate of this point
         */ 
        public int getX()
        {
            return this.x;
        }

        /*
         * returns the y coordinate of this point
         */ 
        public int getY()
        {
            return this.y;
        }
    }
}
