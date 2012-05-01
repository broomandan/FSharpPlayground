#light


let sq z = z *z
let d= sq ( 5 )

let t= sq ( 5 )


//let rec factorial n = if n=0 then 1 else n * factorial (n-1)
//let result=factorial(3)
//
let sumOfSqrt nums = 
nums 
|> Seq.map sq
|> Seq.sum

let data = [2;3;4]