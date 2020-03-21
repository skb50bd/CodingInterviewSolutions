namespace Library

module GridPaths =
    open Math
    let CountUniquePathsConst rows columns =
        let r, c = (rows - 1, columns - 1)
        Factorial (r + c) / (Factorial(r) * Factorial(c))
    
    let CountUniquePathsDP rows columns =
        let paths = 
            Array2D.init rows columns (fun _ _ -> 0)
        
        for i = 0 to rows - 1 do 
            paths.[i, 0] <- 1
        
        for i = 0 to columns - 1 do 
            paths.[0, i] <- 1
        
        for i = 1 to rows - 1 do
            for j = 1 to columns - 1 do
                paths.[i, j] <- paths.[i - 1, j] + paths.[i, j - 1]
        
        paths.[rows - 1, columns - 1]