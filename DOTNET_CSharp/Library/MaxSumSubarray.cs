namespace Library
{
    public static class MaxSumSubarray
    {
        public static (int, int[]) CalculateMaxSubarray(this int[] array)
        {
            var length = array.Length;
            if (length == 0) return (0, new int[] { });

            var maxSum = array[0];
            var currentSum = array[0];
            var maxStartIndex = 0;
            var maxEndIndex = 0;
            var tempStartIndex = 0;

            for (int i = 1; i < length; i++)
            {
                currentSum += array[i];

                if (currentSum < array[i])
                {
                    currentSum = array[i];
                    tempStartIndex = i;
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxStartIndex = tempStartIndex;
                    maxEndIndex = i;
                }
            }
            ++maxEndIndex;
            return (maxSum, array[maxStartIndex..maxEndIndex]);
        }
    }
}