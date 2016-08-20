let set1 = Set.ofList [ 1 .. 6 ]
let set2 = Set.ofList [ 1 .. 5 ]
let set3 = Set.ofList [ 1 .. 6 ]
let set4 = Set.ofList [ 5 .. 10 ]
printfn "%A is a proper subset of %A: %b" set2 set1 (set2.IsProperSubsetOf set1)
printfn "%A is a proper subset of %A: %b" set3 set1 (set3.IsProperSubsetOf set1) 
printfn "%A is a proper subset of %A: %b" set4 set1 (set4.IsProperSubsetOf set1) 