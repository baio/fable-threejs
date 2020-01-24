module CanvasDiffer

open Models
open Models.Diffs
open Aether

let getValues x =
    x
    |> Map.toList
    |> List.map snd

let getId = Optic.get Object.Id_

let getItem m id = m |> Optic.get (Map.key_ id)

let compare<'a when 'a: equality> (perv: 'a) (cur: 'a): Option<'a> =
    if perv = cur then None
    else Some cur

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

let calcUpdate (perv: Canvas) (cur: Canvas): ObjDiff list =
    let getPerv = getId >> getItem perv.Objects

    let getSame cur =
        cur
        |> getPerv
        |> function
        | Some perv -> Some(cur, perv)
        | None -> None

    cur.Objects
    |> getValues
    |> List.choose getSame
    |> List.choose getObjDiff

let getDiff =
    function
    | Some perv, cur ->
        { create = []
          update = calcUpdate perv cur }
    | None, cur ->
        { create = cur.Objects |> getValues
          update = [] }
