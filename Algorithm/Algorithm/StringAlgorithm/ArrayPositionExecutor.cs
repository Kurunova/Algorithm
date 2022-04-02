using System;
using Algorithm.Common;

namespace Algorithm.StringAlgorithm
{
	public class ArrayPositionExecutor : IExecute
	{
		public void Execute()
		{
			//TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

			string s1 = Console.ReadLine();

			int k = Int32.Parse(Console.ReadLine());

			var result = ArrayPosition.Execute("01234567890", 3);

			Console.WriteLine(result);
			
			// textWriter.WriteLine(result);
			//
			// textWriter.Flush();
			// textWriter.Close();
		}
	}
}