namespace Library
{
    public static class ArrayExtensions
    {
        public static int SearchIndex(
            this int[] ar,
            int item, int start, int end)
        {
            if (ar[start] > item) return start - 1;
            if (ar[end] < item) return end + 1;
            
            var mid = (end + start) / 2;
            return ar[mid] switch {
                var x when x == item => mid,
                var x when x < item  => ar.SearchIndex(item, mid + 1, end),
                _                    => ar.SearchIndex(item, start, mid - 1)
            };
        }
    }
}