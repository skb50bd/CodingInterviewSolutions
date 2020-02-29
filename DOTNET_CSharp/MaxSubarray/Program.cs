using System;

namespace MaxSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            // var array = new [] { -1, -2, 1, 2, 3, -5, -4 };
            var array = new [] { 3, -4, 5, 1, 10, -12, -5, 8, 9 };
            
            var (sum, result) = CalculateMaxSubarray(array);

            Console.WriteLine(
                $"Sum: {sum}\nArray: [ {string.Join(", ", result)} ]\n");
        }

        private static (int, int[]) CalculateMaxSubarray(int[] array)
        {
            var length = array.Length;
            if (length == 0) return (0, new int[] {});

            var maxSum = array[0];
            var currentSum = array[0]; 
            var maxStartIndex = 0;
            var maxEndIndex = 0;
            var tempStartIndex = 0;
            
            for (int i = 1; i < length; i++) {
               currentSum += array[i];

               if(currentSum < array[i]) {
                   currentSum = array[i];
                   tempStartIndex = i;
               }

               if (currentSum > maxSum) {
                   maxSum = currentSum;
                   maxStartIndex = tempStartIndex;
                   maxEndIndex = i;
               }
            }
            ++maxEndIndex;
            return (maxSum, array[maxStartIndex .. maxEndIndex]);
        }
    }
}
