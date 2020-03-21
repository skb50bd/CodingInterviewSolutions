namespace Tests

module ArraySerchTests =
    open Xunit
    open Library.ArraySearch
    open Library.Utils

    let data = [|
        // Item in the Middle
        [| ~~[ 1 .. 5 ]; ~~3; ~~2 |]

        // First Item
        [| ~~[ 1 .. 5 ]; ~~1; ~~0 |]

        // Last Item
        [| ~~[ 1 .. 5 ]; ~~5; ~~4 |]
        
        // Non-Existent Item From Right
        [| ~~[ 1 .. 5 ]; ~~6; ~~5 |]

        // Non-Existent Item from Left
        [| ~~[ 1 .. 5 ]; ~~0; ~~(-1) |]
        
        // Non-Existent Item in Between
        [| ~~[ 1 .. 5 ]; ~~3; ~~2 |]
        
        // Repeated Item
        [| ~~[ 1; 2; 4; 4; 5 ]; ~~4; ~~2 |]
    |]

    [<Theory>]
    [<MemberData("data")>]
    let Test (ar, item, expected) = 
        let actual = searchIndex ar item 0 (ar.Length - 1)
        Assert.Equal(expected, actual)
