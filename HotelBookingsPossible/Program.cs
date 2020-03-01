using System;
using System.Linq;
using static HotelBookingsPossible.EventType;

namespace HotelBookingsPossible
{
    public enum EventType { Arrival, Departure }
    class Program
    {
        static void Main(string[] args)
        {
            // Data
            var arrivals = new[] { 1, 3, 5 };
            var departures = new[] { 2, 6, 8 };
            // var totalRooms = 2;
            var totalRooms = 1;

            // Execution
            var isPossible = CheckBookingPossibility(arrivals, departures, totalRooms);

            // Result
            var result = isPossible ? "Yes" : "No";
            Console.WriteLine($"Possible: {result}\n");
        }

        private static bool CheckBookingPossibility(
            int[] arrivals,
            int[] departures,
            int totalRooms)
        {
            var events =
                (arrivals.Select(a => (date: a, type: Arrival))
                    .Union(departures.Select(d => (date: d, type: Departure))))
                .OrderBy(e => e.date);

            var count = 0;
            foreach (var (date, type) in events)
            {
                if (type == Arrival) count++;
                else count--;

                if (count > totalRooms) return false;
            }
            return true;
        }
    }
}
