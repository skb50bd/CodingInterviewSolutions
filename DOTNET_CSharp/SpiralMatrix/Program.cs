using System;
using System.Collections.Generic;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // var inputMatrix = new int[][] {
            //     new [] { 1, 2, 3 },
            //     new [] { 4, 5, 6 },
            //     new [] { 7, 8, 9 }
            // };

            var inputMatrix = new int[][] {
                new [] { 01, 02, 03, 04 },
                new [] { 05, 06, 07, 08 },
                new [] { 09, 10, 11, 12 },
                new [] { 13, 14, 15, 16 } 
            };

            var result = GeSpiralArray(inputMatrix);
            Console.WriteLine(string.Join(", ", result));
        }

        static int[] GeSpiralArray(int[][] inputMatrix)
        {
            var linearArray = new List<int>();

            var m = inputMatrix.Length;
            if (m == 0) return linearArray.ToArray();

            var n = inputMatrix[0].Length;

            var left = 0;
            var right = n - 1;
            var top = 0;
            var bottom = m - 1;

            var direction = 0;
            while (true)
            {
                if (direction == 0)
                {
                    for (var i = left; i <= right; i++)
                    {
                        linearArray.Add(inputMatrix[top][i]);
                    }
                }
                else if (direction == 1)
                {
                    for (var i = top + 1; i <= bottom; i++)
                    {
                        linearArray.Add(inputMatrix[i][right]);
                    }
                }
                else if (direction == 2)
                {
                    for (var i = right - 1; i >= left; i--)
                    {
                        linearArray.Add(inputMatrix[bottom][i]);
                    }
                }
                else
                {
                    for (var i = bottom - 1; i > top; i--)
                    {
                        linearArray.Add(inputMatrix[i][left]);
                    }
                    left++;
                    right--;
                    top++;
                    bottom--;
                }
                if(left > right || top > bottom) break;
                direction = (direction + 1) % 4;
            }

            return linearArray.ToArray();
        }
    }
}
