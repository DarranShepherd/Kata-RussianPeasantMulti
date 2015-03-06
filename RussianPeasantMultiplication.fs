module RussianPeasantMultiplication

let private (|Even|Odd|) n =
    if n &&& 1 = 1 then Odd else Even

let private ascendingTuple x y =
    if x < y then (x, y) else (y, x)

let rec private constructListByHalvingAndDoubling tuple =
    match tuple with
    | (0, _) -> []
    | (x, y) -> tuple :: constructListByHalvingAndDoubling (x >>> 1, y <<< 1)

let rec private sumRightColumnWhereLeftIsOdd list =
    match list with
    | (Odd, right) :: tail -> right + sumRightColumnWhereLeftIsOdd tail
    | (Even, _)    :: tail -> 0     + sumRightColumnWhereLeftIsOdd tail
    | [] -> 0

let private correctSignForNegatives x y multiple =
    if ((x > 0) = (y > 0)) then multiple else -multiple

let multiply x y =
    ascendingTuple (abs x) (abs y)       // Smallest number first to minimise iterations of recursion
    |> constructListByHalvingAndDoubling // Recursively construct the list by halving and doubling until the first column reaches 1
    |> sumRightColumnWhereLeftIsOdd      // Sum all of the values in the second column where the value in the first is odd
    |> correctSignForNegatives x y       // Return the negative of the multiplication if the arguments have opposite sign
