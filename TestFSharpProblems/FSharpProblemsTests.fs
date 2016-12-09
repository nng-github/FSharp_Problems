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

[<TestFixture>]
type Problem4Tests() = 
    [<Test>]
    member this.``Given a list with no elements should return zero``() = 
        []
        |> Problem4.myLength
        |> should equal 0 
    
    [<Test>]
    member this.``Given a list with two elements should return two``() = 
        [222;888]
        |> Problem4.myLength
        |> should equal 2

[<TestFixture>]
type Problem5Tests() = 
    [<Test>]
    member this.``Given [1;2;3] should return [3;2;1]``() =
        [1;2;3]
        |> Problem5.reverse
        |> should equal [3;2;1]

    [<Test>]
    member this.``Given [a;b;c;d] should return [d;c;b;a]``() =
        let elements = (List.ofSeq("abcd"))
        elements
            |> Problem5.reverse2
            |> should equal ['d';'c';'b';'a']

[<TestFixture>]
type Problem6Tests() =
    [<Test>]
    member this.``Given a [1;2;3] should return false``() = 
        [1;2;3]
        |> Problem6.isPalindrome
        |> should equal false

    [<Test>]
    member this.``Given a [1;2;2;1] should return true``() = 
        [1;2;2;1]
        |> Problem6.isPalindrome
        |> should equal true

    [<Test>]
    member this.``Given a [mom] should return true``() = 
        let elements = (List.ofSeq("mom"))
        elements
            |> Problem6.isPalindrome2
            |> should equal true