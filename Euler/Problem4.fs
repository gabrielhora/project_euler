module Problem4

(*
A palindromic number reads the same both ways. The largest palindrome 
made from the product of two 2-digit numbers is 9009 = 91 × 99.
Find the largest palindrome made from the product of two 3-digit numbers.
*)

let reverse (str:string) =
    new string(str.ToCharArray() |> Array.rev)

let palindromes =
    seq { for x in [100..999] do
          for y in [100..999] -> string(x * y) }
    |> Seq.filter (fun n -> n = reverse n) // filter palindromes
    |> Seq.map int // convert to numbers

let result =
    palindromes |> Seq.max