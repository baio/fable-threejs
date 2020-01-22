module Canvas

open Fable.Core
open Fable.Import
open Three
open ThreeJs
open Three.__renderers_WebGLRenderer

let window = Browser.Dom.window

let UP = Vector3.Create(0., 0., 1.)

type Env =
    { renderer: WebGLRenderer
      scene: Scene
      camera: Camera }

let initCamera() =
    // PerspectiveCamera.Create(75., window.innerWidth / window.innerHeight, 0.1, 1000.)

    let zoomFactor = 1.
    let width = window.innerWidth
    let height = window.innerHeight    

    let camera =
        OrthographicCamera.Create
            (width * -0.5 * zoomFactor, width * 0.5 * zoomFactor, height * -0.5 * zoomFactor, height * 0.5 * zoomFactor,
             0.1, 1000.)

    let vector = Vector3.Create().sub(UP)
    camera.lookAt vector
    camera.position.copy UP |> ignore
    camera


let init() =

    let scene = Scene.Create()
    let camera = initCamera()

    let renderer = WebGLRenderer.Create()
    renderer.setSize (window.innerWidth, window.innerHeight)

    window.document.body.appendChild (renderer.domElement) |> ignore

    let geometry = BoxGeometry.Create(1., 1., 1.)
    let color = Color.Create(122., 0., 0.)
    let material = MeshBasicMaterial.Create(color = color)
    let meshGeometry = U2.Case1(geometry :> Geometry)
    let meshMaterial = U2.Case1(material :> Material)
    let cube = Mesh.Create(meshGeometry, meshMaterial)
    let obj3d = new ResizeArray<_>([ cube :> Object3D ])
    scene.add (obj3d) |> ignore

    // camera.position.z <- 5.

    { renderer = renderer
      camera = camera
      scene = scene }

let rec animate (env: Env) _ =
    window.requestAnimationFrame (animate env) |> ignore
    let cube = env.scene.children.[0]
    cube.rotation.x <- cube.rotation.x + 0.01
    cube.rotation.y <- cube.rotation.y + 0.01
    env.renderer.render (env.scene, env.camera)
