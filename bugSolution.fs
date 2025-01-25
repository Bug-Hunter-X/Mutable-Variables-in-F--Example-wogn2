let add x y = x + y

let inline add3 x y z = x + y + z

let x = 10
let y = 20
let z = 30

let result1 = add x y
let result2 = add3 x y z
printfn "%d %d" result1 result2 // Output: 30 60

let x2 = 100
let y2 = 200
let z2 = 300

let result3 = add x2 y2
let result4 = add3 x2 y2 z2
printfn "%d %d" result3 result4 // Output: 300 600