using System;
using System.Collections.Generic;

namespace CommandLineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Hello");
            list.Add("World");
            list.Add("!");
            list.ForEach(Console.WriteLine);
        }
    }
}