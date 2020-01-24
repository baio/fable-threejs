module CanvasDiffer

open Models
open Models.Diffs
open Aether
open Aether.Operators


let getValues x =
    x
    |> Map.toSeq
    |> Seq.map snd
    
let getCubeDiff (perv: Cube) (cur: Cube): CubeDiff =
    {
        Id = perv.Id
        X = if perv.Position.X = cur.Position.X then None else Some cur.Position.X
        Y = if perv.Position.Y = cur.Position.Y then None else Some cur.Position.Y
        Size = if perv.Size = cur.Size then None else Some cur.Size
    }
        
let getObjDiff = function
    | (Cube x, Cube y) ->
       getCubeDiff x y |> ObjCubeDiff
        
let calcUpdate (perv: Canvas) (cur: Canvas): ObjDiff seq =
    // iterate cure
    // find same in perv
    // create diffs
    let getSame cur =
        let id = cur |> Optic.get Object.Id_
        let perv = perv.Objects |> Optic.get (Map.key_ id)
        match perv with
        | Some _perv -> Some(cur, _perv)
        | None -> None

    cur.Objects |> getValues |> Seq.choose getSame |> Seq.map getObjDiff

let getDiff (perv: Canvas option) (cur: Canvas): CanvasDiff =
    match perv, cur with
    | Some _perv, _cur ->
        { create = []
          update = calcUpdate _perv _cur }
    | None, _cur ->
        { create = _cur.Objects |> getValues
          update = [] }
