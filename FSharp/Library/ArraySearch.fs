namespace Library

module ArraySearch =
    let rec searchIndex (ar: int list) item startIndex endIndex =
        if ar.[startIndex] > item then
            startIndex - 1
        elif ar.[endIndex] < item then 
            endIndex + 1
        else
            let mid = (endIndex + startIndex) / 2
            match ar.[mid] with
            | x when x = item -> 
                mid
            | x when x < item -> 
                searchIndex ar item (mid + 1) endIndex
            | _ -> 
                searchIndex ar item startIndex (mid - 1)
