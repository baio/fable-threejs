module Renderer

open Fable.Core
open Fable.Import
open Three
open ThreeJs
open Three.__renderers_WebGLRenderer
open CanvasDiffer

let window = Browser.Dom.window

let UP = Vector3.Create(0., 0., 1.)

type CanvasGetter = unit -> Models.Canvas.Canvas option

type Env =
    { renderer: WebGLRenderer
      scene: Scene
      camera: Camera
      canvasGetter: CanvasGetter
      mutable canvas: Models.Canvas.Canvas option }

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


let init (canvasGetter: CanvasGetter) =

    let width = window.innerWidth
    let height = window.innerHeight

    let scene = Scene.Create()
    let camera = createCamera (width, height)

    let renderer = WebGLRenderer.Create()
    renderer.setClearColor (0xEEEEEE)
    renderer.setSize (width, height)

    let axesHelper = AxesHelper.Create 20.
    scene.add axesHelper |> ignore

    let plane = createPlane (width, height)
    scene.add plane |> ignore

    // let cube = createCube()
    // scene.add cube |> ignore

    window.document.body.appendChild (renderer.domElement) |> ignore

    { renderer = renderer
      camera = camera
      scene = scene
      canvasGetter = canvasGetter
      canvas = None }

let rec animate (env: Env) _ =
    window.requestAnimationFrame (animate env) |> ignore
    //
    let curCanvas = env.canvasGetter()
    let pervCanvas = env.canvas
    let diff = getDiff pervCanvas curCanvas 
    env.canvas <- curCanvas
    Renderer.DiffRenderer.renderDiff env.scene diff
    //
    env.renderer.render (env.scene, env.camera)
