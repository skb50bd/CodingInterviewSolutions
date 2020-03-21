namespace Tests

module HotelBookingsPossibleTests =
    open Library.Utils
    open Library.HotelBookingsPossible
    open Xunit

    let data = [|
        // False Test
        [| ~~[ 1; 3; 5 ]; ~~[ 2; 6; 8 ]; ~~1; ~~false |]

        // True Test
        [| ~~[ 1; 3; 5 ]; ~~[ 2; 6; 8 ]; ~~2; ~~true |]
    |]

    [<Theory>]
    [<MemberData("data")>]
    let Test (arrivals, departures, rooms, expected) =
        let actual = Check arrivals departures rooms
        Assert.Equal(expected, actual)
