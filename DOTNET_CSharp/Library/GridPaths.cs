using static Library.Math;

namespace Library {
    public static class GridExtensions {
        public static int CountUniquePathsConst(int rows, int columns) {
            --rows;
            --columns;
            return Factorial(rows + columns) 
                / (Factorial(rows) * Factorial(columns));
        }

        public static int CountUniquePathsDP(int rows, int columns) {
            var paths = new int[rows, columns];

            for (var i = 0; i < rows; i++) 
                paths[i, 0] = 1;
            
            for (var i = 0; i < columns; i++) 
                paths[0, i] = 1;
            
            for (var i = 1; i < rows; i++)
                for (var j = 1; j < columns; j++) 
                    paths[i, j] = paths[i - 1, j] + paths[i, j - 1];

            return paths[rows - 1, columns - 1];
        }
    }
}