module App

open Fable.Import
open Three
open ThreeJs

let window = Browser.Dom.window

let init() =
    let scene = Globals.Scene.Create()
    let camera = Globals.PerspectiveCamera.Create(75., window.innerWidth / window.innerHeight, 0.1, 1000.)
    let renderer = Globals.WebGLRenderer.Create()
    renderer.setSize (window.innerWidth, window.innerHeight)

    window.document.body.appendChild (renderer.domElement) |> ignore

    let geometry = Globals.BoxGeometry.Create(1., 1., 1.)
    let color = Globals.Color.Create(122., 0., 0.)
    let material = Globals.MeshBasicMaterial.Create(color = color)
    let meshGeometry = Fable.Core.U2.Case1(geometry :> __objects_Mesh.Geometry)
    let meshMaterial = Fable.Core.U2.Case1(material :> __objects_Mesh.Material)
    let cube = Globals.Mesh.Create(meshGeometry, meshMaterial)
    let obj3d = new ResizeArray<_>([ cube :> __core_Object3D.Object3D ])
    scene.add (obj3d) |> ignore

    camera.position.z <- 5.

    let rec animate _ =
        window.requestAnimationFrame (animate) |> ignore
        cube.rotation.x <- cube.rotation.x + 0.01
        cube.rotation.y <- cube.rotation.y + 0.01
        renderer.render (scene, camera)

    animate 0.

init() |> ignore
