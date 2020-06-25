open System
open Flat.FrontEnd
open Lexer

[<EntryPoint>]
let main _ =
  let code =
      """
a = 1 + 1
"""
  try
    printf "%A" <| parse code
  with
  | SyntaxError e -> printf "%A" e
  0
