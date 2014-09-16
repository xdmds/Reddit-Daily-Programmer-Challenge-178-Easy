/*
 * Author: Derek Leung
 * Description: http://www.reddit.com/r/dailyprogrammer/comments/2f6a7b/9012014_challenge_178_easy_transformers_matrices/
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                String start = "";
                String input = "";
                Console.WriteLine("Starting Point:");
                start = Console.ReadLine();
                String x = "";
                String y = "";
                if ((start.Count(x1 => x1 == '(') == 1) && (start.Count(x1 => x1 == ')') == 1))
                {
                    String[] s = start.Split(',');

                    foreach (char c in s[0])
                    {
                        if (Char.IsDigit(c) || c == '-' || c == '.' )
                        {
                            x += c;
                        }
                    }
                    foreach (char c1 in s[1])
                    {
                        if (Char.IsDigit(c1) || c1 == '-' || c1 == '.')
                        {
                            y += c1;
                        }
                    }
                    if (x.Length > 0 && y.Length > 0)
                    {
                        Point pt = new Point(Convert.ToDouble(x), Convert.ToDouble(y));
                        Console.WriteLine("Enter commands. 1 per line. 'help' for info:");
                        while (true)
                        {
                            input = Console.ReadLine();
                            Command cmd = new Command(input, pt);
                            cmd.parseInput();
                        }
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
            }
        }

        /*
         * Test case. output should be (-4, -7)
         */ 
        /*
        static void Main(string[] args){
            Point test_pt = new Point(0,5);
            test_pt.translate(3,2);
            Console.WriteLine("(" + test_pt.getX() + ", " + test_pt.getY() + ")");
            test_pt.scale(1,3,0.5);
            Console.WriteLine("(" + test_pt.getX() + ", " + test_pt.getY() + ")");
            test_pt.rotate(3,2,1.57079632679);
            Console.WriteLine("(" + test_pt.getX() + ", " + test_pt.getY() + ")");
            test_pt.reflect('x');
            Console.WriteLine("(" + test_pt.getX() + ", " + test_pt.getY() + ")");
            test_pt.translate(2,-1);
            Console.WriteLine("(" + test_pt.getX() + ", " + test_pt.getY() + ")");
            test_pt.scale(0,0,-0.25);
            Console.WriteLine("(" + test_pt.getX() + ", " + test_pt.getY() + ")");
            test_pt.rotate(1,-3,3.14159265359);
            Console.WriteLine("(" + test_pt.getX() + ", " + test_pt.getY() + ")");
            test_pt.reflect('y');
            Console.WriteLine("(" + Math.Round(test_pt.getX()) + ", " + Math.Round(test_pt.getY()) + ")");
            Console.Read();
        }
         */
    }
}
