using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Algorithm.ArrayAlgorithm;
using NUnit.Framework;

namespace Algorithm.Tests
{
	[TestFixture]
	public class ArrayManipulationTest : BaseTest
	{
		//[TestCase(200, "input00.txt")]
		//[TestCase(7542539201, "input04.txt")]
		[TestCase(2497169732, "input07.txt")]
		public void CheckFromFile(long result, string fileName)
		{
			var path = Path.Combine(DirectoryName, fileName);
			var lines = File.ReadLines(path).ToList();

			var settings = lines[0].Split(' ');
			var n = int.Parse(settings[0]);
			var count = int.Parse(settings[1]);

			var queries = new List<List<int>>();
			for (int i = 0; i < count; i++)
			{
				var arr = Array.ConvertAll(lines[i + 1].Split(' '), Convert.ToInt32).ToList();
				queries.Add(arr);
			}

			var sw = new Stopwatch();
			sw.Start();
			
			Test(result, n, queries);

			sw.Stop();
			Console.WriteLine("Elapsed={0}",sw.Elapsed);
		}

		private static void Test(long result, int n, List<List<int>> queries)
		{
			var calculated = ArrayManipulation.Execute(n, queries);

			Assert.AreEqual(result, calculated);
		}
	}
}