using System;

namespace Algorithm.StringAlgorithm
{
	public class ArrayPosition
	{
		public static string Execute(string str1, int k)
		{
			// есть строка str1 = "01234567890" ее надо разложить на k
			// 0 3 6 9 
			// 1 4 7 0
			// 2 5 8
			// и потом объединить в 0369 470 258
			
			var newArr = new char[str1.Length];

			int counter = 0;
			for (int i = 0; i < str1.Length; i++)
			{
				counter = counter == k ? 1 : counter + 1;
				
				int startIndex = (str1.Length / k) * (counter - 1) + str1.Length % k - (k - counter); // вычитываем стартовый индекс counter части из k

				newArr[startIndex + i / k] = str1[i];
			}

			return newArr.ToString();
		}
	}
}