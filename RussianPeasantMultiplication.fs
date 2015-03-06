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

let multiply x y =
    ascendingTuple x y |> constructList |> sumRightColumnWhereLeftIsOdd
