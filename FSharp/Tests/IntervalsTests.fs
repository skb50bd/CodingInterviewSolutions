namespace Tests

module InsertAndMergeIntervalsTests =
    open Library.Intervals
    open Xunit
    open Library.Utils
    
    let emptySeq: seq<int * int> = Seq.empty
    let data = [|
        // Insert and Merge into an Empty Interval-List
        [| ~~emptySeq 
           ~~(1, 3)
           ~~(seq { (1, 3) }) |]
        
        // Beginning of the Intervals
        [| ~~(seq { (5, 8); (9, 11) })
           ~~(1, 3)
           ~~(seq { (1, 3); (5, 8); (9, 11) }) |]
        
        // End of the Intervals
        [| ~~(seq { (5, 8); (9, 11) })
           ~~(12, 13)
           ~~(seq { (5, 8); (9, 11); (12, 13) }) |]
   
        // In Between Two Intervals
        [| ~~(seq { (1, 5); (9, 11) })
           ~~(6, 7)
           ~~(seq { (1, 5); (6, 7); (9, 11) }) |]
   
        // Inside an Interval
        [| ~~(seq { (5, 8); (9, 11) })
           ~~(6, 8)
           ~~(seq { (5, 8); (9, 11) }) |]

        // All Intervals Fit Inside the New Interval
        [| ~~(seq { (5, 8); (9, 11) })
           ~~(1, 13)
           ~~(seq { (1, 13) }) |]

        // Overlaps with One
        [| ~~(seq { (5, 8); (9, 11) })
           ~~(1, 6)
           ~~(seq { (1, 8); (9, 11) }) |]

        // Overlaps with One 2
        [| ~~(seq { (3, 5); (9, 11) })
           ~~(7, 10)
           ~~(seq { (3, 5); (7, 11) }) |]
    
        // Overlaps with Two
        [| ~~(seq { (5, 8); (9, 11) })
           ~~(7, 10)
           ~~(seq { (5, 11) }) |]
   
        // Overlaps with Multiple
        [| ~~(seq { (1, 4); (5, 8); (9, 11); (13, 15) })
           ~~(2, 12)
           ~~(seq { (1, 12); (13, 15) }) |]
    |]

    [<Theory>]
    [<MemberData("data")>]
    let ``Insert and Merge Test`` (input, item, expected) =
        let actual = InsertAndMerge input item
        Assert.Equal<seq<int * int>>(expected, actual)

    [<Fact>]
    let ``Merge Test`` () =
        let input = seq { (1, 3); (2, 6); (8, 10); (15, 18) }
        let expected = seq { (1, 6); (8, 10); (15, 18) }
        let actual = Merge input
        Assert.Equal<seq<int * int>>(expected, actual)