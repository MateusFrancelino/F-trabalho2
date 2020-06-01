let rec potenciad x=
    match x with
    | (var1,0) -> 1
    | (var1,var2) -> var1*potenciad(var1,var2-1)



let rec detectar n =
    match n with
    | (var1,var2) when var1 = var2 -> (var1*var2)
    | (var1,var2) when var1 < var2 -> potenciad(var1,var2)
    | (var1,var2) when var2 < var1 -> potenciad(var1,var2)

    







[<EntryPoint>]
let main argv =

    let numero = detectar (2,5)
    printfn "%d" numero    
    0 
