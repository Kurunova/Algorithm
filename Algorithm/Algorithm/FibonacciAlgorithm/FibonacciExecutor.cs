using System;
using Algorithm.Common;

namespace Algorithm.FibonacciAlgorithm
{
	public class FibonacciExecutor : IExecute
	{
		public void Execute()
		{
			var line = Console.ReadLine();
			int inputValue = int.Parse(line);

			var result = BetterFibonacci.Calculate(inputValue); 

			Console.WriteLine(result);
		}
	}
}