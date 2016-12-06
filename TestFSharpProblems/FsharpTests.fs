namespace TestFSharpProblems

open FsUnit
open NUnit.Framework
open FSharpProblems


[<TestFixture>]
type Problem1Tests() = 
            
    [<Test>]
    member this.``Given list with single item should return item``() = 
        [5]
        |> Problem1.MyLast
        |> should equal 5

    [<Test>]
    member this.``Given list with multiple items should return last item``() = 
        [5;6;7]
        |> Problem1.MyLast
        |> should equal 7

            
    [<Test>]
    member this.``2 Given list with single item should return item``() = 
        [5]
        |> Problem1.MyLast2
        |> should equal 5

    [<Test>]
    member this.``2 Given list with multiple items should return last item``() = 
        [5;6;7]
        |> Problem1.MyLast2
        |> should equal 7

    [<Test>]
    member this.``3 Given list with single item should return item``() = 
        [5]
        |> Problem1.MyLast3
        |> should equal 5

    [<Test>]
    member this.``3 Given list with multiple items should return last item``() = 
        [5;6;7]
        |> Problem1.MyLast3
        |> should equal 7

    [<Test>]
    member this.``4 Given list with single item should return item``() = 
        [5]
        |> Problem1.MyLast4
        |> should equal 5

    [<Test>]
    member this.``4 Given list with multiple items should return last item``() = 
        [5;6;7]
        |> Problem1.MyLast4
        |> should equal 7


[<TestFixture>]
type Problem2Tests() =
    [<Test>]
    member this.``Given list with two items should return first item``() = 
        [6;7]
        |> Problem2.myButLast
        |> should equal 6
        
    [<Test>]
    member this.``Given list with multiple items should return second last item``() = 
        [6;7;5;8]
        |> Problem2.myButLast
        |> should equal 5 
        
        
    [<Test>]
    member this.``2 Given list with multiple items should return second last item``() = 
        [6;7;5;8]
        |> Problem2.myButLast2
        |> should equal 5

        
    [<Test>]
    member this.``3 Given list with multiple items should return second last item``() = 
        [6;7;5;8;123;543]
        |> Problem2.myButLast3
        |> should equal 123  

    [<Test>]
    member this.``4 Given list with multiple items should return second last item``() = 
        [6;7;5;8;123;543]
        |> Problem2.myButLast4
        |> should equal 123

    [<Test>]
    member this.``5 Given list with multiple items should return second last item``() = 
        [6;7;5;8;123;543]
        |> Problem2.myButLast5
        |> should equal 123

[<TestFixture>]
type Problem3Tests() =
    [<Test>]
    member this.``Given list with three items and K of 2 should return second item``() = 
        let elements = [1;2;3]
        let result = Problem3.elementAt elements 2
        result 
            |> should equal 2  
            
    [<Test>]
    member this.``Given a list of strings should return matching character``() = 
        let elements = (List.ofSeq "fsharp")
        let result = Problem3.elementAt elements 5
        result 
            |> should equal 'r'   
                     
    [<Test>]
    member this.``2 Given a list of strings should return matching character``() = 
        let elements = (List.ofSeq "fsharp")
        let result = Problem3.elementAt2 elements 5
        result 
            |> should equal 'r'