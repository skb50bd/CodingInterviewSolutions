namespace Library
module Utils =
    let inline (~~) x = x :> System.Object
    
    let (|EmptySeq|_|) a = 
        if Seq.isEmpty a then 
            Some() 
        else None

    let (|EmptyList|_|) a = 
        if List.isEmpty a then 
            Some() 
        else None

    let (|EmptyArray|_|) a = 
        if Array.isEmpty a then 
            Some() 
        else None
     