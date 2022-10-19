using FibonacciUtils;
namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Input fibonacci number: ");
            //int fibonacci = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(fibonaci(fibonacci));
            TryTDDFirst();
        }

        public static void TryTDDFirst()
        {
            // #Testcase 01:
            int expect = 1;
            int actual = FibonacciUtil.fibonaci(1);
            //Minh muon so fibonacci dau tien la 1
            Console.WriteLine($"Expected: {expect} || Actual: {actual}");

            //Testcase 02:
            expect = 13;
            actual = FibonacciUtil.fibonaci(7);
            Console.WriteLine($"Expected: {expect} || Actual: {actual}");

            //Testcase 03:
            expect = 610;
            actual = FibonacciUtil.fibonaci(15);
            Console.WriteLine($"Expected: {expect} || Actual: {actual}");

            //Testcase 04:
            //So fibonacci khong duoc am
            //Hi vong dc thay cau khong hop le

            //Expect: ArgumentOutOfRangeException
            //actual = FibonacciUtil.fibonaci(-5);
            //Console.WriteLine($"Expected: Error || Actual: {actual}");

            //Testcase 05:
            //so 47 cua day Fibonacci la: 2971215073
            //lon hon kieu int:           2147483647
            //nen phai hien ra ArgumentOutOfRangeException

            //Expect: ArgumentOutOfRangeException
            actual = FibonacciUtil.fibonaci(47);
            Console.WriteLine($"Expected: Error || Actual: {actual}");
            Console.ReadLine();
        }
    }
}