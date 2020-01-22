module ThreeJs

open Core
open Fable.Core
open Three

[<Erase>]
type Globals =

    [<Global>]
    static member Scene
        with get (): __scenes_Scene.SceneStatic = jsNative
        and set (v: __scenes_Scene.SceneStatic): unit = jsNative

    [<Global>]
    static member PerspectiveCamera
        with get (): __cameras_PerspectiveCamera.PerspectiveCameraStatic = jsNative
        and set (v: __cameras_PerspectiveCamera.PerspectiveCameraStatic): unit = jsNative

    [<Global>]
    static member WebGLRenderer
        with get (): __renderers_WebGLRenderer.WebGLRendererStatic = jsNative
        and set (v: __renderers_WebGLRenderer.WebGLRendererStatic): unit = jsNative

    [<Global>]
    static member MeshBasicMaterial
        with get (): __materials_MeshBasicMaterial.MeshBasicMaterialStatic = jsNative
        and set (v: __materials_MeshBasicMaterial.MeshBasicMaterialStatic): unit = jsNative

    [<Global>]
    static member BoxGeometry
        with get (): __geometries_BoxGeometry.BoxGeometryStatic = jsNative
        and set (v: __geometries_BoxGeometry.BoxGeometryStatic): unit = jsNative

    [<Global>]
    static member Mesh
        with get (): __objects_Mesh.MeshStatic = jsNative
        and set (v: __objects_Mesh.MeshStatic): unit = jsNative

    [<Global>]
    static member Color
        with get (): __math_Color.ColorStatic = jsNative
        and set (v: __math_Color.ColorStatic): unit = jsNative
// [<Global>] static member ArrayCamera with get(): ArrayCameraType = jsNative and set(v: ArrayCameraType): unit = jsNative
// [<Global>] static member Scene with get(): SceneType = jsNative and set(v: SceneType): unit = jsNative
// [<Global>] static member WebGLRenderer with get(): WebGLRendererType = jsNative and set(v: WebGLRendererType): unit = jsNative
// [<Global>] static member Mesh with get(): MeshType = jsNative and set(v: MeshType): unit = jsNative
// [<Global>] static member Vector4 with get(): Vector4Type = jsNative and set(v: Vector4Type): unit = jsNative
// [<Global>] static member Vector3 with get(): Vector3Type = jsNative and set(v: Vector3Type): unit = jsNative
// [<Global>] static member AmbientLight with get(): AmbientLightType = jsNative and set(v: AmbientLightType): unit = jsNative
// [<Global>] static member Color with get(): ColorType = jsNative and set(v: ColorType): unit = jsNative
// [<Global>] static member DirectionalLight with get(): DirectionalLightType = jsNative and set(v: DirectionalLightType): unit = jsNative
// [<Global>] static member PlaneBufferGeometry with get(): PlaneBufferGeometryType = jsNative and set(v: PlaneBufferGeometryType): unit = jsNative
// [<Global>] static member MeshPhongMaterial with get(): MeshPhongMaterialType = jsNative and set(v: MeshPhongMaterialType): unit = jsNative
// [<Global>] static member CylinderBufferGeometry with get(): CylinderBufferGeometryType = jsNative and set(v: CylinderBufferGeometryType): unit = jsNative
