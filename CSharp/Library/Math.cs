namespace Library
{
    public static class Math
    {
        public static int FactorialIterative(int n)
        {
            var result = 1;

            for (var i = n; i > 1; i--)
                result *= i;

            return result;
        }

        public static int Factorial(int n) =>
            n <= 1 
            ? 1 
            : Factorial(n - 1) * n;

        public static int FactorialTail(int n) {
            int accumulatedFactorial(int n, int acc) =>
                n <= 1 
                ? acc 
                : accumulatedFactorial(n - 1, acc * n);
            
            return accumulatedFactorial(n, 1);
        }
    }
}