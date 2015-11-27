namespace SICP.Exercise.Fs

module Chapter1 =
    let square x = x*x

    let sumOfSquare x y = (square x) + (square y)

    let abs = function 
        | x < 0 -> -x
        | _ -> x