namespace FibonacciUtils
{
    public class FibonacciUtil
    {
        public static int fibonaci(int n)
        {
            if (n <= 0 || n > 46)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return fibonaci(n - 1) + fibonaci(n - 1);
            }
        }
    }
}