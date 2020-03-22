namespace Library

module Matrix =
    type Direction =
        | Right = 0
        | Down = 1
        | Left = 2
        | Up = 3

    let TraverseSpiral matrix =
        match Array2D.length1 matrix with
        | 0 ->
            Array.empty
            
        | height ->
            let width = Array2D.length2 matrix

            let rotate direction = (direction + 1) % 4

            let rec traverse dir l r t b =
                if l > r || t > b then
                    Array.empty

                else
                    let rest() = traverse (rotate dir) l r t b
                    let rest'() = traverse (rotate dir) (l + 1) (r - 1) (t + 1) (b - 1)

                    let d = enum<Direction> dir

                    let current =
                        match d with
                        | Direction.Right ->
                            [| for i in [ l .. r ] -> matrix.[t, i] |]

                        | Direction.Down ->
                            [| for i in [ (t + 1) .. b ] -> matrix.[i, r] |]

                        | Direction.Left ->
                            [| for i in [ (r - 1) .. (-1) .. l ] -> matrix.[b, i] |]

                        | Direction.Up ->
                            [| for i in [ (b - 1) .. (-1) .. (t + 1) ] -> matrix.[i, l] |]

                        | _ -> Array.empty

                    [| yield! current
                       yield! if d = Direction.Up then rest'() else rest() |]

            traverse 0 0 (width - 1) 0 (height - 1)
