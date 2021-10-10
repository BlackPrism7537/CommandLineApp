using System;
using System.Collections.Generic;

namespace CommandLineApp
{
    class CommandLineApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading...");
            Program program = new Program();
            String userInput = program.GetUserInput();
            Console.WriteLine("You entered: " + userInput);
        }
    }

}