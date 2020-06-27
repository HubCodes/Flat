module rec Flat.Core.AST

type Id = string

type Stmt =
  | Expr of Expr

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
  { Id: Id
    Args: List<Var>
    Body: Block }

type Block = List<Stmt>

type Var =
  { Id: Id }
