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
            String start = "";
            String input = "";
            Console.WriteLine("Starting point:");
            start = Console.ReadLine();
            Console.WriteLine("Enter commands. 1 per line. 'help' for info:");
            while (true)
            {
                input = Console.ReadLine();
                Command cmd = new Command(input);
                cmd.parseInput();
            }            

            //press enter to exit
            Console.Read();
        }
    }
}
