module CanvasDiffer

open Models
open Models.Diffs
open Aether

let getValues x =
    x
    |> Map.toSeq
    |> Seq.map snd

let getId = Optic.get Object.Id_

let getItem m id = m |> Optic.get (Map.key_ id)

let compare<'a when 'a :> System.IComparable> (perv: 'a) (cur: 'a): Option<'a> =
    if perv.CompareTo(cur) <> 0 then Some cur
    else None

let isAllNone = Seq.forall Option.isNone

let getCubeDiff (perv: Cube) (cur: Cube): CubeDiff option =
    let x = compare perv.Position.X cur.Position.X
    let y = compare perv.Position.Y cur.Position.Y
    let size = compare perv.Size cur.Size
    let allNone = [ x; y; size ] |> isAllNone
    if allNone then
        None
    else
        Some
            ({ Id = perv.Id
               X = x
               Y = y
               Size = size })


let getObjDiff = function
    | (Cube x, Cube y) ->
        getCubeDiff x y |> Option.map ObjCubeDiff

let calcUpdate (perv: Canvas) (cur: Canvas): ObjDiff seq =
    let getPerv = getId >> getItem perv.Objects

    let getSame cur =
        cur
        |> getPerv
        |> function
        | Some perv -> Some(cur, perv)
        | None -> None

    cur.Objects
    |> getValues
    |> Seq.choose getSame
    |> Seq.choose getObjDiff

let getDiff (perv: Canvas option) (cur: Canvas): CanvasDiff =
    match perv, cur with
    | Some _perv, _cur ->
        { create = []
          update = calcUpdate _perv _cur }
    | None, _cur ->
        { create = _cur.Objects |> getValues
          update = [] }
