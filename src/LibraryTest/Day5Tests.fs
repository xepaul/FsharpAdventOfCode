[<AutoOpen>]
module Day5Test 
open System
open Xunit
open Common   

open Day5.Part1

module Day5TestsPart1 =

  open Xunit

  [<Fact>]
  let ``Test inline sample item1`` () =
      let data = @"BFFFBBFRRR"
      let expected = 567
      let result = Day5.Day5Common.processLine data
      Assert.Equal(expected, result)

  [<Fact>]
  let ``Test inline sample  item2`` () =
      let data = @"FFFBBBFRRR"
      let expected = 119
      let result = Day5.Day5Common.processLine data
      Assert.Equal(expected, result)

  [<Fact>]
  let ``Test inline sample  item3`` () =
      let data = @"BBFFBBFRLL"
      let expected = 820
      let result = Day5.Day5Common.processLine data
      Assert.Equal(expected, result)
