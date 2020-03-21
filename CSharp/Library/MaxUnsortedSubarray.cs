using System.Linq;

namespace Library
{
    public static class MaxUnsortedSubarray
    {
        public static (int start, int end) FindUnsortedIndices(this int[] input)
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

            return (start, end - 1);
        }
    }
}