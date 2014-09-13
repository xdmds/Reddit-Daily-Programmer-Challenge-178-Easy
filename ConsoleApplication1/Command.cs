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

namespace ConsoleApplication1
{
    class Command
    {
        private String input;
        
        /*
         * Constructs a Command object with the input string from the console
         * 
         * Parameters:
         *  input (String) - the user input from the console
         */ 
        public Command(String input)
        {
            this.input = input;
        }

        /*
         * Parses the input and calls the correct transformation method from
         * the Point class
         */ 
        public void parseInput()
        {
            String transformation = "";
            if (input.Contains("(") && input.Contains(")")){
                int i = input.IndexOf("(");
                transformation = input.Substring(0, i).ToLower();

                switch (transformation)
                {
                    case "translate":
                        Console.WriteLine("translate command");
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
                        Console.WriteLine("finish command");
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

    }
}
