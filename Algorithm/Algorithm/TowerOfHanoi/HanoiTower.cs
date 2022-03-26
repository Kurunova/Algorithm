using System;
using System.Collections;

namespace Algorithm.TowerOfHanoi
{
	public class HanoiTower
	{
		public static int Execute(int numberOfRings)
		{
			var a = new Stack();
			for (int i = numberOfRings; i > 0; i--) {
				a.Push(i);
			}
			
			var b = new Stack();
			var c = new Stack();

			char start = 'A'; // start tower in output
			char temp = 'B'; // temporary tower in output
			char end = 'C'; // end tower in output
			
			MoveHanoi(numberOfRings, start, end, temp);
			MoveHanoi(numberOfRings, a, c, b);
			
			return 0;
		}

		private static void MoveHanoi(int numberOfRings, char start, char end, char temp)
		{
			if (numberOfRings == 0)
				return;

			MoveHanoi(numberOfRings - 1, start, temp, end);
			Console.WriteLine($"Moving ring {numberOfRings} from {start} to {end}");
			MoveHanoi(numberOfRings - 1, temp, end, start);
		}
		
		private static void MoveHanoi(int numberOfRings, Stack start, Stack end, Stack temp)
		{
			if (numberOfRings == 0)
				return;
			
			MoveHanoi(numberOfRings - 1, start, temp, end);
			end.Push(start.Pop());
			MoveHanoi(numberOfRings - 1, temp, end, start);
		}
	}
}