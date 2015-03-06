module RussianPeasantMultiplication

let private (|Even|Odd|) n =
    if n % 2 = 0 then Even else Odd

let private ascendingTuple x y =
    if x < y then (x, y) else (y, x)

let rec private constructList tuple =
    match tuple with
    | (0, _) -> []
    | (x, y) -> tuple :: constructList (x / 2, y * 2)

let rec private sumRightColumnWhereLeftIsOdd list =
    match list with
    | [] -> 0
    | (Even, _)    :: tail -> 0 + sumRightColumnWhereLeftIsOdd tail
    | (Odd, right) :: tail -> right + sumRightColumnWhereLeftIsOdd tail

let private correctSignForNegatives x y multiple =
    if (x > 0 && y > 0 || x < 0 && y < 0) then multiple else -multiple

let multiply x y =
    ascendingTuple x y                  // Smallest number first to minimise iterations of recursion
    |> constructList                    // Recursively construct the list by halving and doubling until the first column reaches 1
    |> sumRightColumnWhereLeftIsOdd     // Sum all of the values in the second column where the value in the first is odd
    |> abs                              // Take the absolute of the result (as it will be negative if the larger of the arguments is negative)
    |> correctSignForNegatives x y      // Return the negative of the multiplication if the arguments have opposite sign
