module ThreeJs

open Core
open Fable.Core
open Three

[<Import("Scene", "three")>]
let Scene: __scenes_Scene.SceneStatic = jsNative

[<Import("PerspectiveCamera", "three")>]
let PerspectiveCamera: __cameras_PerspectiveCamera.PerspectiveCameraStatic = jsNative

[<Import("WebGLRenderer", "three")>]
let WebGLRenderer: __renderers_WebGLRenderer.WebGLRendererStatic = jsNative

[<Import("MeshBasicMaterial", "three")>]
let MeshBasicMaterial: __materials_MeshBasicMaterial.MeshBasicMaterialStatic = jsNative

[<Import("BoxGeometry", "three")>]
let BoxGeometry: __geometries_BoxGeometry.BoxGeometryStatic = jsNative

[<Import("Mesh", "three")>]
let Mesh: __objects_Mesh.MeshStatic = jsNative

[<Import("Color", "three")>]
let Color: __math_Color.ColorStatic = jsNative

