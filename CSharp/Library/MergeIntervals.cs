using System.Collections.Generic;
using System.Linq;
using static System.Math;
using Interval = System.ValueTuple<int, int>;

namespace Library
{
    public static class Merger {
        /// <summary>
        /// Merges a sorted array of overlapping intervals
        /// </summary>
        /// <param name="input">Sorted array of potentially overlapped intervals</param>
        /// <returns>Overlap-merged array of intervals</returns>
        public static Interval[] MergeOverlaps (
            this Interval[] input) 
        {
            var output = new Stack<Interval>();

            foreach (var interval in input)
            {
                if (output.Any())
                {
                    var last = output.Peek();
                    if (interval.Item1 < last.Item2)
                    {
                        var merged = (
                                Min(last.Item1, interval.Item1), 
                                Max(last.Item2, interval.Item2)); 
                                
                        output.Pop();
                        output.Push(merged);
                    }
                    else output.Push(interval);
                }
                else output.Push(interval);
            }

            return output.Reverse().ToArray();
        }

        /// <summary>
        /// Inserts a given interval into a given sorted array of intervals
        /// </summary>
        /// <param name="intervals">Sorted array of intervals</param>
        /// <param name="interval">New interval to be inserted</param>
        /// <returns>New array of intervals with the given interval at the correct position</returns>
        public static Interval[] Insert(
            this Interval[] intervals, 
            Interval interval) 
            {
            if (!intervals.Any()) return new[] { interval };
            
            var position = 0;
            for (var i = 0; i < intervals.Length; i++) {
                if (intervals[i].Item1 <= interval.Item1)
                    position = i + 1;
                else break;
            }

            var output = intervals.ToList();
            output.Insert(position, interval);
            return output.ToArray();
        }
    
        public static Interval[] InsertAndMerge(
            this Interval[] intervals,
            Interval interval
        ) => intervals.Insert(interval).MergeOverlaps();
    }
}