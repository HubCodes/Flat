open System
open Flat.FrontEnd
open Lexer

[<EntryPoint>]
let main _ =
  let code =
    """
    fn a(i, j){
      i + j;  
    }
"""
  try
    printf "%A" <| parse code
  with
  | SyntaxError e -> printf "%A" e
  | e -> printf "%A" e
  0
