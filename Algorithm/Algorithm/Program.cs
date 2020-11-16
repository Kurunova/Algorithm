using System;
using Algorithm.Example;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            int inputValue = int.Parse(line);

            var result = SimpleFibonacci.Calculate(inputValue);

            Console.WriteLine(result);
        }
    }
}