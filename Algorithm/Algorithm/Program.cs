using Algorithm.Common;
using Algorithm.StringAlgorithm;
using Algorithm.TowerOfHanoi;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // IExecute fibonacciExecutor = new FibonacciExecutor();
            // fibonacciExecutor.Execute();
            
            // IExecute longestCommonSubsequenceExecutor = new LongestCommonSubsequenceExecutor();
            // longestCommonSubsequenceExecutor.Execute();
            
            IExecute hanoiTowerExecutor = new HanoiTowerExecutor();
            hanoiTowerExecutor.Execute();
            
        }
    }
}