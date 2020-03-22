namespace Tests 
module MatrixTests = 
    open Library.Matrix
    open Library.Utils
    open Xunit

    let data = 
        [|
            // Even Dimentions
            [|
                ~~ (array2D [
                    [| 01; 02; 03; 04 |];
                    [| 05; 06; 07; 08 |];
                    [| 09; 10; 11; 12 |];
                    [| 13; 14; 15; 16 |]])
                ~~[| 01; 02; 03; 04
                     08; 12; 16; 15
                     14; 13; 09; 05
                     06; 07; 11; 10 |]                
            |]

            // Odd Dimentions
            [|
                ~~(array2D [
                    [| 1; 2; 3 |];
                    [| 4; 5; 6 |];
                    [| 7; 8; 9 |] ])
                ~~[| 1; 2; 3
                     6; 9; 8
                     7; 4; 5 |]                
            |]

            // Single Element
            [| ~~(array2D [ [| 1 |] ]); ~~[| 1 |] |]

            // Vertical Matrix
            [|
                ~~(array2D [
                    [| 1; 2 |];
                    [| 3; 4 |];
                    [| 5; 6 |];
                    [| 7; 8 |] ])
                ~~[| 1; 2; 4; 6; 8; 7; 5; 3 |]                
            |]
        |]

    [<Theory>]
    [<MemberData("data")>]
    let Test (input: int[,], expected) = 
        let actual = TraverseSpiral input
        Assert.Equal<int[]>(expected, actual);
