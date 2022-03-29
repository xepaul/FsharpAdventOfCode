[<AutoOpen>]
module CommonTests =
open System
open Xunit
open FsharpAdventOfCode2020.Common   

[<RequireQualifiedAccess>]
type Direction = 
    | E| SE | SW | W | NW | NE
    static member minbound = Direction.E
    static member maxbound = Direction.NE
    static member (..) (start:Direction) (finish:Direction) =
        seq { start ..DuStep.Next.. finish}
    static member (+)  (d:Direction, d2:DuStep) = 
    match d with
    | Direction.E -> Direction.SE
    | Direction.SE -> Direction.SW
    | Direction.SW -> Direction.W
    | Direction.W -> Direction.NW
    | Direction.NW -> Direction.NE
    | Direction.NE -> Direction.E

[<Fact>]
let ``Test Du range`` () =
        let data = seq { Direction.minbound ..DuStep.Next.. Direction.maxbound}                    
        let expected = seq { Direction.E;Direction.SE;Direction.SW;Direction.W;Direction.NW;Direction.NE}
        Assert.True(expected |> Seq.zip data |> Seq.forall (fun (a,b) ->a =b))
