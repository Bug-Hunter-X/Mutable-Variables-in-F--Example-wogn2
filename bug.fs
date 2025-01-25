let mutable x = 10
let mutable y = 20
let mutable z = 30

let add x y = x + y

let inline add3 x y z = x + y + z

let result1 = add x y
let result2 = add3 x y z
printfn "%d %d" result1 result2 // Output: 30 60

x <- 100
y <- 200
z <- 300

let result3 = add x y
let result4 = add3 x y z
printfn "%d %d" result3 result4 // Output: 300 600

//In this example, the mutable variables x,y,z are used.However, If  the function is not using mutable variables or is not mutating any external state, it will be more functional. This can improve the readability, maintainability and testability of the code. In this case, we don't need to use mutable variables. We can make x, y, and z immutable.