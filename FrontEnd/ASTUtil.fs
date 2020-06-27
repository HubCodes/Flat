module ASTUtil

open Flat.Core.Symbol
open Flat.Core.AST

let varOf id =
  { Sym = Symbol.OfId id }

let fnOf id args block =
  { Sym = Symbol.OfId id; Args = args; Body = block }
