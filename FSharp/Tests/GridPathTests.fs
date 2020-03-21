namespace Tests

module GridPathTests = 
    open Library.GridPaths
    open Xunit
    
    [<Fact>]
    let TestConst() =
        let expected = 10;
        let actual = CountUniquePathsConst 3 4
        Assert.Equal(expected, actual)

    [<Fact>]
    let TestDP() =
        let expected = 10;
        let actual = CountUniquePathsDP 3 4
        Assert.Equal(expected, actual);
        