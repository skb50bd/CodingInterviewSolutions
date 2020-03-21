namespace Library

module Math =
    let rec Factorial n =
        match n with
        | 0 -> 1
        | _ -> n * Factorial (n - 1)

    let rec FactorialTail n =
        let rec accumulatedFactorial x acc =
            match x with
            | 0 -> acc
            | _ -> accumulatedFactorial (x - 1) (x * acc)   

        accumulatedFactorial n 1                 

    let FactorialIterative n =
        let mutable result = 1
        for i = n downto 1 do
            result <- result * i
        result
