module Problem3

(*
The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of the number 600851475143 ?
*)

let factors x =
    let rec calculate(y, d) =
        [ if y > 1L then
              if y % d = 0L then
                  yield d
                  yield! calculate(y / d, d)
              else
                  yield! calculate(y, d + 1L) ]
    calculate(x, 2L)

let result = 
    factors 600851475143L |> List.max