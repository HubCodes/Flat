open System
open Flat.FrontEnd

[<EntryPoint>]
let main argv =
    printf "%A" <| parse "1 + 1"
    0
