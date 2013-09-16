module Problem1

(*
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000.
*)

let isMultipleOf x y = (y % x = 0)
let isMultipleOf3Or5 x = isMultipleOf 3 x || isMultipleOf 5 x

let sumOfMultiples =
    [1..999]
    |> List.filter isMultipleOf3Or5
    |> List.sum