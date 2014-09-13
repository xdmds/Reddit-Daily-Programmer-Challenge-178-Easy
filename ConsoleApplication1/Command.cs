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
                        if (param.Count(x => x == ',') == 1)
                        {
                            int x = 0;
                            int y = 0;

                            if ((int) getDigits(param, 0, param.IndexOf(","))[1] == 1)
                            {
                                x = (int) getDigits(param, 0, param.IndexOf(","))[0];
                                if ((int)getDigits(param, param.IndexOf(","), param.Length - param.IndexOf(","))[1] == 1)
                                {
                                    y = (int)getDigits(param, param.IndexOf(","), param.Length - param.IndexOf(","))[0];
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                            }
                            pt.translate(x, y);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                        break;

                    case "rotate":
                        Console.WriteLine("rotate command");
                        break;
                    case "scale":
                        Console.WriteLine("scale command");
                        break;
                    case "reflect":
                        Console.WriteLine("reflect command");
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

    }
}
