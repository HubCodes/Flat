module Flat.Core.Symbol

type Id = string

module SymbolId =
  let private symbolId = ref 0
  
  let next () =
    let value = !symbolId
    symbolId := value + 1
    value

type Symbol =
  { Name: Id
    Id: int }
with
  static member OfId id = { Name = id; Id = SymbolId.next () }
