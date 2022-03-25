using System;

namespace Algorithm.StringAlgorithm
{
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

			return arr[str1.Length+1, str2.Length+1];
		}
	}
}