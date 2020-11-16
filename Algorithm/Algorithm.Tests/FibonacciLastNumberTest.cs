using Algorithm.Example;
using NUnit.Framework;

namespace Algorithm.Tests
{
    [TestFixture]
    public class FibonacciLastNumberTest
    {
        [TestCase(841645, 5)]
        public void Check(int n, int result)
        {
            var calculated = FibonacciLastNumber.Calculate(n);

            Assert.AreEqual(calculated, result);
        }
    }
}