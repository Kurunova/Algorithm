using Algorithm.Example;
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
        public void Check(int n, int result)
        {
            var calculated = Fibonacci.Calculate(n);

            Assert.AreEqual(calculated, result);
        }
    }
}