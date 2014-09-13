/*
 * Author: Derek Leung
 * Description: Determines which transformation to perform based on the
 *              user input from the console
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication1
{
    class Command
    {
        private String input;
        private Point pt;
        
        /*
         * Constructs a Command object with the input string from the console
         * 
         * Parameters:
         *  input (String) - the user input from the console
         */ 
        public Command(String input, Point pt)
        {
            this.input = input;
            this.pt = pt;
        }

        /*
         * Parses the input and calls the correct transformation method from
         * the Point class
         */ 
        public void parseInput()
        {
            String transformation = "";
            if ( (input.Count(x => x == '(') == 1) && (input.Count(x => x == ')') == 1) )
            {
                int i = input.IndexOf("(");
                int i2 = input.IndexOf(")");
                transformation = input.Substring(0, i).ToLower();
                String param = "";
                param = input.Substring(i, i2-i);
                switch (transformation)
                {
                    case "translate":
                        List<int> lst = validate2Args(param);

                        if (lst.Count() == 2)
                        {
                            pt.translate(lst[0], lst[1]);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                        break;

                    case "rotate":
                        Console.WriteLine("rotate command");
                        List<int> lst1 = validate3Args(param);
                        if (lst1.Count() == 3)
                        {
                            pt.rotate(lst1[0], lst1[1], lst1[2]);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                        break;
                    case "scale":
                        Console.WriteLine("scale command");
                        List<int> lst2 = validate3Args(param);
                        if (lst2.Count() == 3)
                        {
                            pt.scale(lst2[0], lst2[1], lst2[2]);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                        break;
                    case "reflect":
                        Console.WriteLine("reflect command");
                        String axis = "";
                        foreach (char c in param)
                        {
                            if (c == 'x' || c == 'y')
                            {
                                axis += c;
                            }
                        }
                        if (axis.Length == 1) 
                        {
                            if (axis.ToLower() == "x")
                            {
                                pt.reflect('x');
                            }
                            else if (axis.ToLower() == "y")
                            {
                                pt.reflect('y');
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                        break;

                    case "finish":
                        Console.Write("\nResult: ");
                        Console.WriteLine("(" + pt.getX() + ", " + pt.getY() + ")");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } else {
                if (input.ToLower().Equals("help"))
                {
                    Console.WriteLine("\nEnter one of the commands in the given format:");
                    Console.WriteLine("translate(A, B)");
                    Console.WriteLine("rotate(A, B, C)");
                    Console.WriteLine("scale(A, B, C)");
                    Console.WriteLine("reflect(axis)");
                    Console.WriteLine("finish()\n");
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }

        /*
         * Iterates through the string to get the digits and return them as an ArrayList. Al
         * 
         * Parameters:
         *  s (String) - the string
         *  start (int) - the start index
         *  end (int) - the end index
         */
        private ArrayList getDigits(String s, int start, int end)
        {
            String digits = "";
            foreach (char c in s.Substring(start, end))
            {
                if (Char.IsDigit(c) || c == '-')
                {
                    digits += c;
                }
            }
            ArrayList lst = new ArrayList();
            if (digits.Length > 0){
                lst.Add(Convert.ToInt32(digits));
                lst.Add(1);
            }
            else
            {
                lst.Add(0);
                lst.Add(0);
            }
            return lst;
            
        }

        /*
         * Validates the parameters for a transformation that takes 2 arguments.
         * 
         * Parameters:
         *  param (String) - the string that contains the arguments
         *  
         * Return:
         *  List<int> - a list containing the validated arguments as ints
         */ 
        public List<int> validate2Args(String param)
        {
            if (param.Count(x => x == ',') == 1)
            {
                int x = 0;
                int y = 0;

                if ((int)getDigits(param, 0, param.IndexOf(","))[1] == 1)
                {
                    x = (int)getDigits(param, 0, param.IndexOf(","))[0];
                    if ((int)getDigits(param, param.IndexOf(","), param.Length - param.IndexOf(","))[1] == 1)
                    {
                        y = (int)getDigits(param, param.IndexOf(","), param.Length - param.IndexOf(","))[0];
                        List<int> lst = new List<int>();
                        lst.Add(x);
                        lst.Add(y);
                        return lst;
                    }
                }
            }
            return new List<int>();
        }

                /*
        * Validates the parameters for a transformation that takes 3 arguments.
        * 
        * Parameters:
        *  param (String) - the string that contains the arguments
        *  
        * Return:
        *  List<int> - a list containing the validated arguments as ints
        */ 
        public List<int> validate3Args(String param)
        {
            if (param.Count(x => x == ',') == 2)
            {
                int x = 0;
                int y = 0;
                int z = 0;
                String[] s = param.Split(',');

                if ((int)getDigits(s[0], 0, s[0].Length)[1] == 1)
                {

                    x = (int)getDigits(s[0], 0, s[0].Length)[0];
                    if ((int)getDigits(s[1], 0, s[1].Length)[1] == 1)
                    {
                        y = (int)getDigits(s[1], 0, s[1].Length)[0];
                        if ((int)getDigits(s[2], 0, s[2].Length)[1] == 1)
                        {
                            z = (int)getDigits(s[2], 0, s[2].Length)[0];
                            List<int> lst = new List<int>();
                            lst.Add(x);
                            lst.Add(y);
                            lst.Add(z);
                            return lst;                            
                        }
                    }
                }
            }
            return new List<int>();
        }
    }

}

