
let rec potenciad x=
    match x with
    | (var1,0) -> 1
    | (var1,var2) -> var1*potenciad(var1,var2-1)



let rec detectar n =
    match n with
    | (var1,var2) when var1 = var2 -> printfn ("%d")(var1*var2)
    | (var1,var2) when var1 < var2 -> potenciad(var1,var2)
    | (var1,var2) when var2 < var1 -> potenciad(var2,var1)

    







[<EntryPoint>]
let main argv =

    let n1=2
    let n2=3
    let numero= potenciad (n1,n2)
    printfn "%d"numero


    
    


        
    0 
