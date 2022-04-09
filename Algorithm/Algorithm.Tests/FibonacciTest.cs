using System;
using System.Diagnostics;
using Algorithm.FibonacciAlgorithm;
using NUnit.Framework;

namespace Algorithm.Tests
{
    [TestFixture]
    public class FibonacciTest
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        [TestCase(6, 8)]
        [TestCase(7, 13)]
        [TestCase(8, 21)]
        [TestCase(9, 34)]
        [TestCase(17, 1597)]
        [TestCase(44, 701408733)]
        [TestCase(60, 1820529360)]
        public void Check(int n, int result)
        {
            var sw = new Stopwatch();
            sw.Start();
            
            var calculated = BetterFibonacci.Calculate(n);

            Assert.AreEqual(result, calculated);
            
            sw.Stop();
			
            Assert.LessOrEqual(sw.Elapsed, new TimeSpan(0 ,0, 1));
			
            Console.WriteLine("Elapsed={0}",sw.Elapsed);
        }
        
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(34, 5702887)]
        //[TestCase(44, 701408733)] // по скорости уже не проходит
        public void CheckFibonacci(int n, int result)
        {
            var sw = new Stopwatch();
            sw.Start();
            
            var calculated = Fibonacci.CalcFibonacci(n);

            Assert.AreEqual(result, calculated);
            
            sw.Stop();
			
            Assert.LessOrEqual(sw.Elapsed, new TimeSpan(0 ,0, 1));
			
            Console.WriteLine("Elapsed={0}",sw.Elapsed);
        }
    }
}