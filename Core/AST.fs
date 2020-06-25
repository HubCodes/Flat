module rec Flat.Core.AST

type Id = string

type Expr =
  | Add of Expr * Expr
  | Sub of Expr * Expr
  | Assign of Expr * Expr
  | Literal of Literal
  | Lhs of LhsExpr
  
type LhsExpr =
  | Var of Var

type Literal =
  | Int of int

type Var =
  { Id : Id }
