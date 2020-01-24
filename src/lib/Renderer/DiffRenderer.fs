module Renderer.DiffRenderer

open Three
open ThreeJs
open Three.__scenes_Scene

open Models.Canvas
open Models.Objects
open Models.Diffs.CanvasDiff

open Browser.Dom
open Models.Diffs.ObjectsDiffs
open Three.__core_Geometry
open Three.__geometries_BoxGeometry
open Three.__objects_Mesh


let createCube (cube: Cube) =
    let geometry = BoxGeometry.Create(cube.Size, cube.Size, cube.Size)
    let color = Color.Create(0xff0000)
    let material = MeshBasicMaterial.Create(color = color)
    let mesh = Mesh.Create(geometry, material)
    mesh.name <- cube.Id.ToString()
    mesh


let createDiff = function
    | Cube cube -> createCube cube

//
let setCubeSize (mesh: Mesh) (size: int) =
    let fsize = (float size)
    (mesh.geometry :> obj :?> BoxGeometry).scale(fsize, fsize, fsize)


let updateCube (scene: Scene) (cubeDiff: CubeDiff) =
    cubeDiff.Id.ToString()
    |> scene.getObjectByName
    |> function
    | Some cube ->
        cubeDiff.X
        |> Option.map cube.position.setX
        |> ignore

        cubeDiff.Y
        |> Option.map cube.position.setY
        |> ignore

        cubeDiff.Size
        |> Option.map(setCubeSize (cube :?> Mesh))
        |> ignore

    | None -> ()


let updateDiff scene = function
    | ObjCubeDiff cubeDiff -> updateCube scene cubeDiff

let renderDiff (scene: Scene) (diff: CanvasDiff): unit =

    // create
    diff.create
    |> List.iter
        (createDiff
         >> scene.add
         >> ignore)

    // update
    diff.update |> List.iter (updateDiff scene)
