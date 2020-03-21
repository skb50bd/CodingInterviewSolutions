namespace Library

module Intervals =
    open Library.Utils
    open System.Collections.Generic
    
    let Merge input = 
        let output = Stack<(int * int)>()
        for iStart, iEnd in input do
            match output with
            | EmptySeq -> 
                output.Push(iStart, iEnd)
            | _ ->
                let lastStart, lastEnd = output.Peek()
                if iStart < lastEnd then
                    let merged = 
                        List.min [ lastStart; iStart ], 
                        List.max [ lastEnd; iEnd ]  
                    output.Pop() |> ignore
                    output.Push(merged)
                else output.Push(iStart, iEnd)
        output |> Seq.rev

    let Insert intervals (interval: int * int) = 
        match intervals with
        | EmptySeq -> seq { interval }
        | _ ->
            let st, _ = interval
            let tryFindIndex = Seq.tryFindIndex (fun (st', _) -> st' > st)
            match tryFindIndex intervals with
            | Some index -> 
                seq { yield! intervals |> Seq.take index 
                      interval
                      yield! intervals |> Seq.skip (index) }
            | None -> seq { yield! intervals; interval }
    
    let InsertAndMerge intervals interval =
        Insert intervals interval |> Merge
