namespace Library {
    public static class Math {
        public static int Factorial(int n) {
            var result = 1;

            for (var i = n; i > 1; i--)
                result *= i;

            return result;
        }
    }
}