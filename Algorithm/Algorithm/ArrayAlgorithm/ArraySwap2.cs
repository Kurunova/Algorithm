using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Algorithm.ArrayAlgorithm
{
	public class ArraySwap2
	{
		/// <summary>
		/// You are given an unordered array consisting of consecutive integers  [1, 2, 3, ..., n] without any duplicates.
		/// You are allowed to swap any two elements.
		/// Find the minimum number of swaps required to sort the array in ascending order.
		/// </summary>
		public static int Execute(int[] arr)
		{
			int result = 0;
			
			var dict = arr.Select((val, index) => new { Index = index, Value = val })
				.ToDictionary(arg => arg.Index, arg => arg.Value);
			
			var dict2 = arr.Select((val, index) => new { Index = index, Value = val })
				.ToDictionary(arg => arg.Value, arg => arg.Index);
			
			int n = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				var currIndex = i; // 0
				var currVal = dict[i]; // 4
				 
				if(currVal == currIndex + 1)
					continue;
            
				var movedToIndex = dict2[currIndex + 1]; // 2
				var movedToVal = currIndex + 1; // 1
				if(currVal == movedToIndex + 1)
				{
					dict[currIndex] = movedToVal;
					dict[movedToIndex] = currVal;
					
					dict2[currVal] = movedToIndex;
					dict2[movedToVal] = currIndex;
					
					result++;
					continue;
				}
			
				dict[currIndex] = movedToVal;
				dict[movedToIndex] = currVal;
									
				dict2[currVal] = movedToIndex;
				dict2[movedToVal] = currIndex;
				
				n++;
			}

			result += n > 0 ? n : 0;
        
			return result;
		}
		
		private static int Calc(int n)
		{
			if(n < 3)
				return 0;

			var r = n / 2;
			n -= n / 2;
			return r + Calc(n);
		}
	}
}