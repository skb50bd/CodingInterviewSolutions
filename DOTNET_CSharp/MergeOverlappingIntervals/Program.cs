using System.Linq;
using System;
using System.Collections.Generic;

namespace MergeOverlappingIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new[] {
                new Interval (1, 3),
                new Interval (2, 6),
                new Interval (8, 10),
                new Interval (15, 18)
            };

            var output = GetMergedIntervals(input);    
            var result = string.Join(", ", output.Select(i => $"[{i.Start}, {i.End}]"));
            Console.WriteLine(result);
        }

        private static Interval[] GetMergedIntervals(Interval[] input) {
            var sortedInput = input.OrderBy(i => i.Start);
            var output = new Stack<Interval>();

            foreach (var interval in sortedInput)
            {
                if (output.Any())
                {
                    var last = output.Peek();
                    if (interval.Start < last.End)
                    {
                        output.Pop();
                        output.Push(new Interval(last.Start, interval.End));
                    }
                    else output.Push(interval);
                }
                else
                {
                    output.Push(interval);
                }
            }

            return output.Reverse().ToArray();
        }
    }
}
