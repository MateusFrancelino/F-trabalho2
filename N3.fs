
let rec produtolista x=
    match x with
    |head :: tail ->  (head*head)::produtolista tail;
    |[] -> []

[<EntryPoint>]
let main argv =

    let lista =[0..10]
    printfn " lista %A" lista
    let novalista = produtolista lista
    printfn " lista %A" novalista
    0
