using System.Linq;
using static Library.EventType;

namespace Library {
    public enum EventType { Arrival, Departure }
    public static class HotelBookingsPossible {
        public static bool Check(
            int[] arrivals,
            int[] departures,
            int totalRooms)
        {
            var arr = arrivals.Select(a => (date: a, type: Arrival));
            var dep = departures.Select(d => (date: d, type: Departure));
            var events = arr.Union(dep)
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