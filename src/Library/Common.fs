module Common 

open System.IO 
    type DuStep = | Current
                  | Next
                  static member Zero = Current
                  static member One = Next

let d = System.Environment.CurrentDirectory ;

let testFileBasePath =  System.Environment.CurrentDirectory+"/data"


type AocDay = | Day5
type AocExample = | Example5

let getNfromDay = function   
                | Day5 -> 5
let getNfromExample = function   
                |      Example5 -> 5              

let readPuzzleInputFromFile (day:AocDay)  =
    System.IO.File.ReadLines(testFileBasePath + $"Day{getNfromDay(day)}_Data.txt") |> Seq.toList

let readPuzzleExampleInputFromFile (day:AocDay)  =
    System.IO.File.ReadLines(testFileBasePath + $"Day{getNfromDay(day)}_DataExample.txt") |> Seq.toList
    

let readPuzzleExampleInputFromFileN (day:AocDay) (n:AocExample)=
    System.IO.File.ReadLines(testFileBasePath + $"Day{getNfromDay(day)}_DataExample{getNfromExample(n)}.txt") |> Seq.toList
