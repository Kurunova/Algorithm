using System;
using Algorithm.Example;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacci = Fibonacci.Calculate(3);

            Console.WriteLine(fibonacci);
        }
    }
}