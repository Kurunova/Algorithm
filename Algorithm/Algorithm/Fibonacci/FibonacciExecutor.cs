using System;
using Algorithm.Common;

namespace Algorithm.Fibonacci
{
	public class FibonacciExecutor : IExecute
	{
		public void Execute()
		{
			var line = Console.ReadLine();
			int inputValue = int.Parse(line);

			var result = SimpleFibonacci.Calculate(inputValue); 

			Console.WriteLine(result);
		}
	}
}