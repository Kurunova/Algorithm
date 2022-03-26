using System;
using Algorithm.Common;

namespace Algorithm.StringAlgorithm
{
	public class LongestCommonSubsequenceExecutor : IExecute
	{
		public void Execute()
		{
			//TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

			string s1 = Console.ReadLine();

			string s2 = Console.ReadLine();

			int result = LongestCommonSubsequence.Execute(s1, s2);

			Console.WriteLine(result);
			
			// textWriter.WriteLine(result);
			//
			// textWriter.Flush();
			// textWriter.Close();
		}
	}
}