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

let createCamera (width, height) =

    let zoomFactor = 0.01

    let camera =
        OrthographicCamera.Create
            (width * -0.5 * zoomFactor, width * 0.5 * zoomFactor, height * -0.5 * zoomFactor, height * 0.5 * zoomFactor,
             0.1, 100.)

    let vector = Vector3.Create().sub(UP)
    camera.lookAt vector
    camera.position.copy UP |> ignore
    camera

let createPlane (width, height) =
    let planeGeometry = PlaneGeometry.Create(width, height, 1., 1.)  
    let planeMaterial = MeshBasicMaterial.Create(color = Color.Create(0xcccccc), wireframe = true)
    Mesh.Create(planeGeometry, planeMaterial)

let createCube () =
    let geometry = BoxGeometry.Create(1., 1., 1.)
    let color = Color.Create(0xff0000)
    let material = MeshBasicMaterial.Create(color = color)
    Mesh.Create(geometry, material)
 

let init() =

    let width = window.innerWidth
    let height = window.innerHeight

    let scene = Scene.Create()
    let camera = createCamera (width, height)

    let renderer = WebGLRenderer.Create()
    renderer.setClearColor (0xEEEEEE)
    renderer.setSize (width, height)

    let axesHelper = AxesHelper.Create 20.
    scene.add axesHelper |> ignore

    let plane = createPlane(width, height)
    scene.add plane |> ignore

    let cube = createCube()
    scene.add cube |> ignore

    window.document.body.appendChild (renderer.domElement) |> ignore

    { renderer = renderer
      camera = camera
      scene = scene }

let rec animate (env: Env) _ =
    window.requestAnimationFrame (animate env) |> ignore
    // let cube = env.scene.children.[1]
    // cube.rotation.x <- cube.rotation.x + 0.01
    // cube.rotation.y <- cube.rotation.y + 0.01
    env.renderer.render (env.scene, env.camera)
