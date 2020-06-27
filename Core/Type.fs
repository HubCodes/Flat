module Flat.Core.Type

[<RequireQualifiedAccess>]
type Type =
  | Prim of Primitive
  | Fn of Fn

and Primitive =
  | Int

and Fn = List<Type> * Type
