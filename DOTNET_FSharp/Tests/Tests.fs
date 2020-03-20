namespace Tests

module ArraySerchTests =
    open Xunit
    open Library

    [<Fact>]  
    let ``Array Search Test 01``() =
        let ar = [ 1 .. 5 ]
        let item = 3;
        let expected = 2;
        let actual = ArraySearch.searchIndex ar item 0 (ar.Length - 1)
        Assert.Equal(expected, actual)

    [<Fact>]  
    let ``First Item``() =
        let ar = [ 1 .. 5 ]
        let item = 1;
        let expected = 0;
        let actual = ArraySearch.searchIndex ar item 0 (ar.Length - 1)
        Assert.Equal(expected, actual)

    [<Fact>]  
    let ``Last Item``() =
        let ar = [ 1 .. 5 ]
        let item = 5;
        let expected = 4;
        let actual = ArraySearch.searchIndex ar item 0 (ar.Length - 1)
        Assert.Equal(expected, actual)

    [<Fact>]  
    let ``Non Existent Item From Right``() =
        let ar = [ 1 .. 5 ]
        let item = 6;
        let expected = 5;
        let actual = ArraySearch.searchIndex ar item 0 (ar.Length - 1)
        Assert.Equal(expected, actual)

    [<Fact>]  
    let ``Non Existent Item From Left``() =
        let ar = [ 1 .. 5 ]
        let item = 0;
        let expected = -1;
        let actual = ArraySearch.searchIndex ar item 0 (ar.Length - 1)
        Assert.Equal(expected, actual)

    [<Fact>]  
    let ``Non Existent Item In Between``() =
        let ar = [ 1; 2; 4; 4; 5 ]
        let item = 3;
        let expected = 2;
        let actual = ArraySearch.searchIndex ar item 0 (ar.Length - 1)
        Assert.Equal(expected, actual)

    [<Fact>]  
    let ``Repeated Item``() =
        let ar = [ 1; 2; 4; 4; 5 ]
        let item = 4;
        let expected = 2;
        let actual = ArraySearch.searchIndex ar item 0 (ar.Length - 1)
        Assert.Equal(expected, actual)
