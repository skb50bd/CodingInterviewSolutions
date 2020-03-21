namespace Library

module HotelBookingsPossible =
    type EventType = Arrival | Departure
    type Event = { Date: int; Type: EventType }

    let Check arrivals departures totalRooms =
        let arr = 
            arrivals 
            |> List.map (fun a -> { Date = a; Type = Arrival })
        
        let dep = 
            departures 
            |> List.map (fun d -> { Date = d; Type = Departure })

        let events = 
            arr @ dep 
            |> List.sortBy (fun e -> e.Date)
        
        let mutable count = 0
        let mutable flag = true

        for e in events do
            if e.Type = Arrival then 
                count <- count + 1
            else 
                count <- count - 1;
            
            if count > totalRooms then 
                flag <- false
        
        flag
    