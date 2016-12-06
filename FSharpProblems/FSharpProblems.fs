namespace FSharpProblems

module Problem1 = 
    let MyLast elements =  
        elements
          |> Seq.last

    let MyLast2 elements =  
        elements
        |> Seq.rev
        |> Seq.head

    let rec MyLast3 elements =  
        match elements with
            | [] -> failwith "need a non-empty list"
            | [x] -> x
            | _::tail -> MyLast3 tail

    let MyLast4 elements =  
        List.reduce (fun _ b -> b) elements

module Problem2 = 
    let myButLast elements = 
        elements
         |> Seq.rev
         |> Seq.tail
         |> Seq.head

    let rec myButLast2 elements = 
         match elements with
            | [] -> failwith "need a non-empty list"
            | [x] -> failwith "need a list with at least two items"
            | [x;y] -> x
            | _::tail -> myButLast2 tail

    let myButLast3 (elements : list<int>) = 
        let lengthOfSecondLast = elements.Length - 2;
        elements.Item(lengthOfSecondLast)

    let myButLast4 (elements : list<int>) = 
        elements.[elements.Length - 2]

    let myButLast5 elements = 
        elements
        |> List.rev
        |> List.item 1

module Problem3 = 
    let elementAt elements position = 
        elements
        |> List.item(position - 1)
        
    let rec elementAt2 elements position = 
        match elements, position with
        | [],_ -> failwith "error"
        | head::tail, 1 -> head
        | head::tail, n -> elementAt2 tail (n-1)
