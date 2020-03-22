using System.Collections.Generic;

namespace Library {
    public static class MatrixOperations {
        public static int[] TraverseSpiral(this int[][] inputMatrix)
        {
            var linearArray = new List<int>();

            var m = inputMatrix.Length;
            if (m == 0) return linearArray.ToArray();

            var n = inputMatrix[0].Length;

            var (direction, left, right, top, bottom) = 
                (0, 0, n - 1, 0, m - 1);

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