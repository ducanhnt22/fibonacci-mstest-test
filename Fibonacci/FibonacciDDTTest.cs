using FibonacciUtils;
using System.Reflection;

namespace Fibonacci
{
    [TestClass]
    public class FibonacciDDTTest
    {
        
        public static IEnumerable<object[]> FibonacciData
        {                                                   
            get
            {
                return new[]
                {
                    new object[] { 1, 1 },
                    new object[] { 13, 7 },
                    new object[] { 21, 8 },
                    new object[] { 34, 9 },
                    new object[] { 55, 10 },
                    new object[] { 610, 15 }
                    //new object[] { 700, 16 }
                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(FibonacciData))]
        public void TestFibonacciGivenRightArgumentsReturnWell(int expect, int numbers)
        {
            int actual = FibonacciUtil.fibonaci(numbers);
            Assert.AreEqual(expect, actual,"numbers: <{0}>",new object[] {expect, numbers});
        }
    }
}