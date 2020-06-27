module Flat.Core.Env

open Flat.Core.Symbol
open Flat.Core.Type
open System.Collections.Generic

[<RequireQualifiedAccess>]
type Entry =
  | Var of name: Symbol * typ: Option<Type>
  | Fn of name: Symbol * typ: Option<Type>

type Scope =
  { Parent: Option<Scope>
    Entries: Dictionary<Symbol, Entry> }
with
  static member Empty () =
    { Parent = None
      Entries = Dictionary () }
  
  static member OfParent parent =
    { Parent = Some parent
      Entries = Dictionary () }

type Env () =
  let mutable scope = Scope.Empty ()

  member __.PushScope () =
    let newScope = Scope.OfParent scope
    scope <- newScope
    newScope
  
  member __.PopScope () =
    scope <- Option.get scope.Parent

  member __.SetEntry sym entry =
    scope.Entries.Add (sym, entry)

  member __.GetEntry sym =
    let rec find = function
      | Some scope ->
        match scope.Entries.TryGetValue sym with
        | true, entry -> Some entry
        | _ -> find scope.Parent
      | _ -> None
    find (Some scope)