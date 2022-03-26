using System;

namespace Algorithm.StringAlgorithm
{
	/// <summary>
	/// A string is said to be a child of a another string if it can be formed by deleting 0 or more characters from the other string.
	/// Letters cannot be rearranged.
	/// Given two strings of equal length, what's the longest string that can be constructed such that it is a child of both?
	/// </summary>
	public class LongestCommonSubsequence
	{
		public static int Execute(string str1, string str2)
		{
			int[,] arr = new int[str1.Length+1, str2.Length+1];

			for (int i = 0; i < str1.Length; i++) {
				for (int j = 0; j < str2.Length; j++) {
					if (str1[i] == str2[j]) {
						arr[i+1, j+1] = arr[i, j] + 1;
					} else {
						arr[i+1, j+1] = Math.Max(arr[i+1, j], arr[i, j+1]);
					}
				}
			}

			return arr[str1.Length, str2.Length];
		}
	}
	
	// using System.CodeDom.Compiler;
	// using System.Collections.Generic;
	// using System.Collections;
	// using System.ComponentModel;
	// using System.Diagnostics.CodeAnalysis;
	// using System.Globalization;
	// using System.IO;
	// using System.Linq;
	// using System.Reflection;
	// using System.Runtime.Serialization;
	// using System.Text.RegularExpressions;
	// using System.Text;
	// using System;
	//
	//
	//
	// class Result
	// {
	//
	// 	/*
	// 	 * Complete the 'findTotalPower' function below.
	// 	 *
	// 	 * The function is expected to return an INTEGER.
	// 	 * The function accepts INTEGER_ARRAY power as parameter.
	// 	 */
	//
	// 	public static int findTotalPower(List<int> power)
	// 	{
	// 		var result = 0;
	//
	// 		for(int i = 0; i < power.Count; i++)
	// 		{            
	// 			for(int j = power.Count - i; j > 0; j--)
	// 			{
	// 				var temp = power.Skip(i).Take(j);
	// 				result += temp.Min(x => x) * temp.Sum(x => x);
	// 			}
	// 		}
 //        
	// 		return result > 1000000000 ? result % 1000000007 : result;
	// 	}
	// }
	//
	// class Solution
	// {
	// 	public static void Main(string[] args)
	// 	{
	// 		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 		int powerCount = Convert.ToInt32(Console.ReadLine().Trim());
	//
	// 		List<int> power = new List<int>();
	//
	// 		for (int i = 0; i < powerCount; i++)
	// 		{
	// 			int powerItem = Convert.ToInt32(Console.ReadLine().Trim());
	// 			power.Add(powerItem);
	// 		}
	//
	// 		int result = Result.findTotalPower(power);
	//
	// 		textWriter.WriteLine(result);
	//
	// 		textWriter.Flush();
	// 		textWriter.Close();
	// 	}
	// }

}