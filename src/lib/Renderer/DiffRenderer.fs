module Renderer.DiffRenderer

open Three
open ThreeJs
open Three.__scenes_Scene

open Models.Canvas
open Models.Objects
open Models.Diffs.CanvasDiff

open Browser.Dom


let createCube (cube: Cube) =    
    let geometry = BoxGeometry.Create(cube.size, cube.size, cube.size)
    let color = Color.Create(0xff0000)
    let material = MeshBasicMaterial.Create(color = color)
    Mesh.Create(geometry, material)


let createDiff (obj: Object) =
    match obj with
    | Cube cube -> createCube cube


let renderDiff (scene: Scene) (diff: CanvasDiff): unit =
    diff.create
    |> Seq.map (createDiff >> scene.add)
    // seq is lazy
    |> Seq.toList
    |> ignore
