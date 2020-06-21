module Flat.FrontEnd

open FSharp.Text.Lexing

let parse str =
  let lexBuffer = LexBuffer<char>.FromString str
  let parseResult = Parser.program Lexer.tokenize lexBuffer
  parseResult
