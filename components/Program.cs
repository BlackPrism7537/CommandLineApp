using System;
using System.Collections.Generic;

namespace CommandLineApp
{
    class Program
    {
        public Program()
        {
            Console.WriteLine("Welcome!");
        }


        public string GetUserInput()
        {
            string? input;
            do
            {
                Console.WriteLine("Please enter a command: ");
                input = Console.ReadLine() ?? "";
            } while (input == "");

            return input;
        }
    }
}