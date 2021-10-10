using System;
using System.Collections.Generic;

namespace CommandLineApp
{
    class CommandLineApp
    {
        static void Main(string[] args)
        {
            Program program = new Program();
        }
    }

    class Program
    {
        public Program(){
            List<string> list = new List<string>();
            list.Add("Hello");
            list.Add("World");
            list.Add("!");
            list.ForEach(Console.WriteLine);
        }
    }
}