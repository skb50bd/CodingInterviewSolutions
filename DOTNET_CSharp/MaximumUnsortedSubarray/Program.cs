using System;
using System.Linq;

namespace MaximumUnsortedSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new[] { 1, 2, 4, 5, 6, 7, 3, 5, 6 };
            // var input = new[] { 1, 2, 4, 3, 5, 6 };

            var (start, end) = GetUnsortedIndices(input);

            Console.WriteLine($"[ {string.Join(", ", input[start..end])} ]");
        }

        private static (int start, int end) GetUnsortedIndices(int[] input)
        {
            var len = input?.Length ?? 0;
            if (len == 0 || len == 1)
                return (-1, -1);

            len--;

            var start = -1;
            for (var i = 0; i < len; i++)
            {
                if (input[i] > input[i + 1])
                {
                    start = i;
                    break;
                }
            }

            var end = -1;
            for (var i = len; i > 0; i--)
            {
                if (input[i] < input[i - 1])
                {
                    end = i + 1;
                    break;
                }
            }

            var min = input[start..end].Min();
            for (var i = 0; i < start; i++)
            {
                if (input[i] >= min)
                {
                    start = i;
                    break;
                }
            }

            var max = input[start..end].Max();
            for (var i = input.Length - 1; i >= end; i--)
            {
                if (input[i] <= max)
                {
                    end = i + 1;
                    break;
                }
            }

            return (start, end);
        }
    }
}
