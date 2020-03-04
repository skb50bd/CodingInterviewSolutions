namespace Library
{
    public static class ArrayExtensions
    {
        public static int SearchIndex(
            this int[] array,
            int item, int start, int end)
        {
            if (array[start] > item) 
                return start - 1;

            else if (array[end] < item) 
                return end + 1;
            
            var mid = (end + start) / 2;
            if (array[mid] == item) 
                return mid;

            else if (array[mid] < item) 
                return array.SearchIndex(item, mid + 1, end);

            else 
                return array[..mid].SearchIndex(item, start, mid - 1);
        }
    }
}