module rec Flat.Core.AST

type Expr =
  | Add of Expr * Expr
  | Sub of Expr * Expr
  | Literal of Literal

type Literal =
  | Int of int
