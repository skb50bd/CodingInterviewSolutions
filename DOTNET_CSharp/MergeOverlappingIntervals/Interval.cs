namespace MergeOverlappingIntervals
{
    public struct Interval
    {
        public int Start { get; private set; }
        public int End { get; private set; }

        public Interval(int start, int end)
        {
            Start = start;
            End = end;
        }
    }
}
