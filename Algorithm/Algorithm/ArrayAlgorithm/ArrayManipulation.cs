using System.Collections.Generic;
using System.Linq;

namespace Algorithm.ArrayAlgorithm
{
	public class ArrayManipulation
	{
		/// <summary>
		/// n = 10, arr = [[1, 5, 3], [4, 8, 7], [6, 9, 1]]
		/// Queries are interpreted as follows:
		/// a b k
		/// 1 5 3
		/// 4 8 7
		/// 6 9 1
		/// Add the values of  between the indices  and  inclusive:
		/// index->	 1 2 3  4  5 6 7 8 9 10
		/// [0,0,0, 0, 0,0,0,0,0, 0]
		/// [3,3,3, 3, 3,0,0,0,0, 0]
		/// [3,3,3,10,10,7,7,7,0, 0]
		/// [3,3,3,10,10,8,8,8,1, 0]
		/// The largest value is  after all operations are performed.
		/// </summary>
		public static long Execute(int n, List<List<int>> queries)
		{
			long max = 0;
        
			var resultRow = new long[n];

			// тут мы убрали прочситывание для каждой строки и добавляем вначале + число а потом - число
			for(int i = 0; i < queries.Count; i++)
			{
				var line = queries[i];
            
				resultRow[line[0]-1] += line[2];
				if(line[1] < n)
					resultRow[line[1]] -= line[2];
			}
        
			long c = 0;
			for(int i = 0; i < resultRow.Count(); i++)
			{
				c += resultRow[i];
				if(max < c)
					max = c;
			}
        
			return max;
		}
		
		/// <summary>
		/// Плохой вариант.
		/// Проходим и просчитываем для каждой входной строки значения
		/// Вложенные массивы отрабатывают очень долго 
		/// </summary>
		public static long arrayManipulation(int n, List<List<int>> queries)
		{
			var resultRow = new long[n];

			for(int i = 0; i < queries.Count; i++)
			{
				var line = queries[i];
            
				for(int j = line[0]; j <= line[1]; j++)
				{
					resultRow[j-1] += line[2];
				}            
			}
			
			return resultRow.Max();
		}

	}
}