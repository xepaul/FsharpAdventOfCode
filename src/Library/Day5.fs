module Day5

  module Day5Common =
    let stringToLines (list: string) =
        list.Split([| '\n' |])
        |> Seq.map (fun x -> x.Replace("\r", ""))
        |> Seq.toList

    let charToBinaryDigit =
        function
        | 'B'
        | 'R' -> 1
        | 'F'
        | 'L' -> 0
        | _ -> failwith "badData"

    let processLine4 s =
        s
        |> Seq.map charToBinaryDigit
        |> Seq.fold
            (fun (s, m) d ->
                let s' = if d = 1 then s + m else s
                let m' = m >>> 1
                s', m')
            (0, 1 <<< (10 - 1))
        |> fst

    let processLine s =
        s
        |> Seq.map charToBinaryDigit
        |> Seq.fold (fun acc digit -> (acc <<< 1) + digit) 0

    let processLine2 (s) =
        s
        |> Seq.fold
            (fun (s, m) ->
                function
                | 'B'
                | 'R' -> s + m, m >>> 1
                | 'F'
                | 'L' -> s, m >>> 1
                | _ -> failwith "badData")
            (0, 1 <<< (10 - 1))
        |> fst

  module Part1 =
      open Day5Common

      let processDay5 = Seq.map processLine >> Seq.max

      let processDay5String = stringToLines >> processDay5