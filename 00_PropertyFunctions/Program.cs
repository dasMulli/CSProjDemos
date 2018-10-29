using System;

namespace HelloPropertyFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello World, Version {typeof(Program).Assembly.GetName().Version}");
        }
    }
}
