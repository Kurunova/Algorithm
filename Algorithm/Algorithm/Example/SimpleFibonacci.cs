namespace Algorithm.Example
{
    public class SimpleFibonacci
    {
        public static int Calculate(int n)
        {
            int[] numbers = {0, 1};

            if (n == 0)
            {
                return numbers[0];
            }

            if (n == 1)
            {
                return numbers[1];
            }

            for (int i = 2; i <= n; i++)
            {
                GetNext(ref numbers);
            }

            return numbers[1];
        }

        private static void GetNext(ref int[] numbers)
        {
            int previousNumber = numbers[1];
            int nextNumber = numbers[0] + numbers[1];

            numbers[0] = previousNumber;
            numbers[1] = nextNumber;
        }
    }
}