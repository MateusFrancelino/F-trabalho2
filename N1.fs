let detectarmultiplotre lista=
    

    lista |>List.filter (fun n->n%2=0) 
          |> List.map (fun n->n*2) 
          |> List.filter (fun n->n%3=0)



[<EntryPoint>]
let main argv =
    
    
    let lista = detectarmultiplotre [0..20]

    List.iter(printfn "%d") lista

    
    


        
    0 
