namespace Algorithm.FibonacciAlgorithm
{
	public class Fibonacci
	{
		public static int CalcFibonacci(int number) {

			if(number == 0)
				return 0;
            
			if(number == 1)
				return 1;
            
			return CalcFibonacci(number - 1) + CalcFibonacci(number - 2);   
		}
	}
}