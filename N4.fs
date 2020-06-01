
let rec produtolista x=
    match x with
    |(var1,var2)when var2 = 1 -> true
    |(var1,var2)when var1%2=0->false
    |(var1,var2)when var1%var2=0->false
    |(var1,var2)when var1%var2<>0-> produtolista(var1,var2-1)


let imprimirprimo x=
    match x with
    | (var1,var2)when produtolista (var1,var2) =true -> printfn"o Numero é %d primo" var1
    | (var1,var2)when produtolista (var1,var2) = false -> printfn "o Numero %d nao e primo"var1

[<EntryPoint>]
let main argv =

    let numero = 18
    let temp = (numero-1)
    imprimirprimo (numero,temp)


    0
