module rec Flat.Core.AST

open Flat.Core.Symbol

type Stmt =
  | Expr of Expr
  | Return of Expr

type Expr =
  | Add of lhs: Expr * rhs: Expr
  | Sub of lhs: Expr * rhs: Expr
  | Assign of lhs: Expr * rhs: Expr
  | Literal of Literal
  | Lhs of LhsExpr
  | Func of FuncExpr
  | Block of Block
  
type LhsExpr =
  | Var of Var

type Literal =
  | Int of int
  
type FuncExpr =
  { Sym: Symbol
    Args: List<Var>
    Body: Block }

type Block = List<Stmt>

type Var =
  { Sym: Symbol }
