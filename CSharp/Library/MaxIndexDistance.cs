using static System.Math;

namespace Library {
    public static class MaxIndexDistance {
        public static int CalculateMaxIndexDistance(this int[] array)
        {
            // Construct a left to right Min-Array (n)
            var LMin = new int[array.Length];            
            LMin[0] = array[0]; 
            for (var i = 1; i < array.Length; i++)
                LMin[i] = Min(LMin[i - 1], array[i]);
            
            // Construct a right to left Max-Array (n)
            var RMax = new int[array.Length];
            RMax[^1] = array[^1];
            for(var i = RMax.Length - 2; i >= 0; i--)
                RMax[i] = Max(RMax[i + 1], array[i]);

            // Find the Max Distance (n)
            var x = 0;
            var y = 0;
            var maxDistance = -1;

            while (x < array.Length && y < array.Length) {
                if (LMin[x] < RMax[y]) {
                    maxDistance = Max(maxDistance, y - x);
                    y++;
                }
                else x++;
            }
            return maxDistance;
        }
    }
}