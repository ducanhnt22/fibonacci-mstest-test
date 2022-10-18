using FibonacciUtils;
namespace FibonacciUtilTest
{
    [TestClass]
    public class FibonacciUtilTest
    {
        [TestMethod]
        public void TestFactorialGivenRightArgumentReturnsWell()
        {
            //Testcase 1: 
            //n = 1; hi vong chu so dau tien cua day fibonacci la 1
            int expected = 1;
            int actual = FibonacciUtil.fibonaci(1);
            Assert.AreEqual(expected, actual);

            //Testcase 2:
            expected = 13;
            actual = FibonacciUtil.fibonaci(7);
            Assert.AreEqual(expected, actual);

            //Testcase 3:
            expected = 610;
            actual = FibonacciUtil.fibonaci(15);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFactorialGivenWrongArgumentThrowsException()
        {
            //Testcase 4:
            //n = 50 => tran data => hi vong se thay duoc exception
            Assert.ThrowsException<ArgumentOutOfRangeException> (() => FibonacciUtil.fibonaci(50));

            //Testcase 5:
            //n = -10 => khong co => hi vong se duoc thay out of range exception
            Assert.ThrowsException<ArgumentOutOfRangeException> (() => FibonacciUtil.fibonaci(-10));
        }
    }
}