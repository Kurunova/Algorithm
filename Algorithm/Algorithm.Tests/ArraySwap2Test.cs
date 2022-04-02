using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using Algorithm.ArrayAlgorithm;
using NUnit.Framework;

namespace Algorithm.Tests
{
	[TestFixture]
	public class ArraySwap2Test
	{
		[TestCase(991, "input7.txt")]
		[TestCase(99987, "input12.txt")]
		public void CheckFromFile(int result, string fileName) 
		{
			var directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			var path = Path.Combine(directory, "Source/ArraySwap2", fileName);
			var lines = File.ReadLines(path).ToList(); 
			
			var sw = new Stopwatch();
			sw.Start();
			
			Test(result, lines[1]);

			sw.Stop();
			Console.WriteLine("Elapsed={0}",sw.Elapsed);
		}
		
		[TestCase(3, "4 3 1 2")]
		[TestCase(5, "7 1 3 2 4 5 6")]
		[TestCase(3, "6 5 4 3 2 1")]
		[TestCase(2, "5 4 3 2 1")]
		[TestCase(3, "5 4 2 3 1")]
		[TestCase(4, "5 4 2 1 3")]
		[TestCase(7, "10 9 8 7 6 1 2 3 4 5")]
		[TestCase(9, "10 9 7 6 8 1 2 3 4 5")]
		public void Check(int result, string str)
		{
			var sw = new Stopwatch();
			sw.Start();
			
			Test(result, str);

			sw.Stop();
			Console.WriteLine("Elapsed={0}",sw.Elapsed);
		}

		private static void Test(int result, string str)
		{
			int[] arr = Array.ConvertAll(str.Split(' '), arrTemp => Convert.ToInt32(arrTemp));

			var calculated = ArraySwap2.Execute(arr);

			Assert.AreEqual(result, calculated);
		}
	}
}