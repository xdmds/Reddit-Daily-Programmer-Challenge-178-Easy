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

        }

        /*
         * Rotate around (a, b) by the angle c (in radians) clockwise
         * 
         * Parameters:
         *  a (int) - the reference point's x coorindate
         *  b (int) - the reference point's y coordinate
         *  c (int) - the rotation angle in radians
         */ 
        public void rotate(int a, int b, int c)
        {

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

        }

        /*
         * reflect over the given axis
         * 
         * Parameters:
         *  axis (char) - the axis to reflect over
         */ 
        public void reflect(char axis)
        {

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
