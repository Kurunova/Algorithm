using System;
using Algorithm.Common;

namespace Algorithm.ArrayAlgorithm
{
	public class ArraySwap2Executor : IExecute
	{
		public void Execute()
		{
			//TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

			int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

			var result = ArraySwap2.Execute(arr);

			Console.WriteLine(result);
			
			// textWriter.WriteLine(result);
			//
			// textWriter.Flush();
			// textWriter.Close();
		}
	}
}