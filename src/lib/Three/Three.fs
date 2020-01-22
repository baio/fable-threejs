// ts2fable 0.7.0-build.489
module rec Three
open Core
open System
open Fable.Core
open Fable.Core.JS
open Browser.Types

type Array<'T> = System.Collections.Generic.IList<'T>
type Error = System.Exception
type Function = System.Action
type RegExp = System.Text.RegularExpressions.Regex

module Constants =

    type [<AllowNullLiteral>] IExports =
        abstract REVISION: string
        abstract CullFaceNone: CullFace
        abstract CullFaceBack: CullFace
        abstract CullFaceFront: CullFace
        abstract CullFaceFrontBack: CullFace
        abstract FrontFaceDirectionCW: FrontFaceDirection
        abstract FrontFaceDirectionCCW: FrontFaceDirection
        abstract BasicShadowMap: ShadowMapType
        abstract PCFShadowMap: ShadowMapType
        abstract PCFSoftShadowMap: ShadowMapType
        abstract VSMShadowMap: ShadowMapType
        abstract FrontSide: Side
        abstract BackSide: Side
        abstract DoubleSide: Side
        abstract FlatShading: Shading
        abstract SmoothShading: Shading
        abstract NoColors: Colors
        abstract FaceColors: Colors
        abstract VertexColors: Colors
        abstract NoBlending: Blending
        abstract NormalBlending: Blending
        abstract AdditiveBlending: Blending
        abstract SubtractiveBlending: Blending
        abstract MultiplyBlending: Blending
        abstract CustomBlending: Blending
        abstract AddEquation: BlendingEquation
        abstract SubtractEquation: BlendingEquation
        abstract ReverseSubtractEquation: BlendingEquation
        abstract MinEquation: BlendingEquation
        abstract MaxEquation: BlendingEquation
        abstract ZeroFactor: BlendingDstFactor
        abstract OneFactor: BlendingDstFactor
        abstract SrcColorFactor: BlendingDstFactor
        abstract OneMinusSrcColorFactor: BlendingDstFactor
        abstract SrcAlphaFactor: BlendingDstFactor
        abstract OneMinusSrcAlphaFactor: BlendingDstFactor
        abstract DstAlphaFactor: BlendingDstFactor
        abstract OneMinusDstAlphaFactor: BlendingDstFactor
        abstract DstColorFactor: BlendingDstFactor
        abstract OneMinusDstColorFactor: BlendingDstFactor
        abstract SrcAlphaSaturateFactor: BlendingSrcFactor
        abstract NeverDepth: DepthModes
        abstract AlwaysDepth: DepthModes
        abstract LessDepth: DepthModes
        abstract LessEqualDepth: DepthModes
        abstract EqualDepth: DepthModes
        abstract GreaterEqualDepth: DepthModes
        abstract GreaterDepth: DepthModes
        abstract NotEqualDepth: DepthModes
        abstract MultiplyOperation: Combine
        abstract MixOperation: Combine
        abstract AddOperation: Combine
        abstract NoToneMapping: ToneMapping
        abstract LinearToneMapping: ToneMapping
        abstract ReinhardToneMapping: ToneMapping
        abstract Uncharted2ToneMapping: ToneMapping
        abstract CineonToneMapping: ToneMapping
        abstract ACESFilmicToneMapping: ToneMapping
        abstract UVMapping: Mapping
        abstract CubeReflectionMapping: Mapping
        abstract CubeRefractionMapping: Mapping
        abstract EquirectangularReflectionMapping: Mapping
        abstract EquirectangularRefractionMapping: Mapping
        abstract SphericalReflectionMapping: Mapping
        abstract CubeUVReflectionMapping: Mapping
        abstract CubeUVRefractionMapping: Mapping
        abstract RepeatWrapping: Wrapping
        abstract ClampToEdgeWrapping: Wrapping
        abstract MirroredRepeatWrapping: Wrapping
        abstract NearestFilter: TextureFilter
        abstract NearestMipmapNearestFilter: TextureFilter
        abstract NearestMipMapNearestFilter: TextureFilter
        abstract NearestMipmapLinearFilter: TextureFilter
        abstract NearestMipMapLinearFilter: TextureFilter
        abstract LinearFilter: TextureFilter
        abstract LinearMipmapNearestFilter: TextureFilter
        abstract LinearMipMapNearestFilter: TextureFilter
        abstract LinearMipmapLinearFilter: TextureFilter
        abstract LinearMipMapLinearFilter: TextureFilter
        abstract UnsignedByteType: TextureDataType
        abstract ByteType: TextureDataType
        abstract ShortType: TextureDataType
        abstract UnsignedShortType: TextureDataType
        abstract IntType: TextureDataType
        abstract UnsignedIntType: TextureDataType
        abstract FloatType: TextureDataType
        abstract HalfFloatType: TextureDataType
        abstract UnsignedShort4444Type: PixelType
        abstract UnsignedShort5551Type: PixelType
        abstract UnsignedShort565Type: PixelType
        abstract UnsignedInt248Type: PixelType
        abstract AlphaFormat: PixelFormat
        abstract RGBFormat: PixelFormat
        abstract RGBAFormat: PixelFormat
        abstract LuminanceFormat: PixelFormat
        abstract LuminanceAlphaFormat: PixelFormat
        abstract RGBEFormat: PixelFormat
        abstract DepthFormat: PixelFormat
        abstract DepthStencilFormat: PixelFormat
        abstract RedFormat: PixelFormat
        abstract RedIntegerFormat: PixelFormat
        abstract RGFormat: PixelFormat
        abstract RGIntegerFormat: PixelFormat
        abstract RGBIntegerFormat: PixelFormat
        abstract RGBAIntegerFormat: PixelFormat
        abstract RGB_S3TC_DXT1_Format: CompressedPixelFormat
        abstract RGBA_S3TC_DXT1_Format: CompressedPixelFormat
        abstract RGBA_S3TC_DXT3_Format: CompressedPixelFormat
        abstract RGBA_S3TC_DXT5_Format: CompressedPixelFormat
        abstract RGB_PVRTC_4BPPV1_Format: CompressedPixelFormat
        abstract RGB_PVRTC_2BPPV1_Format: CompressedPixelFormat
        abstract RGBA_PVRTC_4BPPV1_Format: CompressedPixelFormat
        abstract RGBA_PVRTC_2BPPV1_Format: CompressedPixelFormat
        abstract RGB_ETC1_Format: CompressedPixelFormat
        abstract RGBA_ASTC_4x4_Format: CompressedPixelFormat
        abstract RGBA_ASTC_5x4_Format: CompressedPixelFormat
        abstract RGBA_ASTC_5x5_Format: CompressedPixelFormat
        abstract RGBA_ASTC_6x5_Format: CompressedPixelFormat
        abstract RGBA_ASTC_6x6_Format: CompressedPixelFormat
        abstract RGBA_ASTC_8x5_Format: CompressedPixelFormat
        abstract RGBA_ASTC_8x6_Format: CompressedPixelFormat
        abstract RGBA_ASTC_8x8_Format: CompressedPixelFormat
        abstract RGBA_ASTC_10x5_Format: CompressedPixelFormat
        abstract RGBA_ASTC_10x6_Format: CompressedPixelFormat
        abstract RGBA_ASTC_10x8_Format: CompressedPixelFormat
        abstract RGBA_ASTC_10x10_Format: CompressedPixelFormat
        abstract RGBA_ASTC_12x10_Format: CompressedPixelFormat
        abstract RGBA_ASTC_12x12_Format: CompressedPixelFormat
        abstract LoopOnce: AnimationActionLoopStyles
        abstract LoopRepeat: AnimationActionLoopStyles
        abstract LoopPingPong: AnimationActionLoopStyles
        abstract InterpolateDiscrete: InterpolationModes
        abstract InterpolateLinear: InterpolationModes
        abstract InterpolateSmooth: InterpolationModes
        abstract ZeroCurvatureEnding: InterpolationEndingModes
        abstract ZeroSlopeEnding: InterpolationEndingModes
        abstract WrapAroundEnding: InterpolationEndingModes
        abstract TrianglesDrawMode: TrianglesDrawModes
        abstract TriangleStripDrawMode: TrianglesDrawModes
        abstract TriangleFanDrawMode: TrianglesDrawModes
        abstract LinearEncoding: TextureEncoding
        abstract sRGBEncoding: TextureEncoding
        abstract GammaEncoding: TextureEncoding
        abstract RGBEEncoding: TextureEncoding
        abstract LogLuvEncoding: TextureEncoding
        abstract RGBM7Encoding: TextureEncoding
        abstract RGBM16Encoding: TextureEncoding
        abstract RGBDEncoding: TextureEncoding
        abstract BasicDepthPacking: DepthPackingStrategies
        abstract RGBADepthPacking: DepthPackingStrategies
        abstract TangentSpaceNormalMap: NormalMapTypes
        abstract ObjectSpaceNormalMap: NormalMapTypes
        abstract ZeroStencilOp: StencilOp
        abstract KeepStencilOp: StencilOp
        abstract ReplaceStencilOp: StencilOp
        abstract IncrementStencilOp: StencilOp
        abstract DecrementStencilOp: StencilOp
        abstract IncrementWrapStencilOp: StencilOp
        abstract DecrementWrapStencilOp: StencilOp
        abstract InvertStencilOp: StencilOp
        abstract NeverStencilFunc: StencilFunc
        abstract LessStencilFunc: StencilFunc
        abstract EqualStencilFunc: StencilFunc
        abstract LessEqualStencilFunc: StencilFunc
        abstract GreaterStencilFunc: StencilFunc
        abstract NotEqualStencilFunc: StencilFunc
        abstract GreaterEqualStencilFunc: StencilFunc
        abstract AlwaysStencilFunc: StencilFunc
        abstract StaticDrawUsage: Usage
        abstract DynamicDrawUsage: Usage
        abstract StreamDrawUsage: Usage
        abstract StaticReadUsage: Usage
        abstract DynamicReadUsage: Usage
        abstract StreamReadUsage: Usage
        abstract StaticCopyUsage: Usage
        abstract DynamicCopyUsage: Usage
        abstract StreamCopyUsage: Usage

    type MOUSE =
        obj

    type TOUCH =
        obj

    type [<RequireQualifiedAccess>] CullFace = obj

    type [<RequireQualifiedAccess>] FrontFaceDirection = obj

    type [<RequireQualifiedAccess>] ShadowMapType = obj

    type [<RequireQualifiedAccess>] Side = obj

    type [<RequireQualifiedAccess>] Shading = obj

    type [<RequireQualifiedAccess>] Colors = obj

    type [<RequireQualifiedAccess>] Blending = obj

    type [<RequireQualifiedAccess>] BlendingEquation = obj

    type [<RequireQualifiedAccess>] BlendingDstFactor = obj

    type [<RequireQualifiedAccess>] BlendingSrcFactor = obj

    type [<RequireQualifiedAccess>] DepthModes = obj

    type [<RequireQualifiedAccess>] Combine = obj

    type [<RequireQualifiedAccess>] ToneMapping = obj

    type [<RequireQualifiedAccess>] Mapping = obj

    type [<RequireQualifiedAccess>] Wrapping = obj

    type [<RequireQualifiedAccess>] TextureFilter = obj

    type [<RequireQualifiedAccess>] TextureDataType = obj

    type [<RequireQualifiedAccess>] PixelType = obj

    type [<RequireQualifiedAccess>] PixelFormat = obj

    type [<StringEnum>] [<RequireQualifiedAccess>] PixelFormatGPU =
        | [<CompiledName "ALPHA">] ALPHA
        | [<CompiledName "RGB">] RGB
        | [<CompiledName "RGBA">] RGBA
        | [<CompiledName "LUMINANCE">] LUMINANCE
        | [<CompiledName "LUMINANCE_ALPHA">] LUMINANCE_ALPHA
        | [<CompiledName "RED_INTEGER">] RED_INTEGER
        | [<CompiledName "R8">] R8
        | [<CompiledName "R8_SNORM">] R8_SNORM
        | [<CompiledName "R8I">] R8I
        | [<CompiledName "R8UI">] R8UI
        | [<CompiledName "R16I">] R16I
        | [<CompiledName "R16UI">] R16UI
        | [<CompiledName "R16F">] R16F
        | [<CompiledName "R32I">] R32I
        | [<CompiledName "R32UI">] R32UI
        | [<CompiledName "R32F">] R32F
        | [<CompiledName "RG8">] RG8
        | [<CompiledName "RG8_SNORM">] RG8_SNORM
        | [<CompiledName "RG8I">] RG8I
        | [<CompiledName "RG8UI">] RG8UI
        | [<CompiledName "RG16I">] RG16I
        | [<CompiledName "RG16UI">] RG16UI
        | [<CompiledName "RG16F">] RG16F
        | [<CompiledName "RG32I">] RG32I
        | [<CompiledName "RG32UI">] RG32UI
        | [<CompiledName "RG32F">] RG32F
        | [<CompiledName "RGB565">] RGB565
        | [<CompiledName "RGB8">] RGB8
        | [<CompiledName "RGB8_SNORM">] RGB8_SNORM
        | [<CompiledName "RGB8I">] RGB8I
        | [<CompiledName "RGB8UI">] RGB8UI
        | [<CompiledName "RGB16I">] RGB16I
        | [<CompiledName "RGB16UI">] RGB16UI
        | [<CompiledName "RGB16F">] RGB16F
        | [<CompiledName "RGB32I">] RGB32I
        | [<CompiledName "RGB32UI">] RGB32UI
        | [<CompiledName "RGB32F">] RGB32F
        | [<CompiledName "RGB9_E5">] RGB9_E5
        | [<CompiledName "SRGB8">] SRGB8
        | [<CompiledName "R11F_G11F_B10F">] R11F_G11F_B10F
        | [<CompiledName "RGBA4">] RGBA4
        | [<CompiledName "RGBA8">] RGBA8
        | [<CompiledName "RGBA8_SNORM">] RGBA8_SNORM
        | [<CompiledName "RGBA8I">] RGBA8I
        | [<CompiledName "RGBA8UI">] RGBA8UI
        | [<CompiledName "RGBA16I">] RGBA16I
        | [<CompiledName "RGBA16UI">] RGBA16UI
        | [<CompiledName "RGBA16F">] RGBA16F
        | [<CompiledName "RGBA32I">] RGBA32I
        | [<CompiledName "RGBA32UI">] RGBA32UI
        | [<CompiledName "RGBA32F">] RGBA32F
        | [<CompiledName "RGB5_A1">] RGB5_A1
        | [<CompiledName "RGB10_A2">] RGB10_A2
        | [<CompiledName "RGB10_A2UI">] RGB10_A2UI
        | [<CompiledName "SRGB8_ALPHA8">] SRGB8_ALPHA8
        | [<CompiledName "DEPTH_COMPONENT16">] DEPTH_COMPONENT16
        | [<CompiledName "DEPTH_COMPONENT24">] DEPTH_COMPONENT24
        | [<CompiledName "DEPTH_COMPONENT32F">] DEPTH_COMPONENT32F
        | [<CompiledName "DEPTH24_STENCIL8">] DEPTH24_STENCIL8
        | [<CompiledName "DEPTH32F_STENCIL8">] DEPTH32F_STENCIL8

    type [<RequireQualifiedAccess>] CompressedPixelFormat = obj

    type [<RequireQualifiedAccess>] AnimationActionLoopStyles = obj

    type [<RequireQualifiedAccess>] InterpolationModes = obj

    type [<RequireQualifiedAccess>] InterpolationEndingModes = obj

    type [<RequireQualifiedAccess>] TrianglesDrawModes = obj

    type [<RequireQualifiedAccess>] TextureEncoding = obj

    type [<RequireQualifiedAccess>] DepthPackingStrategies = obj

    type [<RequireQualifiedAccess>] NormalMapTypes = obj

    type [<RequireQualifiedAccess>] StencilOp = obj

    type [<RequireQualifiedAccess>] StencilFunc = obj

    type [<RequireQualifiedAccess>] Usage = obj

module Polyfills =

    type [<AllowNullLiteral>] IExports =
        abstract warn: ?message: obj * [<ParamArray>] optionalParams: ResizeArray<obj option> -> unit
        abstract error: ?message: obj * [<ParamArray>] optionalParams: ResizeArray<obj option> -> unit
        abstract log: ?message: obj * [<ParamArray>] optionalParams: ResizeArray<obj option> -> unit

    type TypedArray =
        obj

module Three_Legacy =
    type Geometry = __core_Geometry.Geometry
    type Material = __materials_Material.Material
    type Object3D = __core_Object3D.Object3D
    type Scene = __scenes_Scene.Scene
    let [<Import("SceneUtils","three/Three.Legacy")>] sceneUtils: SceneUtils.IExports = jsNative

    module SceneUtils =

        type [<AllowNullLiteral>] IExports =
            abstract createMultiMaterialObject: geometry: Geometry * materials: ResizeArray<Material> -> Object3D
            abstract detach: child: Object3D * parent: Object3D * scene: Scene -> unit
            abstract attach: child: Object3D * scene: Scene * parent: Object3D -> unit

module Utils =

    type [<AllowNullLiteral>] IExports =
        abstract arrayMin: array: ResizeArray<float> -> float
        abstract arrayMax: array: ResizeArray<float> -> float

module __animation_AnimationAction =
    type AnimationMixer = __animation_AnimationMixer.AnimationMixer
    type AnimationClip = __animation_AnimationClip.AnimationClip
    type AnimationActionLoopStyles = Constants.AnimationActionLoopStyles
    type Object3D = __core_Object3D.Object3D

    type [<AllowNullLiteral>] IExports =
        abstract AnimationAction: AnimationActionStatic

    type [<AllowNullLiteral>] AnimationAction =
        abstract loop: AnimationActionLoopStyles with get, set
        abstract time: float with get, set
        abstract timeScale: float with get, set
        abstract weight: float with get, set
        abstract repetitions: float with get, set
        abstract paused: bool with get, set
        abstract enabled: bool with get, set
        abstract clampWhenFinished: bool with get, set
        abstract zeroSlopeAtStart: bool with get, set
        abstract zeroSlopeAtEnd: bool with get, set
        abstract play: unit -> AnimationAction
        abstract stop: unit -> AnimationAction
        abstract reset: unit -> AnimationAction
        abstract isRunning: unit -> bool
        abstract isScheduled: unit -> bool
        abstract startAt: time: float -> AnimationAction
        abstract setLoop: mode: AnimationActionLoopStyles * repetitions: float -> AnimationAction
        abstract setEffectiveWeight: weight: float -> AnimationAction
        abstract getEffectiveWeight: unit -> float
        abstract fadeIn: duration: float -> AnimationAction
        abstract fadeOut: duration: float -> AnimationAction
        abstract crossFadeFrom: fadeOutAction: AnimationAction * duration: float * warp: bool -> AnimationAction
        abstract crossFadeTo: fadeInAction: AnimationAction * duration: float * warp: bool -> AnimationAction
        abstract stopFading: unit -> AnimationAction
        abstract setEffectiveTimeScale: timeScale: float -> AnimationAction
        abstract getEffectiveTimeScale: unit -> float
        abstract setDuration: duration: float -> AnimationAction
        abstract syncWith: action: AnimationAction -> AnimationAction
        abstract halt: duration: float -> AnimationAction
        abstract warp: statTimeScale: float * endTimeScale: float * duration: float -> AnimationAction
        abstract stopWarping: unit -> AnimationAction
        abstract getMixer: unit -> AnimationMixer
        abstract getClip: unit -> AnimationClip
        abstract getRoot: unit -> Object3D

    type [<AllowNullLiteral>] AnimationActionStatic =
        [<Emit "new $0($1...)">] abstract Create: mixer: AnimationMixer * clip: AnimationClip * ?localRoot: Object3D -> AnimationAction

module __animation_AnimationClip =
    type KeyframeTrack = __animation_KeyframeTrack.KeyframeTrack
    type Bone = __objects_Bone.Bone
    type MorphTarget = __core_Geometry.MorphTarget

    type [<AllowNullLiteral>] IExports =
        abstract AnimationClip: AnimationClipStatic

    type [<AllowNullLiteral>] AnimationClip =
        abstract name: string with get, set
        abstract tracks: ResizeArray<KeyframeTrack> with get, set
        abstract duration: float with get, set
        abstract uuid: string with get, set
        abstract results: ResizeArray<obj option> with get, set
        abstract resetDuration: unit -> AnimationClip
        abstract trim: unit -> AnimationClip
        abstract validate: unit -> bool
        abstract optimize: unit -> AnimationClip
        abstract clone: unit -> AnimationClip

    type [<AllowNullLiteral>] AnimationClipStatic =
        [<Emit "new $0($1...)">] abstract Create: ?name: string * ?duration: float * ?tracks: ResizeArray<KeyframeTrack> -> AnimationClip
        abstract CreateFromMorphTargetSequence: name: string * morphTargetSequence: ResizeArray<MorphTarget> * fps: float * noLoop: bool -> AnimationClip
        abstract findByName: clipArray: ResizeArray<AnimationClip> * name: string -> AnimationClip
        abstract CreateClipsFromMorphTargetSequences: morphTargets: ResizeArray<MorphTarget> * fps: float * noLoop: bool -> ResizeArray<AnimationClip>
        abstract parse: json: obj option -> AnimationClip
        abstract parseAnimation: animation: obj option * bones: ResizeArray<Bone> * nodeName: string -> AnimationClip
        abstract toJSON: unit -> obj option

module __animation_AnimationMixer =
    type AnimationClip = __animation_AnimationClip.AnimationClip
    type AnimationAction = __animation_AnimationAction.AnimationAction
    type EventDispatcher = __core_EventDispatcher.EventDispatcher
    type Object3D = __core_Object3D.Object3D

    type [<AllowNullLiteral>] IExports =
        abstract AnimationMixer: AnimationMixerStatic

    type [<AllowNullLiteral>] AnimationMixer =
        inherit EventDispatcher
        abstract time: float with get, set
        abstract timeScale: float with get, set
        abstract clipAction: clip: AnimationClip * ?root: Object3D -> AnimationAction
        abstract existingAction: clip: AnimationClip * ?root: Object3D -> AnimationAction option
        abstract stopAllAction: unit -> AnimationMixer
        abstract update: deltaTime: float -> AnimationMixer
        abstract setTime: timeInSeconds: float -> AnimationMixer
        abstract getRoot: unit -> Object3D
        abstract uncacheClip: clip: AnimationClip -> unit
        abstract uncacheRoot: root: Object3D -> unit
        abstract uncacheAction: clip: AnimationClip * ?root: Object3D -> unit

    type [<AllowNullLiteral>] AnimationMixerStatic =
        [<Emit "new $0($1...)">] abstract Create: root: Object3D -> AnimationMixer

module __animation_AnimationObjectGroup =

    type [<AllowNullLiteral>] IExports =
        abstract AnimationObjectGroup: AnimationObjectGroupStatic

    type [<AllowNullLiteral>] AnimationObjectGroup =
        abstract uuid: string with get, set
        abstract stats: AnimationObjectGroupStats with get, set
        abstract add: [<ParamArray>] args: ResizeArray<obj option> -> unit
        abstract remove: [<ParamArray>] args: ResizeArray<obj option> -> unit
        abstract uncache: [<ParamArray>] args: ResizeArray<obj option> -> unit

    type [<AllowNullLiteral>] AnimationObjectGroupStatic =
        [<Emit "new $0($1...)">] abstract Create: [<ParamArray>] args: ResizeArray<obj option> -> AnimationObjectGroup

    type [<AllowNullLiteral>] AnimationObjectGroupStatsObjects =
        abstract total: float with get, set
        abstract inUse: float with get, set

    type [<AllowNullLiteral>] AnimationObjectGroupStats =
        abstract bindingsPerObject: float with get, set
        abstract objects: AnimationObjectGroupStatsObjects with get, set

module __animation_AnimationUtils =
    type AnimationClip = __animation_AnimationClip.AnimationClip
    let [<Import("AnimationUtils","three/animation/AnimationUtils")>] animationUtils: AnimationUtils.IExports = jsNative

    module AnimationUtils =

        type [<AllowNullLiteral>] IExports =
            abstract arraySlice: array: obj option * from: float * ``to``: float -> obj option
            abstract convertArray: array: obj option * ``type``: obj option * forceClone: bool -> obj option
            abstract isTypedArray: ``object``: obj option -> bool
            abstract getKeyFrameOrder: times: ResizeArray<float> -> ResizeArray<float>
            abstract sortedArray: values: ResizeArray<obj option> * stride: float * order: ResizeArray<float> -> ResizeArray<obj option>
            abstract flattenJSON: jsonKeys: ResizeArray<string> * times: ResizeArray<obj option> * values: ResizeArray<obj option> * valuePropertyName: string -> unit
            abstract subclip: sourceClip: AnimationClip * name: string * startFrame: float * endFrame: float * ?fps: float -> AnimationClip

module __animation_KeyframeTrack =
    type DiscreteInterpolant = __math_interpolants_DiscreteInterpolant.DiscreteInterpolant
    type LinearInterpolant = __math_interpolants_LinearInterpolant.LinearInterpolant
    type CubicInterpolant = __math_interpolants_CubicInterpolant.CubicInterpolant
    type InterpolationModes = Constants.InterpolationModes

    type [<AllowNullLiteral>] IExports =
        abstract KeyframeTrack: KeyframeTrackStatic

    type [<AllowNullLiteral>] KeyframeTrack =
        abstract name: string with get, set
        abstract times: Float32Array with get, set
        abstract values: Float32Array with get, set
        abstract ValueTypeName: string with get, set
        abstract TimeBufferType: Float32Array with get, set
        abstract ValueBufferType: Float32Array with get, set
        abstract DefaultInterpolation: InterpolationModes with get, set
        abstract InterpolantFactoryMethodDiscrete: result: obj option -> DiscreteInterpolant
        abstract InterpolantFactoryMethodLinear: result: obj option -> LinearInterpolant
        abstract InterpolantFactoryMethodSmooth: result: obj option -> CubicInterpolant
        abstract setInterpolation: interpolation: InterpolationModes -> KeyframeTrack
        abstract getInterpolation: unit -> InterpolationModes
        abstract getValuesize: unit -> float
        abstract shift: timeOffset: float -> KeyframeTrack
        abstract scale: timeScale: float -> KeyframeTrack
        abstract trim: startTime: float * endTime: float -> KeyframeTrack
        abstract validate: unit -> bool
        abstract optimize: unit -> KeyframeTrack
        abstract clone: unit -> KeyframeTrack

    type [<AllowNullLiteral>] KeyframeTrackStatic =
        [<Emit "new $0($1...)">] abstract Create: name: string * times: ResizeArray<obj option> * values: ResizeArray<obj option> * ?interpolation: InterpolationModes -> KeyframeTrack
        abstract toJSON: track: KeyframeTrack -> obj option

module __animation_PropertyBinding =
    let [<Import("PropertyBinding","three/animation/PropertyBinding")>] propertyBinding: PropertyBinding.IExports = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract PropertyBinding: PropertyBindingStatic

    type [<AllowNullLiteral>] ParseTrackNameResults =
        abstract nodeName: string with get, set
        abstract objectName: string with get, set
        abstract objectIndex: string with get, set
        abstract propertyName: string with get, set
        abstract propertyIndex: string with get, set

    type [<AllowNullLiteral>] PropertyBinding =
        abstract path: string with get, set
        abstract parsedPath: obj option with get, set
        abstract node: obj option with get, set
        abstract rootNode: obj option with get, set
        abstract getValue: targetArray: obj option * offset: float -> obj option
        abstract setValue: sourceArray: obj option * offset: float -> unit
        abstract bind: unit -> unit
        abstract unbind: unit -> unit
        abstract BindingType: PropertyBindingBindingType with get, set
        abstract Versioning: PropertyBindingVersioning with get, set
        abstract GetterByBindingType: ResizeArray<Function> with get, set
        abstract SetterByBindingTypeAndVersioning: Array<ResizeArray<Function>> with get, set

    type [<AllowNullLiteral>] PropertyBindingStatic =
        [<Emit "new $0($1...)">] abstract Create: rootNode: obj option * path: string * ?parsedPath: obj -> PropertyBinding
        abstract create: root: obj option * path: obj option * ?parsedPath: obj -> U2<PropertyBinding, PropertyBinding.Composite>
        abstract sanitizeNodeName: name: string -> string
        abstract parseTrackName: trackName: string -> ParseTrackNameResults
        abstract findNode: root: obj option * nodeName: string -> obj option

    module PropertyBinding =

        type [<AllowNullLiteral>] IExports =
            abstract Composite: CompositeStatic

        type [<AllowNullLiteral>] Composite =
            abstract getValue: array: obj option * offset: float -> obj option
            abstract setValue: array: obj option * offset: float -> unit
            abstract bind: unit -> unit
            abstract unbind: unit -> unit

        type [<AllowNullLiteral>] CompositeStatic =
            [<Emit "new $0($1...)">] abstract Create: targetGroup: obj option * path: obj option * ?parsedPath: obj -> Composite

    type [<AllowNullLiteral>] PropertyBindingBindingType =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: bindingType: string -> float with get, set

    type [<AllowNullLiteral>] PropertyBindingVersioning =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: versioning: string -> float with get, set

module __animation_PropertyMixer =

    type [<AllowNullLiteral>] IExports =
        abstract PropertyMixer: PropertyMixerStatic

    type [<AllowNullLiteral>] PropertyMixer =
        abstract binding: obj option with get, set
        abstract valueSize: float with get, set
        abstract buffer: obj option with get, set
        abstract cumulativeWeight: float with get, set
        abstract useCount: float with get, set
        abstract referenceCount: float with get, set
        abstract accumulate: accuIndex: float * weight: float -> unit
        abstract apply: accuIndex: float -> unit
        abstract saveOriginalState: unit -> unit
        abstract restoreOriginalState: unit -> unit

    type [<AllowNullLiteral>] PropertyMixerStatic =
        [<Emit "new $0($1...)">] abstract Create: binding: obj option * typeName: string * valueSize: float -> PropertyMixer

module __audio_Audio =
    type Object3D = __core_Object3D.Object3D
    type AudioListener = __audio_AudioListener.AudioListener
    type AudioContext = obj // __audio_AudioContext.AudioContext

    type [<AllowNullLiteral>] IExports =
        abstract Audio: AudioStatic

    type [<AllowNullLiteral>] Audio =
        inherit Object3D
        abstract ``type``: string with get, set
        abstract listener: AudioListener with get, set
        abstract context: AudioContext with get, set
        abstract gain: GainNode with get, set
        abstract autoplay: bool with get, set
        abstract buffer: AudioBuffer option with get, set
        abstract detune: float with get, set
        abstract loop: bool with get, set
        abstract loopStart: float with get, set
        abstract loopEnd: float with get, set
        abstract offset: float with get, set
        abstract duration: float option with get, set
        abstract playbackRate: float with get, set
        abstract isPlaying: bool with get, set
        abstract hasPlaybackControl: bool with get, set
        abstract sourceType: string with get, set
        abstract source: AudioBufferSourceNode with get, set
        abstract filters: ResizeArray<obj option> with get, set
        abstract getOutput: unit -> GainNode
        abstract setNodeSource: audioNode: AudioBufferSourceNode -> Audio
        abstract setMediaElementSource: mediaElement: HTMLMediaElement -> Audio
        abstract setMediaStreamSource: mediaStream: MediaStream -> Audio
        abstract setBuffer: audioBuffer: AudioBuffer -> Audio
        abstract play: ?delay: float -> Audio
        abstract onEnded: unit -> unit
        abstract pause: unit -> Audio
        abstract stop: unit -> Audio
        abstract connect: unit -> Audio
        abstract disconnect: unit -> Audio
        abstract setDetune: value: float -> Audio
        abstract getDetune: unit -> float
        abstract getFilters: unit -> ResizeArray<obj option>
        abstract setFilters: value: ResizeArray<obj option> -> Audio
        abstract getFilter: unit -> obj option
        abstract setFilter: filter: obj option -> Audio
        abstract setPlaybackRate: value: float -> Audio
        abstract getPlaybackRate: unit -> float
        abstract getLoop: unit -> bool
        abstract setLoop: value: bool -> Audio
        abstract setLoopStart: value: float -> Audio
        abstract setLoopEnd: value: float -> Audio
        abstract getVolume: unit -> float
        abstract setVolume: value: float -> Audio
        abstract load: file: string -> Audio

    type [<AllowNullLiteral>] AudioStatic =
        [<Emit "new $0($1...)">] abstract Create: listener: AudioListener -> Audio

module __audio_AudioAnalyser =
    type Audio = __audio_Audio.Audio

    type [<AllowNullLiteral>] IExports =
        abstract AudioAnalyser: AudioAnalyserStatic

    type [<AllowNullLiteral>] AudioAnalyser =
        abstract analyser: AnalyserNode with get, set
        abstract data: Uint8Array with get, set
        abstract getFrequencyData: unit -> Uint8Array
        abstract getAverageFrequency: unit -> float
        abstract getData: file: obj option -> obj option

    type [<AllowNullLiteral>] AudioAnalyserStatic =
        [<Emit "new $0($1...)">] abstract Create: audio: Audio * fftSize: float -> AudioAnalyser

module __audio_AudioContext =

    type [<AllowNullLiteral>] IExports =
        abstract AudioContext: AudioContext

module __audio_AudioListener =
    type Object3D = __core_Object3D.Object3D
    type AudioContext = obj //__audio_AudioContext.AudioContext

    type [<AllowNullLiteral>] IExports =
        abstract AudioListener: AudioListenerStatic

    type [<AllowNullLiteral>] AudioListener =
        inherit Object3D
        abstract ``type``: string with get, set
        abstract context: AudioContext with get, set
        abstract gain: GainNode with get, set
        abstract filter: obj option option with get, set
        abstract timeDelta: float with get, set
        abstract getInput: unit -> GainNode
        abstract removeFilter: unit -> AudioListener
        abstract setFilter: value: obj option -> AudioListener
        abstract getFilter: unit -> obj option
        abstract setMasterVolume: value: float -> AudioListener
        abstract getMasterVolume: unit -> float
        abstract updateMatrixWorld: ?force: bool -> unit

    type [<AllowNullLiteral>] AudioListenerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> AudioListener

module __audio_PositionalAudio =
    type AudioListener = __audio_AudioListener.AudioListener
    type Audio = __audio_Audio.Audio

    type [<AllowNullLiteral>] IExports =
        abstract AudioWeaken: AudioWeakenStatic
        abstract PositionalAudio: PositionalAudioStatic

    type [<AllowNullLiteral>] AudioWeaken =
        inherit Audio
        abstract getOutput: unit -> obj option

    type [<AllowNullLiteral>] AudioWeakenStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> AudioWeaken

    type [<AllowNullLiteral>] PositionalAudio =
        inherit AudioWeaken
        abstract panner: PannerNode with get, set
        abstract getOutput: unit -> PannerNode
        abstract setRefDistance: value: float -> PositionalAudio
        abstract getRefDistance: unit -> float
        abstract setRolloffFactor: value: float -> PositionalAudio
        abstract getRolloffFactor: unit -> float
        abstract setDistanceModel: value: DistanceModelType -> PositionalAudio
        abstract getDistanceModel: unit -> DistanceModelType
        abstract setMaxDistance: value: float -> PositionalAudio
        abstract getMaxDistance: unit -> float
        abstract setDirectionalCone: coneInnerAngle: float * coneOuterAngle: float * coneOuterGain: float -> PositionalAudio
        abstract updateMatrixWorld: ?force: bool -> unit

    type [<AllowNullLiteral>] PositionalAudioStatic =
        [<Emit "new $0($1...)">] abstract Create: listener: AudioListener -> PositionalAudio

module __cameras_ArrayCamera =
    type PerspectiveCamera = __cameras_PerspectiveCamera.PerspectiveCamera

    type [<AllowNullLiteral>] IExports =
        abstract ArrayCamera: ArrayCameraStatic

    type [<AllowNullLiteral>] ArrayCamera =
        inherit PerspectiveCamera
        abstract cameras: ResizeArray<PerspectiveCamera> with get, set
        abstract isArrayCamera: obj with get, set

    type [<AllowNullLiteral>] ArrayCameraStatic =
        [<Emit "new $0($1...)">] abstract Create: ?cameras: ResizeArray<PerspectiveCamera> -> ArrayCamera

module __cameras_Camera =
    type Matrix4 = __math_Matrix4.Matrix4
    type Vector3 = __math_Vector3.Vector3
    type Object3D = __core_Object3D.Object3D

    type [<AllowNullLiteral>] IExports =
        abstract Camera: CameraStatic

    /// Abstract base class for cameras. This class should always be inherited when you build a new camera.
    type [<AllowNullLiteral>] Camera =
        inherit Object3D
        /// This is the inverse of matrixWorld. MatrixWorld contains the Matrix which has the world transform of the Camera.
        abstract matrixWorldInverse: Matrix4 with get, set
        /// This is the matrix which contains the projection.
        abstract projectionMatrix: Matrix4 with get, set
        /// This is the inverse of projectionMatrix.
        abstract projectionMatrixInverse: Matrix4 with get, set
        abstract isCamera: obj with get, set
        abstract getWorldDirection: target: Vector3 -> Vector3
        abstract updateMatrixWorld: ?force: bool -> unit

    /// Abstract base class for cameras. This class should always be inherited when you build a new camera.
    type [<AllowNullLiteral>] CameraStatic =
        /// This constructor sets following properties to the correct type: matrixWorldInverse, projectionMatrix and projectionMatrixInverse.
        [<Emit "new $0($1...)">] abstract Create: unit -> Camera

module __cameras_CubeCamera =
    type WebGLRenderTargetCube = __renderers_WebGLRenderTargetCube.WebGLRenderTargetCube
    type WebGLRenderTargetOptions = __renderers_WebGLRenderTarget.WebGLRenderTargetOptions
    type Scene = __scenes_Scene.Scene
    type WebGLRenderer = __renderers_WebGLRenderer.WebGLRenderer
    type Object3D = __core_Object3D.Object3D

    type [<AllowNullLiteral>] IExports =
        abstract CubeCamera: CubeCameraStatic

    type [<AllowNullLiteral>] CubeCamera =
        inherit Object3D
        abstract ``type``: string with get, set
        abstract renderTarget: WebGLRenderTargetCube with get, set
        abstract update: renderer: WebGLRenderer * scene: Scene -> unit
        abstract clear: renderer: WebGLRenderer * color: bool * depth: bool * stencil: bool -> unit

    type [<AllowNullLiteral>] CubeCameraStatic =
        [<Emit "new $0($1...)">] abstract Create: ?near: float * ?far: float * ?cubeResolution: float * ?options: WebGLRenderTargetOptions -> CubeCamera

module __cameras_OrthographicCamera =
    type Camera = __cameras_Camera.Camera

    type [<AllowNullLiteral>] IExports =
        abstract OrthographicCamera: OrthographicCameraStatic

    /// Camera with orthographic projection
    type [<AllowNullLiteral>] OrthographicCamera =
        inherit Camera
        abstract ``type``: string with get, set
        abstract isOrthographicCamera: obj with get, set
        abstract zoom: float with get, set
        abstract view: OrthographicCameraView option with get, set
        /// Camera frustum left plane.
        abstract left: float with get, set
        /// Camera frustum right plane.
        abstract right: float with get, set
        /// Camera frustum top plane.
        abstract top: float with get, set
        /// Camera frustum bottom plane.
        abstract bottom: float with get, set
        /// Camera frustum near plane.
        abstract near: float with get, set
        /// Camera frustum far plane.
        abstract far: float with get, set
        /// Updates the camera projection matrix. Must be called after change of parameters.
        abstract updateProjectionMatrix: unit -> unit
        abstract setViewOffset: fullWidth: float * fullHeight: float * offsetX: float * offsetY: float * width: float * height: float -> unit
        abstract clearViewOffset: unit -> unit
        abstract toJSON: ?meta: obj -> obj option

    /// Camera with orthographic projection
    type [<AllowNullLiteral>] OrthographicCameraStatic =
        /// <param name="left">Camera frustum left plane.</param>
        /// <param name="right">Camera frustum right plane.</param>
        /// <param name="top">Camera frustum top plane.</param>
        /// <param name="bottom">Camera frustum bottom plane.</param>
        /// <param name="near">Camera frustum near plane.</param>
        /// <param name="far">Camera frustum far plane.</param>
        [<Emit "new $0($1...)">] abstract Create: left: float * right: float * top: float * bottom: float * ?near: float * ?far: float -> OrthographicCamera

    type [<AllowNullLiteral>] OrthographicCameraView =
        abstract enabled: bool with get, set
        abstract fullWidth: float with get, set
        abstract fullHeight: float with get, set
        abstract offsetX: float with get, set
        abstract offsetY: float with get, set
        abstract width: float with get, set
        abstract height: float with get, set

module __cameras_PerspectiveCamera =
    type Camera = __cameras_Camera.Camera

    type [<AllowNullLiteral>] IExports =
        abstract PerspectiveCamera: PerspectiveCameraStatic

    /// Camera with perspective projection.
    type [<AllowNullLiteral>] PerspectiveCamera =
        inherit Camera
        abstract ``type``: string with get, set
        abstract isPerspectiveCamera: obj with get, set
        abstract zoom: float with get, set
        /// Camera frustum vertical field of view, from bottom to top of view, in degrees.
        abstract fov: float with get, set
        /// Camera frustum aspect ratio, window width divided by window height.
        abstract aspect: float with get, set
        /// Camera frustum near plane.
        abstract near: float with get, set
        /// Camera frustum far plane.
        abstract far: float with get, set
        abstract focus: float with get, set
        abstract view: PerspectiveCameraView option with get, set
        abstract filmGauge: float with get, set
        abstract filmOffset: float with get, set
        abstract setFocalLength: focalLength: float -> unit
        abstract getFocalLength: unit -> float
        abstract getEffectiveFOV: unit -> float
        abstract getFilmWidth: unit -> float
        abstract getFilmHeight: unit -> float
        /// <summary>Sets an offset in a larger frustum. This is useful for multi-window or multi-monitor/multi-machine setups.
        /// For example, if you have 3x2 monitors and each monitor is 1920x1080 and the monitors are in grid like this:
        /// 
        /// 		 +---+---+---+
        /// 		 | A | B | C |
        /// 		 +---+---+---+
        /// 		 | D | E | F |
        /// 		 +---+---+---+
        /// 
        /// then for each monitor you would call it like this:
        /// 
        /// 		 var w = 1920;
        /// 		 var h = 1080;
        /// 		 var fullWidth = w * 3;
        /// 		 var fullHeight = h * 2;
        /// 
        /// 		 // A
        /// 		 camera.setViewOffset( fullWidth, fullHeight, w * 0, h * 0, w, h );
        /// 		 // B
        /// 		 camera.setViewOffset( fullWidth, fullHeight, w * 1, h * 0, w, h );
        /// 		 // C
        /// 		 camera.setViewOffset( fullWidth, fullHeight, w * 2, h * 0, w, h );
        /// 		 // D
        /// 		 camera.setViewOffset( fullWidth, fullHeight, w * 0, h * 1, w, h );
        /// 		 // E
        /// 		 camera.setViewOffset( fullWidth, fullHeight, w * 1, h * 1, w, h );
        /// 		 // F
        /// 		 camera.setViewOffset( fullWidth, fullHeight, w * 2, h * 1, w, h ); Note there is no reason monitors have to be the same size or in a grid.</summary>
        /// <param name="fullWidth">full width of multiview setup</param>
        /// <param name="fullHeight">full height of multiview setup</param>
        /// <param name="x">horizontal offset of subcamera</param>
        /// <param name="y">vertical offset of subcamera</param>
        /// <param name="width">width of subcamera</param>
        /// <param name="height">height of subcamera</param>
        abstract setViewOffset: fullWidth: float * fullHeight: float * x: float * y: float * width: float * height: float -> unit
        abstract clearViewOffset: unit -> unit
        /// Updates the camera projection matrix. Must be called after change of parameters.
        abstract updateProjectionMatrix: unit -> unit
        abstract toJSON: ?meta: obj -> obj option
        abstract setLens: focalLength: float * ?frameHeight: float -> unit

    /// Camera with perspective projection.
    type [<AllowNullLiteral>] PerspectiveCameraStatic =
        /// <param name="fov">Camera frustum vertical field of view. Default value is 50.</param>
        /// <param name="aspect">Camera frustum aspect ratio. Default value is 1.</param>
        /// <param name="near">Camera frustum near plane. Default value is 0.1.</param>
        /// <param name="far">Camera frustum far plane. Default value is 2000.</param>
        [<Emit "new $0($1...)">] abstract Create: ?fov: float * ?aspect: float * ?near: float * ?far: float -> PerspectiveCamera

    type [<AllowNullLiteral>] PerspectiveCameraView =
        abstract enabled: bool with get, set
        abstract fullWidth: float with get, set
        abstract fullHeight: float with get, set
        abstract offsetX: float with get, set
        abstract offsetY: float with get, set
        abstract width: float with get, set
        abstract height: float with get, set

module __cameras_StereoCamera =
    type PerspectiveCamera = __cameras_PerspectiveCamera.PerspectiveCamera
    type Camera = __cameras_Camera.Camera

    type [<AllowNullLiteral>] IExports =
        abstract StereoCamera: StereoCameraStatic

    type [<AllowNullLiteral>] StereoCamera =
        inherit Camera
        abstract ``type``: string with get, set
        abstract aspect: float with get, set
        abstract eyeSep: float with get, set
        abstract cameraL: PerspectiveCamera with get, set
        abstract cameraR: PerspectiveCamera with get, set
        abstract update: camera: PerspectiveCamera -> unit

    type [<AllowNullLiteral>] StereoCameraStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> StereoCamera

module __core_BufferAttribute =
    type Usage = Constants.Usage
    type Matrix3 = __math_Matrix3.Matrix3
    type Matrix4 = __math_Matrix4.Matrix4

    type [<AllowNullLiteral>] IExports =
        abstract BufferAttribute: BufferAttributeStatic
        abstract Int8Attribute: Int8AttributeStatic
        abstract Uint8Attribute: Uint8AttributeStatic
        abstract Uint8ClampedAttribute: Uint8ClampedAttributeStatic
        abstract Int16Attribute: Int16AttributeStatic
        abstract Uint16Attribute: Uint16AttributeStatic
        abstract Int32Attribute: Int32AttributeStatic
        abstract Uint32Attribute: Uint32AttributeStatic
        abstract Float32Attribute: Float32AttributeStatic
        abstract Float64Attribute: Float64AttributeStatic
        abstract Int8BufferAttribute: Int8BufferAttributeStatic
        abstract Uint8BufferAttribute: Uint8BufferAttributeStatic
        abstract Uint8ClampedBufferAttribute: Uint8ClampedBufferAttributeStatic
        abstract Int16BufferAttribute: Int16BufferAttributeStatic
        abstract Uint16BufferAttribute: Uint16BufferAttributeStatic
        abstract Int32BufferAttribute: Int32BufferAttributeStatic
        abstract Uint32BufferAttribute: Uint32BufferAttributeStatic
        abstract Float32BufferAttribute: Float32BufferAttributeStatic
        abstract Float64BufferAttribute: Float64BufferAttributeStatic

    type [<AllowNullLiteral>] BufferAttribute =
        abstract name: string with get, set
        abstract array: ArrayLike<float> with get, set
        abstract itemSize: float with get, set
        abstract usage: Usage with get, set
        abstract updateRange: BufferAttributeUpdateRange with get, set
        abstract version: float with get, set
        abstract normalized: bool with get, set
        abstract count: float with get, set
        abstract isBufferAttribute: obj with get, set
        abstract onUploadCallback: (unit -> unit) with get, set
        abstract onUpload: callback: (unit -> unit) -> BufferAttribute
        abstract setUsage: usage: Usage -> BufferAttribute
        abstract clone: unit -> BufferAttribute
        abstract copy: source: BufferAttribute -> BufferAttribute
        abstract copyAt: index1: float * attribute: BufferAttribute * index2: float -> BufferAttribute
        abstract copyArray: array: ArrayLike<float> -> BufferAttribute
        abstract copyColorsArray: colors: ResizeArray<BufferAttributeCopyColorsArray> -> BufferAttribute
        abstract copyVector2sArray: vectors: ResizeArray<BufferAttributeCopyVector2sArray> -> BufferAttribute
        abstract copyVector3sArray: vectors: ResizeArray<BufferAttributeCopyVector3sArray> -> BufferAttribute
        abstract copyVector4sArray: vectors: ResizeArray<BufferAttributeCopyVector4sArray> -> BufferAttribute
        abstract applyMatrix3: m: Matrix3 -> BufferAttribute
        abstract applyMatrix4: m: Matrix4 -> BufferAttribute
        abstract applyNormalMatrix: m: Matrix3 -> BufferAttribute
        abstract transformDirection: m: Matrix4 -> BufferAttribute
        abstract set: value: U2<ArrayLike<float>, ArrayBufferView> * ?offset: float -> BufferAttribute
        abstract getX: index: float -> float
        abstract setX: index: float * x: float -> BufferAttribute
        abstract getY: index: float -> float
        abstract setY: index: float * y: float -> BufferAttribute
        abstract getZ: index: float -> float
        abstract setZ: index: float * z: float -> BufferAttribute
        abstract getW: index: float -> float
        abstract setW: index: float * z: float -> BufferAttribute
        abstract setXY: index: float * x: float * y: float -> BufferAttribute
        abstract setXYZ: index: float * x: float * y: float * z: float -> BufferAttribute
        abstract setXYZW: index: float * x: float * y: float * z: float * w: float -> BufferAttribute
        abstract toJSON: unit -> BufferAttributeToJSONReturn

    type [<AllowNullLiteral>] BufferAttributeToJSONReturn =
        abstract itemSize: float with get, set
        abstract ``type``: string with get, set
        abstract array: ResizeArray<float> with get, set
        abstract normalized: bool with get, set

    type [<AllowNullLiteral>] BufferAttributeStatic =
        [<Emit "new $0($1...)">] abstract Create: array: ArrayLike<float> * itemSize: float * ?normalized: bool -> BufferAttribute

    type [<AllowNullLiteral>] Int8Attribute =
        inherit BufferAttribute

    type [<AllowNullLiteral>] Int8AttributeStatic =
        [<Emit "new $0($1...)">] abstract Create: array: obj option * itemSize: float -> Int8Attribute

    type [<AllowNullLiteral>] Uint8Attribute =
        inherit BufferAttribute

    type [<AllowNullLiteral>] Uint8AttributeStatic =
        [<Emit "new $0($1...)">] abstract Create: array: obj option * itemSize: float -> Uint8Attribute

    type [<AllowNullLiteral>] Uint8ClampedAttribute =
        inherit BufferAttribute

    type [<AllowNullLiteral>] Uint8ClampedAttributeStatic =
        [<Emit "new $0($1...)">] abstract Create: array: obj option * itemSize: float -> Uint8ClampedAttribute

    type [<AllowNullLiteral>] Int16Attribute =
        inherit BufferAttribute

    type [<AllowNullLiteral>] Int16AttributeStatic =
        [<Emit "new $0($1...)">] abstract Create: array: obj option * itemSize: float -> Int16Attribute

    type [<AllowNullLiteral>] Uint16Attribute =
        inherit BufferAttribute

    type [<AllowNullLiteral>] Uint16AttributeStatic =
        [<Emit "new $0($1...)">] abstract Create: array: obj option * itemSize: float -> Uint16Attribute

    type [<AllowNullLiteral>] Int32Attribute =
        inherit BufferAttribute

    type [<AllowNullLiteral>] Int32AttributeStatic =
        [<Emit "new $0($1...)">] abstract Create: array: obj option * itemSize: float -> Int32Attribute

    type [<AllowNullLiteral>] Uint32Attribute =
        inherit BufferAttribute

    type [<AllowNullLiteral>] Uint32AttributeStatic =
        [<Emit "new $0($1...)">] abstract Create: array: obj option * itemSize: float -> Uint32Attribute

    type [<AllowNullLiteral>] Float32Attribute =
        inherit BufferAttribute

    type [<AllowNullLiteral>] Float32AttributeStatic =
        [<Emit "new $0($1...)">] abstract Create: array: obj option * itemSize: float -> Float32Attribute

    type [<AllowNullLiteral>] Float64Attribute =
        inherit BufferAttribute

    type [<AllowNullLiteral>] Float64AttributeStatic =
        [<Emit "new $0($1...)">] abstract Create: array: obj option * itemSize: float -> Float64Attribute

    type [<AllowNullLiteral>] Int8BufferAttribute =
        inherit BufferAttribute

    type [<AllowNullLiteral>] Int8BufferAttributeStatic =
        [<Emit "new $0($1...)">] abstract Create: array: U4<Iterable<float>, ArrayLike<float>, ArrayBuffer, float> * itemSize: float * ?normalized: bool -> Int8BufferAttribute

    type [<AllowNullLiteral>] Uint8BufferAttribute =
        inherit BufferAttribute

    type [<AllowNullLiteral>] Uint8BufferAttributeStatic =
        [<Emit "new $0($1...)">] abstract Create: array: U4<Iterable<float>, ArrayLike<float>, ArrayBuffer, float> * itemSize: float * ?normalized: bool -> Uint8BufferAttribute

    type [<AllowNullLiteral>] Uint8ClampedBufferAttribute =
        inherit BufferAttribute

    type [<AllowNullLiteral>] Uint8ClampedBufferAttributeStatic =
        [<Emit "new $0($1...)">] abstract Create: array: U4<Iterable<float>, ArrayLike<float>, ArrayBuffer, float> * itemSize: float * ?normalized: bool -> Uint8ClampedBufferAttribute

    type [<AllowNullLiteral>] Int16BufferAttribute =
        inherit BufferAttribute

    type [<AllowNullLiteral>] Int16BufferAttributeStatic =
        [<Emit "new $0($1...)">] abstract Create: array: U4<Iterable<float>, ArrayLike<float>, ArrayBuffer, float> * itemSize: float * ?normalized: bool -> Int16BufferAttribute

    type [<AllowNullLiteral>] Uint16BufferAttribute =
        inherit BufferAttribute

    type [<AllowNullLiteral>] Uint16BufferAttributeStatic =
        [<Emit "new $0($1...)">] abstract Create: array: U4<Iterable<float>, ArrayLike<float>, ArrayBuffer, float> * itemSize: float * ?normalized: bool -> Uint16BufferAttribute

    type [<AllowNullLiteral>] Int32BufferAttribute =
        inherit BufferAttribute

    type [<AllowNullLiteral>] Int32BufferAttributeStatic =
        [<Emit "new $0($1...)">] abstract Create: array: U4<Iterable<float>, ArrayLike<float>, ArrayBuffer, float> * itemSize: float * ?normalized: bool -> Int32BufferAttribute

    type [<AllowNullLiteral>] Uint32BufferAttribute =
        inherit BufferAttribute

    type [<AllowNullLiteral>] Uint32BufferAttributeStatic =
        [<Emit "new $0($1...)">] abstract Create: array: U4<Iterable<float>, ArrayLike<float>, ArrayBuffer, float> * itemSize: float * ?normalized: bool -> Uint32BufferAttribute

    type [<AllowNullLiteral>] Float32BufferAttribute =
        inherit BufferAttribute

    type [<AllowNullLiteral>] Float32BufferAttributeStatic =
        [<Emit "new $0($1...)">] abstract Create: array: U4<Iterable<float>, ArrayLike<float>, ArrayBuffer, float> * itemSize: float * ?normalized: bool -> Float32BufferAttribute

    type [<AllowNullLiteral>] Float64BufferAttribute =
        inherit BufferAttribute

    type [<AllowNullLiteral>] Float64BufferAttributeStatic =
        [<Emit "new $0($1...)">] abstract Create: array: U4<Iterable<float>, ArrayLike<float>, ArrayBuffer, float> * itemSize: float * ?normalized: bool -> Float64BufferAttribute

    type [<AllowNullLiteral>] BufferAttributeUpdateRange =
        abstract offset: float with get, set
        abstract count: float with get, set

    type [<AllowNullLiteral>] BufferAttributeCopyColorsArray =
        abstract r: float with get, set
        abstract g: float with get, set
        abstract b: float with get, set

    type [<AllowNullLiteral>] BufferAttributeCopyVector2sArray =
        abstract x: float with get, set
        abstract y: float with get, set

    type [<AllowNullLiteral>] BufferAttributeCopyVector3sArray =
        abstract x: float with get, set
        abstract y: float with get, set
        abstract z: float with get, set

    type [<AllowNullLiteral>] BufferAttributeCopyVector4sArray =
        abstract x: float with get, set
        abstract y: float with get, set
        abstract z: float with get, set
        abstract w: float with get, set

module __core_BufferGeometry =
    type BufferAttribute = __core_BufferAttribute.BufferAttribute
    type Box3 = __math_Box3.Box3
    type Sphere = __math_Sphere.Sphere
    type Matrix4 = __math_Matrix4.Matrix4
    type Vector2 = __math_Vector2.Vector2
    type Vector3 = __math_Vector3.Vector3
    type Object3D = __core_Object3D.Object3D
    type Geometry = __core_Geometry.Geometry
    type DirectGeometry = __core_DirectGeometry.DirectGeometry
    type EventDispatcher = __core_EventDispatcher.EventDispatcher
    type InterleavedBufferAttribute = __core_InterleavedBufferAttribute.InterleavedBufferAttribute

    type [<AllowNullLiteral>] IExports =
        abstract BufferGeometry: BufferGeometryStatic

    /// This is a superefficent class for geometries because it saves all data in buffers.
    /// It reduces memory costs and cpu cycles. But it is not as easy to work with because of all the nessecary buffer calculations.
    /// It is mainly interesting when working with static objects.
    type [<AllowNullLiteral>] BufferGeometry =
        inherit EventDispatcher
        /// Unique number of this buffergeometry instance
        abstract id: float with get, set
        abstract uuid: string with get, set
        abstract name: string with get, set
        abstract ``type``: string with get, set
        abstract index: BufferAttribute option with get, set
        abstract attributes: BufferGeometryAttributes with get, set
        abstract morphAttributes: BufferGeometryMorphAttributes with get, set
        abstract morphTargetsRelative: bool with get, set
        abstract groups: ResizeArray<BufferGeometryGroups> with get, set
        abstract boundingBox: Box3 with get, set
        abstract boundingSphere: Sphere with get, set
        abstract drawRange: BufferGeometryDrawRange with get, set
        abstract userData: BufferGeometryUserData with get, set
        abstract isBufferGeometry: bool with get, set
        abstract getIndex: unit -> BufferAttribute option
        abstract setIndex: index: U2<BufferAttribute, ResizeArray<float>> option -> unit
        abstract setAttribute: name: string * attribute: U2<BufferAttribute, InterleavedBufferAttribute> -> BufferGeometry
        abstract getAttribute: name: string -> U2<BufferAttribute, InterleavedBufferAttribute>
        abstract deleteAttribute: name: string -> BufferGeometry
        abstract addGroup: start: float * count: float * ?materialIndex: float -> unit
        abstract clearGroups: unit -> unit
        abstract setDrawRange: start: float * count: float -> unit
        /// Bakes matrix transform directly into vertex coordinates.
        abstract applyMatrix: matrix: Matrix4 -> BufferGeometry
        abstract rotateX: angle: float -> BufferGeometry
        abstract rotateY: angle: float -> BufferGeometry
        abstract rotateZ: angle: float -> BufferGeometry
        abstract translate: x: float * y: float * z: float -> BufferGeometry
        abstract scale: x: float * y: float * z: float -> BufferGeometry
        abstract lookAt: v: Vector3 -> unit
        abstract center: unit -> BufferGeometry
        abstract setFromObject: ``object``: Object3D -> BufferGeometry
        abstract setFromPoints: points: U2<ResizeArray<Vector3>, ResizeArray<Vector2>> -> BufferGeometry
        abstract updateFromObject: ``object``: Object3D -> unit
        abstract fromGeometry: geometry: Geometry * ?settings: obj -> BufferGeometry
        abstract fromDirectGeometry: geometry: DirectGeometry -> BufferGeometry
        /// Computes bounding box of the geometry, updating Geometry.boundingBox attribute.
        /// Bounding boxes aren't computed by default. They need to be explicitly computed, otherwise they are null.
        abstract computeBoundingBox: unit -> unit
        /// Computes bounding sphere of the geometry, updating Geometry.boundingSphere attribute.
        /// Bounding spheres aren't' computed by default. They need to be explicitly computed, otherwise they are null.
        abstract computeBoundingSphere: unit -> unit
        /// Computes vertex normals by averaging face normals.
        abstract computeVertexNormals: unit -> unit
        abstract merge: geometry: BufferGeometry * offset: float -> BufferGeometry
        abstract normalizeNormals: unit -> unit
        abstract toNonIndexed: unit -> BufferGeometry
        abstract toJSON: unit -> obj option
        abstract clone: unit -> BufferGeometry
        abstract copy: source: BufferGeometry -> BufferGeometry
        /// Disposes the object from memory.
        /// You need to call this when you want the bufferGeometry removed while the application is running.
        abstract dispose: unit -> unit
        abstract drawcalls: obj option with get, set
        abstract offsets: obj option with get, set
        abstract addIndex: index: obj option -> unit
        abstract addDrawCall: start: obj option * count: obj option * ?indexOffset: obj -> unit
        abstract clearDrawCalls: unit -> unit
        abstract addAttribute: name: string * attribute: U2<BufferAttribute, InterleavedBufferAttribute> -> BufferGeometry
        abstract removeAttribute: name: string -> BufferGeometry
        abstract addAttribute: name: obj option * array: obj option * itemSize: obj option -> obj option

    /// This is a superefficent class for geometries because it saves all data in buffers.
    /// It reduces memory costs and cpu cycles. But it is not as easy to work with because of all the nessecary buffer calculations.
    /// It is mainly interesting when working with static objects.
    type [<AllowNullLiteral>] BufferGeometryStatic =
        /// This creates a new BufferGeometry. It also sets several properties to an default value.
        [<Emit "new $0($1...)">] abstract Create: unit -> BufferGeometry
        abstract MaxIndex: float with get, set

    type [<AllowNullLiteral>] BufferGeometryAttributes =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: name: string -> U2<BufferAttribute, InterleavedBufferAttribute> with get, set

    type [<AllowNullLiteral>] BufferGeometryMorphAttributes =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: name: string -> ResizeArray<U2<BufferAttribute, InterleavedBufferAttribute>> with get, set

    type [<AllowNullLiteral>] BufferGeometryGroups =
        abstract start: float with get, set
        abstract count: float with get, set
        abstract materialIndex: float option with get, set

    type [<AllowNullLiteral>] BufferGeometryDrawRange =
        abstract start: float with get, set
        abstract count: float with get, set

    type [<AllowNullLiteral>] BufferGeometryUserData =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

module __core_Clock =

    type [<AllowNullLiteral>] IExports =
        abstract Clock: ClockStatic

    /// Object for keeping track of time.
    type [<AllowNullLiteral>] Clock =
        /// If set, starts the clock automatically when the first update is called.
        abstract autoStart: bool with get, set
        /// When the clock is running, It holds the starttime of the clock.
        /// This counted from the number of milliseconds elapsed since 1 January 1970 00:00:00 UTC.
        abstract startTime: float with get, set
        /// When the clock is running, It holds the previous time from a update.
        /// This counted from the number of milliseconds elapsed since 1 January 1970 00:00:00 UTC.
        abstract oldTime: float with get, set
        /// When the clock is running, It holds the time elapsed between the start of the clock to the previous update.
        /// This parameter is in seconds of three decimal places.
        abstract elapsedTime: float with get, set
        /// This property keeps track whether the clock is running or not.
        abstract running: bool with get, set
        /// Starts clock.
        abstract start: unit -> unit
        /// Stops clock.
        abstract stop: unit -> unit
        /// Get the seconds passed since the clock started.
        abstract getElapsedTime: unit -> float
        /// Get the seconds passed since the last call to this method.
        abstract getDelta: unit -> float

    /// Object for keeping track of time.
    type [<AllowNullLiteral>] ClockStatic =
        /// <param name="autoStart">Automatically start the clock.</param>
        [<Emit "new $0($1...)">] abstract Create: ?autoStart: bool -> Clock

module __core_DirectGeometry =
    type Vector3 = __math_Vector3.Vector3
    type Color = __math_Color.Color
    type Vector2 = __math_Vector2.Vector2
    type Vector4 = __math_Vector4.Vector4
    type Box3 = __math_Box3.Box3
    type Sphere = __math_Sphere.Sphere
    type Geometry = __core_Geometry.Geometry
    type MorphTarget = __core_Geometry.MorphTarget

    type [<AllowNullLiteral>] IExports =
        abstract DirectGeometry: DirectGeometryStatic

    type [<AllowNullLiteral>] DirectGeometry =
        abstract id: float with get, set
        abstract uuid: string with get, set
        abstract name: string with get, set
        abstract ``type``: string with get, set
        abstract indices: ResizeArray<float> with get, set
        abstract vertices: ResizeArray<Vector3> with get, set
        abstract normals: ResizeArray<Vector3> with get, set
        abstract colors: ResizeArray<Color> with get, set
        abstract uvs: ResizeArray<Vector2> with get, set
        abstract uvs2: ResizeArray<Vector2> with get, set
        abstract groups: ResizeArray<DirectGeometryGroups> with get, set
        abstract morphTargets: ResizeArray<MorphTarget> with get, set
        abstract skinWeights: ResizeArray<Vector4> with get, set
        abstract skinIndices: ResizeArray<Vector4> with get, set
        abstract boundingBox: Box3 with get, set
        abstract boundingSphere: Sphere with get, set
        abstract verticesNeedUpdate: bool with get, set
        abstract normalsNeedUpdate: bool with get, set
        abstract colorsNeedUpdate: bool with get, set
        abstract uvsNeedUpdate: bool with get, set
        abstract groupsNeedUpdate: bool with get, set
        abstract computeBoundingBox: unit -> unit
        abstract computeBoundingSphere: unit -> unit
        abstract computeGroups: geometry: Geometry -> unit
        abstract fromGeometry: geometry: Geometry -> DirectGeometry
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] DirectGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> DirectGeometry

    type [<AllowNullLiteral>] DirectGeometryGroups =
        abstract start: float with get, set
        abstract materialIndex: float with get, set

module __core_EventDispatcher =
    type Event = __core_Face3.Event

    type [<AllowNullLiteral>] IExports =
        abstract EventDispatcher: EventDispatcherStatic

    /// JavaScript events for custom objects
    type [<AllowNullLiteral>] EventDispatcher =
        /// <summary>Adds a listener to an event type.</summary>
        /// <param name="type">The type of event to listen to.</param>
        /// <param name="listener">The function that gets called when the event is fired.</param>
        abstract addEventListener: ``type``: string * listener: (Event -> unit) -> unit
        /// <summary>Checks if listener is added to an event type.</summary>
        /// <param name="type">The type of event to listen to.</param>
        /// <param name="listener">The function that gets called when the event is fired.</param>
        abstract hasEventListener: ``type``: string * listener: (Event -> unit) -> bool
        /// <summary>Removes a listener from an event type.</summary>
        /// <param name="type">The type of the listener that gets removed.</param>
        /// <param name="listener">The listener function that gets removed.</param>
        abstract removeEventListener: ``type``: string * listener: (Event -> unit) -> unit
        /// Fire an event type.
        abstract dispatchEvent: ``event``: EventDispatcherDispatchEventEvent -> unit

    type [<AllowNullLiteral>] EventDispatcherDispatchEventEvent =
        abstract ``type``: string with get, set
        [<Emit "$0[$1]{{=$2}}">] abstract Item: attachment: string -> obj option with get, set

    /// JavaScript events for custom objects
    type [<AllowNullLiteral>] EventDispatcherStatic =
        /// Creates eventDispatcher object. It needs to be call with '.call' to add the functionality to an object.
        [<Emit "new $0($1...)">] abstract Create: unit -> EventDispatcher

module __core_Face3 =
    type Vector3 = __math_Vector3.Vector3
    type Color = __math_Color.Color

    type [<AllowNullLiteral>] IExports =
        abstract Face3: Face3Static

    type [<AllowNullLiteral>] Event =
        abstract ``type``: string with get, set
        abstract target: obj option with get, set
        [<Emit "$0[$1]{{=$2}}">] abstract Item: attachment: string -> obj option with get, set

    /// Triangle face.
    type [<AllowNullLiteral>] Face3 =
        /// Vertex A index.
        abstract a: float with get, set
        /// Vertex B index.
        abstract b: float with get, set
        /// Vertex C index.
        abstract c: float with get, set
        /// Face normal.
        abstract normal: Vector3 with get, set
        /// Array of 4 vertex normals.
        abstract vertexNormals: ResizeArray<Vector3> with get, set
        /// Face color.
        abstract color: Color with get, set
        /// Array of 4 vertex normals.
        abstract vertexColors: ResizeArray<Color> with get, set
        /// Material index (points to {@link Geometry.materials}).
        abstract materialIndex: float with get, set
        abstract clone: unit -> Face3
        abstract copy: source: Face3 -> Face3

    /// Triangle face.
    type [<AllowNullLiteral>] Face3Static =
        /// <param name="a">Vertex A index.</param>
        /// <param name="b">Vertex B index.</param>
        /// <param name="c">Vertex C index.</param>
        /// <param name="normal">Face normal or array of vertex normals.</param>
        /// <param name="color">Face color or array of vertex colors.</param>
        /// <param name="materialIndex">Material index.</param>
        [<Emit "new $0($1...)">] abstract Create: a: float * b: float * c: float * ?normal: Vector3 * ?color: Color * ?materialIndex: float -> Face3
        [<Emit "new $0($1...)">] abstract Create: a: float * b: float * c: float * ?normal: Vector3 * ?vertexColors: ResizeArray<Color> * ?materialIndex: float -> Face3
        [<Emit "new $0($1...)">] abstract Create: a: float * b: float * c: float * ?vertexNormals: ResizeArray<Vector3> * ?color: Color * ?materialIndex: float -> Face3
        [<Emit "new $0($1...)">] abstract Create: a: float * b: float * c: float * ?vertexNormals: ResizeArray<Vector3> * ?vertexColors: ResizeArray<Color> * ?materialIndex: float -> Face3

module __core_Geometry =
    type Vector3 = __math_Vector3.Vector3
    type Color = __math_Color.Color
    type Face3 = __core_Face3.Face3
    type Vector2 = __math_Vector2.Vector2
    type Vector4 = __math_Vector4.Vector4
    type Box3 = __math_Box3.Box3
    type Sphere = __math_Sphere.Sphere
    type Matrix4 = __math_Matrix4.Matrix4
    type BufferGeometry = __core_BufferGeometry.BufferGeometry
    type Matrix = __math_Matrix3.Matrix
    type Mesh = __objects_Mesh.Mesh
    type Bone = __objects_Bone.Bone
    type AnimationClip = __animation_AnimationClip.AnimationClip
    type EventDispatcher = __core_EventDispatcher.EventDispatcher

    type [<AllowNullLiteral>] IExports =
        abstract GeometryIdCount: float
        abstract Geometry: GeometryStatic

    type [<AllowNullLiteral>] MorphTarget =
        abstract name: string with get, set
        abstract vertices: ResizeArray<Vector3> with get, set

    type [<AllowNullLiteral>] MorphColor =
        abstract name: string with get, set
        abstract colors: ResizeArray<Color> with get, set

    type [<AllowNullLiteral>] MorphNormals =
        abstract name: string with get, set
        abstract normals: ResizeArray<Vector3> with get, set

    /// Base class for geometries
    type [<AllowNullLiteral>] Geometry =
        inherit EventDispatcher
        /// Unique number of this geometry instance
        abstract id: float with get, set
        abstract uuid: string with get, set
        abstract isGeometry: bool with get, set
        /// Name for this geometry. Default is an empty string.
        abstract name: string with get, set
        abstract ``type``: string with get, set
        /// The array of vertices hold every position of points of the model.
        /// To signal an update in this array, Geometry.verticesNeedUpdate needs to be set to true.
        abstract vertices: ResizeArray<Vector3> with get, set
        /// Array of vertex colors, matching number and order of vertices.
        /// Used in ParticleSystem, Line and Ribbon.
        /// Meshes use per-face-use-of-vertex colors embedded directly in faces.
        /// To signal an update in this array, Geometry.colorsNeedUpdate needs to be set to true.
        abstract colors: ResizeArray<Color> with get, set
        /// Array of triangles or/and quads.
        /// The array of faces describe how each vertex in the model is connected with each other.
        /// To signal an update in this array, Geometry.elementsNeedUpdate needs to be set to true.
        abstract faces: ResizeArray<Face3> with get, set
        /// Array of face UV layers.
        /// Each UV layer is an array of UV matching order and number of vertices in faces.
        /// To signal an update in this array, Geometry.uvsNeedUpdate needs to be set to true.
        abstract faceVertexUvs: ResizeArray<ResizeArray<ResizeArray<Vector2>>> with get, set
        /// Array of morph targets. Each morph target is a Javascript object:
        /// 
        /// 		 { name: "targetName", vertices: [ new THREE.Vector3(), ... ] }
        /// 
        /// Morph vertices match number and order of primary vertices.
        abstract morphTargets: ResizeArray<MorphTarget> with get, set
        /// Array of morph normals. Morph normals have similar structure as morph targets, each normal set is a Javascript object:
        /// 
        /// 		 morphNormal = { name: "NormalName", normals: [ new THREE.Vector3(), ... ] }
        abstract morphNormals: ResizeArray<MorphNormals> with get, set
        /// Array of skinning weights, matching number and order of vertices.
        abstract skinWeights: ResizeArray<Vector4> with get, set
        /// Array of skinning indices, matching number and order of vertices.
        abstract skinIndices: ResizeArray<Vector4> with get, set
        abstract lineDistances: ResizeArray<float> with get, set
        /// Bounding box.
        abstract boundingBox: Box3 with get, set
        /// Bounding sphere.
        abstract boundingSphere: Sphere with get, set
        /// Set to true if the vertices array has been updated.
        abstract verticesNeedUpdate: bool with get, set
        /// Set to true if the faces array has been updated.
        abstract elementsNeedUpdate: bool with get, set
        /// Set to true if the uvs array has been updated.
        abstract uvsNeedUpdate: bool with get, set
        /// Set to true if the normals array has been updated.
        abstract normalsNeedUpdate: bool with get, set
        /// Set to true if the colors array has been updated.
        abstract colorsNeedUpdate: bool with get, set
        /// Set to true if the linedistances array has been updated.
        abstract lineDistancesNeedUpdate: bool with get, set
        abstract groupsNeedUpdate: bool with get, set
        /// Bakes matrix transform directly into vertex coordinates.
        abstract applyMatrix: matrix: Matrix4 -> Geometry
        abstract rotateX: angle: float -> Geometry
        abstract rotateY: angle: float -> Geometry
        abstract rotateZ: angle: float -> Geometry
        abstract translate: x: float * y: float * z: float -> Geometry
        abstract scale: x: float * y: float * z: float -> Geometry
        abstract lookAt: vector: Vector3 -> unit
        abstract fromBufferGeometry: geometry: BufferGeometry -> Geometry
        abstract center: unit -> Geometry
        abstract normalize: unit -> Geometry
        /// Computes face normals.
        abstract computeFaceNormals: unit -> unit
        /// Computes vertex normals by averaging face normals.
        /// Face normals must be existing / computed beforehand.
        abstract computeVertexNormals: ?areaWeighted: bool -> unit
        /// Compute vertex normals, but duplicating face normals.
        abstract computeFlatVertexNormals: unit -> unit
        /// Computes morph normals.
        abstract computeMorphNormals: unit -> unit
        /// Computes bounding box of the geometry, updating {@link Geometry.boundingBox} attribute.
        abstract computeBoundingBox: unit -> unit
        /// Computes bounding sphere of the geometry, updating Geometry.boundingSphere attribute.
        /// Neither bounding boxes or bounding spheres are computed by default. They need to be explicitly computed, otherwise they are null.
        abstract computeBoundingSphere: unit -> unit
        abstract merge: geometry: Geometry * ?matrix: Matrix * ?materialIndexOffset: float -> unit
        abstract mergeMesh: mesh: Mesh -> unit
        /// Checks for duplicate vertices using hashmap.
        /// Duplicated vertices are removed and faces' vertices are updated.
        abstract mergeVertices: unit -> float
        abstract setFromPoints: points: U2<Array<Vector2>, Array<Vector3>> -> Geometry
        abstract sortFacesByMaterialIndex: unit -> unit
        abstract toJSON: unit -> obj option
        /// Creates a new clone of the Geometry.
        abstract clone: unit -> Geometry
        abstract copy: source: Geometry -> Geometry
        /// Removes The object from memory.
        /// Don't forget to call this method when you remove an geometry because it can cuase meomory leaks.
        abstract dispose: unit -> unit
        abstract bones: ResizeArray<Bone> with get, set
        abstract animation: AnimationClip with get, set
        abstract animations: ResizeArray<AnimationClip> with get, set

    /// Base class for geometries
    type [<AllowNullLiteral>] GeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Geometry

module __core_InstancedBufferAttribute =
    type BufferGeometry = __core_BufferGeometry.BufferGeometry
    type BufferAttribute = __core_BufferAttribute.BufferAttribute
    let [<Import("BufferGeometryUtils","three/core/InstancedBufferAttribute")>] bufferGeometryUtils: BufferGeometryUtils.IExports = jsNative
    let [<Import("GeometryUtils","three/core/InstancedBufferAttribute")>] geometryUtils: GeometryUtils.IExports = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract InstancedBufferAttribute: InstancedBufferAttributeStatic

    module BufferGeometryUtils =

        type [<AllowNullLiteral>] IExports =
            abstract mergeBufferGeometries: geometries: ResizeArray<BufferGeometry> -> BufferGeometry
            abstract computeTangents: geometry: BufferGeometry -> obj
            abstract mergeBufferAttributes: attributes: ResizeArray<BufferAttribute> -> BufferAttribute

    module GeometryUtils =

        type [<AllowNullLiteral>] IExports =
            abstract merge: geometry1: obj option * geometry2: obj option * ?materialIndexOffset: obj -> obj option
            abstract center: geometry: obj option -> obj option

    type [<AllowNullLiteral>] InstancedBufferAttribute =
        inherit BufferAttribute
        abstract meshPerAttribute: float with get, set

    type [<AllowNullLiteral>] InstancedBufferAttributeStatic =
        [<Emit "new $0($1...)">] abstract Create: array: ArrayLike<float> * itemSize: float * ?normalized: bool * ?meshPerAttribute: float -> InstancedBufferAttribute

module __core_InstancedBufferGeometry =
    type BufferGeometry = __core_BufferGeometry.BufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract InstancedBufferGeometry: InstancedBufferGeometryStatic

    type [<AllowNullLiteral>] InstancedBufferGeometry =
        inherit BufferGeometry
        abstract groups: ResizeArray<InstancedBufferGeometryGroups> with get, set
        abstract maxInstancedCount: float with get, set
        abstract addGroup: start: float * count: float * instances: float -> unit

    type [<AllowNullLiteral>] InstancedBufferGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> InstancedBufferGeometry

    type [<AllowNullLiteral>] InstancedBufferGeometryGroups =
        abstract start: float with get, set
        abstract count: float with get, set
        abstract instances: float with get, set

module __core_InstancedInterleavedBuffer =
    type InterleavedBuffer = __core_InterleavedBuffer.InterleavedBuffer

    type [<AllowNullLiteral>] IExports =
        abstract InstancedInterleavedBuffer: InstancedInterleavedBufferStatic

    type [<AllowNullLiteral>] InstancedInterleavedBuffer =
        inherit InterleavedBuffer
        abstract meshPerAttribute: float with get, set

    type [<AllowNullLiteral>] InstancedInterleavedBufferStatic =
        [<Emit "new $0($1...)">] abstract Create: array: ArrayLike<float> * stride: float * ?meshPerAttribute: float -> InstancedInterleavedBuffer

module __core_InterleavedBuffer =
    type InterleavedBufferAttribute = __core_InterleavedBufferAttribute.InterleavedBufferAttribute
    type Usage = Constants.Usage

    type [<AllowNullLiteral>] IExports =
        abstract InterleavedBuffer: InterleavedBufferStatic

    type [<AllowNullLiteral>] InterleavedBuffer =
        abstract array: ArrayLike<float> with get, set
        abstract stride: float with get, set
        abstract usage: Usage with get, set
        abstract updateRange: InterleavedBufferUpdateRange with get, set
        abstract version: float with get, set
        abstract length: float with get, set
        abstract count: float with get, set
        abstract needsUpdate: bool with get, set
        abstract setUsage: usage: Usage -> InterleavedBuffer
        abstract clone: unit -> InterleavedBuffer
        abstract copy: source: InterleavedBuffer -> InterleavedBuffer
        abstract copyAt: index1: float * attribute: InterleavedBufferAttribute * index2: float -> InterleavedBuffer
        abstract set: value: ArrayLike<float> * index: float -> InterleavedBuffer

    type [<AllowNullLiteral>] InterleavedBufferStatic =
        [<Emit "new $0($1...)">] abstract Create: array: ArrayLike<float> * stride: float -> InterleavedBuffer

    type [<AllowNullLiteral>] InterleavedBufferUpdateRange =
        abstract offset: float with get, set
        abstract count: float with get, set

module __core_InterleavedBufferAttribute =
    type InterleavedBuffer = __core_InterleavedBuffer.InterleavedBuffer
    type Matrix4 = __math_Matrix4.Matrix4

    type [<AllowNullLiteral>] IExports =
        abstract InterleavedBufferAttribute: InterleavedBufferAttributeStatic

    type [<AllowNullLiteral>] InterleavedBufferAttribute =
        abstract data: InterleavedBuffer with get, set
        abstract itemSize: float with get, set
        abstract offset: float with get, set
        abstract normalized: bool with get, set
        abstract isInterleavedBufferAttribute: obj with get, set
        abstract applyMatrix4: m: Matrix4 -> InterleavedBufferAttribute
        abstract getX: index: float -> float
        abstract setX: index: float * x: float -> InterleavedBufferAttribute
        abstract getY: index: float -> float
        abstract setY: index: float * y: float -> InterleavedBufferAttribute
        abstract getZ: index: float -> float
        abstract setZ: index: float * z: float -> InterleavedBufferAttribute
        abstract getW: index: float -> float
        abstract setW: index: float * z: float -> InterleavedBufferAttribute
        abstract setXY: index: float * x: float * y: float -> InterleavedBufferAttribute
        abstract setXYZ: index: float * x: float * y: float * z: float -> InterleavedBufferAttribute
        abstract setXYZW: index: float * x: float * y: float * z: float * w: float -> InterleavedBufferAttribute

    type [<AllowNullLiteral>] InterleavedBufferAttributeStatic =
        [<Emit "new $0($1...)">] abstract Create: interleavedBuffer: InterleavedBuffer * itemSize: float * offset: float * ?normalized: bool -> InterleavedBufferAttribute

module __core_Layers =

    type [<AllowNullLiteral>] IExports =
        abstract Layers: LayersStatic

    type [<AllowNullLiteral>] Layers =
        abstract mask: float with get, set
        abstract set: channel: float -> unit
        abstract enable: channel: float -> unit
        abstract enableAll: unit -> unit
        abstract toggle: channel: float -> unit
        abstract disable: channel: float -> unit
        abstract disableAll: unit -> unit
        abstract test: layers: Layers -> bool

    type [<AllowNullLiteral>] LayersStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Layers

module __core_Object3D =
    type Vector3 = __math_Vector3.Vector3
    type Euler = __math_Euler.Euler
    type Quaternion = __math_Quaternion.Quaternion
    type Matrix4 = __math_Matrix4.Matrix4
    type Matrix3 = __math_Matrix3.Matrix3
    type Layers = __core_Layers.Layers
    type WebGLRenderer = __renderers_WebGLRenderer.WebGLRenderer
    type Scene = __scenes_Scene.Scene
    type Camera = __cameras_Camera.Camera
    type Geometry = __core_Geometry.Geometry
    type Material = __materials_Material.Material
    type Group = __objects_Group.Group
    type Raycaster = __core_Raycaster.Raycaster
    type EventDispatcher = __core_EventDispatcher.EventDispatcher
    type BufferGeometry = __core_BufferGeometry.BufferGeometry
    type Intersection = __core_Raycaster.Intersection

    type [<AllowNullLiteral>] IExports =
        abstract Object3DIdCount: float
        abstract Object3D: Object3DStatic

    /// Base class for scene graph objects
    type [<AllowNullLiteral>] Object3D =
        inherit EventDispatcher
        /// Unique number of this object instance.
        abstract id: float with get, set
        abstract uuid: string with get, set
        /// Optional name of the object (doesn't need to be unique).
        abstract name: string with get, set
        abstract ``type``: string with get, set
        /// Object's parent in the scene graph.
        abstract parent: Object3D option with get, set
        /// Array with object's children.
        abstract children: ResizeArray<Object3D> with get, set
        /// Up direction.
        abstract up: Vector3 with get, set
        /// Object's local position.
        abstract position: Vector3
        /// Object's local rotation (Euler angles), in radians.
        abstract rotation: Euler
        /// Global rotation.
        abstract quaternion: Quaternion
        /// Object's local scale.
        abstract scale: Vector3
        abstract modelViewMatrix: Matrix4
        abstract normalMatrix: Matrix3
        /// Local transform.
        abstract matrix: Matrix4 with get, set
        /// The global transform of the object. If the Object3d has no parent, then it's identical to the local transform.
        abstract matrixWorld: Matrix4 with get, set
        /// When this is set, it calculates the matrix of position, (rotation or quaternion) and scale every frame and also recalculates the matrixWorld property.
        abstract matrixAutoUpdate: bool with get, set
        /// When this is set, it calculates the matrixWorld in that frame and resets this property to false.
        abstract matrixWorldNeedsUpdate: bool with get, set
        abstract layers: Layers with get, set
        /// Object gets rendered if true.
        abstract visible: bool with get, set
        /// Gets rendered into shadow map.
        abstract castShadow: bool with get, set
        /// Material gets baked in shadow receiving.
        abstract receiveShadow: bool with get, set
        /// When this is set, it checks every frame if the object is in the frustum of the camera. Otherwise the object gets drawn every frame even if it isn't visible.
        abstract frustumCulled: bool with get, set
        /// Overrides the default rendering order of scene graph objects, from lowest to highest renderOrder. Opaque and transparent objects remain sorted independently though. When this property is set for an instance of Group, all descendants objects will be sorted and rendered together.
        abstract renderOrder: float with get, set
        /// An object that can be used to store custom data about the Object3d. It should not hold references to functions as these will not be cloned.
        abstract userData: Object3DUserData with get, set
        /// Custom depth material to be used when rendering to the depth map. Can only be used in context of meshes.
        /// When shadow-casting with a DirectionalLight or SpotLight, if you are (a) modifying vertex positions in
        /// the vertex shader, (b) using a displacement map, (c) using an alpha map with alphaTest, or (d) using a
        /// transparent texture with alphaTest, you must specify a customDepthMaterial for proper shadows.
        abstract customDepthMaterial: Material with get, set
        /// Same as customDepthMaterial, but used with PointLight.
        abstract customDistanceMaterial: Material with get, set
        /// Used to check whether this or derived classes are Object3Ds. Default is true.
        /// You should not change this, as it is used internally for optimisation.
        abstract isObject3D: obj with get, set
        /// Calls before rendering object
        abstract onBeforeRender: (WebGLRenderer -> Scene -> Camera -> U2<Geometry, BufferGeometry> -> Material -> Group -> unit) with get, set
        /// Calls after rendering object
        abstract onAfterRender: (WebGLRenderer -> Scene -> Camera -> U2<Geometry, BufferGeometry> -> Material -> Group -> unit) with get, set
        /// This updates the position, rotation and scale with the matrix.
        abstract applyMatrix: matrix: Matrix4 -> unit
        abstract applyQuaternion: quaternion: Quaternion -> Object3D
        abstract setRotationFromAxisAngle: axis: Vector3 * angle: float -> unit
        abstract setRotationFromEuler: euler: Euler -> unit
        abstract setRotationFromMatrix: m: Matrix4 -> unit
        abstract setRotationFromQuaternion: q: Quaternion -> unit
        /// <summary>Rotate an object along an axis in object space. The axis is assumed to be normalized.</summary>
        /// <param name="axis">A normalized vector in object space.</param>
        /// <param name="angle">The angle in radians.</param>
        abstract rotateOnAxis: axis: Vector3 * angle: float -> Object3D
        /// <summary>Rotate an object along an axis in world space. The axis is assumed to be normalized. Method Assumes no rotated parent.</summary>
        /// <param name="axis">A normalized vector in object space.</param>
        /// <param name="angle">The angle in radians.</param>
        abstract rotateOnWorldAxis: axis: Vector3 * angle: float -> Object3D
        abstract rotateX: angle: float -> Object3D
        abstract rotateY: angle: float -> Object3D
        abstract rotateZ: angle: float -> Object3D
        /// <param name="axis">A normalized vector in object space.</param>
        /// <param name="distance">The distance to translate.</param>
        abstract translateOnAxis: axis: Vector3 * distance: float -> Object3D
        /// <summary>Translates object along x axis by distance.</summary>
        /// <param name="distance">Distance.</param>
        abstract translateX: distance: float -> Object3D
        /// <summary>Translates object along y axis by distance.</summary>
        /// <param name="distance">Distance.</param>
        abstract translateY: distance: float -> Object3D
        /// <summary>Translates object along z axis by distance.</summary>
        /// <param name="distance">Distance.</param>
        abstract translateZ: distance: float -> Object3D
        /// <summary>Updates the vector from local space to world space.</summary>
        /// <param name="vector">A local vector.</param>
        abstract localToWorld: vector: Vector3 -> Vector3
        /// <summary>Updates the vector from world space to local space.</summary>
        /// <param name="vector">A world vector.</param>
        abstract worldToLocal: vector: Vector3 -> Vector3
        /// <summary>Rotates object to face point in space.</summary>
        /// <param name="vector">A world vector to look at.</param>
        // abstract lookAt: vector: U2<Vector3, float> * ?y: float * ?z: float -> unit
        abstract lookAt: vector: Vector3 -> unit
        /// Adds object as child of this object.
        abstract add: [<ParamArray>] ``object``: ResizeArray<Object3D> -> Object3D
        /// Removes object as child of this object.
        abstract remove: [<ParamArray>] ``object``: ResizeArray<Object3D> -> Object3D
        /// Adds object as a child of this, while maintaining the object's world transform.
        abstract attach: ``object``: Object3D -> Object3D
        /// <summary>Searches through the object's children and returns the first with a matching id.</summary>
        /// <param name="id">Unique number of the object instance</param>
        abstract getObjectById: id: float -> Object3D option
        /// <summary>Searches through the object's children and returns the first with a matching name.</summary>
        /// <param name="name">String to match to the children's Object3d.name property.</param>
        abstract getObjectByName: name: string -> Object3D option
        abstract getObjectByProperty: name: string * value: string -> Object3D option
        abstract getWorldPosition: target: Vector3 -> Vector3
        abstract getWorldQuaternion: target: Quaternion -> Quaternion
        abstract getWorldScale: target: Vector3 -> Vector3
        abstract getWorldDirection: target: Vector3 -> Vector3
        abstract raycast: raycaster: Raycaster * intersects: ResizeArray<Intersection> -> unit
        abstract traverse: callback: (Object3D -> obj option) -> unit
        abstract traverseVisible: callback: (Object3D -> obj option) -> unit
        abstract traverseAncestors: callback: (Object3D -> obj option) -> unit
        /// Updates local transform.
        abstract updateMatrix: unit -> unit
        /// Updates global transform of the object and its children.
        abstract updateMatrixWorld: ?force: bool -> unit
        abstract updateWorldMatrix: updateParents: bool * updateChildren: bool -> unit
        abstract toJSON: ?meta: Object3DToJSONMeta -> obj option
        abstract clone: ?recursive: bool -> Object3D
        abstract copy: source: Object3D * ?recursive: bool -> Object3D

    type [<AllowNullLiteral>] Object3DToJSONMeta =
        abstract geometries: obj option with get, set
        abstract materials: obj option with get, set
        abstract textures: obj option with get, set
        abstract images: obj option with get, set

    /// Base class for scene graph objects
    type [<AllowNullLiteral>] Object3DStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Object3D
        abstract DefaultUp: Vector3 with get, set
        abstract DefaultMatrixAutoUpdate: bool with get, set

    type [<AllowNullLiteral>] Object3DUserData =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

module __core_Raycaster =
    type Vector3 = __math_Vector3.Vector3
    type Face3 = __core_Face3.Face3
    type Object3D = __core_Object3D.Object3D
    type Vector2 = __math_Vector2.Vector2
    type Ray = __math_Ray.Ray
    type Camera = __cameras_Camera.Camera

    type [<AllowNullLiteral>] IExports =
        abstract Raycaster: RaycasterStatic

    type [<AllowNullLiteral>] Intersection =
        abstract distance: float with get, set
        abstract distanceToRay: float option with get, set
        abstract point: Vector3 with get, set
        abstract index: float option with get, set
        abstract face: Face3 option with get, set
        abstract faceIndex: float option with get, set
        abstract ``object``: Object3D with get, set
        abstract uv: Vector2 option with get, set

    type [<AllowNullLiteral>] RaycasterParameters =
        abstract Mesh: obj option with get, set
        abstract Line: obj option with get, set
        abstract LOD: obj option with get, set
        abstract Points: RaycasterParametersPoints option with get, set
        abstract Sprite: obj option with get, set

    type [<AllowNullLiteral>] Raycaster =
        /// The Ray used for the raycasting.
        abstract ray: Ray with get, set
        /// The near factor of the raycaster. This value indicates which objects can be discarded based on the
        /// distance. This value shouldn't be negative and should be smaller than the far property.
        abstract near: float with get, set
        /// The far factor of the raycaster. This value indicates which objects can be discarded based on the
        /// distance. This value shouldn't be negative and should be larger than the near property.
        abstract far: float with get, set
        /// The camera to use when raycasting against view-dependent objects such as billboarded objects like Sprites. This field
        /// can be set manually or is set when calling "setFromCamera".
        abstract camera: Camera with get, set
        abstract ``params``: RaycasterParameters with get, set
        /// The precision factor of the raycaster when intersecting Line objects.
        abstract linePrecision: float with get, set
        /// <summary>Updates the ray with a new origin and direction.</summary>
        /// <param name="origin">The origin vector where the ray casts from.</param>
        /// <param name="direction">The normalized direction vector that gives direction to the ray.</param>
        abstract set: origin: Vector3 * direction: Vector3 -> unit
        /// <summary>Updates the ray with a new origin and direction.</summary>
        /// <param name="coords">2D coordinates of the mouse, in normalized device coordinates (NDC)---X and Y components should be between -1 and 1.</param>
        /// <param name="camera">camera from which the ray should originate</param>
        abstract setFromCamera: coords: RaycasterSetFromCameraCoords * camera: Camera -> unit
        /// <summary>Checks all intersection between the ray and the object with or without the descendants. Intersections are returned sorted by distance, closest first.</summary>
        /// <param name="object">The object to check for intersection with the ray.</param>
        /// <param name="recursive">If true, it also checks all descendants. Otherwise it only checks intersecton with the object. Default is false.</param>
        /// <param name="optionalTarget">(optional) target to set the result. Otherwise a new Array is instantiated. If set, you must clear this array prior to each call (i.e., array.length = 0;).</param>
        abstract intersectObject: ``object``: Object3D * ?recursive: bool * ?optionalTarget: ResizeArray<Intersection> -> ResizeArray<Intersection>
        /// <summary>Checks all intersection between the ray and the objects with or without the descendants. Intersections are returned sorted by distance, closest first. Intersections are of the same form as those returned by .intersectObject.</summary>
        /// <param name="objects">The objects to check for intersection with the ray.</param>
        /// <param name="recursive">If true, it also checks all descendants of the objects. Otherwise it only checks intersecton with the objects. Default is false.</param>
        /// <param name="optionalTarget">(optional) target to set the result. Otherwise a new Array is instantiated. If set, you must clear this array prior to each call (i.e., array.length = 0;).</param>
        abstract intersectObjects: objects: ResizeArray<Object3D> * ?recursive: bool * ?optionalTarget: ResizeArray<Intersection> -> ResizeArray<Intersection>

    type [<AllowNullLiteral>] RaycasterSetFromCameraCoords =
        abstract x: float with get, set
        abstract y: float with get, set

    type [<AllowNullLiteral>] RaycasterStatic =
        /// <summary>This creates a new raycaster object.</summary>
        /// <param name="origin">The origin vector where the ray casts from.</param>
        /// <param name="direction">The direction vector that gives direction to the ray. Should be normalized.</param>
        /// <param name="near">All results returned are further away than near. Near can't be negative. Default value is 0.</param>
        /// <param name="far">All results returned are closer then far. Far can't be lower then near . Default value is Infinity.</param>
        [<Emit "new $0($1...)">] abstract Create: ?origin: Vector3 * ?direction: Vector3 * ?near: float * ?far: float -> Raycaster

    type [<AllowNullLiteral>] RaycasterParametersPoints =
        abstract threshold: float with get, set

module __core_Uniform =

    type [<AllowNullLiteral>] IExports =
        abstract Uniform: UniformStatic

    type [<AllowNullLiteral>] Uniform =
        abstract ``type``: string with get, set
        abstract value: obj option with get, set
        abstract dynamic: bool with get, set
        abstract onUpdateCallback: Function with get, set
        abstract onUpdate: callback: Function -> Uniform

    type [<AllowNullLiteral>] UniformStatic =
        [<Emit "new $0($1...)">] abstract Create: value: obj option -> Uniform
        [<Emit "new $0($1...)">] abstract Create: ``type``: string * value: obj option -> Uniform

module __extras_ImageUtils =
    type Mapping = Constants.Mapping
    type Texture = __textures_Texture.Texture
    let [<Import("ImageUtils","three/extras/ImageUtils")>] imageUtils: ImageUtils.IExports = jsNative

    module ImageUtils =

        type [<AllowNullLiteral>] IExports =
            abstract getDataURL: image: obj option -> string
            abstract crossOrigin: string
            abstract loadTexture: url: string * ?mapping: Mapping * ?onLoad: (Texture -> unit) * ?onError: (string -> unit) -> Texture
            abstract loadTextureCube: array: ResizeArray<string> * ?mapping: Mapping * ?onLoad: (Texture -> unit) * ?onError: (string -> unit) -> Texture

module __extras_PMREMGenerator =
    type WebGLRenderer = __renderers_WebGLRenderer.WebGLRenderer
    type WebGLRenderTarget = __renderers_WebGLRenderTarget.WebGLRenderTarget
    type Texture = __textures_Texture.Texture
    type CubeTexture = __textures_CubeTexture.CubeTexture
    type Scene = __scenes_Scene.Scene

    type [<AllowNullLiteral>] IExports =
        abstract PMREMGenerator: PMREMGeneratorStatic

    type [<AllowNullLiteral>] PMREMGenerator =
        abstract fromScene: scene: Scene * ?sigma: float * ?near: float * ?far: float -> WebGLRenderTarget
        abstract fromEquirectangular: equirectangular: Texture -> WebGLRenderTarget
        abstract fromCubemap: cubemap: CubeTexture -> WebGLRenderTarget
        abstract compileCubemapShader: unit -> unit
        abstract compileEquirectangularShader: unit -> unit
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] PMREMGeneratorStatic =
        [<Emit "new $0($1...)">] abstract Create: renderer: WebGLRenderer -> PMREMGenerator

module __extras_ShapeUtils =
    let [<Import("ShapeUtils","three/extras/ShapeUtils")>] shapeUtils: ShapeUtils.IExports = jsNative

    type [<AllowNullLiteral>] Vec2 =
        abstract x: float with get, set
        abstract y: float with get, set

    module ShapeUtils =

        type [<AllowNullLiteral>] IExports =
            abstract area: contour: ResizeArray<Vec2> -> float
            abstract triangulateShape: contour: ResizeArray<Vec2> * holes: ResizeArray<ResizeArray<Vec2>> -> ResizeArray<ResizeArray<float>>
            abstract isClockWise: pts: ResizeArray<Vec2> -> bool

module __geometries_BoxGeometry =
    type Geometry = __core_Geometry.Geometry
    type BufferGeometry = __core_BufferGeometry.BufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract BoxBufferGeometry: BoxBufferGeometryStatic
        abstract BoxGeometry: BoxGeometryStatic

    type [<AllowNullLiteral>] BoxBufferGeometry =
        inherit BufferGeometry
        abstract parameters: BoxBufferGeometryParameters with get, set

    type [<AllowNullLiteral>] BoxBufferGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?width: float * ?height: float * ?depth: float * ?widthSegments: float * ?heightSegments: float * ?depthSegments: float -> BoxBufferGeometry

    /// BoxGeometry is the quadrilateral primitive geometry class. It is typically used for creating a cube or irregular quadrilateral of the dimensions provided within the (optional) 'width', 'height', & 'depth' constructor arguments.
    type [<AllowNullLiteral>] BoxGeometry =
        inherit Geometry
        abstract parameters: BoxBufferGeometryParameters with get, set

    /// BoxGeometry is the quadrilateral primitive geometry class. It is typically used for creating a cube or irregular quadrilateral of the dimensions provided within the (optional) 'width', 'height', & 'depth' constructor arguments.
    type [<AllowNullLiteral>] BoxGeometryStatic =
        /// <param name="width">— Width of the sides on the X axis.</param>
        /// <param name="height">— Height of the sides on the Y axis.</param>
        /// <param name="depth">— Depth of the sides on the Z axis.</param>
        /// <param name="widthSegments">— Number of segmented faces along the width of the sides.</param>
        /// <param name="heightSegments">— Number of segmented faces along the height of the sides.</param>
        /// <param name="depthSegments">— Number of segmented faces along the depth of the sides.</param>
        [<Emit "new $0($1...)">] abstract Create: ?width: float * ?height: float * ?depth: float * ?widthSegments: float * ?heightSegments: float * ?depthSegments: float -> BoxGeometry

    type [<AllowNullLiteral>] BoxBufferGeometryParameters =
        abstract width: float with get, set
        abstract height: float with get, set
        abstract depth: float with get, set
        abstract widthSegments: float with get, set
        abstract heightSegments: float with get, set
        abstract depthSegments: float with get, set

module __geometries_CircleGeometry =
    type Geometry = __core_Geometry.Geometry
    type BufferGeometry = __core_BufferGeometry.BufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract CircleBufferGeometry: CircleBufferGeometryStatic
        abstract CircleGeometry: CircleGeometryStatic

    type [<AllowNullLiteral>] CircleBufferGeometry =
        inherit BufferGeometry
        abstract parameters: CircleBufferGeometryParameters with get, set

    type [<AllowNullLiteral>] CircleBufferGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?segments: float * ?thetaStart: float * ?thetaLength: float -> CircleBufferGeometry

    type [<AllowNullLiteral>] CircleGeometry =
        inherit Geometry
        abstract parameters: CircleBufferGeometryParameters with get, set

    type [<AllowNullLiteral>] CircleGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?segments: float * ?thetaStart: float * ?thetaLength: float -> CircleGeometry

    type [<AllowNullLiteral>] CircleBufferGeometryParameters =
        abstract radius: float with get, set
        abstract segments: float with get, set
        abstract thetaStart: float with get, set
        abstract thetaLength: float with get, set

module __geometries_ConeGeometry =
    type CylinderGeometry = __geometries_CylinderGeometry.CylinderGeometry
    type CylinderBufferGeometry = __geometries_CylinderGeometry.CylinderBufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract ConeBufferGeometry: ConeBufferGeometryStatic
        abstract ConeGeometry: ConeGeometryStatic

    type [<AllowNullLiteral>] ConeBufferGeometry =
        inherit CylinderBufferGeometry

    type [<AllowNullLiteral>] ConeBufferGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?height: float * ?radialSegment: float * ?heightSegment: float * ?openEnded: bool * ?thetaStart: float * ?thetaLength: float -> ConeBufferGeometry

    type [<AllowNullLiteral>] ConeGeometry =
        inherit CylinderGeometry

    type [<AllowNullLiteral>] ConeGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?height: float * ?radialSegment: float * ?heightSegment: float * ?openEnded: bool * ?thetaStart: float * ?thetaLength: float -> ConeGeometry

module __geometries_CylinderGeometry =
    type Geometry = __core_Geometry.Geometry
    type BufferGeometry = __core_BufferGeometry.BufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract CylinderBufferGeometry: CylinderBufferGeometryStatic
        abstract CylinderGeometry: CylinderGeometryStatic

    type [<AllowNullLiteral>] CylinderBufferGeometry =
        inherit BufferGeometry
        abstract parameters: CylinderBufferGeometryParameters with get, set

    type [<AllowNullLiteral>] CylinderBufferGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?radiusTop: float * ?radiusBottom: float * ?height: float * ?radialSegments: float * ?heightSegments: float * ?openEnded: bool * ?thetaStart: float * ?thetaLength: float -> CylinderBufferGeometry

    type [<AllowNullLiteral>] CylinderGeometry =
        inherit Geometry
        abstract parameters: CylinderBufferGeometryParameters with get, set

    type [<AllowNullLiteral>] CylinderGeometryStatic =
        /// <param name="radiusTop">— Radius of the cylinder at the top.</param>
        /// <param name="radiusBottom">— Radius of the cylinder at the bottom.</param>
        /// <param name="height">— Height of the cylinder.</param>
        /// <param name="radiusSegments">— Number of segmented faces around the circumference of the cylinder.</param>
        /// <param name="heightSegments">— Number of rows of faces along the height of the cylinder.</param>
        /// <param name="openEnded">- A Boolean indicating whether or not to cap the ends of the cylinder.</param>
        [<Emit "new $0($1...)">] abstract Create: ?radiusTop: float * ?radiusBottom: float * ?height: float * ?radiusSegments: float * ?heightSegments: float * ?openEnded: bool * ?thetaStart: float * ?thetaLength: float -> CylinderGeometry

    type [<AllowNullLiteral>] CylinderBufferGeometryParameters =
        abstract radiusTop: float with get, set
        abstract radiusBottom: float with get, set
        abstract height: float with get, set
        abstract radialSegments: float with get, set
        abstract heightSegments: float with get, set
        abstract openEnded: bool with get, set
        abstract thetaStart: float with get, set
        abstract thetaLength: float with get, set

module __geometries_DodecahedronGeometry =
    type Geometry = __core_Geometry.Geometry
    type PolyhedronBufferGeometry = __geometries_PolyhedronGeometry.PolyhedronBufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract DodecahedronBufferGeometry: DodecahedronBufferGeometryStatic
        abstract DodecahedronGeometry: DodecahedronGeometryStatic

    type [<AllowNullLiteral>] DodecahedronBufferGeometry =
        inherit PolyhedronBufferGeometry

    type [<AllowNullLiteral>] DodecahedronBufferGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?detail: float -> DodecahedronBufferGeometry

    type [<AllowNullLiteral>] DodecahedronGeometry =
        inherit Geometry
        abstract parameters: DodecahedronGeometryParameters with get, set

    type [<AllowNullLiteral>] DodecahedronGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?detail: float -> DodecahedronGeometry

    type [<AllowNullLiteral>] DodecahedronGeometryParameters =
        abstract radius: float with get, set
        abstract detail: float with get, set

module __geometries_EdgesGeometry =
    type BufferGeometry = __core_BufferGeometry.BufferGeometry
    type Geometry = __core_Geometry.Geometry

    type [<AllowNullLiteral>] IExports =
        abstract EdgesGeometry: EdgesGeometryStatic

    type [<AllowNullLiteral>] EdgesGeometry =
        inherit BufferGeometry

    type [<AllowNullLiteral>] EdgesGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: geometry: U2<BufferGeometry, Geometry> * ?thresholdAngle: float -> EdgesGeometry

module __geometries_ExtrudeGeometry =
    type Curve<'a> = __extras_core_Curve.Curve<'a>
    type Vector2 = __math_Vector2.Vector2
    type Vector3 = __math_Vector3.Vector3
    type Shape = __extras_core_Shape.Shape
    type Geometry = __core_Geometry.Geometry
    type BufferGeometry = __core_BufferGeometry.BufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract ExtrudeBufferGeometry: ExtrudeBufferGeometryStatic
        abstract ExtrudeGeometry: ExtrudeGeometryStatic

    type [<AllowNullLiteral>] ExtrudeGeometryOptions =
        abstract curveSegments: float option with get, set
        abstract steps: float option with get, set
        abstract depth: float option with get, set
        abstract bevelEnabled: bool option with get, set
        abstract bevelThickness: float option with get, set
        abstract bevelSize: float option with get, set
        abstract bevelOffset: float option with get, set
        abstract bevelSegments: float option with get, set
        abstract extrudePath: Curve<Vector3> option with get, set
        abstract UVGenerator: UVGenerator option with get, set

    type [<AllowNullLiteral>] UVGenerator =
        abstract generateTopUV: geometry: ExtrudeBufferGeometry * vertices: ResizeArray<float> * indexA: float * indexB: float * indexC: float -> ResizeArray<Vector2>
        abstract generateSideWallUV: geometry: ExtrudeBufferGeometry * vertices: ResizeArray<float> * indexA: float * indexB: float * indexC: float * indexD: float -> ResizeArray<Vector2>

    type [<AllowNullLiteral>] ExtrudeBufferGeometry =
        inherit BufferGeometry
        abstract addShapeList: shapes: ResizeArray<Shape> * ?options: obj -> unit
        abstract addShape: shape: Shape * ?options: obj -> unit

    type [<AllowNullLiteral>] ExtrudeBufferGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: shapes: U2<Shape, ResizeArray<Shape>> * ?options: ExtrudeGeometryOptions -> ExtrudeBufferGeometry
        abstract WorldUVGenerator: UVGenerator with get, set

    type [<AllowNullLiteral>] ExtrudeGeometry =
        inherit Geometry
        abstract addShapeList: shapes: ResizeArray<Shape> * ?options: obj -> unit
        abstract addShape: shape: Shape * ?options: obj -> unit

    type [<AllowNullLiteral>] ExtrudeGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: shapes: U2<Shape, ResizeArray<Shape>> * ?options: ExtrudeGeometryOptions -> ExtrudeGeometry
        abstract WorldUVGenerator: UVGenerator with get, set

module __geometries_IcosahedronGeometry =
    type PolyhedronGeometry = __geometries_PolyhedronGeometry.PolyhedronGeometry
    type PolyhedronBufferGeometry = __geometries_PolyhedronGeometry.PolyhedronBufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract IcosahedronBufferGeometry: IcosahedronBufferGeometryStatic
        abstract IcosahedronGeometry: IcosahedronGeometryStatic

    type [<AllowNullLiteral>] IcosahedronBufferGeometry =
        inherit PolyhedronBufferGeometry

    type [<AllowNullLiteral>] IcosahedronBufferGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?detail: float -> IcosahedronBufferGeometry

    type [<AllowNullLiteral>] IcosahedronGeometry =
        inherit PolyhedronGeometry

    type [<AllowNullLiteral>] IcosahedronGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?detail: float -> IcosahedronGeometry

module __geometries_LatheGeometry =
    type Vector2 = __math_Vector2.Vector2
    type Geometry = __core_Geometry.Geometry
    type BufferGeometry = __core_BufferGeometry.BufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract LatheBufferGeometry: LatheBufferGeometryStatic
        abstract LatheGeometry: LatheGeometryStatic

    type [<AllowNullLiteral>] LatheBufferGeometry =
        inherit BufferGeometry
        abstract parameters: LatheBufferGeometryParameters with get, set

    type [<AllowNullLiteral>] LatheBufferGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: points: ResizeArray<Vector2> * ?segments: float * ?phiStart: float * ?phiLength: float -> LatheBufferGeometry

    type [<AllowNullLiteral>] LatheGeometry =
        inherit Geometry
        abstract parameters: LatheBufferGeometryParameters with get, set

    type [<AllowNullLiteral>] LatheGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: points: ResizeArray<Vector2> * ?segments: float * ?phiStart: float * ?phiLength: float -> LatheGeometry

    type [<AllowNullLiteral>] LatheBufferGeometryParameters =
        abstract points: ResizeArray<Vector2> with get, set
        abstract segments: float with get, set
        abstract phiStart: float with get, set
        abstract phiLength: float with get, set

module __geometries_OctahedronGeometry =
    type PolyhedronGeometry = __geometries_PolyhedronGeometry.PolyhedronGeometry
    type PolyhedronBufferGeometry = __geometries_PolyhedronGeometry.PolyhedronBufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract OctahedronBufferGeometry: OctahedronBufferGeometryStatic
        abstract OctahedronGeometry: OctahedronGeometryStatic

    type [<AllowNullLiteral>] OctahedronBufferGeometry =
        inherit PolyhedronBufferGeometry

    type [<AllowNullLiteral>] OctahedronBufferGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?detail: float -> OctahedronBufferGeometry

    type [<AllowNullLiteral>] OctahedronGeometry =
        inherit PolyhedronGeometry

    type [<AllowNullLiteral>] OctahedronGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?detail: float -> OctahedronGeometry

module __geometries_ParametricGeometry =
    type Vector3 = __math_Vector3.Vector3
    type Geometry = __core_Geometry.Geometry
    type BufferGeometry = __core_BufferGeometry.BufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract ParametricBufferGeometry: ParametricBufferGeometryStatic
        abstract ParametricGeometry: ParametricGeometryStatic

    type [<AllowNullLiteral>] ParametricBufferGeometry =
        inherit BufferGeometry
        abstract parameters: ParametricBufferGeometryParameters with get, set

    type [<AllowNullLiteral>] ParametricBufferGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: func: (float -> float -> Vector3 -> unit) * slices: float * stacks: float -> ParametricBufferGeometry

    type [<AllowNullLiteral>] ParametricGeometry =
        inherit Geometry
        abstract parameters: ParametricBufferGeometryParameters with get, set

    type [<AllowNullLiteral>] ParametricGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: func: (float -> float -> Vector3 -> unit) * slices: float * stacks: float -> ParametricGeometry

    type [<AllowNullLiteral>] ParametricBufferGeometryParameters =
        abstract func: (float -> float -> Vector3 -> unit) with get, set
        abstract slices: float with get, set
        abstract stacks: float with get, set

module __geometries_PlaneGeometry =
    type Geometry = __core_Geometry.Geometry
    type BufferGeometry = __core_BufferGeometry.BufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract PlaneBufferGeometry: PlaneBufferGeometryStatic
        abstract PlaneGeometry: PlaneGeometryStatic

    type [<AllowNullLiteral>] PlaneBufferGeometry =
        inherit BufferGeometry
        abstract parameters: PlaneBufferGeometryParameters with get, set

    type [<AllowNullLiteral>] PlaneBufferGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?width: float * ?height: float * ?widthSegments: float * ?heightSegments: float -> PlaneBufferGeometry

    type [<AllowNullLiteral>] PlaneGeometry =
        inherit Geometry
        abstract parameters: PlaneBufferGeometryParameters with get, set

    type [<AllowNullLiteral>] PlaneGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?width: float * ?height: float * ?widthSegments: float * ?heightSegments: float -> PlaneGeometry

    type [<AllowNullLiteral>] PlaneBufferGeometryParameters =
        abstract width: float with get, set
        abstract height: float with get, set
        abstract widthSegments: float with get, set
        abstract heightSegments: float with get, set

module __geometries_PolyhedronGeometry =
    type Sphere = __math_Sphere.Sphere
    type Geometry = __core_Geometry.Geometry
    type BufferGeometry = __core_BufferGeometry.BufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract PolyhedronBufferGeometry: PolyhedronBufferGeometryStatic
        abstract PolyhedronGeometry: PolyhedronGeometryStatic

    type [<AllowNullLiteral>] PolyhedronBufferGeometry =
        inherit BufferGeometry
        abstract parameters: PolyhedronBufferGeometryParameters with get, set

    type [<AllowNullLiteral>] PolyhedronBufferGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: vertices: ResizeArray<float> * indices: ResizeArray<float> * ?radius: float * ?detail: float -> PolyhedronBufferGeometry

    type [<AllowNullLiteral>] PolyhedronGeometry =
        inherit Geometry
        abstract parameters: PolyhedronBufferGeometryParameters with get, set
        abstract boundingSphere: Sphere with get, set

    type [<AllowNullLiteral>] PolyhedronGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: vertices: ResizeArray<float> * indices: ResizeArray<float> * ?radius: float * ?detail: float -> PolyhedronGeometry

    type [<AllowNullLiteral>] PolyhedronBufferGeometryParameters =
        abstract vertices: ResizeArray<float> with get, set
        abstract indices: ResizeArray<float> with get, set
        abstract radius: float with get, set
        abstract detail: float with get, set

module __geometries_RingGeometry =
    type Geometry = __core_Geometry.Geometry
    type BufferGeometry = __core_BufferGeometry.BufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract RingBufferGeometry: RingBufferGeometryStatic
        abstract RingGeometry: RingGeometryStatic

    type [<AllowNullLiteral>] RingBufferGeometry =
        inherit BufferGeometry
        abstract parameters: RingBufferGeometryParameters with get, set

    type [<AllowNullLiteral>] RingBufferGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?innerRadius: float * ?outerRadius: float * ?thetaSegments: float * ?phiSegments: float * ?thetaStart: float * ?thetaLength: float -> RingBufferGeometry

    type [<AllowNullLiteral>] RingGeometry =
        inherit Geometry
        abstract parameters: RingBufferGeometryParameters with get, set

    type [<AllowNullLiteral>] RingGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?innerRadius: float * ?outerRadius: float * ?thetaSegments: float * ?phiSegments: float * ?thetaStart: float * ?thetaLength: float -> RingGeometry

    type [<AllowNullLiteral>] RingBufferGeometryParameters =
        abstract innerRadius: float with get, set
        abstract outerRadius: float with get, set
        abstract thetaSegments: float with get, set
        abstract phiSegments: float with get, set
        abstract thetaStart: float with get, set
        abstract thetaLength: float with get, set

module __geometries_ShapeGeometry =
    type Shape = __extras_core_Shape.Shape
    type Geometry = __core_Geometry.Geometry
    type BufferGeometry = __core_BufferGeometry.BufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract ShapeBufferGeometry: ShapeBufferGeometryStatic
        abstract ShapeGeometry: ShapeGeometryStatic

    type [<AllowNullLiteral>] ShapeBufferGeometry =
        inherit BufferGeometry

    type [<AllowNullLiteral>] ShapeBufferGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: shapes: U2<Shape, ResizeArray<Shape>> * ?curveSegments: float -> ShapeBufferGeometry

    type [<AllowNullLiteral>] ShapeGeometry =
        inherit Geometry
        abstract addShapeList: shapes: ResizeArray<Shape> * options: obj option -> ShapeGeometry
        abstract addShape: shape: Shape * ?options: obj -> unit

    type [<AllowNullLiteral>] ShapeGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: shapes: U2<Shape, ResizeArray<Shape>> * ?curveSegments: float -> ShapeGeometry

module __geometries_SphereGeometry =
    type Geometry = __core_Geometry.Geometry
    type BufferGeometry = __core_BufferGeometry.BufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract SphereBufferGeometry: SphereBufferGeometryStatic
        abstract SphereGeometry: SphereGeometryStatic

    type [<AllowNullLiteral>] SphereBufferGeometry =
        inherit BufferGeometry
        abstract parameters: SphereBufferGeometryParameters with get, set

    type [<AllowNullLiteral>] SphereBufferGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?widthSegments: float * ?heightSegments: float * ?phiStart: float * ?phiLength: float * ?thetaStart: float * ?thetaLength: float -> SphereBufferGeometry

    /// A class for generating sphere geometries
    type [<AllowNullLiteral>] SphereGeometry =
        inherit Geometry
        abstract parameters: SphereBufferGeometryParameters with get, set

    /// A class for generating sphere geometries
    type [<AllowNullLiteral>] SphereGeometryStatic =
        /// <summary>The geometry is created by sweeping and calculating vertexes around the Y axis (horizontal sweep) and the Z axis (vertical sweep). Thus, incomplete spheres (akin to 'sphere slices') can be created through the use of different values of phiStart, phiLength, thetaStart and thetaLength, in order to define the points in which we start (or end) calculating those vertices.</summary>
        /// <param name="radius">— sphere radius. Default is 50.</param>
        /// <param name="widthSegments">— number of horizontal segments. Minimum value is 3, and the default is 8.</param>
        /// <param name="heightSegments">— number of vertical segments. Minimum value is 2, and the default is 6.</param>
        /// <param name="phiStart">— specify horizontal starting angle. Default is 0.</param>
        /// <param name="phiLength">— specify horizontal sweep angle size. Default is Math.PI * 2.</param>
        /// <param name="thetaStart">— specify vertical starting angle. Default is 0.</param>
        /// <param name="thetaLength">— specify vertical sweep angle size. Default is Math.PI.</param>
        [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?widthSegments: float * ?heightSegments: float * ?phiStart: float * ?phiLength: float * ?thetaStart: float * ?thetaLength: float -> SphereGeometry

    type [<AllowNullLiteral>] SphereBufferGeometryParameters =
        abstract radius: float with get, set
        abstract widthSegments: float with get, set
        abstract heightSegments: float with get, set
        abstract phiStart: float with get, set
        abstract phiLength: float with get, set
        abstract thetaStart: float with get, set
        abstract thetaLength: float with get, set

module __geometries_TetrahedronGeometry =
    type PolyhedronGeometry = __geometries_PolyhedronGeometry.PolyhedronGeometry
    type PolyhedronBufferGeometry = __geometries_PolyhedronGeometry.PolyhedronBufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract TetrahedronBufferGeometry: TetrahedronBufferGeometryStatic
        abstract TetrahedronGeometry: TetrahedronGeometryStatic

    type [<AllowNullLiteral>] TetrahedronBufferGeometry =
        inherit PolyhedronBufferGeometry

    type [<AllowNullLiteral>] TetrahedronBufferGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?detail: float -> TetrahedronBufferGeometry

    type [<AllowNullLiteral>] TetrahedronGeometry =
        inherit PolyhedronGeometry

    type [<AllowNullLiteral>] TetrahedronGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?detail: float -> TetrahedronGeometry

module __geometries_TextGeometry =
    type Font = __extras_core_Font.Font
    type ExtrudeGeometry = __geometries_ExtrudeGeometry.ExtrudeGeometry
    type ExtrudeBufferGeometry = __geometries_ExtrudeGeometry.ExtrudeBufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract TextBufferGeometry: TextBufferGeometryStatic
        abstract TextGeometry: TextGeometryStatic

    type [<AllowNullLiteral>] TextGeometryParameters =
        abstract font: Font option with get, set
        abstract size: float option with get, set
        abstract height: float option with get, set
        abstract curveSegments: float option with get, set
        abstract bevelEnabled: bool option with get, set
        abstract bevelThickness: float option with get, set
        abstract bevelSize: float option with get, set
        abstract bevelOffset: float option with get, set
        abstract bevelSegments: float option with get, set

    type [<AllowNullLiteral>] TextBufferGeometry =
        inherit ExtrudeBufferGeometry
        abstract parameters: TextBufferGeometryParameters with get, set

    type [<AllowNullLiteral>] TextBufferGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: text: string * ?parameters: TextGeometryParameters -> TextBufferGeometry

    type [<AllowNullLiteral>] TextGeometry =
        inherit ExtrudeGeometry
        abstract parameters: TextBufferGeometryParameters with get, set

    type [<AllowNullLiteral>] TextGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: text: string * ?parameters: TextGeometryParameters -> TextGeometry

    type [<AllowNullLiteral>] TextBufferGeometryParameters =
        abstract font: Font with get, set
        abstract size: float with get, set
        abstract height: float with get, set
        abstract curveSegments: float with get, set
        abstract bevelEnabled: bool with get, set
        abstract bevelThickness: float with get, set
        abstract bevelSize: float with get, set
        abstract bevelOffset: float with get, set
        abstract bevelSegments: float with get, set

module __geometries_TorusGeometry =
    type Geometry = __core_Geometry.Geometry
    type BufferGeometry = __core_BufferGeometry.BufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract TorusBufferGeometry: TorusBufferGeometryStatic
        abstract TorusGeometry: TorusGeometryStatic

    type [<AllowNullLiteral>] TorusBufferGeometry =
        inherit BufferGeometry
        abstract parameters: TorusBufferGeometryParameters with get, set

    type [<AllowNullLiteral>] TorusBufferGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?tube: float * ?radialSegments: float * ?tubularSegments: float * ?arc: float -> TorusBufferGeometry

    type [<AllowNullLiteral>] TorusGeometry =
        inherit Geometry
        abstract parameters: TorusBufferGeometryParameters with get, set

    type [<AllowNullLiteral>] TorusGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?tube: float * ?radialSegments: float * ?tubularSegments: float * ?arc: float -> TorusGeometry

    type [<AllowNullLiteral>] TorusBufferGeometryParameters =
        abstract radius: float with get, set
        abstract tube: float with get, set
        abstract radialSegments: float with get, set
        abstract tubularSegments: float with get, set
        abstract arc: float with get, set

module __geometries_TorusKnotGeometry =
    type Geometry = __core_Geometry.Geometry
    type BufferGeometry = __core_BufferGeometry.BufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract TorusKnotBufferGeometry: TorusKnotBufferGeometryStatic
        abstract TorusKnotGeometry: TorusKnotGeometryStatic

    type [<AllowNullLiteral>] TorusKnotBufferGeometry =
        inherit BufferGeometry
        abstract parameters: TorusKnotBufferGeometryParameters with get, set

    type [<AllowNullLiteral>] TorusKnotBufferGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?tube: float * ?tubularSegments: float * ?radialSegments: float * ?p: float * ?q: float -> TorusKnotBufferGeometry

    type [<AllowNullLiteral>] TorusKnotGeometry =
        inherit Geometry
        abstract parameters: TorusKnotBufferGeometryParameters with get, set

    type [<AllowNullLiteral>] TorusKnotGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?tube: float * ?tubularSegments: float * ?radialSegments: float * ?p: float * ?q: float -> TorusKnotGeometry

    type [<AllowNullLiteral>] TorusKnotBufferGeometryParameters =
        abstract radius: float with get, set
        abstract tube: float with get, set
        abstract tubularSegments: float with get, set
        abstract radialSegments: float with get, set
        abstract p: float with get, set
        abstract q: float with get, set
        abstract heightScale: float with get, set

module __geometries_TubeGeometry =
    type Curve<'a> = __extras_core_Curve.Curve<'a>
    type Vector3 = __math_Vector3.Vector3
    type Geometry = __core_Geometry.Geometry
    type BufferGeometry = __core_BufferGeometry.BufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract TubeBufferGeometry: TubeBufferGeometryStatic
        abstract TubeGeometry: TubeGeometryStatic

    type [<AllowNullLiteral>] TubeBufferGeometry =
        inherit BufferGeometry
        abstract parameters: TubeBufferGeometryParameters with get, set
        abstract tangents: ResizeArray<Vector3> with get, set
        abstract normals: ResizeArray<Vector3> with get, set
        abstract binormals: ResizeArray<Vector3> with get, set

    type [<AllowNullLiteral>] TubeBufferGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: path: Curve<Vector3> * ?tubularSegments: float * ?radius: float * ?radiusSegments: float * ?closed: bool -> TubeBufferGeometry

    type [<AllowNullLiteral>] TubeGeometry =
        inherit Geometry
        abstract parameters: TubeBufferGeometryParameters with get, set
        abstract tangents: ResizeArray<Vector3> with get, set
        abstract normals: ResizeArray<Vector3> with get, set
        abstract binormals: ResizeArray<Vector3> with get, set

    type [<AllowNullLiteral>] TubeGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: path: Curve<Vector3> * ?tubularSegments: float * ?radius: float * ?radiusSegments: float * ?closed: bool -> TubeGeometry

    type [<AllowNullLiteral>] TubeBufferGeometryParameters =
        abstract path: Curve<Vector3> with get, set
        abstract tubularSegments: float with get, set
        abstract radius: float with get, set
        abstract radialSegments: float with get, set
        abstract closed: bool with get, set

module __geometries_WireframeGeometry =
    type Geometry = __core_Geometry.Geometry
    type BufferGeometry = __core_BufferGeometry.BufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract WireframeGeometry: WireframeGeometryStatic

    type [<AllowNullLiteral>] WireframeGeometry =
        inherit BufferGeometry

    type [<AllowNullLiteral>] WireframeGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: geometry: U2<Geometry, BufferGeometry> -> WireframeGeometry

module __helpers_ArrowHelper =
    type Vector3 = __math_Vector3.Vector3
    type Line = __objects_Line.Line
    type Mesh = __objects_Mesh.Mesh
    type Color = __math_Color.Color
    type Object3D = __core_Object3D.Object3D

    type [<AllowNullLiteral>] IExports =
        abstract ArrowHelper: ArrowHelperStatic

    type [<AllowNullLiteral>] ArrowHelper =
        inherit Object3D
        abstract line: Line with get, set
        abstract cone: Mesh with get, set
        abstract setDirection: dir: Vector3 -> unit
        abstract setLength: length: float * ?headLength: float * ?headWidth: float -> unit
        abstract setColor: color: U3<Color, string, float> -> unit

    type [<AllowNullLiteral>] ArrowHelperStatic =
        [<Emit "new $0($1...)">] abstract Create: dir: Vector3 * ?origin: Vector3 * ?length: float * ?hex: float * ?headLength: float * ?headWidth: float -> ArrowHelper

module __helpers_AxesHelper =
    type LineSegments = __objects_LineSegments.LineSegments

    type [<AllowNullLiteral>] IExports =
        abstract AxesHelper: AxesHelperStatic

    type [<AllowNullLiteral>] AxesHelper =
        inherit LineSegments

    type [<AllowNullLiteral>] AxesHelperStatic =
        [<Emit "new $0($1...)">] abstract Create: ?size: float -> AxesHelper

module __helpers_Box3Helper =
    type Box3 = __math_Box3.Box3
    type Color = __math_Color.Color
    type LineSegments = __objects_LineSegments.LineSegments

    type [<AllowNullLiteral>] IExports =
        abstract Box3Helper: Box3HelperStatic

    type [<AllowNullLiteral>] Box3Helper =
        inherit LineSegments
        abstract box: Box3 with get, set

    type [<AllowNullLiteral>] Box3HelperStatic =
        [<Emit "new $0($1...)">] abstract Create: box: Box3 * ?color: Color -> Box3Helper

module __helpers_BoxHelper =
    type Object3D = __core_Object3D.Object3D
    type Color = __math_Color.Color
    type LineSegments = __objects_LineSegments.LineSegments

    type [<AllowNullLiteral>] IExports =
        abstract BoxHelper: BoxHelperStatic

    type [<AllowNullLiteral>] BoxHelper =
        inherit LineSegments
        abstract update: ?``object``: Object3D -> unit
        abstract setFromObject: ``object``: Object3D -> BoxHelper

    type [<AllowNullLiteral>] BoxHelperStatic =
        [<Emit "new $0($1...)">] abstract Create: ``object``: Object3D * ?color: Color -> BoxHelper

module __helpers_CameraHelper =
    type Camera = __cameras_Camera.Camera
    type LineSegments = __objects_LineSegments.LineSegments

    type [<AllowNullLiteral>] IExports =
        abstract CameraHelper: CameraHelperStatic

    type [<AllowNullLiteral>] CameraHelper =
        inherit LineSegments
        abstract camera: Camera with get, set
        abstract pointMap: CameraHelperPointMap with get, set
        abstract update: unit -> unit

    type [<AllowNullLiteral>] CameraHelperStatic =
        [<Emit "new $0($1...)">] abstract Create: camera: Camera -> CameraHelper

    type [<AllowNullLiteral>] CameraHelperPointMap =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: id: string -> ResizeArray<float> with get, set

module __helpers_DirectionalLightHelper =
    type DirectionalLight = __lights_DirectionalLight.DirectionalLight
    type Color = __math_Color.Color
    type Line = __objects_Line.Line
    type Matrix4 = __math_Matrix4.Matrix4
    type Object3D = __core_Object3D.Object3D

    type [<AllowNullLiteral>] IExports =
        abstract DirectionalLightHelper: DirectionalLightHelperStatic

    type [<AllowNullLiteral>] DirectionalLightHelper =
        inherit Object3D
        abstract light: DirectionalLight with get, set
        abstract lightPlane: Line with get, set
        abstract targetLine: Line with get, set
        abstract color: U3<Color, string, float> option with get, set
        abstract matrix: Matrix4 with get, set
        abstract matrixAutoUpdate: bool with get, set
        abstract dispose: unit -> unit
        abstract update: unit -> unit

    type [<AllowNullLiteral>] DirectionalLightHelperStatic =
        [<Emit "new $0($1...)">] abstract Create: light: DirectionalLight * ?size: float * ?color: U3<Color, string, float> -> DirectionalLightHelper

module __helpers_GridHelper =
    type Color = __math_Color.Color
    type LineSegments = __objects_LineSegments.LineSegments

    type [<AllowNullLiteral>] IExports =
        abstract GridHelper: GridHelperStatic

    type [<AllowNullLiteral>] GridHelper =
        inherit LineSegments
        abstract setColors: ?color1: U2<Color, float> * ?color2: U2<Color, float> -> unit

    type [<AllowNullLiteral>] GridHelperStatic =
        [<Emit "new $0($1...)">] abstract Create: size: float * divisions: float * ?color1: U2<Color, float> * ?color2: U2<Color, float> -> GridHelper

module __helpers_HemisphereLightHelper =
    type HemisphereLight = __lights_HemisphereLight.HemisphereLight
    type Color = __math_Color.Color
    type Matrix4 = __math_Matrix4.Matrix4
    type MeshBasicMaterial = __materials_MeshBasicMaterial.MeshBasicMaterial
    type Object3D = __core_Object3D.Object3D

    type [<AllowNullLiteral>] IExports =
        abstract HemisphereLightHelper: HemisphereLightHelperStatic

    type [<AllowNullLiteral>] HemisphereLightHelper =
        inherit Object3D
        abstract light: HemisphereLight with get, set
        abstract matrix: Matrix4 with get, set
        abstract matrixAutoUpdate: bool with get, set
        abstract material: MeshBasicMaterial with get, set
        abstract color: U3<Color, string, float> option with get, set
        abstract dispose: unit -> unit
        abstract update: unit -> unit

    type [<AllowNullLiteral>] HemisphereLightHelperStatic =
        [<Emit "new $0($1...)">] abstract Create: light: HemisphereLight * size: float * ?color: U3<Color, float, string> -> HemisphereLightHelper

module __helpers_PlaneHelper =
    type Plane = __math_Plane.Plane
    type LineSegments = __objects_LineSegments.LineSegments

    type [<AllowNullLiteral>] IExports =
        abstract PlaneHelper: PlaneHelperStatic

    type [<AllowNullLiteral>] PlaneHelper =
        inherit LineSegments
        abstract plane: Plane with get, set
        abstract size: float with get, set
        abstract updateMatrixWorld: ?force: bool -> unit

    type [<AllowNullLiteral>] PlaneHelperStatic =
        [<Emit "new $0($1...)">] abstract Create: plane: Plane * ?size: float * ?hex: float -> PlaneHelper

module __helpers_PointLightHelper =
    type PointLight = __lights_PointLight.PointLight
    type Color = __math_Color.Color
    type Matrix4 = __math_Matrix4.Matrix4
    type Object3D = __core_Object3D.Object3D

    type [<AllowNullLiteral>] IExports =
        abstract PointLightHelper: PointLightHelperStatic

    type [<AllowNullLiteral>] PointLightHelper =
        inherit Object3D
        abstract light: PointLight with get, set
        abstract color: U3<Color, string, float> option with get, set
        abstract matrix: Matrix4 with get, set
        abstract matrixAutoUpdate: bool with get, set
        abstract dispose: unit -> unit
        abstract update: unit -> unit

    type [<AllowNullLiteral>] PointLightHelperStatic =
        [<Emit "new $0($1...)">] abstract Create: light: PointLight * ?sphereSize: float * ?color: U3<Color, string, float> -> PointLightHelper

module __helpers_PolarGridHelper =
    type LineSegments = __objects_LineSegments.LineSegments
    type Color = __math_Color.Color

    type [<AllowNullLiteral>] IExports =
        abstract PolarGridHelper: PolarGridHelperStatic

    type [<AllowNullLiteral>] PolarGridHelper =
        inherit LineSegments

    type [<AllowNullLiteral>] PolarGridHelperStatic =
        [<Emit "new $0($1...)">] abstract Create: radius: float * radials: float * circles: float * divisions: float * color1: U3<Color, string, float> option * color2: U3<Color, string, float> option -> PolarGridHelper

module __helpers_SkeletonHelper =
    type Object3D = __core_Object3D.Object3D
    type Bone = __objects_Bone.Bone
    type LineSegments = __objects_LineSegments.LineSegments

    type [<AllowNullLiteral>] IExports =
        abstract SkeletonHelper: SkeletonHelperStatic

    type [<AllowNullLiteral>] SkeletonHelper =
        inherit LineSegments
        abstract bones: ResizeArray<Bone> with get, set
        abstract root: Object3D with get, set
        abstract getBoneList: ``object``: Object3D -> ResizeArray<Bone>
        abstract update: unit -> unit

    type [<AllowNullLiteral>] SkeletonHelperStatic =
        [<Emit "new $0($1...)">] abstract Create: ``object``: Object3D -> SkeletonHelper

module __helpers_SpotLightHelper =
    type Light = __lights_Light.Light
    type Color = __math_Color.Color
    type Matrix4 = __math_Matrix4.Matrix4
    type Object3D = __core_Object3D.Object3D
    type LineSegments = __objects_LineSegments.LineSegments

    type [<AllowNullLiteral>] IExports =
        abstract SpotLightHelper: SpotLightHelperStatic

    type [<AllowNullLiteral>] SpotLightHelper =
        inherit Object3D
        abstract light: Light with get, set
        abstract matrix: Matrix4 with get, set
        abstract matrixAutoUpdate: bool with get, set
        abstract color: U3<Color, string, float> option with get, set
        abstract cone: LineSegments with get, set
        abstract dispose: unit -> unit
        abstract update: unit -> unit

    type [<AllowNullLiteral>] SpotLightHelperStatic =
        [<Emit "new $0($1...)">] abstract Create: light: Light * ?color: U3<Color, string, float> -> SpotLightHelper

module __lights_AmbientLight =
    type Color = __math_Color.Color
    type Light = __lights_Light.Light

    type [<AllowNullLiteral>] IExports =
        abstract AmbientLight: AmbientLightStatic

    /// This light's color gets applied to all the objects in the scene globally.
    type [<AllowNullLiteral>] AmbientLight =
        inherit Light
        abstract castShadow: bool with get, set

    /// This light's color gets applied to all the objects in the scene globally.
    type [<AllowNullLiteral>] AmbientLightStatic =
        /// <summary>This creates a Ambientlight with a color.</summary>
        /// <param name="color">Numeric value of the RGB component of the color or a Color instance.</param>
        [<Emit "new $0($1...)">] abstract Create: ?color: U3<Color, string, float> * ?intensity: float -> AmbientLight

module __lights_AmbientLightProbe =
    type Color = __math_Color.Color
    type LightProbe = __lights_LightProbe.LightProbe

    type [<AllowNullLiteral>] IExports =
        abstract AmbientLightProbe: AmbientLightProbeStatic

    type [<AllowNullLiteral>] AmbientLightProbe =
        inherit LightProbe
        abstract isAmbientLightProbe: obj with get, set

    type [<AllowNullLiteral>] AmbientLightProbeStatic =
        [<Emit "new $0($1...)">] abstract Create: ?color: U3<Color, string, float> * ?intensity: float -> AmbientLightProbe

module __lights_DirectionalLight =
    type Color = __math_Color.Color
    type Object3D = __core_Object3D.Object3D
    type DirectionalLightShadow = __lights_DirectionalLightShadow.DirectionalLightShadow
    type Light = __lights_Light.Light

    type [<AllowNullLiteral>] IExports =
        abstract DirectionalLight: DirectionalLightStatic

    /// Affects objects using MeshLambertMaterial or MeshPhongMaterial.
    type [<AllowNullLiteral>] DirectionalLight =
        inherit Light
        /// Target used for shadow camera orientation.
        abstract target: Object3D with get, set
        /// Light's intensity.
        /// Default — 1.0.
        abstract intensity: float with get, set
        abstract shadow: DirectionalLightShadow with get, set

    /// Affects objects using MeshLambertMaterial or MeshPhongMaterial.
    type [<AllowNullLiteral>] DirectionalLightStatic =
        [<Emit "new $0($1...)">] abstract Create: ?color: U3<Color, string, float> * ?intensity: float -> DirectionalLight

module __lights_DirectionalLightShadow =
    type OrthographicCamera = __cameras_OrthographicCamera.OrthographicCamera
    type LightShadow = __lights_LightShadow.LightShadow

    type [<AllowNullLiteral>] IExports =
        abstract DirectionalLightShadow: DirectionalLightShadowStatic

    type [<AllowNullLiteral>] DirectionalLightShadow =
        inherit LightShadow
        abstract camera: OrthographicCamera with get, set

    type [<AllowNullLiteral>] DirectionalLightShadowStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> DirectionalLightShadow

module __lights_HemisphereLight =
    type Color = __math_Color.Color
    type Light = __lights_Light.Light

    type [<AllowNullLiteral>] IExports =
        abstract HemisphereLight: HemisphereLightStatic

    type [<AllowNullLiteral>] HemisphereLight =
        inherit Light
        abstract skyColor: Color with get, set
        abstract groundColor: Color with get, set
        abstract intensity: float with get, set

    type [<AllowNullLiteral>] HemisphereLightStatic =
        [<Emit "new $0($1...)">] abstract Create: ?skyColor: U3<Color, string, float> * ?groundColor: U3<Color, string, float> * ?intensity: float -> HemisphereLight

module __lights_HemisphereLightProbe =
    type Color = __math_Color.Color
    type LightProbe = __lights_LightProbe.LightProbe

    type [<AllowNullLiteral>] IExports =
        abstract HemisphereLightProbe: HemisphereLightProbeStatic

    type [<AllowNullLiteral>] HemisphereLightProbe =
        inherit LightProbe
        abstract isHemisphereLightProbe: obj with get, set

    type [<AllowNullLiteral>] HemisphereLightProbeStatic =
        [<Emit "new $0($1...)">] abstract Create: ?skyColor: U3<Color, string, float> * ?groundColor: U3<Color, string, float> * ?intensity: float -> HemisphereLightProbe

module __lights_Light =
    type Color = __math_Color.Color
    type LightShadow = __lights_LightShadow.LightShadow
    type Object3D = __core_Object3D.Object3D

    type [<AllowNullLiteral>] IExports =
        abstract Light: LightStatic

    /// Abstract base class for lights.
    type [<AllowNullLiteral>] Light =
        inherit Object3D
        abstract color: Color with get, set
        abstract intensity: float with get, set
        abstract isLight: obj with get, set
        abstract receiveShadow: bool with get, set
        abstract shadow: LightShadow with get, set
        abstract shadowCameraFov: obj option with get, set
        abstract shadowCameraLeft: obj option with get, set
        abstract shadowCameraRight: obj option with get, set
        abstract shadowCameraTop: obj option with get, set
        abstract shadowCameraBottom: obj option with get, set
        abstract shadowCameraNear: obj option with get, set
        abstract shadowCameraFar: obj option with get, set
        abstract shadowBias: obj option with get, set
        abstract shadowMapWidth: obj option with get, set
        abstract shadowMapHeight: obj option with get, set

    /// Abstract base class for lights.
    type [<AllowNullLiteral>] LightStatic =
        [<Emit "new $0($1...)">] abstract Create: ?hex: U2<float, string> * ?intensity: float -> Light

module __lights_LightProbe =
    type SphericalHarmonics3 = __math_SphericalHarmonics3.SphericalHarmonics3
    type Light = __lights_Light.Light

    type [<AllowNullLiteral>] IExports =
        abstract LightProbe: LightProbeStatic

    type [<AllowNullLiteral>] LightProbe =
        inherit Light
        abstract isLightProbe: obj with get, set
        abstract sh: SphericalHarmonics3 with get, set

    type [<AllowNullLiteral>] LightProbeStatic =
        [<Emit "new $0($1...)">] abstract Create: ?sh: SphericalHarmonics3 * ?intensity: float -> LightProbe

module __lights_LightShadow =
    type Camera = __cameras_Camera.Camera
    type Light = __lights_Light.Light
    type Vector2 = __math_Vector2.Vector2
    type Vector4 = __math_Vector4.Vector4
    type Matrix4 = __math_Matrix4.Matrix4
    type RenderTarget = __renderers_webgl_WebGLRenderLists.RenderTarget

    type [<AllowNullLiteral>] IExports =
        abstract LightShadow: LightShadowStatic

    type [<AllowNullLiteral>] LightShadow =
        abstract camera: Camera with get, set
        abstract bias: float with get, set
        abstract radius: float with get, set
        abstract mapSize: Vector2 with get, set
        abstract map: RenderTarget with get, set
        abstract mapPass: RenderTarget with get, set
        abstract matrix: Matrix4 with get, set
        abstract copy: source: LightShadow -> LightShadow
        abstract clone: ?recursive: bool -> LightShadow
        abstract toJSON: unit -> obj option
        abstract getFrustum: unit -> float
        abstract updateMatrices: light: Light * ?viewportIndex: float -> unit
        abstract getViewport: viewportIndex: float -> Vector4
        abstract getFrameExtents: unit -> Vector2

    type [<AllowNullLiteral>] LightShadowStatic =
        [<Emit "new $0($1...)">] abstract Create: camera: Camera -> LightShadow

module __lights_PointLight =
    type Color = __math_Color.Color
    type Light = __lights_Light.Light
    type PerspectiveCamera = __cameras_PerspectiveCamera.PerspectiveCamera
    type LightShadow = __lights_LightShadow.LightShadow

    type [<AllowNullLiteral>] IExports =
        abstract PointLightShadow: PointLightShadowStatic
        abstract PointLight: PointLightStatic

    type [<AllowNullLiteral>] PointLightShadow =
        inherit LightShadow
        abstract camera: PerspectiveCamera with get, set

    type [<AllowNullLiteral>] PointLightShadowStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PointLightShadow

    /// Affects objects using {@link MeshLambertMaterial} or {@link MeshPhongMaterial}.
    type [<AllowNullLiteral>] PointLight =
        inherit Light
        abstract intensity: float with get, set
        /// If non-zero, light will attenuate linearly from maximum intensity at light position down to zero at distance.
        /// Default — 0.0.
        abstract distance: float with get, set
        abstract decay: float with get, set
        abstract shadow: PointLightShadow with get, set
        abstract power: float with get, set

    /// Affects objects using {@link MeshLambertMaterial} or {@link MeshPhongMaterial}.
    type [<AllowNullLiteral>] PointLightStatic =
        [<Emit "new $0($1...)">] abstract Create: ?color: U3<Color, string, float> * ?intensity: float * ?distance: float * ?decay: float -> PointLight

module __lights_PointLightShadow =
    type PerspectiveCamera = __cameras_PerspectiveCamera.PerspectiveCamera
    type LightShadow = __lights_LightShadow.LightShadow

    type [<AllowNullLiteral>] IExports =
        abstract PointLightShadow: PointLightShadowStatic

    type [<AllowNullLiteral>] PointLightShadow =
        inherit LightShadow
        abstract camera: PerspectiveCamera with get, set

    type [<AllowNullLiteral>] PointLightShadowStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PointLightShadow

module __lights_RectAreaLight =
    type Light = __lights_Light.Light
    type Color = __math_Color.Color

    type [<AllowNullLiteral>] IExports =
        abstract RectAreaLight: RectAreaLightStatic

    type [<AllowNullLiteral>] RectAreaLight =
        inherit Light
        abstract ``type``: string with get, set
        abstract width: float with get, set
        abstract height: float with get, set
        abstract intensity: float with get, set

    type [<AllowNullLiteral>] RectAreaLightStatic =
        [<Emit "new $0($1...)">] abstract Create: ?color: U3<Color, string, float> * ?intensity: float * ?width: float * ?height: float -> RectAreaLight

module __lights_SpotLight =
    type Color = __math_Color.Color
    type Object3D = __core_Object3D.Object3D
    type SpotLightShadow = __lights_SpotLightShadow.SpotLightShadow
    type Light = __lights_Light.Light

    type [<AllowNullLiteral>] IExports =
        abstract SpotLight: SpotLightStatic

    /// A point light that can cast shadow in one direction.
    type [<AllowNullLiteral>] SpotLight =
        inherit Light
        /// Spotlight focus points at target.position.
        /// Default position — (0,0,0).
        abstract target: Object3D with get, set
        /// Light's intensity.
        /// Default — 1.0.
        abstract intensity: float with get, set
        /// If non-zero, light will attenuate linearly from maximum intensity at light position down to zero at distance.
        /// Default — 0.0.
        abstract distance: float with get, set
        abstract angle: float with get, set
        /// Rapidity of the falloff of light from its target direction.
        /// Default — 10.0.
        abstract exponent: float with get, set
        abstract decay: float with get, set
        abstract shadow: SpotLightShadow with get, set
        abstract power: float with get, set
        abstract penumbra: float with get, set

    /// A point light that can cast shadow in one direction.
    type [<AllowNullLiteral>] SpotLightStatic =
        [<Emit "new $0($1...)">] abstract Create: ?color: U3<Color, string, float> * ?intensity: float * ?distance: float * ?angle: float * ?exponent: float * ?decay: float -> SpotLight

module __lights_SpotLightShadow =
    type PerspectiveCamera = __cameras_PerspectiveCamera.PerspectiveCamera
    type LightShadow = __lights_LightShadow.LightShadow

    type [<AllowNullLiteral>] IExports =
        abstract SpotLightShadow: SpotLightShadowStatic

    type [<AllowNullLiteral>] SpotLightShadow =
        inherit LightShadow
        abstract camera: PerspectiveCamera with get, set

    type [<AllowNullLiteral>] SpotLightShadowStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SpotLightShadow

module __loaders_AnimationLoader =
    type LoadingManager = __loaders_LoadingManager.LoadingManager
    type Loader = __loaders_Loader.Loader
    type AnimationClip = __animation_AnimationClip.AnimationClip

    type [<AllowNullLiteral>] IExports =
        abstract AnimationLoader: AnimationLoaderStatic

    type [<AllowNullLiteral>] AnimationLoader =
        inherit Loader
        abstract load: url: string * onLoad: (ResizeArray<AnimationClip> -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> unit
        abstract parse: json: obj option -> ResizeArray<AnimationClip>

    type [<AllowNullLiteral>] AnimationLoaderStatic =
        [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> AnimationLoader

module __loaders_AudioLoader =
    type Loader = __loaders_Loader.Loader
    type LoadingManager = __loaders_LoadingManager.LoadingManager

    type [<AllowNullLiteral>] IExports =
        abstract AudioLoader: AudioLoaderStatic

    type [<AllowNullLiteral>] AudioLoader =
        inherit Loader
        abstract load: url: string * onLoad: (AudioBuffer -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> unit

    type [<AllowNullLiteral>] AudioLoaderStatic =
        [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> AudioLoader

module __loaders_BufferGeometryLoader =
    type Loader = __loaders_Loader.Loader
    type LoadingManager = __loaders_LoadingManager.LoadingManager
    type BufferGeometry = __core_BufferGeometry.BufferGeometry
    type InstancedBufferGeometry = __core_InstancedBufferGeometry.InstancedBufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract BufferGeometryLoader: BufferGeometryLoaderStatic

    type [<AllowNullLiteral>] BufferGeometryLoader =
        inherit Loader
        abstract load: url: string * onLoad: (U2<InstancedBufferGeometry, BufferGeometry> -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> unit
        abstract parse: json: obj option -> U2<InstancedBufferGeometry, BufferGeometry>

    type [<AllowNullLiteral>] BufferGeometryLoaderStatic =
        [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> BufferGeometryLoader

module __loaders_Cache =
    let [<Import("Cache","three/loaders/Cache")>] cache: Cache.IExports = jsNative

    module Cache =

        type [<AllowNullLiteral>] IExports =
            abstract enabled: bool
            abstract files: obj option
            abstract add: key: string * file: obj option -> unit
            abstract get: key: string -> obj option
            abstract remove: key: string -> unit
            abstract clear: unit -> unit

module __loaders_CompressedTextureLoader =
    type Loader = __loaders_Loader.Loader
    type LoadingManager = __loaders_LoadingManager.LoadingManager
    type CompressedTexture = __textures_CompressedTexture.CompressedTexture

    type [<AllowNullLiteral>] IExports =
        abstract CompressedTextureLoader: CompressedTextureLoaderStatic

    type [<AllowNullLiteral>] CompressedTextureLoader =
        inherit Loader
        abstract load: url: string * onLoad: (CompressedTexture -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> unit

    type [<AllowNullLiteral>] CompressedTextureLoaderStatic =
        [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> CompressedTextureLoader

module __loaders_CubeTextureLoader =
    type Loader = __loaders_Loader.Loader
    type LoadingManager = __loaders_LoadingManager.LoadingManager
    type CubeTexture = __textures_CubeTexture.CubeTexture

    type [<AllowNullLiteral>] IExports =
        abstract CubeTextureLoader: CubeTextureLoaderStatic

    type [<AllowNullLiteral>] CubeTextureLoader =
        inherit Loader
        abstract load: urls: Array<string> * ?onLoad: (CubeTexture -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> CubeTexture

    type [<AllowNullLiteral>] CubeTextureLoaderStatic =
        [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> CubeTextureLoader

module __loaders_DataTextureLoader =
    type Loader = __loaders_Loader.Loader
    type LoadingManager = __loaders_LoadingManager.LoadingManager
    type DataTexture = __textures_DataTexture.DataTexture

    type [<AllowNullLiteral>] IExports =
        abstract DataTextureLoader: DataTextureLoaderStatic

    type [<AllowNullLiteral>] DataTextureLoader =
        inherit Loader
        abstract load: url: string * onLoad: (DataTexture -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> unit

    type [<AllowNullLiteral>] DataTextureLoaderStatic =
        [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> DataTextureLoader

module __loaders_FileLoader =
    type Loader = __loaders_Loader.Loader
    type LoadingManager = __loaders_LoadingManager.LoadingManager

    type [<AllowNullLiteral>] IExports =
        abstract FileLoader: FileLoaderStatic

    type [<AllowNullLiteral>] FileLoader =
        inherit Loader
        abstract mimeType: MimeType option with get, set
        abstract responseType: string option with get, set
        abstract withCredentials: string option with get, set
        abstract requestHeader: FileLoaderRequestHeader option with get, set
        abstract load: url: string * ?onLoad: (U2<string, ArrayBuffer> -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> obj option
        abstract setMimeType: mimeType: MimeType -> FileLoader
        abstract setResponseType: responseType: string -> FileLoader
        abstract setWithCredentials: value: bool -> FileLoader
        abstract setRequestHeader: value: FileLoaderSetRequestHeaderValue -> FileLoader

    type [<AllowNullLiteral>] FileLoaderSetRequestHeaderValue =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: header: string -> string with get, set

    type [<AllowNullLiteral>] FileLoaderStatic =
        [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> FileLoader

    type [<AllowNullLiteral>] FileLoaderRequestHeader =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: header: string -> string with get, set

module __loaders_FontLoader =
    type Loader = __loaders_Loader.Loader
    type LoadingManager = __loaders_LoadingManager.LoadingManager
    type Font = __extras_core_Font.Font

    type [<AllowNullLiteral>] IExports =
        abstract FontLoader: FontLoaderStatic

    type [<AllowNullLiteral>] FontLoader =
        inherit Loader
        abstract load: url: string * ?onLoad: (Font -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> unit
        abstract parse: json: obj option -> Font

    type [<AllowNullLiteral>] FontLoaderStatic =
        [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> FontLoader

module __loaders_ImageBitmapLoader =
    type Loader = __loaders_Loader.Loader
    type LoadingManager = __loaders_LoadingManager.LoadingManager

    type [<AllowNullLiteral>] IExports =
        abstract ImageBitmapLoader: ImageBitmapLoaderStatic

    type [<AllowNullLiteral>] ImageBitmapLoader =
        inherit Loader
        abstract options: obj option with get, set
        abstract setOptions: options: obj -> ImageBitmapLoader
        abstract load: url: string * ?onLoad: (ImageBitmap -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> obj option

    type [<AllowNullLiteral>] ImageBitmapLoaderStatic =
        [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> ImageBitmapLoader

module __loaders_ImageLoader =
    type Loader = __loaders_Loader.Loader
    type LoadingManager = __loaders_LoadingManager.LoadingManager

    type [<AllowNullLiteral>] IExports =
        abstract ImageLoader: ImageLoaderStatic

    /// A loader for loading an image.
    /// Unlike other loaders, this one emits events instead of using predefined callbacks. So if you're interested in getting notified when things happen, you need to add listeners to the object.
    type [<AllowNullLiteral>] ImageLoader =
        inherit Loader
        abstract load: url: string * ?onLoad: (HTMLImageElement -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> HTMLImageElement

    /// A loader for loading an image.
    /// Unlike other loaders, this one emits events instead of using predefined callbacks. So if you're interested in getting notified when things happen, you need to add listeners to the object.
    type [<AllowNullLiteral>] ImageLoaderStatic =
        [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> ImageLoader

module __loaders_Loader =
    type LoadingManager = __loaders_LoadingManager.LoadingManager

    type [<AllowNullLiteral>] IExports =
        abstract Loader: LoaderStatic

    /// Base class for implementing loaders.
    type [<AllowNullLiteral>] Loader =
        abstract crossOrigin: string with get, set
        abstract path: string with get, set
        abstract resourcePath: string with get, set
        abstract manager: LoadingManager with get, set
        abstract setCrossOrigin: crossOrigin: string -> Loader
        abstract setPath: path: string -> Loader
        abstract setResourcePath: resourcePath: string -> Loader

    /// Base class for implementing loaders.
    type [<AllowNullLiteral>] LoaderStatic =
        [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> Loader

module __loaders_LoaderUtils =
    type TypedArray = Polyfills.TypedArray

    type [<AllowNullLiteral>] IExports =
        abstract LoaderUtils: LoaderUtilsStatic

    type [<AllowNullLiteral>] LoaderUtils =
        interface end

    type [<AllowNullLiteral>] LoaderUtilsStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> LoaderUtils
        abstract decodeText: array: TypedArray -> string
        abstract extractUrlBase: url: string -> string

module __loaders_LoadingManager =
    type Loader = __loaders_Loader.Loader

    type [<AllowNullLiteral>] IExports =
        abstract DefaultLoadingManager: LoadingManager
        abstract LoadingManager: LoadingManagerStatic

    /// Handles and keeps track of loaded and pending data.
    type [<AllowNullLiteral>] LoadingManager =
        /// Will be called when loading of an item starts.
        abstract onStart: (string -> float -> float -> unit) option with get, set
        /// Will be called when all items finish loading.
        /// The default is a function with empty body.
        abstract onLoad: (unit -> unit) with get, set
        /// Will be called for each loaded item.
        /// The default is a function with empty body.
        abstract onProgress: (string -> float -> float -> unit) with get, set
        /// Will be called when item loading fails.
        /// The default is a function with empty body.
        abstract onError: (string -> unit) with get, set
        /// <summary>If provided, the callback will be passed each resource URL before a request is sent.
        /// The callback may return the original URL, or a new URL to override loading behavior.
        /// This behavior can be used to load assets from .ZIP files, drag-and-drop APIs, and Data URIs.</summary>
        /// <param name="callback">URL modifier callback. Called with url argument, and must return resolvedURL.</param>
        abstract setURLModifier: ?callback: (string -> string) -> LoadingManager
        /// <summary>Given a URL, uses the URL modifier callback (if any) and returns a resolved URL.
        /// If no URL modifier is set, returns the original URL.</summary>
        /// <param name="url">the url to load</param>
        abstract resolveURL: url: string -> string
        abstract itemStart: url: string -> unit
        abstract itemEnd: url: string -> unit
        abstract itemError: url: string -> unit
        abstract addHandler: regex: RegExp * loader: Loader -> LoadingManager
        abstract removeHandler: regex: RegExp -> LoadingManager
        abstract getHandler: file: string -> Loader option

    /// Handles and keeps track of loaded and pending data.
    type [<AllowNullLiteral>] LoadingManagerStatic =
        [<Emit "new $0($1...)">] abstract Create: ?onLoad: (unit -> unit) * ?onProgress: (string -> float -> float -> unit) * ?onError: (string -> unit) -> LoadingManager

module __loaders_MaterialLoader =
    type Loader = __loaders_Loader.Loader
    type LoadingManager = __loaders_LoadingManager.LoadingManager
    type Texture = __textures_Texture.Texture
    type Material = __materials_Material.Material

    type [<AllowNullLiteral>] IExports =
        abstract MaterialLoader: MaterialLoaderStatic

    type [<AllowNullLiteral>] MaterialLoader =
        inherit Loader
        abstract textures: MaterialLoaderTextures with get, set
        abstract load: url: string * onLoad: (Material -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (U2<Error, ErrorEvent> -> unit) -> unit
        abstract setTextures: textures: MaterialLoaderSetTexturesTextures -> MaterialLoader
        abstract parse: json: obj option -> Material

    type [<AllowNullLiteral>] MaterialLoaderSetTexturesTextures =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> Texture with get, set

    type [<AllowNullLiteral>] MaterialLoaderStatic =
        [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> MaterialLoader

    type [<AllowNullLiteral>] MaterialLoaderTextures =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> Texture with get, set

module __loaders_ObjectLoader =
    type Loader = __loaders_Loader.Loader
    type LoadingManager = __loaders_LoadingManager.LoadingManager
    type Object3D = __core_Object3D.Object3D
    type Texture = __textures_Texture.Texture
    type Material = __materials_Material.Material
    type AnimationClip = __animation_AnimationClip.AnimationClip

    type [<AllowNullLiteral>] IExports =
        abstract ObjectLoader: ObjectLoaderStatic

    type [<AllowNullLiteral>] ObjectLoader =
        inherit Loader
        abstract load: url: string * ?onLoad: ('ObjectType -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (U2<Error, ErrorEvent> -> unit) -> unit
        abstract parse: json: obj option * ?onLoad: (Object3D -> unit) -> 'T
        abstract parseGeometries: json: obj option -> ResizeArray<obj option>
        abstract parseMaterials: json: obj option * textures: ResizeArray<Texture> -> ResizeArray<Material>
        abstract parseAnimations: json: obj option -> ResizeArray<AnimationClip>
        abstract parseImages: json: obj option * onLoad: (unit -> unit) -> ObjectLoaderParseImagesReturn
        abstract parseTextures: json: obj option * images: obj option -> ResizeArray<Texture>
        abstract parseObject: data: obj option * geometries: ResizeArray<obj option> * materials: ResizeArray<Material> -> 'T

    type [<AllowNullLiteral>] ObjectLoaderParseImagesReturn =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> HTMLImageElement with get, set

    type [<AllowNullLiteral>] ObjectLoaderStatic =
        [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> ObjectLoader

module __loaders_TextureLoader =
    type Loader = __loaders_Loader.Loader
    type LoadingManager = __loaders_LoadingManager.LoadingManager
    type Texture = __textures_Texture.Texture

    type [<AllowNullLiteral>] IExports =
        abstract TextureLoader: TextureLoaderStatic

    /// Class for loading a texture.
    /// Unlike other loaders, this one emits events instead of using predefined callbacks. So if you're interested in getting notified when things happen, you need to add listeners to the object.
    type [<AllowNullLiteral>] TextureLoader =
        inherit Loader
        abstract load: url: string * ?onLoad: (Texture -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> Texture

    /// Class for loading a texture.
    /// Unlike other loaders, this one emits events instead of using predefined callbacks. So if you're interested in getting notified when things happen, you need to add listeners to the object.
    type [<AllowNullLiteral>] TextureLoaderStatic =
        [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> TextureLoader

module __materials_LineBasicMaterial =
    type Color = __math_Color.Color
    type MaterialParameters = __materials_Material.MaterialParameters
    type Material = __materials_Material.Material

    type [<AllowNullLiteral>] IExports =
        abstract LineBasicMaterial: LineBasicMaterialStatic

    type [<AllowNullLiteral>] LineBasicMaterialParameters =
        inherit MaterialParameters
        abstract color: U3<Color, string, float> option with get, set
        abstract linewidth: float option with get, set
        abstract linecap: string option with get, set
        abstract linejoin: string option with get, set

    type [<AllowNullLiteral>] LineBasicMaterial =
        inherit Material
        abstract color: Color with get, set
        abstract linewidth: float with get, set
        abstract linecap: string with get, set
        abstract linejoin: string with get, set
        abstract setValues: parameters: LineBasicMaterialParameters -> unit

    type [<AllowNullLiteral>] LineBasicMaterialStatic =
        [<Emit "new $0($1...)">] abstract Create: ?parameters: LineBasicMaterialParameters -> LineBasicMaterial

module __materials_LineDashedMaterial =
    type Color = __math_Color.Color
    type MaterialParameters = __materials_Material.MaterialParameters
    type LineBasicMaterial = __materials_LineBasicMaterial.LineBasicMaterial

    type [<AllowNullLiteral>] IExports =
        abstract LineDashedMaterial: LineDashedMaterialStatic

    type [<AllowNullLiteral>] LineDashedMaterialParameters =
        inherit MaterialParameters
        abstract color: U3<Color, string, float> option with get, set
        abstract linewidth: float option with get, set
        abstract scale: float option with get, set
        abstract dashSize: float option with get, set
        abstract gapSize: float option with get, set

    type [<AllowNullLiteral>] LineDashedMaterial =
        inherit LineBasicMaterial
        abstract scale: float with get, set
        abstract dashSize: float with get, set
        abstract gapSize: float with get, set
        abstract isLineDashedMaterial: bool with get, set
        abstract setValues: parameters: LineDashedMaterialParameters -> unit

    type [<AllowNullLiteral>] LineDashedMaterialStatic =
        [<Emit "new $0($1...)">] abstract Create: ?parameters: LineDashedMaterialParameters -> LineDashedMaterial

module __materials_Material =
    type Plane = __math_Plane.Plane
    type Shader = __renderers_shaders_ShaderLib.Shader
    type EventDispatcher = __core_EventDispatcher.EventDispatcher
    type WebGLRenderer = __renderers_WebGLRenderer.WebGLRenderer
    type BlendingDstFactor = Constants.BlendingDstFactor
    type BlendingEquation = Constants.BlendingEquation
    type Blending = Constants.Blending
    type BlendingSrcFactor = Constants.BlendingSrcFactor
    type DepthModes = Constants.DepthModes
    type Side = Constants.Side
    type Colors = Constants.Colors
    type StencilFunc = Constants.StencilFunc
    type StencilOp = Constants.StencilOp

    type [<AllowNullLiteral>] IExports =
        abstract MaterialIdCount: float
        abstract Material: MaterialStatic

    type [<AllowNullLiteral>] MaterialParameters =
        abstract alphaTest: float option with get, set
        abstract blendDst: BlendingDstFactor option with get, set
        abstract blendDstAlpha: float option with get, set
        abstract blendEquation: BlendingEquation option with get, set
        abstract blendEquationAlpha: float option with get, set
        abstract blending: Blending option with get, set
        abstract blendSrc: U2<BlendingSrcFactor, BlendingDstFactor> option with get, set
        abstract blendSrcAlpha: float option with get, set
        abstract clipIntersection: bool option with get, set
        abstract clippingPlanes: ResizeArray<Plane> option with get, set
        abstract clipShadows: bool option with get, set
        abstract colorWrite: bool option with get, set
        abstract defines: obj option with get, set
        abstract depthFunc: DepthModes option with get, set
        abstract depthTest: bool option with get, set
        abstract depthWrite: bool option with get, set
        abstract fog: bool option with get, set
        abstract name: string option with get, set
        abstract opacity: float option with get, set
        abstract polygonOffset: bool option with get, set
        abstract polygonOffsetFactor: float option with get, set
        abstract polygonOffsetUnits: float option with get, set
        abstract precision: MaterialParametersPrecision option with get, set
        abstract premultipliedAlpha: bool option with get, set
        abstract dithering: bool option with get, set
        abstract flatShading: bool option with get, set
        abstract side: Side option with get, set
        abstract shadowSide: Side option with get, set
        abstract toneMapped: bool option with get, set
        abstract transparent: bool option with get, set
        abstract vertexColors: Colors option with get, set
        abstract vertexTangents: bool option with get, set
        abstract visible: bool option with get, set
        abstract stencilWrite: bool option with get, set
        abstract stencilFunc: StencilFunc option with get, set
        abstract stencilRef: float option with get, set
        abstract stencilMask: float option with get, set
        abstract stencilFail: StencilOp option with get, set
        abstract stencilZFail: StencilOp option with get, set
        abstract stencilZPass: StencilOp option with get, set

    /// Materials describe the appearance of objects. They are defined in a (mostly) renderer-independent way, so you don't have to rewrite materials if you decide to use a different renderer.
    type [<AllowNullLiteral>] Material =
        inherit EventDispatcher
        /// Sets the alpha value to be used when running an alpha test. Default is 0.
        abstract alphaTest: float with get, set
        /// Blending destination. It's one of the blending mode constants defined in Three.js. Default is {@link OneMinusSrcAlphaFactor}.
        abstract blendDst: BlendingDstFactor with get, set
        /// The tranparency of the .blendDst. Default is null.
        abstract blendDstAlpha: float option with get, set
        /// Blending equation to use when applying blending. It's one of the constants defined in Three.js. Default is {@link AddEquation}.
        abstract blendEquation: BlendingEquation with get, set
        /// The tranparency of the .blendEquation. Default is null.
        abstract blendEquationAlpha: float option with get, set
        /// Which blending to use when displaying objects with this material. Default is {@link NormalBlending}.
        abstract blending: Blending with get, set
        /// Blending source. It's one of the blending mode constants defined in Three.js. Default is {@link SrcAlphaFactor}.
        abstract blendSrc: U2<BlendingSrcFactor, BlendingDstFactor> with get, set
        /// The tranparency of the .blendSrc. Default is null.
        abstract blendSrcAlpha: float option with get, set
        /// Changes the behavior of clipping planes so that only their intersection is clipped, rather than their union. Default is false.
        abstract clipIntersection: bool with get, set
        /// User-defined clipping planes specified as THREE.Plane objects in world space. These planes apply to the objects this material is attached to. Points in space whose signed distance to the plane is negative are clipped (not rendered). See the WebGL / clipping /intersection example. Default is null.
        abstract clippingPlanes: obj option with get, set
        /// Defines whether to clip shadows according to the clipping planes specified on this material. Default is false.
        abstract clipShadows: bool with get, set
        /// Whether to render the material's color. This can be used in conjunction with a mesh's .renderOrder property to create invisible objects that occlude other objects. Default is true.
        abstract colorWrite: bool with get, set
        /// Custom defines to be injected into the shader. These are passed in form of an object literal, with key/value pairs. { MY_CUSTOM_DEFINE: '' , PI2: Math.PI * 2 }.
        /// The pairs are defined in both vertex and fragment shaders. Default is undefined.
        abstract defines: obj option with get, set
        /// Which depth function to use. Default is {@link LessEqualDepth}. See the depth mode constants for all possible values.
        abstract depthFunc: DepthModes with get, set
        /// Whether to have depth test enabled when rendering this material. Default is true.
        abstract depthTest: bool with get, set
        /// Whether rendering this material has any effect on the depth buffer. Default is true.
        /// When drawing 2D overlays it can be useful to disable the depth writing in order to layer several things together without creating z-index artifacts.
        abstract depthWrite: bool with get, set
        /// Whether the material is affected by fog. Default is true.
        abstract fog: bool with get, set
        /// Unique number of this material instance.
        abstract id: float with get, set
        /// Whether rendering this material has any effect on the stencil buffer. Default is *false*.
        abstract stencilWrite: bool with get, set
        /// The stencil comparison function to use. Default is {@link AlwaysStencilFunc}. See stencil operation constants for all possible values.
        abstract stencilFunc: StencilFunc with get, set
        /// The value to use when performing stencil comparisons or stencil operations. Default is *0*.
        abstract stencilRef: float with get, set
        /// The bit mask to use when comparing against or writing to the stencil buffer. Default is *0xFF*.
        abstract stencilMask: float with get, set
        /// Which stencil operation to perform when the comparison function returns false. Default is {@link KeepStencilOp}. See the stencil operation constants for all possible values.
        abstract stencilFail: StencilOp with get, set
        /// Which stencil operation to perform when the comparison function returns true but the depth test fails. Default is {@link KeepStencilOp}. See the stencil operation constants for all possible values.
        abstract stencilZFail: StencilOp with get, set
        /// Which stencil operation to perform when the comparison function returns true and the depth test passes. Default is {@link KeepStencilOp}. See the stencil operation constants for all possible values.
        abstract stencilZPass: StencilOp with get, set
        /// Used to check whether this or derived classes are materials. Default is true.
        /// You should not change this, as it used internally for optimisation.
        abstract isMaterial: bool with get, set
        /// Material name. Default is an empty string.
        abstract name: string with get, set
        /// Specifies that the material needs to be updated, WebGL wise. Set it to true if you made changes that need to be reflected in WebGL.
        /// This property is automatically set to true when instancing a new material.
        abstract needsUpdate: bool with get, set
        /// Opacity. Default is 1.
        abstract opacity: float with get, set
        /// Whether to use polygon offset. Default is false. This corresponds to the POLYGON_OFFSET_FILL WebGL feature.
        abstract polygonOffset: bool with get, set
        /// Sets the polygon offset factor. Default is 0.
        abstract polygonOffsetFactor: float with get, set
        /// Sets the polygon offset units. Default is 0.
        abstract polygonOffsetUnits: float with get, set
        /// Override the renderer's default precision for this material. Can be "highp", "mediump" or "lowp". Defaults is null.
        abstract precision: MaterialParametersPrecision with get, set
        /// Whether to premultiply the alpha (transparency) value. See WebGL / Materials / Transparency for an example of the difference. Default is false.
        abstract premultipliedAlpha: bool with get, set
        /// Whether to apply dithering to the color to remove the appearance of banding. Default is false.
        abstract dithering: bool with get, set
        /// Define whether the material is rendered with flat shading. Default is false.
        abstract flatShading: bool with get, set
        /// Defines which of the face sides will be rendered - front, back or both.
        /// Default is THREE.FrontSide. Other options are THREE.BackSide and THREE.DoubleSide.
        abstract side: Side with get, set
        /// Defines whether this material is tone mapped according to the renderer's toneMapping setting.
        /// Default is true.
        abstract toneMapped: bool with get, set
        /// Defines whether this material is transparent. This has an effect on rendering as transparent objects need special treatment and are rendered after non-transparent objects.
        /// When set to true, the extent to which the material is transparent is controlled by setting it's .opacity property.
        /// Default is false.
        abstract transparent: bool with get, set
        /// Value is the string 'Material'. This shouldn't be changed, and can be used to find all objects of this type in a scene.
        abstract ``type``: string with get, set
        /// UUID of this material instance. This gets automatically assigned, so this shouldn't be edited.
        abstract uuid: string with get, set
        /// Defines whether vertex coloring is used. Default is THREE.NoColors. Other options are THREE.VertexColors and THREE.FaceColors.
        abstract vertexColors: Colors with get, set
        /// Defines whether precomputed vertex tangents are used. Default is false.
        abstract vertexTangents: bool with get, set
        /// Defines whether this material is visible. Default is true.
        abstract visible: bool with get, set
        /// An object that can be used to store custom data about the Material. It should not hold references to functions as these will not be cloned.
        abstract userData: obj option with get, set
        /// This starts at 0 and counts how many times .needsUpdate is set to true.
        abstract version: float with get, set
        /// Return a new material with the same parameters as this material.
        abstract clone: unit -> Material
        /// Copy the parameters from the passed material into this material.
        abstract copy: material: Material -> Material
        /// This disposes the material. Textures of a material don't get disposed. These needs to be disposed by {@link Texture}.
        abstract dispose: unit -> unit
        /// <summary>An optional callback that is executed immediately before the shader program is compiled. This function is called with the shader source code as a parameter. Useful for the modification of built-in materials.</summary>
        /// <param name="shader">Source code of the shader</param>
        /// <param name="renderer">WebGLRenderer Context that is initializing the material</param>
        abstract onBeforeCompile: shader: Shader * renderer: WebGLRenderer -> unit
        /// <summary>Sets the properties based on the values.</summary>
        /// <param name="values">A container with parameters.</param>
        abstract setValues: values: MaterialParameters -> unit
        /// <summary>Convert the material to three.js JSON format.</summary>
        /// <param name="meta">Object containing metadata such as textures or images for the material.</param>
        abstract toJSON: ?meta: obj -> obj option

    /// Materials describe the appearance of objects. They are defined in a (mostly) renderer-independent way, so you don't have to rewrite materials if you decide to use a different renderer.
    type [<AllowNullLiteral>] MaterialStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Material

    type [<StringEnum>] [<RequireQualifiedAccess>] MaterialParametersPrecision =
        | Highp
        | Mediump
        | Lowp

module __materials_MeshBasicMaterial =
    type Color = __math_Color.Color
    type Texture = __textures_Texture.Texture
    type MaterialParameters = __materials_Material.MaterialParameters
    type Material = __materials_Material.Material
    type Combine = Constants.Combine

    type [<AllowNullLiteral>] IExports =
        abstract MeshBasicMaterial: MeshBasicMaterialStatic

    /// parameters is an object with one or more properties defining the material's appearance.
    type [<AllowNullLiteral>] MeshBasicMaterialParameters =
        inherit MaterialParameters
        abstract color: U3<Color, string, float> option with get, set
        abstract opacity: float option with get, set
        abstract map: Texture option with get, set
        abstract aoMap: Texture option with get, set
        abstract aoMapIntensity: float option with get, set
        abstract specularMap: Texture option with get, set
        abstract alphaMap: Texture option with get, set
        abstract envMap: Texture option with get, set
        abstract combine: Combine option with get, set
        abstract reflectivity: float option with get, set
        abstract refractionRatio: float option with get, set
        abstract wireframe: bool option with get, set
        abstract wireframeLinewidth: float option with get, set
        abstract wireframeLinecap: string option with get, set
        abstract wireframeLinejoin: string option with get, set
        abstract skinning: bool option with get, set
        abstract morphTargets: bool option with get, set

    type [<AllowNullLiteral>] MeshBasicMaterial =
        inherit Material
        abstract color: Color with get, set
        abstract map: Texture option with get, set
        abstract aoMap: Texture option with get, set
        abstract aoMapIntensity: float with get, set
        abstract specularMap: Texture option with get, set
        abstract alphaMap: Texture option with get, set
        abstract envMap: Texture option with get, set
        abstract combine: Combine with get, set
        abstract reflectivity: float with get, set
        abstract refractionRatio: float with get, set
        abstract wireframe: bool with get, set
        abstract wireframeLinewidth: float with get, set
        abstract wireframeLinecap: string with get, set
        abstract wireframeLinejoin: string with get, set
        abstract skinning: bool with get, set
        abstract morphTargets: bool with get, set
        abstract setValues: parameters: MeshBasicMaterialParameters -> unit

    type [<AllowNullLiteral>] MeshBasicMaterialStatic =
        [<Emit "new $0($1...)">] abstract Create: ?parameters: MeshBasicMaterialParameters -> MeshBasicMaterial

module __materials_MeshDepthMaterial =
    type DepthPackingStrategies = Constants.DepthPackingStrategies
    type MaterialParameters = __materials_Material.MaterialParameters
    type Material = __materials_Material.Material
    type Texture = __textures_Texture.Texture

    type [<AllowNullLiteral>] IExports =
        abstract MeshDepthMaterial: MeshDepthMaterialStatic

    type [<AllowNullLiteral>] MeshDepthMaterialParameters =
        inherit MaterialParameters
        abstract map: Texture option with get, set
        abstract alphaMap: Texture option with get, set
        abstract depthPacking: DepthPackingStrategies option with get, set
        abstract displacementMap: Texture option with get, set
        abstract displacementScale: float option with get, set
        abstract displacementBias: float option with get, set
        abstract wireframe: bool option with get, set
        abstract wireframeLinewidth: float option with get, set

    type [<AllowNullLiteral>] MeshDepthMaterial =
        inherit Material
        abstract map: Texture option with get, set
        abstract alphaMap: Texture option with get, set
        abstract depthPacking: DepthPackingStrategies with get, set
        abstract displacementMap: Texture option with get, set
        abstract displacementScale: float with get, set
        abstract displacementBias: float with get, set
        abstract wireframe: bool with get, set
        abstract wireframeLinewidth: float with get, set
        abstract setValues: parameters: MeshDepthMaterialParameters -> unit

    type [<AllowNullLiteral>] MeshDepthMaterialStatic =
        [<Emit "new $0($1...)">] abstract Create: ?parameters: MeshDepthMaterialParameters -> MeshDepthMaterial

module __materials_MeshDistanceMaterial =
    type MaterialParameters = __materials_Material.MaterialParameters
    type Material = __materials_Material.Material
    type Vector3 = __math_Vector3.Vector3
    type Texture = __textures_Texture.Texture

    type [<AllowNullLiteral>] IExports =
        abstract MeshDistanceMaterial: MeshDistanceMaterialStatic

    type [<AllowNullLiteral>] MeshDistanceMaterialParameters =
        inherit MaterialParameters
        abstract map: Texture option with get, set
        abstract alphaMap: Texture option with get, set
        abstract displacementMap: Texture option with get, set
        abstract displacementScale: float option with get, set
        abstract displacementBias: float option with get, set
        abstract farDistance: float option with get, set
        abstract nearDistance: float option with get, set
        abstract referencePosition: Vector3 option with get, set

    type [<AllowNullLiteral>] MeshDistanceMaterial =
        inherit Material
        abstract map: Texture option with get, set
        abstract alphaMap: Texture option with get, set
        abstract displacementMap: Texture option with get, set
        abstract displacementScale: float with get, set
        abstract displacementBias: float with get, set
        abstract farDistance: float with get, set
        abstract nearDistance: float with get, set
        abstract referencePosition: Vector3 with get, set
        abstract setValues: parameters: MeshDistanceMaterialParameters -> unit

    type [<AllowNullLiteral>] MeshDistanceMaterialStatic =
        [<Emit "new $0($1...)">] abstract Create: ?parameters: MeshDistanceMaterialParameters -> MeshDistanceMaterial

module __materials_MeshLambertMaterial =
    type Color = __math_Color.Color
    type Texture = __textures_Texture.Texture
    type MaterialParameters = __materials_Material.MaterialParameters
    type Material = __materials_Material.Material
    type Combine = Constants.Combine

    type [<AllowNullLiteral>] IExports =
        abstract MeshLambertMaterial: MeshLambertMaterialStatic

    type [<AllowNullLiteral>] MeshLambertMaterialParameters =
        inherit MaterialParameters
        abstract color: U3<Color, string, float> option with get, set
        abstract emissive: U3<Color, string, float> option with get, set
        abstract emissiveIntensity: float option with get, set
        abstract emissiveMap: Texture option with get, set
        abstract map: Texture option with get, set
        abstract lightMap: Texture option with get, set
        abstract lightMapIntensity: float option with get, set
        abstract aoMap: Texture option with get, set
        abstract aoMapIntensity: float option with get, set
        abstract specularMap: Texture option with get, set
        abstract alphaMap: Texture option with get, set
        abstract envMap: Texture option with get, set
        abstract combine: Combine option with get, set
        abstract reflectivity: float option with get, set
        abstract refractionRatio: float option with get, set
        abstract wireframe: bool option with get, set
        abstract wireframeLinewidth: float option with get, set
        abstract wireframeLinecap: string option with get, set
        abstract wireframeLinejoin: string option with get, set
        abstract skinning: bool option with get, set
        abstract morphTargets: bool option with get, set
        abstract morphNormals: bool option with get, set

    type [<AllowNullLiteral>] MeshLambertMaterial =
        inherit Material
        abstract color: Color with get, set
        abstract emissive: Color with get, set
        abstract emissiveIntensity: float with get, set
        abstract emissiveMap: Texture option with get, set
        abstract map: Texture option with get, set
        abstract lightMap: Texture option with get, set
        abstract lightMapIntensity: float with get, set
        abstract aoMap: Texture option with get, set
        abstract aoMapIntensity: float with get, set
        abstract specularMap: Texture option with get, set
        abstract alphaMap: Texture option with get, set
        abstract envMap: Texture option with get, set
        abstract combine: Combine with get, set
        abstract reflectivity: float with get, set
        abstract refractionRatio: float with get, set
        abstract wireframe: bool with get, set
        abstract wireframeLinewidth: float with get, set
        abstract wireframeLinecap: string with get, set
        abstract wireframeLinejoin: string with get, set
        abstract skinning: bool with get, set
        abstract morphTargets: bool with get, set
        abstract morphNormals: bool with get, set
        abstract setValues: parameters: MeshLambertMaterialParameters -> unit

    type [<AllowNullLiteral>] MeshLambertMaterialStatic =
        [<Emit "new $0($1...)">] abstract Create: ?parameters: MeshLambertMaterialParameters -> MeshLambertMaterial

module __materials_MeshMatcapMaterial =
    type Color = __math_Color.Color
    type Texture = __textures_Texture.Texture
    type Vector2 = __math_Vector2.Vector2
    type MaterialParameters = __materials_Material.MaterialParameters
    type Material = __materials_Material.Material
    type NormalMapTypes = Constants.NormalMapTypes

    type [<AllowNullLiteral>] IExports =
        abstract MeshMatcapMaterial: MeshMatcapMaterialStatic

    type [<AllowNullLiteral>] MeshMatcapMaterialParameters =
        inherit MaterialParameters
        abstract color: U3<Color, string, float> option with get, set
        abstract matcap: Texture option with get, set
        abstract map: Texture option with get, set
        abstract bumpMap: Texture option with get, set
        abstract bumpScale: float option with get, set
        abstract normalMap: Texture option with get, set
        abstract normalMapType: NormalMapTypes option with get, set
        abstract normalScale: Vector2 option with get, set
        abstract displacementMap: Texture option with get, set
        abstract displacementScale: float option with get, set
        abstract displacementBias: float option with get, set
        abstract alphaMap: Texture option with get, set
        abstract skinning: bool option with get, set
        abstract morphTargets: bool option with get, set
        abstract morphNormals: bool option with get, set

    type [<AllowNullLiteral>] MeshMatcapMaterial =
        inherit Material
        abstract color: Color with get, set
        abstract matcap: Texture option with get, set
        abstract map: Texture option with get, set
        abstract bumpMap: Texture option with get, set
        abstract bumpScale: float with get, set
        abstract normalMap: Texture option with get, set
        abstract normalMapType: NormalMapTypes with get, set
        abstract normalScale: Vector2 with get, set
        abstract displacementMap: Texture option with get, set
        abstract displacementScale: float with get, set
        abstract displacementBias: float with get, set
        abstract alphaMap: Texture option with get, set
        abstract skinning: bool with get, set
        abstract morphTargets: bool with get, set
        abstract morphNormals: bool with get, set
        abstract setValues: parameters: MeshMatcapMaterialParameters -> unit

    type [<AllowNullLiteral>] MeshMatcapMaterialStatic =
        [<Emit "new $0($1...)">] abstract Create: ?parameters: MeshMatcapMaterialParameters -> MeshMatcapMaterial

module __materials_MeshNormalMaterial =
    type MaterialParameters = __materials_Material.MaterialParameters
    type Material = __materials_Material.Material
    type Texture = __textures_Texture.Texture
    type Vector2 = __math_Vector2.Vector2
    type NormalMapTypes = Constants.NormalMapTypes

    type [<AllowNullLiteral>] IExports =
        abstract MeshNormalMaterial: MeshNormalMaterialStatic

    type [<AllowNullLiteral>] MeshNormalMaterialParameters =
        inherit MaterialParameters
        abstract bumpMap: Texture option with get, set
        abstract bumpScale: float option with get, set
        abstract normalMap: Texture option with get, set
        abstract normalMapType: NormalMapTypes option with get, set
        abstract normalScale: Vector2 option with get, set
        abstract displacementMap: Texture option with get, set
        abstract displacementScale: float option with get, set
        abstract displacementBias: float option with get, set
        abstract wireframe: bool option with get, set
        abstract wireframeLinewidth: float option with get, set
        abstract skinning: bool option with get, set
        abstract morphTargets: bool option with get, set
        abstract morphNormals: bool option with get, set

    type [<AllowNullLiteral>] MeshNormalMaterial =
        inherit Material
        abstract bumpMap: Texture option with get, set
        abstract bumpScale: float with get, set
        abstract normalMap: Texture option with get, set
        abstract normalMapType: NormalMapTypes with get, set
        abstract normalScale: Vector2 with get, set
        abstract displacementMap: Texture option with get, set
        abstract displacementScale: float with get, set
        abstract displacementBias: float with get, set
        abstract wireframe: bool with get, set
        abstract wireframeLinewidth: float with get, set
        abstract skinning: bool with get, set
        abstract morphTargets: bool with get, set
        abstract morphNormals: bool with get, set
        abstract setValues: parameters: MeshNormalMaterialParameters -> unit

    type [<AllowNullLiteral>] MeshNormalMaterialStatic =
        [<Emit "new $0($1...)">] abstract Create: ?parameters: MeshNormalMaterialParameters -> MeshNormalMaterial

module __materials_MeshPhongMaterial =
    type Color = __math_Color.Color
    type Texture = __textures_Texture.Texture
    type Vector2 = __math_Vector2.Vector2
    type MaterialParameters = __materials_Material.MaterialParameters
    type Material = __materials_Material.Material
    type Combine = Constants.Combine
    type NormalMapTypes = Constants.NormalMapTypes

    type [<AllowNullLiteral>] IExports =
        abstract MeshPhongMaterial: MeshPhongMaterialStatic

    type [<AllowNullLiteral>] MeshPhongMaterialParameters =
        inherit MaterialParameters
        /// geometry color in hexadecimal. Default is 0xffffff.
        abstract color: U3<Color, string, float> option with get, set
        abstract specular: U3<Color, string, float> option with get, set
        abstract shininess: float option with get, set
        abstract opacity: float option with get, set
        abstract map: Texture option with get, set
        abstract lightMap: Texture option with get, set
        abstract lightMapIntensity: float option with get, set
        abstract aoMap: Texture option with get, set
        abstract aoMapIntensity: float option with get, set
        abstract emissive: U3<Color, string, float> option with get, set
        abstract emissiveIntensity: float option with get, set
        abstract emissiveMap: Texture option with get, set
        abstract bumpMap: Texture option with get, set
        abstract bumpScale: float option with get, set
        abstract normalMap: Texture option with get, set
        abstract normalMapType: NormalMapTypes option with get, set
        abstract normalScale: Vector2 option with get, set
        abstract displacementMap: Texture option with get, set
        abstract displacementScale: float option with get, set
        abstract displacementBias: float option with get, set
        abstract specularMap: Texture option with get, set
        abstract alphaMap: Texture option with get, set
        abstract envMap: Texture option with get, set
        abstract combine: Combine option with get, set
        abstract reflectivity: float option with get, set
        abstract refractionRatio: float option with get, set
        abstract wireframe: bool option with get, set
        abstract wireframeLinewidth: float option with get, set
        abstract wireframeLinecap: string option with get, set
        abstract wireframeLinejoin: string option with get, set
        abstract skinning: bool option with get, set
        abstract morphTargets: bool option with get, set
        abstract morphNormals: bool option with get, set

    type [<AllowNullLiteral>] MeshPhongMaterial =
        inherit Material
        abstract color: Color with get, set
        abstract specular: Color with get, set
        abstract shininess: float with get, set
        abstract map: Texture option with get, set
        abstract lightMap: Texture option with get, set
        abstract lightMapIntensity: float with get, set
        abstract aoMap: Texture option with get, set
        abstract aoMapIntensity: float with get, set
        abstract emissive: Color with get, set
        abstract emissiveIntensity: float with get, set
        abstract emissiveMap: Texture option with get, set
        abstract bumpMap: Texture option with get, set
        abstract bumpScale: float with get, set
        abstract normalMap: Texture option with get, set
        abstract normalMapType: NormalMapTypes with get, set
        abstract normalScale: Vector2 with get, set
        abstract displacementMap: Texture option with get, set
        abstract displacementScale: float with get, set
        abstract displacementBias: float with get, set
        abstract specularMap: Texture option with get, set
        abstract alphaMap: Texture option with get, set
        abstract envMap: Texture option with get, set
        abstract combine: Combine with get, set
        abstract reflectivity: float with get, set
        abstract refractionRatio: float with get, set
        abstract wireframe: bool with get, set
        abstract wireframeLinewidth: float with get, set
        abstract wireframeLinecap: string with get, set
        abstract wireframeLinejoin: string with get, set
        abstract skinning: bool with get, set
        abstract morphTargets: bool with get, set
        abstract morphNormals: bool with get, set
        abstract metal: bool with get, set
        abstract setValues: parameters: MeshPhongMaterialParameters -> unit

    type [<AllowNullLiteral>] MeshPhongMaterialStatic =
        [<Emit "new $0($1...)">] abstract Create: ?parameters: MeshPhongMaterialParameters -> MeshPhongMaterial

module __materials_MeshPhysicalMaterial =
    type Texture = __textures_Texture.Texture
    type Vector2 = __math_Vector2.Vector2
    type MeshStandardMaterialParameters = __materials_MeshStandardMaterial.MeshStandardMaterialParameters
    type MeshStandardMaterial = __materials_MeshStandardMaterial.MeshStandardMaterial
    type Color = __math_Color.Color

    type [<AllowNullLiteral>] IExports =
        abstract MeshPhysicalMaterial: MeshPhysicalMaterialStatic

    type [<AllowNullLiteral>] MeshPhysicalMaterialParameters =
        inherit MeshStandardMaterialParameters
        abstract reflectivity: float option with get, set
        abstract clearcoat: float option with get, set
        abstract clearcoatRoughness: float option with get, set
        abstract sheen: Color option with get, set
        abstract clearcoatNormalScale: Vector2 option with get, set
        abstract clearcoatNormalMap: Texture option with get, set

    type [<AllowNullLiteral>] MeshPhysicalMaterial =
        inherit MeshStandardMaterial
        abstract reflectivity: float with get, set
        abstract clearcoat: float with get, set
        abstract clearcoatRoughness: float with get, set
        abstract sheen: Color option with get, set
        abstract clearcoatNormalScale: Vector2 with get, set
        abstract clearcoatNormalMap: Texture option with get, set

    type [<AllowNullLiteral>] MeshPhysicalMaterialStatic =
        [<Emit "new $0($1...)">] abstract Create: parameters: MeshPhysicalMaterialParameters -> MeshPhysicalMaterial

module __materials_MeshStandardMaterial =
    type Color = __math_Color.Color
    type Texture = __textures_Texture.Texture
    type Vector2 = __math_Vector2.Vector2
    type MaterialParameters = __materials_Material.MaterialParameters
    type Material = __materials_Material.Material
    type NormalMapTypes = Constants.NormalMapTypes

    type [<AllowNullLiteral>] IExports =
        abstract MeshStandardMaterial: MeshStandardMaterialStatic

    type [<AllowNullLiteral>] MeshStandardMaterialParameters =
        inherit MaterialParameters
        abstract color: U3<Color, string, float> option with get, set
        abstract roughness: float option with get, set
        abstract metalness: float option with get, set
        abstract map: Texture option with get, set
        abstract lightMap: Texture option with get, set
        abstract lightMapIntensity: float option with get, set
        abstract aoMap: Texture option with get, set
        abstract aoMapIntensity: float option with get, set
        abstract emissive: U3<Color, string, float> option with get, set
        abstract emissiveIntensity: float option with get, set
        abstract emissiveMap: Texture option with get, set
        abstract bumpMap: Texture option with get, set
        abstract bumpScale: float option with get, set
        abstract normalMap: Texture option with get, set
        abstract normalMapType: NormalMapTypes option with get, set
        abstract normalScale: Vector2 option with get, set
        abstract displacementMap: Texture option with get, set
        abstract displacementScale: float option with get, set
        abstract displacementBias: float option with get, set
        abstract roughnessMap: Texture option with get, set
        abstract metalnessMap: Texture option with get, set
        abstract alphaMap: Texture option with get, set
        abstract envMap: Texture option with get, set
        abstract envMapIntensity: float option with get, set
        abstract refractionRatio: float option with get, set
        abstract wireframe: bool option with get, set
        abstract wireframeLinewidth: float option with get, set
        abstract skinning: bool option with get, set
        abstract morphTargets: bool option with get, set
        abstract morphNormals: bool option with get, set

    type [<AllowNullLiteral>] MeshStandardMaterial =
        inherit Material
        abstract color: Color with get, set
        abstract roughness: float with get, set
        abstract metalness: float with get, set
        abstract map: Texture option with get, set
        abstract lightMap: Texture option with get, set
        abstract lightMapIntensity: float with get, set
        abstract aoMap: Texture option with get, set
        abstract aoMapIntensity: float with get, set
        abstract emissive: Color with get, set
        abstract emissiveIntensity: float with get, set
        abstract emissiveMap: Texture option with get, set
        abstract bumpMap: Texture option with get, set
        abstract bumpScale: float with get, set
        abstract normalMap: Texture option with get, set
        abstract normalMapType: NormalMapTypes with get, set
        abstract normalScale: Vector2 with get, set
        abstract displacementMap: Texture option with get, set
        abstract displacementScale: float with get, set
        abstract displacementBias: float with get, set
        abstract roughnessMap: Texture option with get, set
        abstract metalnessMap: Texture option with get, set
        abstract alphaMap: Texture option with get, set
        abstract envMap: Texture option with get, set
        abstract envMapIntensity: float with get, set
        abstract refractionRatio: float with get, set
        abstract wireframe: bool with get, set
        abstract wireframeLinewidth: float with get, set
        abstract skinning: bool with get, set
        abstract morphTargets: bool with get, set
        abstract morphNormals: bool with get, set
        abstract setValues: parameters: MeshStandardMaterialParameters -> unit

    type [<AllowNullLiteral>] MeshStandardMaterialStatic =
        [<Emit "new $0($1...)">] abstract Create: ?parameters: MeshStandardMaterialParameters -> MeshStandardMaterial

module __materials_MeshToonMaterial =
    type Color = __math_Color.Color
    type Texture = __textures_Texture.Texture
    type Vector2 = __math_Vector2.Vector2
    type MaterialParameters = __materials_Material.MaterialParameters
    type Material = __materials_Material.Material
    type NormalMapTypes = Constants.NormalMapTypes

    type [<AllowNullLiteral>] IExports =
        abstract MeshToonMaterial: MeshToonMaterialStatic

    type [<AllowNullLiteral>] MeshToonMaterialParameters =
        inherit MaterialParameters
        /// geometry color in hexadecimal. Default is 0xffffff.
        abstract color: U3<Color, string, float> option with get, set
        abstract specular: U3<Color, string, float> option with get, set
        abstract shininess: float option with get, set
        abstract opacity: float option with get, set
        abstract gradientMap: Texture option with get, set
        abstract map: Texture option with get, set
        abstract lightMap: Texture option with get, set
        abstract lightMapIntensity: float option with get, set
        abstract aoMap: Texture option with get, set
        abstract aoMapIntensity: float option with get, set
        abstract emissive: U3<Color, string, float> option with get, set
        abstract emissiveIntensity: float option with get, set
        abstract emissiveMap: Texture option with get, set
        abstract bumpMap: Texture option with get, set
        abstract bumpScale: float option with get, set
        abstract normalMap: Texture option with get, set
        abstract normalMapType: NormalMapTypes option with get, set
        abstract normalScale: Vector2 option with get, set
        abstract displacementMap: Texture option with get, set
        abstract displacementScale: float option with get, set
        abstract displacementBias: float option with get, set
        abstract specularMap: Texture option with get, set
        abstract alphaMap: Texture option with get, set
        abstract wireframe: bool option with get, set
        abstract wireframeLinewidth: float option with get, set
        abstract wireframeLinecap: string option with get, set
        abstract wireframeLinejoin: string option with get, set
        abstract skinning: bool option with get, set
        abstract morphTargets: bool option with get, set
        abstract morphNormals: bool option with get, set

    type [<AllowNullLiteral>] MeshToonMaterial =
        inherit Material
        abstract color: Color with get, set
        abstract specular: Color with get, set
        abstract shininess: float with get, set
        abstract gradientMap: Texture option with get, set
        abstract map: Texture option with get, set
        abstract lightMap: Texture option with get, set
        abstract lightMapIntensity: float with get, set
        abstract aoMap: Texture option with get, set
        abstract aoMapIntensity: float with get, set
        abstract emissive: Color with get, set
        abstract emissiveIntensity: float with get, set
        abstract emissiveMap: Texture option with get, set
        abstract bumpMap: Texture option with get, set
        abstract bumpScale: float with get, set
        abstract normalMap: Texture option with get, set
        abstract normalMapType: NormalMapTypes with get, set
        abstract normalScale: Vector2 with get, set
        abstract displacementMap: Texture option with get, set
        abstract displacementScale: float with get, set
        abstract displacementBias: float with get, set
        abstract specularMap: Texture option with get, set
        abstract alphaMap: Texture option with get, set
        abstract wireframe: bool with get, set
        abstract wireframeLinewidth: float with get, set
        abstract wireframeLinecap: string with get, set
        abstract wireframeLinejoin: string with get, set
        abstract skinning: bool with get, set
        abstract morphTargets: bool with get, set
        abstract morphNormals: bool with get, set
        abstract setValues: parameters: MeshToonMaterialParameters -> unit

    type [<AllowNullLiteral>] MeshToonMaterialStatic =
        [<Emit "new $0($1...)">] abstract Create: ?parameters: MeshToonMaterialParameters -> MeshToonMaterial

module __materials_PointsMaterial =
    type Material = __materials_Material.Material
    type MaterialParameters = __materials_Material.MaterialParameters
    type Color = __math_Color.Color
    type Texture = __textures_Texture.Texture

    type [<AllowNullLiteral>] IExports =
        abstract MultiMaterial: MultiMaterialStatic
        abstract PointsMaterial: PointsMaterialStatic

    type [<AllowNullLiteral>] MultiMaterial =
        inherit Material
        abstract isMultiMaterial: obj with get, set
        abstract materials: ResizeArray<Material> with get, set
        abstract toJSON: meta: obj option -> obj option

    type [<AllowNullLiteral>] MultiMaterialStatic =
        [<Emit "new $0($1...)">] abstract Create: ?materials: ResizeArray<Material> -> MultiMaterial

    type [<AllowNullLiteral>] PointsMaterialParameters =
        inherit MaterialParameters
        abstract color: U3<Color, string, float> option with get, set
        abstract map: Texture option with get, set
        abstract alphaMap: Texture option with get, set
        abstract size: float option with get, set
        abstract sizeAttenuation: bool option with get, set

    type [<AllowNullLiteral>] PointsMaterial =
        inherit Material
        abstract color: Color with get, set
        abstract map: Texture option with get, set
        abstract alphaMap: Texture option with get, set
        abstract size: float with get, set
        abstract sizeAttenuation: bool with get, set
        abstract setValues: parameters: PointsMaterialParameters -> unit

    type [<AllowNullLiteral>] PointsMaterialStatic =
        [<Emit "new $0($1...)">] abstract Create: ?parameters: PointsMaterialParameters -> PointsMaterial

module __materials_RawShaderMaterial =
    type ShaderMaterialParameters = __materials_ShaderMaterial.ShaderMaterialParameters
    type ShaderMaterial = __materials_ShaderMaterial.ShaderMaterial

    type [<AllowNullLiteral>] IExports =
        abstract RawShaderMaterial: RawShaderMaterialStatic

    type [<AllowNullLiteral>] RawShaderMaterial =
        inherit ShaderMaterial

    type [<AllowNullLiteral>] RawShaderMaterialStatic =
        [<Emit "new $0($1...)">] abstract Create: ?parameters: ShaderMaterialParameters -> RawShaderMaterial

module __materials_ShaderMaterial =
    type IUniform = __renderers_shaders_UniformsLib.IUniform
    type MaterialParameters = __materials_Material.MaterialParameters
    type Material = __materials_Material.Material

    type [<AllowNullLiteral>] IExports =
        abstract ShaderMaterial: ShaderMaterialStatic

    type [<AllowNullLiteral>] ShaderMaterialParameters =
        inherit MaterialParameters
        abstract uniforms: obj option with get, set
        abstract vertexShader: string option with get, set
        abstract fragmentShader: string option with get, set
        abstract linewidth: float option with get, set
        abstract wireframe: bool option with get, set
        abstract wireframeLinewidth: float option with get, set
        abstract lights: bool option with get, set
        abstract clipping: bool option with get, set
        abstract skinning: bool option with get, set
        abstract morphTargets: bool option with get, set
        abstract morphNormals: bool option with get, set
        abstract extensions: ShaderMaterialParametersExtensions option with get, set

    type [<AllowNullLiteral>] ShaderMaterial =
        inherit Material
        abstract uniforms: ShaderMaterialUniforms with get, set
        abstract vertexShader: string with get, set
        abstract fragmentShader: string with get, set
        abstract linewidth: float with get, set
        abstract wireframe: bool with get, set
        abstract wireframeLinewidth: float with get, set
        abstract lights: bool with get, set
        abstract clipping: bool with get, set
        abstract skinning: bool with get, set
        abstract morphTargets: bool with get, set
        abstract morphNormals: bool with get, set
        abstract derivatives: obj option with get, set
        abstract extensions: ShaderMaterialExtensions with get, set
        abstract defaultAttributeValues: obj option with get, set
        abstract index0AttributeName: string option with get, set
        abstract setValues: parameters: ShaderMaterialParameters -> unit
        abstract toJSON: meta: obj option -> obj option

    type [<AllowNullLiteral>] ShaderMaterialStatic =
        [<Emit "new $0($1...)">] abstract Create: ?parameters: ShaderMaterialParameters -> ShaderMaterial

    type [<AllowNullLiteral>] ShaderMaterialParametersExtensions =
        abstract derivatives: bool option with get, set
        abstract fragDepth: bool option with get, set
        abstract drawBuffers: bool option with get, set
        abstract shaderTextureLOD: bool option with get, set

    type [<AllowNullLiteral>] ShaderMaterialUniforms =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: uniform: string -> IUniform with get, set

    type [<AllowNullLiteral>] ShaderMaterialExtensions =
        abstract derivatives: bool with get, set
        abstract fragDepth: bool with get, set
        abstract drawBuffers: bool with get, set
        abstract shaderTextureLOD: bool with get, set

module __materials_ShadowMaterial =
    type Color = __math_Color.Color
    type MaterialParameters = __materials_Material.MaterialParameters
    type Material = __materials_Material.Material

    type [<AllowNullLiteral>] IExports =
        abstract ShadowMaterial: ShadowMaterialStatic

    type [<AllowNullLiteral>] ShadowMaterialParameters =
        inherit MaterialParameters
        abstract color: U3<Color, string, float> option with get, set

    type [<AllowNullLiteral>] ShadowMaterial =
        inherit Material
        abstract color: Color with get, set

    type [<AllowNullLiteral>] ShadowMaterialStatic =
        [<Emit "new $0($1...)">] abstract Create: ?parameters: ShadowMaterialParameters -> ShadowMaterial

module __materials_SpriteMaterial =
    type Color = __math_Color.Color
    type Texture = __textures_Texture.Texture
    type MaterialParameters = __materials_Material.MaterialParameters
    type Material = __materials_Material.Material

    type [<AllowNullLiteral>] IExports =
        abstract SpriteMaterial: SpriteMaterialStatic

    type [<AllowNullLiteral>] SpriteMaterialParameters =
        inherit MaterialParameters
        abstract color: U3<Color, string, float> option with get, set
        abstract map: Texture option with get, set
        abstract alphaMap: Texture option with get, set
        abstract rotation: float option with get, set
        abstract sizeAttenuation: bool option with get, set

    type [<AllowNullLiteral>] SpriteMaterial =
        inherit Material
        abstract color: Color with get, set
        abstract map: Texture option with get, set
        abstract alphaMap: Texture option with get, set
        abstract rotation: float with get, set
        abstract sizeAttenuation: bool with get, set
        abstract isSpriteMaterial: obj with get, set
        abstract setValues: parameters: SpriteMaterialParameters -> unit
        abstract copy: source: SpriteMaterial -> SpriteMaterial

    type [<AllowNullLiteral>] SpriteMaterialStatic =
        [<Emit "new $0($1...)">] abstract Create: ?parameters: SpriteMaterialParameters -> SpriteMaterial

module __math_Box2 =
    type Vector2 = __math_Vector2.Vector2

    type [<AllowNullLiteral>] IExports =
        abstract Box2: Box2Static

    type [<AllowNullLiteral>] Box2 =
        abstract max: Vector2 with get, set
        abstract min: Vector2 with get, set
        abstract set: min: Vector2 * max: Vector2 -> Box2
        abstract setFromPoints: points: ResizeArray<Vector2> -> Box2
        abstract setFromCenterAndSize: center: Vector2 * size: Vector2 -> Box2
        abstract clone: unit -> Box2
        abstract copy: box: Box2 -> Box2
        abstract makeEmpty: unit -> Box2
        abstract isEmpty: unit -> bool
        abstract getCenter: target: Vector2 -> Vector2
        abstract getSize: target: Vector2 -> Vector2
        abstract expandByPoint: point: Vector2 -> Box2
        abstract expandByVector: vector: Vector2 -> Box2
        abstract expandByScalar: scalar: float -> Box2
        abstract containsPoint: point: Vector2 -> bool
        abstract containsBox: box: Box2 -> bool
        abstract getParameter: point: Vector2 -> Vector2
        abstract intersectsBox: box: Box2 -> bool
        abstract clampPoint: point: Vector2 * target: Vector2 -> Vector2
        abstract distanceToPoint: point: Vector2 -> float
        abstract intersect: box: Box2 -> Box2
        abstract union: box: Box2 -> Box2
        abstract translate: offset: Vector2 -> Box2
        abstract equals: box: Box2 -> bool
        abstract empty: unit -> obj option
        abstract isIntersectionBox: b: obj option -> obj option

    type [<AllowNullLiteral>] Box2Static =
        [<Emit "new $0($1...)">] abstract Create: ?min: Vector2 * ?max: Vector2 -> Box2

module __math_Box3 =
    type Vector3 = __math_Vector3.Vector3
    type Object3D = __core_Object3D.Object3D
    type Sphere = __math_Sphere.Sphere
    type Plane = __math_Plane.Plane
    type Matrix4 = __math_Matrix4.Matrix4
    type Triangle = __math_Triangle.Triangle

    type [<AllowNullLiteral>] IExports =
        abstract Box3: Box3Static

    type [<AllowNullLiteral>] Box3 =
        abstract max: Vector3 with get, set
        abstract min: Vector3 with get, set
        abstract set: min: Vector3 * max: Vector3 -> Box3
        abstract setFromArray: array: ArrayLike<float> -> Box3
        abstract setFromPoints: points: ResizeArray<Vector3> -> Box3
        abstract setFromCenterAndSize: center: Vector3 * size: Vector3 -> Box3
        abstract setFromObject: ``object``: Object3D -> Box3
        abstract clone: unit -> Box3
        abstract copy: box: Box3 -> Box3
        abstract makeEmpty: unit -> Box3
        abstract isEmpty: unit -> bool
        abstract getCenter: target: Vector3 -> Vector3
        abstract getSize: target: Vector3 -> Vector3
        abstract expandByPoint: point: Vector3 -> Box3
        abstract expandByVector: vector: Vector3 -> Box3
        abstract expandByScalar: scalar: float -> Box3
        abstract expandByObject: ``object``: Object3D -> Box3
        abstract containsPoint: point: Vector3 -> bool
        abstract containsBox: box: Box3 -> bool
        abstract getParameter: point: Vector3 -> Vector3
        abstract intersectsBox: box: Box3 -> bool
        abstract intersectsSphere: sphere: Sphere -> bool
        abstract intersectsPlane: plane: Plane -> bool
        abstract intersectsTriangle: triangle: Triangle -> bool
        abstract clampPoint: point: Vector3 * target: Vector3 -> Vector3
        abstract distanceToPoint: point: Vector3 -> float
        abstract getBoundingSphere: target: Sphere -> Sphere
        abstract intersect: box: Box3 -> Box3
        abstract union: box: Box3 -> Box3
        abstract applyMatrix4: matrix: Matrix4 -> Box3
        abstract translate: offset: Vector3 -> Box3
        abstract equals: box: Box3 -> bool
        abstract empty: unit -> obj option
        abstract isIntersectionBox: b: obj option -> obj option
        abstract isIntersectionSphere: s: obj option -> obj option

    type [<AllowNullLiteral>] Box3Static =
        [<Emit "new $0($1...)">] abstract Create: ?min: Vector3 * ?max: Vector3 -> Box3

module __math_Color =

    type [<AllowNullLiteral>] IExports =
        abstract Color: ColorStatic

    type [<AllowNullLiteral>] HSL =
        abstract h: float with get, set
        abstract s: float with get, set
        abstract l: float with get, set

    /// Represents a color. See also {@link ColorUtils}.
    type [<AllowNullLiteral>] Color =
        abstract isColor: bool with get, set
        /// Red channel value between 0 and 1. Default is 1.
        abstract r: float with get, set
        /// Green channel value between 0 and 1. Default is 1.
        abstract g: float with get, set
        /// Blue channel value between 0 and 1. Default is 1.
        abstract b: float with get, set
        abstract set: color: Color -> Color
        abstract set: color: float -> Color
        abstract set: color: string -> Color
        abstract setScalar: scalar: float -> Color
        abstract setHex: hex: float -> Color
        /// <summary>Sets this color from RGB values.</summary>
        /// <param name="r">Red channel value between 0 and 1.</param>
        /// <param name="g">Green channel value between 0 and 1.</param>
        /// <param name="b">Blue channel value between 0 and 1.</param>
        abstract setRGB: r: float * g: float * b: float -> Color
        /// <summary>Sets this color from HSL values.
        /// Based on MochiKit implementation by Bob Ippolito.</summary>
        /// <param name="h">Hue channel value between 0 and 1.</param>
        /// <param name="s">Saturation value channel between 0 and 1.</param>
        /// <param name="l">Value channel value between 0 and 1.</param>
        abstract setHSL: h: float * s: float * l: float -> Color
        /// Sets this color from a CSS context style string.
        abstract setStyle: style: string -> Color
        /// <summary>Sets this color from a color name.
        /// Faster than {@link Color#setStyle .setStyle()} method if you don't need the other CSS-style formats.</summary>
        /// <param name="style">Color name in X11 format.</param>
        abstract setColorName: style: string -> Color
        /// Clones this color.
        abstract clone: unit -> Color
        /// <summary>Copies given color.</summary>
        /// <param name="color">Color to copy.</param>
        abstract copy: color: Color -> Color
        /// <summary>Copies given color making conversion from gamma to linear space.</summary>
        /// <param name="color">Color to copy.</param>
        abstract copyGammaToLinear: color: Color * ?gammaFactor: float -> Color
        /// <summary>Copies given color making conversion from linear to gamma space.</summary>
        /// <param name="color">Color to copy.</param>
        abstract copyLinearToGamma: color: Color * ?gammaFactor: float -> Color
        /// Converts this color from gamma to linear space.
        abstract convertGammaToLinear: ?gammaFactor: float -> Color
        /// Converts this color from linear to gamma space.
        abstract convertLinearToGamma: ?gammaFactor: float -> Color
        /// <summary>Copies given color making conversion from sRGB to linear space.</summary>
        /// <param name="color">Color to copy.</param>
        abstract copySRGBToLinear: color: Color -> Color
        /// <summary>Copies given color making conversion from linear to sRGB space.</summary>
        /// <param name="color">Color to copy.</param>
        abstract copyLinearToSRGB: color: Color -> Color
        /// Converts this color from sRGB to linear space.
        abstract convertSRGBToLinear: unit -> Color
        /// Converts this color from linear to sRGB space.
        abstract convertLinearToSRGB: unit -> Color
        /// Returns the hexadecimal value of this color.
        abstract getHex: unit -> float
        /// Returns the string formated hexadecimal value of this color.
        abstract getHexString: unit -> string
        abstract getHSL: target: HSL -> HSL
        /// Returns the value of this color in CSS context style.
        /// Example: rgb(r, g, b)
        abstract getStyle: unit -> string
        abstract offsetHSL: h: float * s: float * l: float -> Color
        abstract add: color: Color -> Color
        abstract addColors: color1: Color * color2: Color -> Color
        abstract addScalar: s: float -> Color
        abstract sub: color: Color -> Color
        abstract multiply: color: Color -> Color
        abstract multiplyScalar: s: float -> Color
        abstract lerp: color: Color * alpha: float -> Color
        abstract lerpHSL: color: Color * alpha: float -> Color
        abstract equals: color: Color -> bool
        /// <summary>Sets this color's red, green and blue value from the provided array.</summary>
        /// <param name="array">the source array.</param>
        /// <param name="offset">(optional) offset into the array. Default is 0.</param>
        abstract fromArray: array: ResizeArray<float> * ?offset: float -> Color
        /// <summary>Sets this color's red, green and blue value from the provided array-like.</summary>
        /// <param name="array">the source array-like.</param>
        /// <param name="offset">(optional) offset into the array-like. Default is 0.</param>
        abstract fromArray: array: ArrayLike<float> * ?offset: float -> Color
        /// <summary>Returns an array [red, green, blue], or copies red, green and blue into the provided array.</summary>
        /// <param name="array">(optional) array to store the color to. If this is not provided, a new array will be created.</param>
        /// <param name="offset">(optional) optional offset into the array.</param>
        abstract toArray: ?array: ResizeArray<float> * ?offset: float -> ResizeArray<float>
        /// <summary>Copies red, green and blue into the provided array-like.</summary>
        /// <param name="offset">(optional) optional offset into the array-like.</param>
        abstract toArray: xyz: ArrayLike<float> * ?offset: float -> ArrayLike<float>

    /// Represents a color. See also {@link ColorUtils}.
    type [<AllowNullLiteral>] ColorStatic =
        [<Emit "new $0($1...)">] abstract Create: ?color: U3<Color, string, float> -> Color
        [<Emit "new $0($1...)">] abstract Create: r: float * g: float * b: float -> Color
        /// List of X11 color names.
        abstract NAMES: Record<string, float> with get, set

module __math_Cylindrical =
    type Vector3 = __math_Vector3.Vector3

    type [<AllowNullLiteral>] IExports =
        abstract Cylindrical: CylindricalStatic

    type [<AllowNullLiteral>] Cylindrical =
        abstract radius: float with get, set
        abstract theta: float with get, set
        abstract y: float with get, set
        abstract clone: unit -> Cylindrical
        abstract copy: other: Cylindrical -> Cylindrical
        abstract set: radius: float * theta: float * y: float -> Cylindrical
        abstract setFromVector3: vec3: Vector3 -> Cylindrical
        abstract setFromCartesianCoords: x: float * y: float * z: float -> Cylindrical

    type [<AllowNullLiteral>] CylindricalStatic =
        [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?theta: float * ?y: float -> Cylindrical

module __math_Euler =
    type Matrix4 = __math_Matrix4.Matrix4
    type Quaternion = __math_Quaternion.Quaternion
    type Vector3 = __math_Vector3.Vector3

    type [<AllowNullLiteral>] IExports =
        abstract Euler: EulerStatic

    type [<AllowNullLiteral>] Euler =
        abstract x: float with get, set
        abstract y: float with get, set
        abstract z: float with get, set
        abstract order: string with get, set
        abstract _onChangeCallback: Function with get, set
        abstract set: x: float * y: float * z: float * ?order: string -> Euler
        abstract clone: unit -> Euler
        abstract copy: euler: Euler -> Euler
        abstract setFromRotationMatrix: m: Matrix4 * ?order: string -> Euler
        abstract setFromQuaternion: q: Quaternion * ?order: string -> Euler
        abstract setFromVector3: v: Vector3 * ?order: string -> Euler
        abstract reorder: newOrder: string -> Euler
        abstract equals: euler: Euler -> bool
        abstract fromArray: xyzo: ResizeArray<obj option> -> Euler
        abstract toArray: ?array: ResizeArray<float> * ?offset: float -> ResizeArray<float>
        abstract toVector3: ?optionalResult: Vector3 -> Vector3
        abstract _onChange: callback: Function -> Euler

    type [<AllowNullLiteral>] EulerStatic =
        [<Emit "new $0($1...)">] abstract Create: ?x: float * ?y: float * ?z: float * ?order: string -> Euler
        abstract RotationOrders: ResizeArray<string> with get, set
        abstract DefaultOrder: string with get, set

module __math_Frustum =
    type Plane = __math_Plane.Plane
    type Matrix4 = __math_Matrix4.Matrix4
    type Object3D = __core_Object3D.Object3D
    type Sprite = __objects_Sprite.Sprite
    type Sphere = __math_Sphere.Sphere
    type Box3 = __math_Box3.Box3
    type Vector3 = __math_Vector3.Vector3

    type [<AllowNullLiteral>] IExports =
        abstract Frustum: FrustumStatic

    /// Frustums are used to determine what is inside the camera's field of view. They help speed up the rendering process.
    type [<AllowNullLiteral>] Frustum =
        /// Array of 6 vectors.
        abstract planes: ResizeArray<Plane> with get, set
        abstract set: p0: Plane * p1: Plane * p2: Plane * p3: Plane * p4: Plane * p5: Plane -> Frustum
        abstract clone: unit -> Frustum
        abstract copy: frustum: Frustum -> Frustum
        abstract setFromMatrix: m: Matrix4 -> Frustum
        abstract intersectsObject: ``object``: Object3D -> bool
        abstract intersectsSprite: sprite: Sprite -> bool
        abstract intersectsSphere: sphere: Sphere -> bool
        abstract intersectsBox: box: Box3 -> bool
        abstract containsPoint: point: Vector3 -> bool

    /// Frustums are used to determine what is inside the camera's field of view. They help speed up the rendering process.
    type [<AllowNullLiteral>] FrustumStatic =
        [<Emit "new $0($1...)">] abstract Create: ?p0: Plane * ?p1: Plane * ?p2: Plane * ?p3: Plane * ?p4: Plane * ?p5: Plane -> Frustum

module __math_Interpolant =

    type [<AllowNullLiteral>] IExports =
        abstract Interpolant: InterpolantStatic

    type [<AllowNullLiteral>] Interpolant =
        abstract parameterPositions: obj option with get, set
        abstract sampleValues: obj option with get, set
        abstract valueSize: float with get, set
        abstract resultBuffer: obj option with get, set
        abstract evaluate: time: float -> obj option

    type [<AllowNullLiteral>] InterpolantStatic =
        [<Emit "new $0($1...)">] abstract Create: parameterPositions: obj option * sampleValues: obj option * sampleSize: float * ?resultBuffer: obj -> Interpolant

module __math_Line3 =
    type Vector3 = __math_Vector3.Vector3
    type Matrix4 = __math_Matrix4.Matrix4

    type [<AllowNullLiteral>] IExports =
        abstract Line3: Line3Static

    type [<AllowNullLiteral>] Line3 =
        abstract start: Vector3 with get, set
        abstract ``end``: Vector3 with get, set
        abstract set: ?start: Vector3 * ?``end``: Vector3 -> Line3
        abstract clone: unit -> Line3
        abstract copy: line: Line3 -> Line3
        abstract getCenter: target: Vector3 -> Vector3
        abstract delta: target: Vector3 -> Vector3
        abstract distanceSq: unit -> float
        abstract distance: unit -> float
        abstract at: t: float * target: Vector3 -> Vector3
        abstract closestPointToPointParameter: point: Vector3 * ?clampToLine: bool -> float
        abstract closestPointToPoint: point: Vector3 * clampToLine: bool * target: Vector3 -> Vector3
        abstract applyMatrix4: matrix: Matrix4 -> Line3
        abstract equals: line: Line3 -> bool

    type [<AllowNullLiteral>] Line3Static =
        [<Emit "new $0($1...)">] abstract Create: ?start: Vector3 * ?``end``: Vector3 -> Line3

module __math_Math =
    let [<Import("_Math","three/math/Math")>] _Math: _Math.IExports = jsNative

    module _Math =

        type [<AllowNullLiteral>] IExports =
            abstract DEG2RAD: float
            abstract RAD2DEG: float
            abstract generateUUID: unit -> string
            /// <summary>Clamps the x to be between a and b.</summary>
            /// <param name="value">Value to be clamped.</param>
            /// <param name="min">Minimum value</param>
            /// <param name="max">Maximum value.</param>
            abstract clamp: value: float * min: float * max: float -> float
            abstract euclideanModulo: n: float * m: float -> float
            /// <summary>Linear mapping of x from range [a1, a2] to range [b1, b2].</summary>
            /// <param name="x">Value to be mapped.</param>
            /// <param name="a1">Minimum value for range A.</param>
            /// <param name="a2">Maximum value for range A.</param>
            /// <param name="b1">Minimum value for range B.</param>
            /// <param name="b2">Maximum value for range B.</param>
            abstract mapLinear: x: float * a1: float * a2: float * b1: float * b2: float -> float
            abstract smoothstep: x: float * min: float * max: float -> float
            abstract smootherstep: x: float * min: float * max: float -> float
            /// Random float from 0 to 1 with 16 bits of randomness.
            /// Standard Math.random() creates repetitive patterns when applied over larger space.
            abstract random16: unit -> float
            /// Random integer from low to high interval.
            abstract randInt: low: float * high: float -> float
            /// Random float from low to high interval.
            abstract randFloat: low: float * high: float -> float
            /// Random float from - range / 2 to range / 2 interval.
            abstract randFloatSpread: range: float -> float
            abstract degToRad: degrees: float -> float
            abstract radToDeg: radians: float -> float
            abstract isPowerOfTwo: value: float -> bool
            /// <summary>Returns a value linearly interpolated from two known points based
            /// on the given interval - t = 0 will return x and t = 1 will return y.</summary>
            /// <param name="x">Start point.</param>
            /// <param name="y">End point.</param>
            /// <param name="t">interpolation factor in the closed interval [0, 1]</param>
            abstract lerp: x: float * y: float * t: float -> float
            abstract nearestPowerOfTwo: value: float -> float
            abstract nextPowerOfTwo: value: float -> float
            abstract floorPowerOfTwo: value: float -> float
            abstract ceilPowerOfTwo: value: float -> float

module __math_Matrix3 =
    type Matrix4 = __math_Matrix4.Matrix4
    type BufferAttribute = __core_BufferAttribute.BufferAttribute
    type Vector3 = __math_Vector3.Vector3

    type [<AllowNullLiteral>] IExports =
        abstract Matrix3: Matrix3Static

    /// ( interface Matrix&lt;T&gt; )
    type [<AllowNullLiteral>] Matrix =
        /// Array with matrix values.
        abstract elements: ResizeArray<float> with get, set
        /// identity():T;
        abstract identity: unit -> Matrix
        /// copy(m:T):T;
        abstract copy: m: Matrix -> Matrix
        /// multiplyScalar(s:number):T;
        abstract multiplyScalar: s: float -> Matrix
        abstract determinant: unit -> float
        /// getInverse(matrix:T, throwOnInvertible?:boolean):T;
        abstract getInverse: matrix: Matrix * ?throwOnInvertible: bool -> Matrix
        /// transpose():T;
        abstract transpose: unit -> Matrix
        /// clone():T;
        abstract clone: unit -> Matrix

    /// ( class Matrix3 implements Matrix&lt;Matrix3&gt; )
    type [<AllowNullLiteral>] Matrix3 =
        inherit Matrix
        /// Array with matrix values.
        abstract elements: ResizeArray<float> with get, set
        abstract set: n11: float * n12: float * n13: float * n21: float * n22: float * n23: float * n31: float * n32: float * n33: float -> Matrix3
        /// identity():T;
        abstract identity: unit -> Matrix3
        /// clone():T;
        abstract clone: unit -> Matrix3
        /// copy(m:T):T;
        abstract copy: m: Matrix3 -> Matrix3
        abstract setFromMatrix4: m: Matrix4 -> Matrix3
        abstract applyToBuffer: buffer: BufferAttribute * ?offset: float * ?length: float -> BufferAttribute
        abstract applyToBufferAttribute: attribute: BufferAttribute -> BufferAttribute
        /// multiplyScalar(s:number):T;
        abstract multiplyScalar: s: float -> Matrix3
        abstract determinant: unit -> float
        /// getInverse(matrix:T, throwOnInvertible?:boolean):T;
        abstract getInverse: matrix: Matrix3 * ?throwOnDegenerate: bool -> Matrix3
        /// Transposes this matrix in place.
        abstract transpose: unit -> Matrix3
        abstract getNormalMatrix: matrix4: Matrix4 -> Matrix3
        /// Transposes this matrix into the supplied array r, and returns itself.
        abstract transposeIntoArray: r: ResizeArray<float> -> ResizeArray<float>
        abstract setUvTransform: tx: float * ty: float * sx: float * sy: float * rotation: float * cx: float * cy: float -> Matrix3
        abstract scale: sx: float * sy: float -> Matrix3
        abstract rotate: theta: float -> Matrix3
        abstract translate: tx: float * ty: float -> Matrix3
        abstract equals: matrix: Matrix3 -> bool
        /// <summary>Sets the values of this matrix from the provided array.</summary>
        /// <param name="array">the source array.</param>
        /// <param name="offset">(optional) offset into the array. Default is 0.</param>
        abstract fromArray: array: ResizeArray<float> * ?offset: float -> Matrix3
        /// <summary>Sets the values of this matrix from the provided array-like.</summary>
        /// <param name="array">the source array-like.</param>
        /// <param name="offset">(optional) offset into the array-like. Default is 0.</param>
        abstract fromArray: array: ArrayLike<float> * ?offset: float -> Matrix3
        /// <summary>Returns an array with the values of this matrix, or copies them into the provided array.</summary>
        /// <param name="array">(optional) array to store the matrix to. If this is not provided, a new array will be created.</param>
        /// <param name="offset">(optional) optional offset into the array.</param>
        abstract toArray: ?array: ResizeArray<float> * ?offset: float -> ResizeArray<float>
        /// <summary>Copies he values of this matrix into the provided array-like.</summary>
        /// <param name="array">array-like to store the matrix to.</param>
        /// <param name="offset">(optional) optional offset into the array-like.</param>
        abstract toArray: ?array: ArrayLike<float> * ?offset: float -> ArrayLike<float>
        /// Multiplies this matrix by m.
        abstract multiply: m: Matrix3 -> Matrix3
        abstract premultiply: m: Matrix3 -> Matrix3
        /// Sets this matrix to a x b.
        abstract multiplyMatrices: a: Matrix3 * b: Matrix3 -> Matrix3
        abstract multiplyVector3: vector: Vector3 -> obj option
        abstract multiplyVector3Array: a: obj option -> obj option
        /// getInverse(matrix:T, throwOnInvertible?:boolean):T;
        abstract getInverse: matrix: Matrix4 * ?throwOnDegenerate: bool -> Matrix3
        abstract flattenToArrayOffset: array: ResizeArray<float> * offset: float -> ResizeArray<float>

    /// ( class Matrix3 implements Matrix&lt;Matrix3&gt; )
    type [<AllowNullLiteral>] Matrix3Static =
        /// Creates an identity matrix.
        [<Emit "new $0($1...)">] abstract Create: unit -> Matrix3

module __math_Matrix4 =
    type Vector3 = __math_Vector3.Vector3
    type Euler = __math_Euler.Euler
    type Quaternion = __math_Quaternion.Quaternion
    type BufferAttribute = __core_BufferAttribute.BufferAttribute
    type Matrix = __math_Matrix3.Matrix

    type [<AllowNullLiteral>] IExports =
        abstract Matrix4: Matrix4Static

    /// A 4x4 Matrix.
    type [<AllowNullLiteral>] Matrix4 =
        inherit Matrix
        /// Array with matrix values.
        abstract elements: ResizeArray<float> with get, set
        /// Sets all fields of this matrix.
        abstract set: n11: float * n12: float * n13: float * n14: float * n21: float * n22: float * n23: float * n24: float * n31: float * n32: float * n33: float * n34: float * n41: float * n42: float * n43: float * n44: float -> Matrix4
        /// Resets this matrix to identity.
        abstract identity: unit -> Matrix4
        abstract clone: unit -> Matrix4
        abstract copy: m: Matrix4 -> Matrix4
        abstract copyPosition: m: Matrix4 -> Matrix4
        abstract extractBasis: xAxis: Vector3 * yAxis: Vector3 * zAxis: Vector3 -> Matrix4
        abstract makeBasis: xAxis: Vector3 * yAxis: Vector3 * zAxis: Vector3 -> Matrix4
        /// Copies the rotation component of the supplied matrix m into this matrix rotation component.
        abstract extractRotation: m: Matrix4 -> Matrix4
        abstract makeRotationFromEuler: euler: Euler -> Matrix4
        abstract makeRotationFromQuaternion: q: Quaternion -> Matrix4
        /// Constructs a rotation matrix, looking from eye towards center with defined up vector.
        abstract lookAt: eye: Vector3 * target: Vector3 * up: Vector3 -> Matrix4
        /// Multiplies this matrix by m.
        abstract multiply: m: Matrix4 -> Matrix4
        abstract premultiply: m: Matrix4 -> Matrix4
        /// Sets this matrix to a x b.
        abstract multiplyMatrices: a: Matrix4 * b: Matrix4 -> Matrix4
        /// Sets this matrix to a x b and stores the result into the flat array r.
        /// r can be either a regular Array or a TypedArray.
        abstract multiplyToArray: a: Matrix4 * b: Matrix4 * r: ResizeArray<float> -> Matrix4
        /// Multiplies this matrix by s.
        abstract multiplyScalar: s: float -> Matrix4
        abstract applyToBuffer: buffer: BufferAttribute * ?offset: float * ?length: float -> BufferAttribute
        abstract applyToBufferAttribute: attribute: BufferAttribute -> BufferAttribute
        /// Computes determinant of this matrix.
        /// Based on http://www.euclideanspace.com/maths/algebra/matrix/functions/inverse/fourD/index.htm
        abstract determinant: unit -> float
        /// Transposes this matrix.
        abstract transpose: unit -> Matrix4
        /// Sets the position component for this matrix from vector v.
        abstract setPosition: v: U2<Vector3, float> * ?y: float * ?z: float -> Matrix4
        /// Sets this matrix to the inverse of matrix m.
        /// Based on http://www.euclideanspace.com/maths/algebra/matrix/functions/inverse/fourD/index.htm.
        abstract getInverse: m: Matrix4 * ?throwOnDegeneratee: bool -> Matrix4
        /// Multiplies the columns of this matrix by vector v.
        abstract scale: v: Vector3 -> Matrix4
        abstract getMaxScaleOnAxis: unit -> float
        /// Sets this matrix as translation transform.
        abstract makeTranslation: x: float * y: float * z: float -> Matrix4
        /// <summary>Sets this matrix as rotation transform around x axis by theta radians.</summary>
        /// <param name="theta">Rotation angle in radians.</param>
        abstract makeRotationX: theta: float -> Matrix4
        /// <summary>Sets this matrix as rotation transform around y axis by theta radians.</summary>
        /// <param name="theta">Rotation angle in radians.</param>
        abstract makeRotationY: theta: float -> Matrix4
        /// <summary>Sets this matrix as rotation transform around z axis by theta radians.</summary>
        /// <param name="theta">Rotation angle in radians.</param>
        abstract makeRotationZ: theta: float -> Matrix4
        /// <summary>Sets this matrix as rotation transform around axis by angle radians.
        /// Based on http://www.gamedev.net/reference/articles/article1199.asp.</summary>
        /// <param name="axis">Rotation axis.</param>
        abstract makeRotationAxis: axis: Vector3 * angle: float -> Matrix4
        /// Sets this matrix as scale transform.
        abstract makeScale: x: float * y: float * z: float -> Matrix4
        /// Sets this matrix to the transformation composed of translation, rotation and scale.
        abstract compose: translation: Vector3 * rotation: Quaternion * scale: Vector3 -> Matrix4
        /// Decomposes this matrix into the translation, rotation and scale components.
        /// If parameters are not passed, new instances will be created.
        abstract decompose: ?translation: Vector3 * ?rotation: Quaternion * ?scale: Vector3 -> ResizeArray<Object>
        /// Creates a frustum matrix.
        abstract makePerspective: left: float * right: float * bottom: float * top: float * near: float * far: float -> Matrix4
        /// Creates a perspective projection matrix.
        abstract makePerspective: fov: float * aspect: float * near: float * far: float -> Matrix4
        /// Creates an orthographic projection matrix.
        abstract makeOrthographic: left: float * right: float * top: float * bottom: float * near: float * far: float -> Matrix4
        abstract equals: matrix: Matrix4 -> bool
        /// <summary>Sets the values of this matrix from the provided array.</summary>
        /// <param name="array">the source array.</param>
        /// <param name="offset">(optional) offset into the array. Default is 0.</param>
        abstract fromArray: array: ResizeArray<float> * ?offset: float -> Matrix4
        /// <summary>Sets the values of this matrix from the provided array-like.</summary>
        /// <param name="array">the source array-like.</param>
        /// <param name="offset">(optional) offset into the array-like. Default is 0.</param>
        abstract fromArray: array: ArrayLike<float> * ?offset: float -> Matrix4
        /// <summary>Returns an array with the values of this matrix, or copies them into the provided array.</summary>
        /// <param name="array">(optional) array to store the matrix to. If this is not provided, a new array will be created.</param>
        /// <param name="offset">(optional) optional offset into the array.</param>
        abstract toArray: ?array: ResizeArray<float> * ?offset: float -> ResizeArray<float>
        /// <summary>Copies he values of this matrix into the provided array-like.</summary>
        /// <param name="array">array-like to store the matrix to.</param>
        /// <param name="offset">(optional) optional offset into the array-like.</param>
        abstract toArray: ?array: ArrayLike<float> * ?offset: float -> ArrayLike<float>
        abstract extractPosition: m: Matrix4 -> Matrix4
        abstract setRotationFromQuaternion: q: Quaternion -> Matrix4
        abstract multiplyVector3: v: obj option -> obj option
        abstract multiplyVector4: v: obj option -> obj option
        abstract multiplyVector3Array: array: ResizeArray<float> -> ResizeArray<float>
        abstract rotateAxis: v: obj option -> unit
        abstract crossVector: v: obj option -> unit
        abstract flattenToArrayOffset: array: ResizeArray<float> * offset: float -> ResizeArray<float>

    /// A 4x4 Matrix.
    type [<AllowNullLiteral>] Matrix4Static =
        [<Emit "new $0($1...)">] abstract Create: unit -> Matrix4

module __math_Plane =
    type Vector3 = __math_Vector3.Vector3
    type Sphere = __math_Sphere.Sphere
    type Line3 = __math_Line3.Line3
    type Box3 = __math_Box3.Box3
    type Matrix4 = __math_Matrix4.Matrix4
    type Matrix3 = __math_Matrix3.Matrix3

    type [<AllowNullLiteral>] IExports =
        abstract Plane: PlaneStatic

    type [<AllowNullLiteral>] Plane =
        abstract normal: Vector3 with get, set
        abstract constant: float with get, set
        abstract set: normal: Vector3 * constant: float -> Plane
        abstract setComponents: x: float * y: float * z: float * w: float -> Plane
        abstract setFromNormalAndCoplanarPoint: normal: Vector3 * point: Vector3 -> Plane
        abstract setFromCoplanarPoints: a: Vector3 * b: Vector3 * c: Vector3 -> Plane
        abstract clone: unit -> Plane
        abstract copy: plane: Plane -> Plane
        abstract normalize: unit -> Plane
        abstract negate: unit -> Plane
        abstract distanceToPoint: point: Vector3 -> float
        abstract distanceToSphere: sphere: Sphere -> float
        abstract projectPoint: point: Vector3 * target: Vector3 -> Vector3
        abstract orthoPoint: point: Vector3 * target: Vector3 -> Vector3
        abstract intersectLine: line: Line3 * target: Vector3 -> Vector3 option
        abstract intersectsLine: line: Line3 -> bool
        abstract intersectsBox: box: Box3 -> bool
        abstract intersectsSphere: sphere: Sphere -> bool
        abstract coplanarPoint: target: Vector3 -> Vector3
        abstract applyMatrix4: matrix: Matrix4 * ?optionalNormalMatrix: Matrix3 -> Plane
        abstract translate: offset: Vector3 -> Plane
        abstract equals: plane: Plane -> bool
        abstract isIntersectionLine: l: obj option -> obj option

    type [<AllowNullLiteral>] PlaneStatic =
        [<Emit "new $0($1...)">] abstract Create: ?normal: Vector3 * ?constant: float -> Plane

module __math_Quaternion =
    type Euler = __math_Euler.Euler
    type Vector3 = __math_Vector3.Vector3
    type Matrix4 = __math_Matrix4.Matrix4

    type [<AllowNullLiteral>] IExports =
        abstract Quaternion: QuaternionStatic

    /// Implementation of a quaternion. This is used for rotating things without incurring in the dreaded gimbal lock issue, amongst other advantages.
    type [<AllowNullLiteral>] Quaternion =
        abstract x: float with get, set
        abstract y: float with get, set
        abstract z: float with get, set
        abstract w: float with get, set
        /// Sets values of this quaternion.
        abstract set: x: float * y: float * z: float * w: float -> Quaternion
        /// Clones this quaternion.
        abstract clone: unit -> Quaternion
        /// Copies values of q to this quaternion.
        abstract copy: q: Quaternion -> Quaternion
        /// Sets this quaternion from rotation specified by Euler angles.
        abstract setFromEuler: euler: Euler -> Quaternion
        /// Sets this quaternion from rotation specified by axis and angle.
        /// Adapted from http://www.euclideanspace.com/maths/geometry/rotations/conversions/angleToQuaternion/index.htm.
        /// Axis have to be normalized, angle is in radians.
        abstract setFromAxisAngle: axis: Vector3 * angle: float -> Quaternion
        /// Sets this quaternion from rotation component of m. Adapted from http://www.euclideanspace.com/maths/geometry/rotations/conversions/matrixToQuaternion/index.htm.
        abstract setFromRotationMatrix: m: Matrix4 -> Quaternion
        abstract setFromUnitVectors: vFrom: Vector3 * vTo: Vector3 -> Quaternion
        abstract angleTo: q: Quaternion -> float
        abstract rotateTowards: q: Quaternion * step: float -> Quaternion
        /// Inverts this quaternion.
        abstract inverse: unit -> Quaternion
        abstract conjugate: unit -> Quaternion
        abstract dot: v: Quaternion -> float
        abstract lengthSq: unit -> float
        /// Computes length of this quaternion.
        abstract length: unit -> float
        /// Normalizes this quaternion.
        abstract normalize: unit -> Quaternion
        /// Multiplies this quaternion by b.
        abstract multiply: q: Quaternion -> Quaternion
        abstract premultiply: q: Quaternion -> Quaternion
        /// Sets this quaternion to a x b
        /// Adapted from http://www.euclideanspace.com/maths/algebra/realNormedAlgebra/quaternions/code/index.htm.
        abstract multiplyQuaternions: a: Quaternion * b: Quaternion -> Quaternion
        abstract slerp: qb: Quaternion * t: float -> Quaternion
        abstract equals: v: Quaternion -> bool
        /// <summary>Sets this quaternion's x, y, z and w value from the provided array.</summary>
        /// <param name="array">the source array.</param>
        /// <param name="offset">(optional) offset into the array. Default is 0.</param>
        abstract fromArray: array: ResizeArray<float> * ?offset: float -> Quaternion
        /// <summary>Sets this quaternion's x, y, z and w value from the provided array-like.</summary>
        /// <param name="array">the source array-like.</param>
        /// <param name="offset">(optional) offset into the array-like. Default is 0.</param>
        abstract fromArray: array: ArrayLike<float> * ?offset: float -> Quaternion
        /// <summary>Returns an array [x, y, z, w], or copies x, y, z and w into the provided array.</summary>
        /// <param name="array">(optional) array to store the quaternion to. If this is not provided, a new array will be created.</param>
        /// <param name="offset">(optional) optional offset into the array.</param>
        abstract toArray: ?array: ResizeArray<float> * ?offset: float -> ResizeArray<float>
        /// <summary>Copies x, y, z and w into the provided array-like.</summary>
        /// <param name="array">array-like to store the quaternion to.</param>
        /// <param name="offset">(optional) optional offset into the array.</param>
        abstract toArray: array: ArrayLike<float> * ?offset: float -> ArrayLike<float>
        abstract _onChange: callback: Function -> Quaternion
        abstract _onChangeCallback: Function with get, set
        abstract multiplyVector3: v: obj option -> obj option

    /// Implementation of a quaternion. This is used for rotating things without incurring in the dreaded gimbal lock issue, amongst other advantages.
    type [<AllowNullLiteral>] QuaternionStatic =
        /// <param name="x">x coordinate</param>
        /// <param name="y">y coordinate</param>
        /// <param name="z">z coordinate</param>
        /// <param name="w">w coordinate</param>
        [<Emit "new $0($1...)">] abstract Create: ?x: float * ?y: float * ?z: float * ?w: float -> Quaternion
        /// Adapted from http://www.euclideanspace.com/maths/algebra/realNormedAlgebra/quaternions/slerp/.
        abstract slerp: qa: Quaternion * qb: Quaternion * qm: Quaternion * t: float -> Quaternion
        abstract slerpFlat: dst: ResizeArray<float> * dstOffset: float * src0: ResizeArray<float> * srcOffset: float * src1: ResizeArray<float> * stcOffset1: float * t: float -> Quaternion

module __math_Ray =
    type Vector3 = __math_Vector3.Vector3
    type Sphere = __math_Sphere.Sphere
    type Plane = __math_Plane.Plane
    type Box3 = __math_Box3.Box3
    type Matrix4 = __math_Matrix4.Matrix4

    type [<AllowNullLiteral>] IExports =
        abstract Ray: RayStatic

    type [<AllowNullLiteral>] Ray =
        abstract origin: Vector3 with get, set
        abstract direction: Vector3 with get, set
        abstract set: origin: Vector3 * direction: Vector3 -> Ray
        abstract clone: unit -> Ray
        abstract copy: ray: Ray -> Ray
        abstract at: t: float * target: Vector3 -> Vector3
        abstract lookAt: v: Vector3 -> Vector3
        abstract recast: t: float -> Ray
        abstract closestPointToPoint: point: Vector3 * target: Vector3 -> Vector3
        abstract distanceToPoint: point: Vector3 -> float
        abstract distanceSqToPoint: point: Vector3 -> float
        abstract distanceSqToSegment: v0: Vector3 * v1: Vector3 * ?optionalPointOnRay: Vector3 * ?optionalPointOnSegment: Vector3 -> float
        abstract intersectSphere: sphere: Sphere * target: Vector3 -> Vector3 option
        abstract intersectsSphere: sphere: Sphere -> bool
        abstract distanceToPlane: plane: Plane -> float
        abstract intersectPlane: plane: Plane * target: Vector3 -> Vector3 option
        abstract intersectsPlane: plane: Plane -> bool
        abstract intersectBox: box: Box3 * target: Vector3 -> Vector3 option
        abstract intersectsBox: box: Box3 -> bool
        abstract intersectTriangle: a: Vector3 * b: Vector3 * c: Vector3 * backfaceCulling: bool * target: Vector3 -> Vector3 option
        abstract applyMatrix4: matrix4: Matrix4 -> Ray
        abstract equals: ray: Ray -> bool
        abstract isIntersectionBox: b: obj option -> obj option
        abstract isIntersectionPlane: p: obj option -> obj option
        abstract isIntersectionSphere: s: obj option -> obj option

    type [<AllowNullLiteral>] RayStatic =
        [<Emit "new $0($1...)">] abstract Create: ?origin: Vector3 * ?direction: Vector3 -> Ray

module __math_Sphere =
    type Vector3 = __math_Vector3.Vector3
    type Box3 = __math_Box3.Box3
    type Plane = __math_Plane.Plane
    type Matrix4 = __math_Matrix4.Matrix4

    type [<AllowNullLiteral>] IExports =
        abstract Sphere: SphereStatic

    type [<AllowNullLiteral>] Sphere =
        abstract center: Vector3 with get, set
        abstract radius: float with get, set
        abstract set: center: Vector3 * radius: float -> Sphere
        abstract setFromPoints: points: ResizeArray<Vector3> * ?optionalCenter: Vector3 -> Sphere
        abstract clone: unit -> Sphere
        abstract copy: sphere: Sphere -> Sphere
        abstract empty: unit -> bool
        abstract containsPoint: point: Vector3 -> bool
        abstract distanceToPoint: point: Vector3 -> float
        abstract intersectsSphere: sphere: Sphere -> bool
        abstract intersectsBox: box: Box3 -> bool
        abstract intersectsPlane: plane: Plane -> bool
        abstract clampPoint: point: Vector3 * target: Vector3 -> Vector3
        abstract getBoundingBox: target: Box3 -> Box3
        abstract applyMatrix4: matrix: Matrix4 -> Sphere
        abstract translate: offset: Vector3 -> Sphere
        abstract equals: sphere: Sphere -> bool

    type [<AllowNullLiteral>] SphereStatic =
        [<Emit "new $0($1...)">] abstract Create: ?center: Vector3 * ?radius: float -> Sphere

module __math_Spherical =
    type Vector3 = __math_Vector3.Vector3

    type [<AllowNullLiteral>] IExports =
        abstract Spherical: SphericalStatic

    type [<AllowNullLiteral>] Spherical =
        abstract radius: float with get, set
        abstract phi: float with get, set
        abstract theta: float with get, set
        abstract set: radius: float * phi: float * theta: float -> Spherical
        abstract clone: unit -> Spherical
        abstract copy: other: Spherical -> Spherical
        abstract makeSafe: unit -> Spherical
        abstract setFromVector3: v: Vector3 -> Spherical
        abstract setFromCartesianCoords: x: float * y: float * z: float -> Spherical

    type [<AllowNullLiteral>] SphericalStatic =
        [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?phi: float * ?theta: float -> Spherical

module __math_SphericalHarmonics3 =
    type Vector3 = __math_Vector3.Vector3

    type [<AllowNullLiteral>] IExports =
        abstract SphericalHarmonics3: SphericalHarmonics3Static

    type [<AllowNullLiteral>] SphericalHarmonics3 =
        abstract coefficients: ResizeArray<Vector3> with get, set
        abstract isSphericalHarmonics3: bool with get, set
        abstract set: coefficients: ResizeArray<Vector3> -> SphericalHarmonics3
        abstract zero: unit -> SphericalHarmonics3
        abstract add: sh: SphericalHarmonics3 -> SphericalHarmonics3
        abstract scale: s: float -> SphericalHarmonics3
        abstract lerp: sh: SphericalHarmonics3 * alpha: float -> SphericalHarmonics3
        abstract equals: sh: SphericalHarmonics3 -> bool
        abstract copy: sh: SphericalHarmonics3 -> SphericalHarmonics3
        abstract clone: unit -> SphericalHarmonics3
        /// <summary>Sets the values of this spherical harmonics from the provided array.</summary>
        /// <param name="array">the source array.</param>
        /// <param name="offset">(optional) offset into the array. Default is 0.</param>
        abstract fromArray: array: ResizeArray<float> * ?offset: float -> SphericalHarmonics3
        /// <summary>Sets the values of this spherical harmonics from the provided array-like.</summary>
        /// <param name="array">the source array-like.</param>
        /// <param name="offset">(optional) offset into the array-like. Default is 0.</param>
        abstract fromArray: array: ArrayLike<float> * ?offset: float -> SphericalHarmonics3
        /// <summary>Returns an array with the values of this spherical harmonics, or copies them into the provided array.</summary>
        /// <param name="array">(optional) array to store the spherical harmonics to. If this is not provided, a new array will be created.</param>
        /// <param name="offset">(optional) optional offset into the array.</param>
        abstract toArray: ?array: ResizeArray<float> * ?offset: float -> ResizeArray<float>
        /// <summary>Returns an array with the values of this spherical harmonics, or copies them into the provided array-like.</summary>
        /// <param name="array">array-like to store the spherical harmonics to.</param>
        /// <param name="offset">(optional) optional offset into the array-like.</param>
        abstract toArray: array: ArrayLike<float> * ?offset: float -> ArrayLike<float>
        abstract getAt: normal: Vector3 * target: Vector3 -> Vector3
        abstract getIrradianceAt: normal: Vector3 * target: Vector3 -> Vector3

    type [<AllowNullLiteral>] SphericalHarmonics3Static =
        [<Emit "new $0($1...)">] abstract Create: unit -> SphericalHarmonics3
        abstract getBasisAt: normal: Vector3 * shBasis: ResizeArray<float> -> unit

module __math_Triangle =
    type Vector2 = __math_Vector2.Vector2
    type Vector3 = __math_Vector3.Vector3
    type Plane = __math_Plane.Plane
    type Box3 = __math_Box3.Box3

    type [<AllowNullLiteral>] IExports =
        abstract Triangle: TriangleStatic

    type [<AllowNullLiteral>] SplineControlPoint =
        abstract x: float with get, set
        abstract y: float with get, set
        abstract z: float with get, set

    type [<AllowNullLiteral>] Triangle =
        abstract a: Vector3 with get, set
        abstract b: Vector3 with get, set
        abstract c: Vector3 with get, set
        abstract set: a: Vector3 * b: Vector3 * c: Vector3 -> Triangle
        abstract setFromPointsAndIndices: points: ResizeArray<Vector3> * i0: float * i1: float * i2: float -> Triangle
        abstract clone: unit -> Triangle
        abstract copy: triangle: Triangle -> Triangle
        abstract getArea: unit -> float
        abstract getMidpoint: target: Vector3 -> Vector3
        abstract getNormal: target: Vector3 -> Vector3
        abstract getPlane: target: Plane -> Plane
        abstract getBarycoord: point: Vector3 * target: Vector3 -> Vector3
        abstract getUV: point: Vector3 * uv1: Vector2 * uv2: Vector2 * uv3: Vector2 * target: Vector2 -> Vector2
        abstract containsPoint: point: Vector3 -> bool
        abstract intersectsBox: box: Box3 -> bool
        abstract isFrontFacing: direction: Vector3 -> bool
        abstract closestPointToPoint: point: Vector3 * target: Vector3 -> Vector3
        abstract equals: triangle: Triangle -> bool

    type [<AllowNullLiteral>] TriangleStatic =
        [<Emit "new $0($1...)">] abstract Create: ?a: Vector3 * ?b: Vector3 * ?c: Vector3 -> Triangle
        abstract getNormal: a: Vector3 * b: Vector3 * c: Vector3 * target: Vector3 -> Vector3
        abstract getBarycoord: point: Vector3 * a: Vector3 * b: Vector3 * c: Vector3 * target: Vector3 -> Vector3
        abstract containsPoint: point: Vector3 * a: Vector3 * b: Vector3 * c: Vector3 -> bool
        abstract getUV: point: Vector3 * p1: Vector3 * p2: Vector3 * p3: Vector3 * uv1: Vector2 * uv2: Vector2 * uv3: Vector2 * target: Vector2 -> Vector2
        abstract isFrontFacing: a: Vector3 * b: Vector3 * c: Vector3 * direction: Vector3 -> bool

module __math_Vector2 =
    type Matrix3 = __math_Matrix3.Matrix3
    type BufferAttribute = __core_BufferAttribute.BufferAttribute

    type [<AllowNullLiteral>] IExports =
        abstract Vector2: Vector2Static

    /// ( interface Vector&lt;T&gt; )
    /// 
    /// Abstract interface of Vector2, Vector3 and Vector4.
    /// Currently the members of Vector is NOT type safe because it accepts different typed vectors.
    /// Those definitions will be changed when TypeScript innovates Generics to be type safe.
    type [<AllowNullLiteral>] Vector =
        abstract setComponent: index: float * value: float -> Vector
        abstract getComponent: index: float -> float
        abstract set: [<ParamArray>] args: ResizeArray<float> -> Vector
        abstract setScalar: scalar: float -> Vector
        /// copy(v:T):T;
        abstract copy: v: Vector -> Vector
        /// NOTE: The second argument is deprecated.
        /// 
        /// add(v:T):T;
        abstract add: v: Vector * ?w: Vector -> Vector
        /// addVectors(a:T, b:T):T;
        abstract addVectors: a: Vector * b: Vector -> Vector
        abstract addScaledVector: vector: Vector * scale: float -> Vector
        /// Adds the scalar value s to this vector's values.
        abstract addScalar: scalar: float -> Vector
        /// sub(v:T):T;
        abstract sub: v: Vector -> Vector
        /// subVectors(a:T, b:T):T;
        abstract subVectors: a: Vector * b: Vector -> Vector
        /// multiplyScalar(s:number):T;
        abstract multiplyScalar: s: float -> Vector
        /// divideScalar(s:number):T;
        abstract divideScalar: s: float -> Vector
        /// negate():T;
        abstract negate: unit -> Vector
        /// dot(v:T):T;
        abstract dot: v: Vector -> float
        /// lengthSq():number;
        abstract lengthSq: unit -> float
        /// length():number;
        abstract length: unit -> float
        /// normalize():T;
        abstract normalize: unit -> Vector
        /// NOTE: Vector4 doesn't have the property.
        /// 
        /// distanceTo(v:T):number;
        abstract distanceTo: v: Vector -> float
        /// NOTE: Vector4 doesn't have the property.
        /// 
        /// distanceToSquared(v:T):number;
        abstract distanceToSquared: v: Vector -> float
        /// setLength(l:number):T;
        abstract setLength: l: float -> Vector
        /// lerp(v:T, alpha:number):T;
        abstract lerp: v: Vector * alpha: float -> Vector
        /// equals(v:T):boolean;
        abstract equals: v: Vector -> bool
        /// clone():T;
        abstract clone: unit -> Vector

    /// 2D vector.
    /// 
    /// ( class Vector2 implements Vector<Vector2> )
    type [<AllowNullLiteral>] Vector2 =
        inherit Vector
        abstract x: float with get, set
        abstract y: float with get, set
        abstract width: float with get, set
        abstract height: float with get, set
        abstract isVector2: obj with get, set
        /// Sets value of this vector.
        abstract set: x: float * y: float -> Vector2
        /// Sets the x and y values of this vector both equal to scalar.
        abstract setScalar: scalar: float -> Vector2
        /// Sets X component of this vector.
        abstract setX: x: float -> Vector2
        /// Sets Y component of this vector.
        abstract setY: y: float -> Vector2
        /// Sets a component of this vector.
        abstract setComponent: index: float * value: float -> Vector2
        /// Gets a component of this vector.
        abstract getComponent: index: float -> float
        /// Returns a new Vector2 instance with the same `x` and `y` values.
        abstract clone: unit -> Vector2
        /// Copies value of v to this vector.
        abstract copy: v: Vector2 -> Vector2
        /// Adds v to this vector.
        abstract add: v: Vector2 * ?w: Vector2 -> Vector2
        /// Adds the scalar value s to this vector's x and y values.
        abstract addScalar: s: float -> Vector2
        /// Sets this vector to a + b.
        abstract addVectors: a: Vector2 * b: Vector2 -> Vector2
        /// Adds the multiple of v and s to this vector.
        abstract addScaledVector: v: Vector2 * s: float -> Vector2
        /// Subtracts v from this vector.
        abstract sub: v: Vector2 -> Vector2
        /// Subtracts s from this vector's x and y components.
        abstract subScalar: s: float -> Vector2
        /// Sets this vector to a - b.
        abstract subVectors: a: Vector2 * b: Vector2 -> Vector2
        /// Multiplies this vector by v.
        abstract multiply: v: Vector2 -> Vector2
        /// Multiplies this vector by scalar s.
        abstract multiplyScalar: scalar: float -> Vector2
        /// Divides this vector by v.
        abstract divide: v: Vector2 -> Vector2
        /// Divides this vector by scalar s.
        /// Set vector to ( 0, 0 ) if s == 0.
        abstract divideScalar: s: float -> Vector2
        /// Multiplies this vector (with an implicit 1 as the 3rd component) by m.
        abstract applyMatrix3: m: Matrix3 -> Vector2
        /// If this vector's x or y value is greater than v's x or y value, replace that value with the corresponding min value.
        abstract min: v: Vector2 -> Vector2
        /// If this vector's x or y value is less than v's x or y value, replace that value with the corresponding max value.
        abstract max: v: Vector2 -> Vector2
        /// <summary>If this vector's x or y value is greater than the max vector's x or y value, it is replaced by the corresponding value.
        /// If this vector's x or y value is less than the min vector's x or y value, it is replaced by the corresponding value.</summary>
        /// <param name="min">the minimum x and y values.</param>
        /// <param name="max">the maximum x and y values in the desired range.</param>
        abstract clamp: min: Vector2 * max: Vector2 -> Vector2
        /// <summary>If this vector's x or y values are greater than the max value, they are replaced by the max value.
        /// If this vector's x or y values are less than the min value, they are replaced by the min value.</summary>
        /// <param name="min">the minimum value the components will be clamped to.</param>
        /// <param name="max">the maximum value the components will be clamped to.</param>
        abstract clampScalar: min: float * max: float -> Vector2
        /// <summary>If this vector's length is greater than the max value, it is replaced by the max value.
        /// If this vector's length is less than the min value, it is replaced by the min value.</summary>
        /// <param name="min">the minimum value the length will be clamped to.</param>
        /// <param name="max">the maximum value the length will be clamped to.</param>
        abstract clampLength: min: float * max: float -> Vector2
        /// The components of the vector are rounded down to the nearest integer value.
        abstract floor: unit -> Vector2
        /// The x and y components of the vector are rounded up to the nearest integer value.
        abstract ceil: unit -> Vector2
        /// The components of the vector are rounded to the nearest integer value.
        abstract round: unit -> Vector2
        /// The components of the vector are rounded towards zero (up if negative, down if positive) to an integer value.
        abstract roundToZero: unit -> Vector2
        /// Inverts this vector.
        abstract negate: unit -> Vector2
        /// Computes dot product of this vector and v.
        abstract dot: v: Vector2 -> float
        /// Computes cross product of this vector and v.
        abstract cross: v: Vector2 -> float
        /// Computes squared length of this vector.
        abstract lengthSq: unit -> float
        /// Computes length of this vector.
        abstract length: unit -> float
        abstract lengthManhattan: unit -> float
        /// Computes the Manhattan length of this vector.
        abstract manhattanLength: unit -> float
        /// Normalizes this vector.
        abstract normalize: unit -> Vector2
        /// computes the angle in radians with respect to the positive x-axis
        abstract angle: unit -> float
        /// Computes distance of this vector to v.
        abstract distanceTo: v: Vector2 -> float
        /// Computes squared distance of this vector to v.
        abstract distanceToSquared: v: Vector2 -> float
        abstract distanceToManhattan: v: Vector2 -> float
        /// Computes the Manhattan length (distance) from this vector to the given vector v
        abstract manhattanDistanceTo: v: Vector2 -> float
        /// Normalizes this vector and multiplies it by l.
        abstract setLength: length: float -> Vector2
        /// <summary>Linearly interpolates between this vector and v, where alpha is the distance along the line - alpha = 0 will be this vector, and alpha = 1 will be v.</summary>
        /// <param name="v">vector to interpolate towards.</param>
        /// <param name="alpha">interpolation factor in the closed interval [0, 1].</param>
        abstract lerp: v: Vector2 * alpha: float -> Vector2
        /// <summary>Sets this vector to be the vector linearly interpolated between v1 and v2 where alpha is the distance along the line connecting the two vectors - alpha = 0 will be v1, and alpha = 1 will be v2.</summary>
        /// <param name="v1">the starting vector.</param>
        /// <param name="v2">vector to interpolate towards.</param>
        /// <param name="alpha">interpolation factor in the closed interval [0, 1].</param>
        abstract lerpVectors: v1: Vector2 * v2: Vector2 * alpha: float -> Vector2
        /// Checks for strict equality of this vector and v.
        abstract equals: v: Vector2 -> bool
        /// <summary>Sets this vector's x and y value from the provided array.</summary>
        /// <param name="array">the source array.</param>
        /// <param name="offset">(optional) offset into the array. Default is 0.</param>
        abstract fromArray: array: ResizeArray<float> * ?offset: float -> Vector2
        /// <summary>Sets this vector's x and y value from the provided array-like.</summary>
        /// <param name="array">the source array-like.</param>
        /// <param name="offset">(optional) offset into the array-like. Default is 0.</param>
        abstract fromArray: array: ArrayLike<float> * ?offset: float -> Vector2
        /// <summary>Returns an array [x, y], or copies x and y into the provided array.</summary>
        /// <param name="array">(optional) array to store the vector to. If this is not provided, a new array will be created.</param>
        /// <param name="offset">(optional) optional offset into the array.</param>
        abstract toArray: ?array: ResizeArray<float> * ?offset: float -> ResizeArray<float>
        /// <summary>Copies x and y into the provided array-like.</summary>
        /// <param name="array">array-like to store the vector to.</param>
        /// <param name="offset">(optional) optional offset into the array.</param>
        abstract toArray: array: ArrayLike<float> * ?offset: float -> ArrayLike<float>
        /// <summary>Sets this vector's x and y values from the attribute.</summary>
        /// <param name="attribute">the source attribute.</param>
        /// <param name="index">index in the attribute.</param>
        abstract fromBufferAttribute: attribute: BufferAttribute * index: float -> Vector2
        /// <summary>Rotates the vector around center by angle radians.</summary>
        /// <param name="center">the point around which to rotate.</param>
        /// <param name="angle">the angle to rotate, in radians.</param>
        abstract rotateAround: center: Vector2 * angle: float -> Vector2

    /// 2D vector.
    /// 
    /// ( class Vector2 implements Vector<Vector2> )
    type [<AllowNullLiteral>] Vector2Static =
        [<Emit "new $0($1...)">] abstract Create: ?x: float * ?y: float -> Vector2

module __math_Vector3 =
    type Euler = __math_Euler.Euler
    type Matrix3 = __math_Matrix3.Matrix3
    type Matrix4 = __math_Matrix4.Matrix4
    type Quaternion = __math_Quaternion.Quaternion
    type Camera = __cameras_Camera.Camera
    type Spherical = __math_Spherical.Spherical
    type Cylindrical = __math_Cylindrical.Cylindrical
    type BufferAttribute = __core_BufferAttribute.BufferAttribute
    type Vector = __math_Vector2.Vector

    type [<AllowNullLiteral>] IExports =
        abstract Vector3: Vector3Static

    /// 3D vector.
    type [<AllowNullLiteral>] Vector3 =
        inherit Vector
        abstract x: float with get, set
        abstract y: float with get, set
        abstract z: float with get, set
        abstract isVector3: obj with get, set
        /// Sets value of this vector.
        abstract set: x: float * y: float * z: float -> Vector3
        /// Sets all values of this vector.
        abstract setScalar: scalar: float -> Vector3
        /// Sets x value of this vector.
        abstract setX: x: float -> Vector3
        /// Sets y value of this vector.
        abstract setY: y: float -> Vector3
        /// Sets z value of this vector.
        abstract setZ: z: float -> Vector3
        abstract setComponent: index: float * value: float -> Vector3
        abstract getComponent: index: float -> float
        /// Clones this vector.
        abstract clone: unit -> Vector3
        /// Copies value of v to this vector.
        abstract copy: v: Vector3 -> Vector3
        /// Adds v to this vector.
        abstract add: v: Vector3 * ?w: Vector3 -> Vector3
        abstract addScalar: s: float -> Vector3
        abstract addScaledVector: v: Vector3 * s: float -> Vector3
        /// Sets this vector to a + b.
        abstract addVectors: a: Vector3 * b: Vector3 -> Vector3
        /// Subtracts v from this vector.
        abstract sub: a: Vector3 -> Vector3
        abstract subScalar: s: float -> Vector3
        /// Sets this vector to a - b.
        abstract subVectors: a: Vector3 * b: Vector3 -> Vector3
        abstract multiply: v: Vector3 -> Vector3
        /// Multiplies this vector by scalar s.
        abstract multiplyScalar: s: float -> Vector3
        abstract multiplyVectors: a: Vector3 * b: Vector3 -> Vector3
        abstract applyEuler: euler: Euler -> Vector3
        abstract applyAxisAngle: axis: Vector3 * angle: float -> Vector3
        abstract applyMatrix3: m: Matrix3 -> Vector3
        abstract applyNormalMatrix: m: Matrix3 -> Vector3
        abstract applyMatrix4: m: Matrix4 -> Vector3
        abstract applyQuaternion: q: Quaternion -> Vector3
        abstract project: camera: Camera -> Vector3
        abstract unproject: camera: Camera -> Vector3
        abstract transformDirection: m: Matrix4 -> Vector3
        abstract divide: v: Vector3 -> Vector3
        /// Divides this vector by scalar s.
        /// Set vector to ( 0, 0, 0 ) if s == 0.
        abstract divideScalar: s: float -> Vector3
        abstract min: v: Vector3 -> Vector3
        abstract max: v: Vector3 -> Vector3
        abstract clamp: min: Vector3 * max: Vector3 -> Vector3
        abstract clampScalar: min: float * max: float -> Vector3
        abstract clampLength: min: float * max: float -> Vector3
        abstract floor: unit -> Vector3
        abstract ceil: unit -> Vector3
        abstract round: unit -> Vector3
        abstract roundToZero: unit -> Vector3
        /// Inverts this vector.
        abstract negate: unit -> Vector3
        /// Computes dot product of this vector and v.
        abstract dot: v: Vector3 -> float
        /// Computes squared length of this vector.
        abstract lengthSq: unit -> float
        /// Computes length of this vector.
        abstract length: unit -> float
        /// Computes Manhattan length of this vector.
        /// http://en.wikipedia.org/wiki/Taxicab_geometry
        abstract lengthManhattan: unit -> float
        /// Computes the Manhattan length of this vector.
        abstract manhattanLength: unit -> float
        /// Computes the Manhattan length (distance) from this vector to the given vector v
        abstract manhattanDistanceTo: v: Vector3 -> float
        /// Normalizes this vector.
        abstract normalize: unit -> Vector3
        /// Normalizes this vector and multiplies it by l.
        abstract setLength: l: float -> Vector3
        abstract lerp: v: Vector3 * alpha: float -> Vector3
        abstract lerpVectors: v1: Vector3 * v2: Vector3 * alpha: float -> Vector3
        /// Sets this vector to cross product of itself and v.
        abstract cross: a: Vector3 * ?w: Vector3 -> Vector3
        /// Sets this vector to cross product of a and b.
        abstract crossVectors: a: Vector3 * b: Vector3 -> Vector3
        abstract projectOnVector: v: Vector3 -> Vector3
        abstract projectOnPlane: planeNormal: Vector3 -> Vector3
        abstract reflect: vector: Vector3 -> Vector3
        abstract angleTo: v: Vector3 -> float
        /// Computes distance of this vector to v.
        abstract distanceTo: v: Vector3 -> float
        /// Computes squared distance of this vector to v.
        abstract distanceToSquared: v: Vector3 -> float
        abstract distanceToManhattan: v: Vector3 -> float
        abstract setFromSpherical: s: Spherical -> Vector3
        abstract setFromSphericalCoords: r: float * phi: float * theta: float -> Vector3
        abstract setFromCylindrical: s: Cylindrical -> Vector3
        abstract setFromCylindricalCoords: radius: float * theta: float * y: float -> Vector3
        abstract setFromMatrixPosition: m: Matrix4 -> Vector3
        abstract setFromMatrixScale: m: Matrix4 -> Vector3
        abstract setFromMatrixColumn: matrix: Matrix4 * index: float -> Vector3
        /// Checks for strict equality of this vector and v.
        abstract equals: v: Vector3 -> bool
        /// <summary>Sets this vector's x, y and z value from the provided array.</summary>
        /// <param name="array">the source array.</param>
        /// <param name="offset">(optional) offset into the array. Default is 0.</param>
        abstract fromArray: array: ResizeArray<float> * ?offset: float -> Vector3
        /// <summary>Sets this vector's x, y and z value from the provided array-like.</summary>
        /// <param name="array">the source array-like.</param>
        /// <param name="offset">(optional) offset into the array-like. Default is 0.</param>
        abstract fromArray: array: ArrayLike<float> * ?offset: float -> Vector3
        /// <summary>Returns an array [x, y, z], or copies x, y and z into the provided array.</summary>
        /// <param name="array">(optional) array to store the vector to. If this is not provided, a new array will be created.</param>
        /// <param name="offset">(optional) optional offset into the array.</param>
        abstract toArray: ?array: ResizeArray<float> * ?offset: float -> ResizeArray<float>
        /// <summary>Copies x, y and z into the provided array-like.</summary>
        /// <param name="array">array-like to store the vector to.</param>
        /// <param name="offset">(optional) optional offset into the array-like.</param>
        abstract toArray: array: ArrayLike<float> * ?offset: float -> ArrayLike<float>
        abstract fromBufferAttribute: attribute: BufferAttribute * index: float * ?offset: float -> Vector3

    /// 3D vector.
    type [<AllowNullLiteral>] Vector3Static =
        [<Emit "new $0($1...)">] abstract Create: ?x: float * ?y: float * ?z: float -> Vector3

module __math_Vector4 =
    type Matrix4 = __math_Matrix4.Matrix4
    type Quaternion = __math_Quaternion.Quaternion
    type Matrix3 = __math_Matrix3.Matrix3
    type BufferAttribute = __core_BufferAttribute.BufferAttribute
    type Vector = __math_Vector2.Vector

    type [<AllowNullLiteral>] IExports =
        abstract Vector4: Vector4Static

    /// 4D vector.
    /// 
    /// ( class Vector4 implements Vector<Vector4> )
    type [<AllowNullLiteral>] Vector4 =
        inherit Vector
        abstract x: float with get, set
        abstract y: float with get, set
        abstract z: float with get, set
        abstract w: float with get, set
        abstract width: float with get, set
        abstract height: float with get, set
        abstract isVector4: obj with get, set
        /// Sets value of this vector.
        abstract set: x: float * y: float * z: float * w: float -> Vector4
        /// Sets all values of this vector.
        abstract setScalar: scalar: float -> Vector4
        /// Sets X component of this vector.
        abstract setX: x: float -> Vector4
        /// Sets Y component of this vector.
        abstract setY: y: float -> Vector4
        /// Sets Z component of this vector.
        abstract setZ: z: float -> Vector4
        /// Sets w component of this vector.
        abstract setW: w: float -> Vector4
        abstract setComponent: index: float * value: float -> Vector4
        abstract getComponent: index: float -> float
        /// Clones this vector.
        abstract clone: unit -> Vector4
        /// Copies value of v to this vector.
        abstract copy: v: Vector4 -> Vector4
        /// Adds v to this vector.
        abstract add: v: Vector4 * ?w: Vector4 -> Vector4
        abstract addScalar: scalar: float -> Vector4
        /// Sets this vector to a + b.
        abstract addVectors: a: Vector4 * b: Vector4 -> Vector4
        abstract addScaledVector: v: Vector4 * s: float -> Vector4
        /// Subtracts v from this vector.
        abstract sub: v: Vector4 -> Vector4
        abstract subScalar: s: float -> Vector4
        /// Sets this vector to a - b.
        abstract subVectors: a: Vector4 * b: Vector4 -> Vector4
        /// Multiplies this vector by scalar s.
        abstract multiplyScalar: s: float -> Vector4
        abstract applyMatrix4: m: Matrix4 -> Vector4
        /// Divides this vector by scalar s.
        /// Set vector to ( 0, 0, 0 ) if s == 0.
        abstract divideScalar: s: float -> Vector4
        /// <summary>http://www.euclideanspace.com/maths/geometry/rotations/conversions/quaternionToAngle/index.htm</summary>
        /// <param name="q">is assumed to be normalized</param>
        abstract setAxisAngleFromQuaternion: q: Quaternion -> Vector4
        /// <summary>http://www.euclideanspace.com/maths/geometry/rotations/conversions/matrixToAngle/index.htm</summary>
        /// <param name="m">assumes the upper 3x3 of m is a pure rotation matrix (i.e, unscaled)</param>
        abstract setAxisAngleFromRotationMatrix: m: Matrix3 -> Vector4
        abstract min: v: Vector4 -> Vector4
        abstract max: v: Vector4 -> Vector4
        abstract clamp: min: Vector4 * max: Vector4 -> Vector4
        abstract clampScalar: min: float * max: float -> Vector4
        abstract floor: unit -> Vector4
        abstract ceil: unit -> Vector4
        abstract round: unit -> Vector4
        abstract roundToZero: unit -> Vector4
        /// Inverts this vector.
        abstract negate: unit -> Vector4
        /// Computes dot product of this vector and v.
        abstract dot: v: Vector4 -> float
        /// Computes squared length of this vector.
        abstract lengthSq: unit -> float
        /// Computes length of this vector.
        abstract length: unit -> float
        /// Computes the Manhattan length of this vector.
        abstract manhattanLength: unit -> float
        /// Normalizes this vector.
        abstract normalize: unit -> Vector4
        /// Normalizes this vector and multiplies it by l.
        abstract setLength: length: float -> Vector4
        /// Linearly interpolate between this vector and v with alpha factor.
        abstract lerp: v: Vector4 * alpha: float -> Vector4
        abstract lerpVectors: v1: Vector4 * v2: Vector4 * alpha: float -> Vector4
        /// Checks for strict equality of this vector and v.
        abstract equals: v: Vector4 -> bool
        /// <summary>Sets this vector's x, y, z and w value from the provided array.</summary>
        /// <param name="array">the source array.</param>
        /// <param name="offset">(optional) offset into the array. Default is 0.</param>
        abstract fromArray: array: ResizeArray<float> * ?offset: float -> Vector4
        /// <summary>Sets this vector's x, y, z and w value from the provided array-like.</summary>
        /// <param name="array">the source array-like.</param>
        /// <param name="offset">(optional) offset into the array-like. Default is 0.</param>
        abstract fromArray: array: ArrayLike<float> * ?offset: float -> Vector4
        /// <summary>Returns an array [x, y, z, w], or copies x, y, z and w into the provided array.</summary>
        /// <param name="array">(optional) array to store the vector to. If this is not provided, a new array will be created.</param>
        /// <param name="offset">(optional) optional offset into the array.</param>
        abstract toArray: ?array: ResizeArray<float> * ?offset: float -> ResizeArray<float>
        /// <summary>Copies x, y, z and w into the provided array-like.</summary>
        /// <param name="array">array-like to store the vector to.</param>
        /// <param name="offset">(optional) optional offset into the array-like.</param>
        abstract toArray: array: ArrayLike<float> * ?offset: float -> ArrayLike<float>
        abstract fromBufferAttribute: attribute: BufferAttribute * index: float * ?offset: float -> Vector4

    /// 4D vector.
    /// 
    /// ( class Vector4 implements Vector<Vector4> )
    type [<AllowNullLiteral>] Vector4Static =
        [<Emit "new $0($1...)">] abstract Create: ?x: float * ?y: float * ?z: float * ?w: float -> Vector4

module __objects_Bone =
    type Object3D = __core_Object3D.Object3D

    type [<AllowNullLiteral>] IExports =
        abstract Bone: BoneStatic

    type [<AllowNullLiteral>] Bone =
        inherit Object3D
        abstract isBone: obj with get, set
        abstract ``type``: string with get, set

    type [<AllowNullLiteral>] BoneStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Bone

module __objects_Group =
    type Object3D = __core_Object3D.Object3D

    type [<AllowNullLiteral>] IExports =
        abstract Group: GroupStatic

    type [<AllowNullLiteral>] Group =
        inherit Object3D
        abstract ``type``: string with get, set
        abstract isGroup: obj with get, set

    type [<AllowNullLiteral>] GroupStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Group

module __objects_InstancedMesh =
    type Geometry = __core_Geometry.Geometry
    type BufferGeometry = __core_BufferGeometry.BufferGeometry
    type Material = __materials_Material.Material
    type BufferAttribute = __core_BufferAttribute.BufferAttribute
    type Mesh = __objects_Mesh.Mesh
    type Matrix4 = __math_Matrix4.Matrix4

    type [<AllowNullLiteral>] IExports =
        abstract InstancedMesh: InstancedMeshStatic

    type [<AllowNullLiteral>] InstancedMesh =
        inherit Mesh
        abstract count: float with get, set
        abstract instanceMatrix: BufferAttribute with get, set
        abstract isInstancedMesh: obj with get, set
        abstract getMatrixAt: index: float * matrix: Matrix4 -> unit
        abstract setMatrixAt: index: float * matrix: Matrix4 -> unit

    type [<AllowNullLiteral>] InstancedMeshStatic =
        [<Emit "new $0($1...)">] abstract Create: geometry: U2<Geometry, BufferGeometry> * material: U2<Material, ResizeArray<Material>> * count: float -> InstancedMesh

module __objects_Line =
    type Geometry = __core_Geometry.Geometry
    type Material = __materials_Material.Material
    type Raycaster = __core_Raycaster.Raycaster
    type Object3D = __core_Object3D.Object3D
    type BufferGeometry = __core_BufferGeometry.BufferGeometry
    type Intersection = __core_Raycaster.Intersection

    type [<AllowNullLiteral>] IExports =
        abstract Line: LineStatic

    type [<AllowNullLiteral>] Line =
        inherit Object3D
        abstract geometry: U2<Geometry, BufferGeometry> with get, set
        abstract material: U2<Material, ResizeArray<Material>> with get, set
        abstract ``type``: LineType with get, set
        abstract isLine: obj with get, set
        abstract computeLineDistances: unit -> Line
        abstract raycast: raycaster: Raycaster * intersects: ResizeArray<Intersection> -> unit

    type [<AllowNullLiteral>] LineStatic =
        [<Emit "new $0($1...)">] abstract Create: ?geometry: U2<Geometry, BufferGeometry> * ?material: U2<Material, ResizeArray<Material>> * ?mode: float -> Line

    type [<StringEnum>] [<RequireQualifiedAccess>] LineType =
        | [<CompiledName "Line">] Line
        | [<CompiledName "LineLoop">] LineLoop
        | [<CompiledName "LineSegments">] LineSegments

module __objects_LineLoop =
    type Line = __objects_Line.Line
    type Geometry = __core_Geometry.Geometry
    type Material = __materials_Material.Material
    type BufferGeometry = __core_BufferGeometry.BufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract LineLoop: LineLoopStatic

    type [<AllowNullLiteral>] LineLoop =
        inherit Line
        abstract ``type``: string with get, set
        abstract isLineLoop: obj with get, set

    type [<AllowNullLiteral>] LineLoopStatic =
        [<Emit "new $0($1...)">] abstract Create: ?geometry: U2<Geometry, BufferGeometry> * ?material: U2<Material, ResizeArray<Material>> -> LineLoop

module __objects_LineSegments =
    type Geometry = __core_Geometry.Geometry
    type Material = __materials_Material.Material
    type Line = __objects_Line.Line
    type BufferGeometry = __core_BufferGeometry.BufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract LineStrip: float
        abstract LinePieces: float
        abstract LineSegments: LineSegmentsStatic

    type [<AllowNullLiteral>] LineSegments =
        inherit Line
        abstract ``type``: string with get, set
        abstract isLineSegments: obj with get, set

    type [<AllowNullLiteral>] LineSegmentsStatic =
        [<Emit "new $0($1...)">] abstract Create: ?geometry: U2<Geometry, BufferGeometry> * ?material: U2<Material, ResizeArray<Material>> * ?mode: float -> LineSegments

module __objects_LOD =
    type Object3D = __core_Object3D.Object3D
    type Raycaster = __core_Raycaster.Raycaster
    type Camera = __cameras_Camera.Camera
    type Intersection = __core_Raycaster.Intersection

    type [<AllowNullLiteral>] IExports =
        abstract LOD: LODStatic

    type [<AllowNullLiteral>] LOD =
        inherit Object3D
        abstract ``type``: string with get, set
        abstract levels: ResizeArray<LODLevels> with get, set
        abstract autoUpdate: bool with get, set
        abstract addLevel: ``object``: Object3D * ?distance: float -> LOD
        abstract getObjectForDistance: distance: float -> Object3D option
        abstract raycast: raycaster: Raycaster * intersects: ResizeArray<Intersection> -> unit
        abstract update: camera: Camera -> unit
        abstract toJSON: meta: obj option -> obj option
        abstract objects: ResizeArray<obj option> with get, set

    type [<AllowNullLiteral>] LODStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> LOD

    type [<AllowNullLiteral>] LODLevels =
        abstract distance: float with get, set
        abstract ``object``: Object3D with get, set

module __objects_Mesh =
    type Geometry = __core_Geometry.Geometry
    type Material = __materials_Material.Material
    type Raycaster = __core_Raycaster.Raycaster
    type Object3D = __core_Object3D.Object3D
    type BufferGeometry = __core_BufferGeometry.BufferGeometry
    type Intersection = __core_Raycaster.Intersection

    type [<AllowNullLiteral>] IExports =
        abstract Mesh: MeshStatic

    type [<AllowNullLiteral>] Mesh =
        inherit Object3D
        abstract geometry: U2<Geometry, BufferGeometry> with get, set
        abstract material: U2<Material, ResizeArray<Material>> with get, set
        abstract morphTargetInfluences: ResizeArray<float> option with get, set
        abstract morphTargetDictionary: MeshMorphTargetDictionary option with get, set
        abstract isMesh: obj with get, set
        abstract ``type``: string with get, set
        abstract updateMorphTargets: unit -> unit
        abstract raycast: raycaster: Raycaster * intersects: ResizeArray<Intersection> -> unit

    type [<AllowNullLiteral>] MeshStatic =
        [<Emit "new $0($1...)">] abstract Create: ?geometry: U2<Geometry, BufferGeometry> * ?material: U2<Material, ResizeArray<Material>> -> Mesh

    type [<AllowNullLiteral>] MeshMorphTargetDictionary =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> float with get, set

module __objects_Points =
    type Geometry = __core_Geometry.Geometry
    type Material = __materials_Material.Material
    type Raycaster = __core_Raycaster.Raycaster
    type Object3D = __core_Object3D.Object3D
    type BufferGeometry = __core_BufferGeometry.BufferGeometry
    type Intersection = __core_Raycaster.Intersection

    type [<AllowNullLiteral>] IExports =
        abstract Points: PointsStatic

    /// A class for displaying particles in the form of variable size points. For example, if using the WebGLRenderer, the particles are displayed using GL_POINTS.
    type [<AllowNullLiteral>] Points =
        inherit Object3D
        abstract ``type``: string with get, set
        abstract morphTargetInfluences: ResizeArray<float> option with get, set
        abstract morphTargetDictionary: PointsMorphTargetDictionary option with get, set
        abstract isPoints: obj with get, set
        /// An instance of Geometry or BufferGeometry, where each vertex designates the position of a particle in the system.
        abstract geometry: U2<Geometry, BufferGeometry> with get, set
        /// An instance of Material, defining the object's appearance. Default is a PointsMaterial with randomised colour.
        abstract material: U2<Material, ResizeArray<Material>> with get, set
        abstract raycast: raycaster: Raycaster * intersects: ResizeArray<Intersection> -> unit
        abstract updateMorphTargets: unit -> unit

    /// A class for displaying particles in the form of variable size points. For example, if using the WebGLRenderer, the particles are displayed using GL_POINTS.
    type [<AllowNullLiteral>] PointsStatic =
        /// <param name="geometry">An instance of Geometry or BufferGeometry.</param>
        /// <param name="material">An instance of Material (optional).</param>
        [<Emit "new $0($1...)">] abstract Create: ?geometry: U2<Geometry, BufferGeometry> * ?material: U2<Material, ResizeArray<Material>> -> Points

    type [<AllowNullLiteral>] PointsMorphTargetDictionary =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> float with get, set

module __objects_Skeleton =
    type Bone = __objects_Bone.Bone
    type Matrix4 = __math_Matrix4.Matrix4
    type DataTexture = __textures_DataTexture.DataTexture

    type [<AllowNullLiteral>] IExports =
        abstract Skeleton: SkeletonStatic

    type [<AllowNullLiteral>] Skeleton =
        abstract useVertexTexture: bool with get, set
        abstract identityMatrix: Matrix4 with get, set
        abstract bones: ResizeArray<Bone> with get, set
        abstract boneTextureWidth: float with get, set
        abstract boneTextureHeight: float with get, set
        abstract boneMatrices: Float32Array with get, set
        abstract boneTexture: DataTexture with get, set
        abstract boneInverses: ResizeArray<Matrix4> with get, set
        abstract calculateInverses: bone: Bone -> unit
        abstract pose: unit -> unit
        abstract update: unit -> unit
        abstract clone: unit -> Skeleton

    type [<AllowNullLiteral>] SkeletonStatic =
        [<Emit "new $0($1...)">] abstract Create: bones: ResizeArray<Bone> * ?boneInverses: ResizeArray<Matrix4> -> Skeleton

module __objects_SkinnedMesh =
    type Geometry = __core_Geometry.Geometry
    type Material = __materials_Material.Material
    type Matrix4 = __math_Matrix4.Matrix4
    type Skeleton = __objects_Skeleton.Skeleton
    type Mesh = __objects_Mesh.Mesh
    type BufferGeometry = __core_BufferGeometry.BufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract SkinnedMesh: SkinnedMeshStatic

    type [<AllowNullLiteral>] SkinnedMesh =
        inherit Mesh
        abstract bindMode: string with get, set
        abstract bindMatrix: Matrix4 with get, set
        abstract bindMatrixInverse: Matrix4 with get, set
        abstract skeleton: Skeleton with get, set
        abstract bind: skeleton: Skeleton * ?bindMatrix: Matrix4 -> unit
        abstract pose: unit -> unit
        abstract normalizeSkinWeights: unit -> unit
        abstract updateMatrixWorld: ?force: bool -> unit

    type [<AllowNullLiteral>] SkinnedMeshStatic =
        [<Emit "new $0($1...)">] abstract Create: ?geometry: U2<Geometry, BufferGeometry> * ?material: U2<Material, ResizeArray<Material>> * ?useVertexTexture: bool -> SkinnedMesh

module __objects_Sprite =
    type Vector2 = __math_Vector2.Vector2
    type Raycaster = __core_Raycaster.Raycaster
    type Object3D = __core_Object3D.Object3D
    type Intersection = __core_Raycaster.Intersection
    type SpriteMaterial = obj // TODO __materials_Materials.SpriteMaterial
    type BufferGeometry = __core_BufferGeometry.BufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract Sprite: SpriteStatic

    type [<AllowNullLiteral>] Sprite =
        inherit Object3D
        abstract ``type``: string with get, set
        abstract isSprite: obj with get, set
        abstract geometry: BufferGeometry with get, set
        abstract material: SpriteMaterial with get, set
        abstract center: Vector2 with get, set
        abstract raycast: raycaster: Raycaster * intersects: ResizeArray<Intersection> -> unit
        abstract copy: source: Sprite -> Sprite

    type [<AllowNullLiteral>] SpriteStatic =
        [<Emit "new $0($1...)">] abstract Create: ?material: SpriteMaterial -> Sprite

module __renderers_WebGLMultisampleRenderTarget =
    type WebGLRenderTarget = __renderers_WebGLRenderTarget.WebGLRenderTarget
    type WebGLRenderTargetOptions = __renderers_WebGLRenderTarget.WebGLRenderTargetOptions

    type [<AllowNullLiteral>] IExports =
        abstract WebGLMultisampleRenderTarget: WebGLMultisampleRenderTargetStatic

    type [<AllowNullLiteral>] WebGLMultisampleRenderTarget =
        inherit WebGLRenderTarget

    type [<AllowNullLiteral>] WebGLMultisampleRenderTargetStatic =
        [<Emit "new $0($1...)">] abstract Create: width: float * height: float * ?options: WebGLRenderTargetOptions -> WebGLMultisampleRenderTarget

module __renderers_WebGLMultiviewRenderTarget =
    type WebGLRenderTarget = __renderers_WebGLRenderTarget.WebGLRenderTarget
    type WebGLRenderTargetOptions = __renderers_WebGLRenderTarget.WebGLRenderTargetOptions

    type [<AllowNullLiteral>] IExports =
        abstract WebGLMultiviewRenderTarget: WebGLMultiviewRenderTargetStatic

    type [<AllowNullLiteral>] WebGLMultiviewRenderTarget =
        inherit WebGLRenderTarget
        abstract setNumViews: numViews: float -> WebGLMultiviewRenderTarget

    type [<AllowNullLiteral>] WebGLMultiviewRenderTargetStatic =
        [<Emit "new $0($1...)">] abstract Create: width: float * height: float * numViews: float * ?options: WebGLRenderTargetOptions -> WebGLMultiviewRenderTarget

module __renderers_WebGLRenderer =
    type Scene = __scenes_Scene.Scene
    type Camera = __cameras_Camera.Camera
    type WebGLExtensions = __renderers_webgl_WebGLExtensions.WebGLExtensions
    type WebGLInfo = __renderers_webgl_WebGLInfo.WebGLInfo
    type WebGLShadowMap = __renderers_webgl_WebGLShadowMap.WebGLShadowMap
    type WebGLCapabilities = __renderers_webgl_WebGLCapabilities.WebGLCapabilities
    type WebGLProperties = __renderers_webgl_WebGLProperties.WebGLProperties
    type WebGLRenderLists = __renderers_webgl_WebGLRenderLists.WebGLRenderLists
    type WebGLState = __renderers_webgl_WebGLState.WebGLState
    type Vector2 = __math_Vector2.Vector2
    type Vector4 = __math_Vector4.Vector4
    type Color = __math_Color.Color
    type WebGLRenderTarget = __renderers_WebGLRenderTarget.WebGLRenderTarget
    type Object3D = __core_Object3D.Object3D
    type Material = __materials_Material.Material
    type Fog = __scenes_Fog.Fog
    type ToneMapping = Constants.ToneMapping
    type ShadowMapType = Constants.ShadowMapType
    type CullFace = Constants.CullFace
    type TextureEncoding = Constants.TextureEncoding
    type WebXRManager = __renderers_webxr_WebXRManager.WebXRManager
    type RenderTarget = __renderers_webgl_WebGLRenderLists.RenderTarget
    type Geometry = __core_Geometry.Geometry
    type BufferGeometry = __core_BufferGeometry.BufferGeometry
    type Texture = __textures_Texture.Texture

    type [<AllowNullLiteral>] IExports =
        abstract WebGLRenderer: WebGLRendererStatic

    type [<AllowNullLiteral>] Renderer =
        abstract domElement: HTMLCanvasElement with get, set
        abstract render: scene: Scene * camera: Camera -> unit
        abstract setSize: width: float * height: float * ?updateStyle: bool -> unit

    type [<AllowNullLiteral>] WebGLRendererParameters =
        /// A Canvas where the renderer draws its output.
        abstract canvas: U2<HTMLCanvasElement, OffscreenCanvas> option with get, set
        /// A WebGL Rendering Context.
        /// (https://developer.mozilla.org/en-US/docs/Web/API/WebGLRenderingContext)
        /// Default is null
        abstract context: WebGLRenderingContext option with get, set
        /// shader precision. Can be "highp", "mediump" or "lowp".
        abstract precision: string option with get, set
        /// default is true.
        abstract alpha: bool option with get, set
        /// default is true.
        abstract premultipliedAlpha: bool option with get, set
        /// default is false.
        abstract antialias: bool option with get, set
        /// default is true.
        abstract stencil: bool option with get, set
        /// default is false.
        abstract preserveDrawingBuffer: bool option with get, set
        /// Can be "high-performance", "low-power" or "default"
        abstract powerPreference: string option with get, set
        /// default is true.
        abstract depth: bool option with get, set
        /// default is false.
        abstract logarithmicDepthBuffer: bool option with get, set

    type [<AllowNullLiteral>] WebGLDebug =
        /// Enables error checking and reporting when shader programs are being compiled.
        abstract checkShaderErrors: bool with get, set

    /// The WebGL renderer displays your beautifully crafted scenes using WebGL, if your device supports it.
    /// This renderer has way better performance than CanvasRenderer.
    type [<AllowNullLiteral>] WebGLRenderer =
        inherit Renderer
        /// A Canvas where the renderer draws its output.
        /// This is automatically created by the renderer in the constructor (if not provided already); you just need to add it to your page.
        abstract domElement: HTMLCanvasElement with get, set
        /// The HTML5 Canvas's 'webgl' context obtained from the canvas where the renderer will draw.
        abstract context: WebGLRenderingContext with get, set
        /// Defines whether the renderer should automatically clear its output before rendering.
        abstract autoClear: bool with get, set
        /// If autoClear is true, defines whether the renderer should clear the color buffer. Default is true.
        abstract autoClearColor: bool with get, set
        /// If autoClear is true, defines whether the renderer should clear the depth buffer. Default is true.
        abstract autoClearDepth: bool with get, set
        /// If autoClear is true, defines whether the renderer should clear the stencil buffer. Default is true.
        abstract autoClearStencil: bool with get, set
        /// Debug configurations.
        abstract debug: WebGLDebug with get, set
        /// Defines whether the renderer should sort objects. Default is true.
        abstract sortObjects: bool with get, set
        abstract clippingPlanes: ResizeArray<obj option> with get, set
        abstract localClippingEnabled: bool with get, set
        abstract extensions: WebGLExtensions with get, set
        /// Default is LinearEncoding.
        abstract outputEncoding: TextureEncoding with get, set
        abstract physicallyCorrectLights: bool with get, set
        abstract toneMapping: ToneMapping with get, set
        abstract toneMappingExposure: float with get, set
        abstract toneMappingWhitePoint: float with get, set
        /// Default is false.
        abstract shadowMapDebug: bool with get, set
        /// Default is 8.
        abstract maxMorphTargets: float with get, set
        /// Default is 4.
        abstract maxMorphNormals: float with get, set
        abstract info: WebGLInfo with get, set
        abstract shadowMap: WebGLShadowMap with get, set
        abstract pixelRatio: float with get, set
        abstract capabilities: WebGLCapabilities with get, set
        abstract properties: WebGLProperties with get, set
        abstract renderLists: WebGLRenderLists with get, set
        abstract state: WebGLState with get, set
        abstract xr: WebXRManager with get, set
        /// Return the WebGL context.
        abstract getContext: unit -> WebGLRenderingContext
        abstract getContextAttributes: unit -> obj option
        abstract forceContextLoss: unit -> unit
        abstract getMaxAnisotropy: unit -> float
        abstract getPrecision: unit -> string
        abstract getPixelRatio: unit -> float
        abstract setPixelRatio: value: float -> unit
        abstract getDrawingBufferSize: target: Vector2 -> Vector2
        abstract setDrawingBufferSize: width: float * height: float * pixelRatio: float -> unit
        abstract getSize: target: Vector2 -> Vector2
        /// Resizes the output canvas to (width, height), and also sets the viewport to fit that size, starting in (0, 0).
        abstract setSize: width: float * height: float * ?updateStyle: bool -> unit
        abstract getCurrentViewport: target: Vector4 -> Vector4
        /// Copies the viewport into target.
        abstract getViewport: target: Vector4 -> Vector4
        /// Sets the viewport to render from (x, y) to (x + width, y + height).
        /// (x, y) is the lower-left corner of the region.
        abstract setViewport: x: U2<Vector4, float> * ?y: float * ?width: float * ?height: float -> unit
        /// Copies the scissor area into target.
        abstract getScissor: target: Vector4 -> Vector4
        /// Sets the scissor area from (x, y) to (x + width, y + height).
        abstract setScissor: x: U2<Vector4, float> * ?y: float * ?width: float * ?height: float -> unit
        /// Returns true if scissor test is enabled; returns false otherwise.
        abstract getScissorTest: unit -> bool
        /// Enable the scissor test. When this is enabled, only the pixels within the defined scissor area will be affected by further renderer actions.
        abstract setScissorTest: enable: bool -> unit
        /// Sets the custom opaque sort function for the WebGLRenderLists. Pass null to use the default painterSortStable function.
        abstract setOpaqueSort: ``method``: Function -> unit
        /// Sets the custom transparent sort function for the WebGLRenderLists. Pass null to use the default reversePainterSortStable function.
        abstract setTransparentSort: ``method``: Function -> unit
        /// Returns a THREE.Color instance with the current clear color.
        abstract getClearColor: unit -> Color
        /// Sets the clear color, using color for the color and alpha for the opacity.
        abstract setClearColor: color: Color * ?alpha: float -> unit
        abstract setClearColor: color: string * ?alpha: float -> unit
        abstract setClearColor: color: float * ?alpha: float -> unit
        /// Returns a float with the current clear alpha. Ranges from 0 to 1.
        abstract getClearAlpha: unit -> float
        abstract setClearAlpha: alpha: float -> unit
        /// Tells the renderer to clear its color, depth or stencil drawing buffer(s).
        /// Arguments default to true
        abstract clear: ?color: bool * ?depth: bool * ?stencil: bool -> unit
        abstract clearColor: unit -> unit
        abstract clearDepth: unit -> unit
        abstract clearStencil: unit -> unit
        abstract clearTarget: renderTarget: WebGLRenderTarget * color: bool * depth: bool * stencil: bool -> unit
        abstract resetGLState: unit -> unit
        abstract dispose: unit -> unit
        /// Tells the shadow map plugin to update using the passed scene and camera parameters.
        abstract renderBufferImmediate: ``object``: Object3D * program: Object * material: Material -> unit
        abstract renderBufferDirect: camera: Camera * fog: Fog * geometry: U2<Geometry, BufferGeometry> * material: Material * ``object``: Object3D * geometryGroup: obj option -> unit
        /// <summary>A build in function that can be used instead of requestAnimationFrame. For WebXR projects this function must be used.</summary>
        /// <param name="callback">The function will be called every available frame. If `null` is passed it will stop any already ongoing animation.</param>
        abstract setAnimationLoop: callback: Function option -> unit
        abstract animate: callback: Function -> unit
        /// Compiles all materials in the scene with the camera. This is useful to precompile shaders before the first rendering.
        abstract compile: scene: Scene * camera: Camera -> unit
        /// Render a scene using a camera.
        /// The render is done to a previously specified {@link WebGLRenderTarget#renderTarget .renderTarget} set by calling
        /// {@link WebGLRenderer#setRenderTarget .setRenderTarget} or to the canvas as usual.
        /// 
        /// By default render buffers are cleared before rendering but you can prevent this by setting the property
        /// {@link WebGLRenderer#autoClear autoClear} to false. If you want to prevent only certain buffers being cleared
        /// you can set either the {@link WebGLRenderer#autoClearColor autoClearColor},
        /// {@link WebGLRenderer#autoClearStencil autoClearStencil} or {@link WebGLRenderer#autoClearDepth autoClearDepth}
        /// properties to false. To forcibly clear one ore more buffers call {@link WebGLRenderer#clear .clear}.
        abstract render: scene: Scene * camera: Camera -> unit
        /// Returns the current active cube face.
        abstract getActiveCubeFace: unit -> float
        /// Returns the current active mipmap level.
        abstract getActiveMipmapLevel: unit -> float
        /// Returns the current render target. If no render target is set, null is returned.
        abstract getRenderTarget: unit -> RenderTarget option
        abstract getCurrentRenderTarget: unit -> RenderTarget option
        /// <summary>Sets the active render target.</summary>
        /// <param name="renderTarget">The {@link WebGLRenderTarget renderTarget} that needs to be activated. When `null` is given, the canvas is set as the active render target instead.</param>
        /// <param name="activeCubeFace">Specifies the active cube side (PX 0, NX 1, PY 2, NY 3, PZ 4, NZ 5) of {@link WebGLRenderTargetCube}.</param>
        /// <param name="activeMipmapLevel">Specifies the active mipmap level.</param>
        abstract setRenderTarget: renderTarget: RenderTarget option * ?activeCubeFace: float * ?activeMipmapLevel: float -> unit
        abstract readRenderTargetPixels: renderTarget: RenderTarget * x: float * y: float * width: float * height: float * buffer: obj option * ?activeCubeFaceIndex: float -> unit
        /// <summary>Copies a region of the currently bound framebuffer into the selected mipmap level of the selected texture.
        /// This region is defined by the size of the destination texture's mip level, offset by the input position.</summary>
        /// <param name="position">Specifies the pixel offset from which to copy out of the framebuffer.</param>
        /// <param name="texture">Specifies the destination texture.</param>
        /// <param name="level">Specifies the destination mipmap level of the texture.</param>
        abstract copyFramebufferToTexture: position: Vector2 * texture: Texture * ?level: float -> unit
        /// <summary>Copies srcTexture to the specified level of dstTexture, offset by the input position.</summary>
        /// <param name="position">Specifies the pixel offset into the dstTexture where the copy will occur.</param>
        /// <param name="srcTexture">Specifies the source texture.</param>
        /// <param name="dstTexture">Specifies the destination texture.</param>
        /// <param name="level">Specifies the destination mipmap level of the texture.</param>
        abstract copyTextureToTexture: position: Vector2 * srcTexture: Texture * dstTexture: Texture * ?level: float -> unit
        /// <summary>Initializes the given texture. Can be used to preload a texture rather than waiting until first render (which can cause noticeable lags due to decode and GPU upload overhead).</summary>
        /// <param name="texture">The texture to Initialize.</param>
        abstract initTexture: texture: Texture -> unit
        abstract gammaFactor: float with get, set
        abstract vr: bool with get, set
        abstract shadowMapEnabled: bool with get, set
        abstract shadowMapType: ShadowMapType with get, set
        abstract shadowMapCullFace: CullFace with get, set
        abstract supportsFloatTextures: unit -> obj option
        abstract supportsHalfFloatTextures: unit -> obj option
        abstract supportsStandardDerivatives: unit -> obj option
        abstract supportsCompressedTextureS3TC: unit -> obj option
        abstract supportsCompressedTexturePVRTC: unit -> obj option
        abstract supportsBlendMinMax: unit -> obj option
        abstract supportsVertexTextures: unit -> obj option
        abstract supportsInstancedArrays: unit -> obj option
        abstract enableScissorTest: boolean: obj option -> obj option

    /// The WebGL renderer displays your beautifully crafted scenes using WebGL, if your device supports it.
    /// This renderer has way better performance than CanvasRenderer.
    type [<AllowNullLiteral>] WebGLRendererStatic =
        /// parameters is an optional object with properties defining the renderer's behaviour. The constructor also accepts no parameters at all. In all cases, it will assume sane defaults when parameters are missing.
        [<Emit "new $0($1...)">] abstract Create: ?parameters: WebGLRendererParameters -> WebGLRenderer

module __renderers_WebGLRenderTarget =
    type Vector4 = __math_Vector4.Vector4
    type Texture = __textures_Texture.Texture
    type DepthTexture = __textures_DepthTexture.DepthTexture
    type EventDispatcher = __core_EventDispatcher.EventDispatcher
    type Wrapping = Constants.Wrapping
    type TextureFilter = Constants.TextureFilter
    type TextureDataType = Constants.TextureDataType

    type [<AllowNullLiteral>] IExports =
        abstract WebGLRenderTarget: WebGLRenderTargetStatic

    type [<AllowNullLiteral>] WebGLRenderTargetOptions =
        abstract wrapS: Wrapping option with get, set
        abstract wrapT: Wrapping option with get, set
        abstract magFilter: TextureFilter option with get, set
        abstract minFilter: TextureFilter option with get, set
        abstract format: float option with get, set
        abstract ``type``: TextureDataType option with get, set
        abstract anisotropy: float option with get, set
        abstract depthBuffer: bool option with get, set
        abstract stencilBuffer: bool option with get, set
        abstract generateMipmaps: bool option with get, set
        abstract depthTexture: DepthTexture option with get, set

    type [<AllowNullLiteral>] WebGLRenderTarget =
        inherit EventDispatcher
        abstract uuid: string with get, set
        abstract width: float with get, set
        abstract height: float with get, set
        abstract scissor: Vector4 with get, set
        abstract scissorTest: bool with get, set
        abstract viewport: Vector4 with get, set
        abstract texture: Texture with get, set
        abstract depthBuffer: bool with get, set
        abstract stencilBuffer: bool with get, set
        abstract depthTexture: DepthTexture with get, set
        abstract wrapS: obj option with get, set
        abstract wrapT: obj option with get, set
        abstract magFilter: obj option with get, set
        abstract minFilter: obj option with get, set
        abstract anisotropy: obj option with get, set
        abstract offset: obj option with get, set
        abstract repeat: obj option with get, set
        abstract format: obj option with get, set
        abstract ``type``: obj option with get, set
        abstract generateMipmaps: obj option with get, set
        abstract setSize: width: float * height: float -> unit
        abstract clone: unit -> WebGLRenderTarget
        abstract copy: source: WebGLRenderTarget -> WebGLRenderTarget
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] WebGLRenderTargetStatic =
        [<Emit "new $0($1...)">] abstract Create: width: float * height: float * ?options: WebGLRenderTargetOptions -> WebGLRenderTarget

module __renderers_WebGLRenderTargetCube =
    type WebGLRenderTargetOptions = __renderers_WebGLRenderTarget.WebGLRenderTargetOptions
    type WebGLRenderTarget = __renderers_WebGLRenderTarget.WebGLRenderTarget
    type WebGLRenderer = __renderers_WebGLRenderer.WebGLRenderer
    type Texture = __textures_Texture.Texture

    type [<AllowNullLiteral>] IExports =
        abstract WebGLRenderTargetCube: WebGLRenderTargetCubeStatic

    type [<AllowNullLiteral>] WebGLRenderTargetCube =
        inherit WebGLRenderTarget
        abstract fromEquirectangularTexture: renderer: WebGLRenderer * texture: Texture -> WebGLRenderTargetCube

    type [<AllowNullLiteral>] WebGLRenderTargetCubeStatic =
        [<Emit "new $0($1...)">] abstract Create: width: float * height: float * ?options: WebGLRenderTargetOptions -> WebGLRenderTargetCube

module __scenes_Fog =
    type Color = __math_Color.Color

    type [<AllowNullLiteral>] IExports =
        abstract Fog: FogStatic

    type [<AllowNullLiteral>] IFog =
        abstract name: string with get, set
        abstract color: Color with get, set
        abstract clone: unit -> IFog
        abstract toJSON: unit -> obj option

    /// This class contains the parameters that define linear fog, i.e., that grows linearly denser with the distance.
    type [<AllowNullLiteral>] Fog =
        inherit IFog
        abstract name: string with get, set
        /// Fog color.
        abstract color: Color with get, set
        /// The minimum distance to start applying fog. Objects that are less than 'near' units from the active camera won't be affected by fog.
        abstract near: float with get, set
        /// The maximum distance at which fog stops being calculated and applied. Objects that are more than 'far' units away from the active camera won't be affected by fog.
        /// Default is 1000.
        abstract far: float with get, set
        abstract clone: unit -> Fog
        abstract toJSON: unit -> obj option

    /// This class contains the parameters that define linear fog, i.e., that grows linearly denser with the distance.
    type [<AllowNullLiteral>] FogStatic =
        [<Emit "new $0($1...)">] abstract Create: hex: float * ?near: float * ?far: float -> Fog

module __scenes_FogExp2 =
    type Color = __math_Color.Color
    type IFog = __scenes_Fog.IFog

    type [<AllowNullLiteral>] IExports =
        abstract FogExp2: FogExp2Static

    /// This class contains the parameters that define linear fog, i.e., that grows exponentially denser with the distance.
    type [<AllowNullLiteral>] FogExp2 =
        inherit IFog
        abstract name: string with get, set
        abstract color: Color with get, set
        /// Defines how fast the fog will grow dense.
        /// Default is 0.00025.
        abstract density: float with get, set
        abstract clone: unit -> FogExp2
        abstract toJSON: unit -> obj option

    /// This class contains the parameters that define linear fog, i.e., that grows exponentially denser with the distance.
    type [<AllowNullLiteral>] FogExp2Static =
        [<Emit "new $0($1...)">] abstract Create: hex: U2<float, string> * ?density: float -> FogExp2

module __scenes_Scene =
    type IFog = __scenes_Fog.IFog
    type Material = __materials_Material.Material
    type Object3D = __core_Object3D.Object3D
    type Color = __math_Color.Color
    type Texture = __textures_Texture.Texture

    type [<AllowNullLiteral>] IExports =
        abstract Scene: SceneStatic

    /// Scenes allow you to set up what and where is to be rendered by three.js. This is where you place objects, lights and cameras.
    type [<AllowNullLiteral>] Scene =
        inherit Object3D
        abstract ``type``: string with get, set
        /// A fog instance defining the type of fog that affects everything rendered in the scene. Default is null.
        abstract fog: IFog option with get, set
        /// If not null, it will force everything in the scene to be rendered with that material. Default is null.
        abstract overrideMaterial: Material option with get, set
        abstract autoUpdate: bool with get, set
        abstract background: U2<Color, Texture> option with get, set
        abstract environment: Texture option with get, set
        abstract toJSON: ?meta: obj -> obj option
        abstract dispose: unit -> unit

    /// Scenes allow you to set up what and where is to be rendered by three.js. This is where you place objects, lights and cameras.
    type [<AllowNullLiteral>] SceneStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Scene

module __textures_CanvasTexture =
    type Texture = __textures_Texture.Texture
    type Mapping = Constants.Mapping
    type Wrapping = Constants.Wrapping
    type TextureFilter = Constants.TextureFilter
    type PixelFormat = Constants.PixelFormat
    type TextureDataType = Constants.TextureDataType

    type [<AllowNullLiteral>] IExports =
        abstract CanvasTexture: CanvasTextureStatic

    type [<AllowNullLiteral>] CanvasTexture =
        inherit Texture

    type [<AllowNullLiteral>] CanvasTextureStatic =
        [<Emit "new $0($1...)">] abstract Create: canvas: U3<HTMLImageElement, HTMLCanvasElement, HTMLVideoElement> * ?mapping: Mapping * ?wrapS: Wrapping * ?wrapT: Wrapping * ?magFilter: TextureFilter * ?minFilter: TextureFilter * ?format: PixelFormat * ?``type``: TextureDataType * ?anisotropy: float -> CanvasTexture

module __textures_CompressedTexture =
    type Texture = __textures_Texture.Texture
    type Mapping = Constants.Mapping
    type Wrapping = Constants.Wrapping
    type TextureFilter = Constants.TextureFilter
    type CompressedPixelFormat = Constants.CompressedPixelFormat
    type TextureDataType = Constants.TextureDataType
    type TextureEncoding = Constants.TextureEncoding

    type [<AllowNullLiteral>] IExports =
        abstract CompressedTexture: CompressedTextureStatic

    type [<AllowNullLiteral>] CompressedTexture =
        inherit Texture
        abstract image: CompressedTextureImage with get, set

    type [<AllowNullLiteral>] CompressedTextureStatic =
        [<Emit "new $0($1...)">] abstract Create: mipmaps: ResizeArray<ImageData> * width: float * height: float * ?format: CompressedPixelFormat * ?``type``: TextureDataType * ?mapping: Mapping * ?wrapS: Wrapping * ?wrapT: Wrapping * ?magFilter: TextureFilter * ?minFilter: TextureFilter * ?anisotropy: float * ?encoding: TextureEncoding -> CompressedTexture

    type [<AllowNullLiteral>] CompressedTextureImage =
        abstract width: float with get, set
        abstract height: float with get, set

module __textures_CubeTexture =
    type Texture = __textures_Texture.Texture
    type Mapping = Constants.Mapping
    type Wrapping = Constants.Wrapping
    type TextureFilter = Constants.TextureFilter
    type PixelFormat = Constants.PixelFormat
    type TextureDataType = Constants.TextureDataType
    type TextureEncoding = Constants.TextureEncoding

    type [<AllowNullLiteral>] IExports =
        abstract CubeTexture: CubeTextureStatic

    type [<AllowNullLiteral>] CubeTexture =
        inherit Texture
        abstract images: obj option with get, set

    type [<AllowNullLiteral>] CubeTextureStatic =
        [<Emit "new $0($1...)">] abstract Create: ?images: ResizeArray<obj option> * ?mapping: Mapping * ?wrapS: Wrapping * ?wrapT: Wrapping * ?magFilter: TextureFilter * ?minFilter: TextureFilter * ?format: PixelFormat * ?``type``: TextureDataType * ?anisotropy: float * ?encoding: TextureEncoding -> CubeTexture

module __textures_DataTexture =
    type Texture = __textures_Texture.Texture
    type Mapping = Constants.Mapping
    type Wrapping = Constants.Wrapping
    type TextureFilter = Constants.TextureFilter
    type PixelFormat = Constants.PixelFormat
    type TextureDataType = Constants.TextureDataType
    type TextureEncoding = Constants.TextureEncoding
    type TypedArray = Polyfills.TypedArray

    type [<AllowNullLiteral>] IExports =
        abstract DataTexture: DataTextureStatic

    type [<AllowNullLiteral>] DataTexture =
        inherit Texture
        abstract image: ImageData with get, set

    type [<AllowNullLiteral>] DataTextureStatic =
        [<Emit "new $0($1...)">] abstract Create: data: TypedArray * width: float * height: float * ?format: PixelFormat * ?``type``: TextureDataType * ?mapping: Mapping * ?wrapS: Wrapping * ?wrapT: Wrapping * ?magFilter: TextureFilter * ?minFilter: TextureFilter * ?anisotropy: float * ?encoding: TextureEncoding -> DataTexture

module __textures_DataTexture2DArray =
    type Texture = __textures_Texture.Texture
    type TypedArray = Polyfills.TypedArray

    type [<AllowNullLiteral>] IExports =
        abstract DataTexture2DArray: DataTexture2DArrayStatic

    type [<AllowNullLiteral>] DataTexture2DArray =
        inherit Texture

    type [<AllowNullLiteral>] DataTexture2DArrayStatic =
        [<Emit "new $0($1...)">] abstract Create: data: TypedArray * width: float * height: float * depth: float -> DataTexture2DArray

module __textures_DataTexture3D =
    type Texture = __textures_Texture.Texture
    type TypedArray = Polyfills.TypedArray

    type [<AllowNullLiteral>] IExports =
        abstract DataTexture3D: DataTexture3DStatic

    type [<AllowNullLiteral>] DataTexture3D =
        inherit Texture

    type [<AllowNullLiteral>] DataTexture3DStatic =
        [<Emit "new $0($1...)">] abstract Create: data: TypedArray * width: float * height: float * depth: float -> DataTexture3D

module __textures_DepthTexture =
    type Texture = __textures_Texture.Texture
    type Mapping = Constants.Mapping
    type Wrapping = Constants.Wrapping
    type TextureFilter = Constants.TextureFilter
    type TextureDataType = Constants.TextureDataType

    type [<AllowNullLiteral>] IExports =
        abstract DepthTexture: DepthTextureStatic

    type [<AllowNullLiteral>] DepthTexture =
        inherit Texture
        abstract image: DepthTextureImage with get, set

    type [<AllowNullLiteral>] DepthTextureStatic =
        [<Emit "new $0($1...)">] abstract Create: width: float * heighht: float * ?``type``: TextureDataType * ?mapping: Mapping * ?wrapS: Wrapping * ?wrapT: Wrapping * ?magFilter: TextureFilter * ?minFilter: TextureFilter * ?anisotropy: float -> DepthTexture

    type [<AllowNullLiteral>] DepthTextureImage =
        abstract width: float with get, set
        abstract height: float with get, set

module __textures_Texture =
    type Vector2 = __math_Vector2.Vector2
    type Vector = __math_Vector2.Vector
    type EventDispatcher = __core_EventDispatcher.EventDispatcher
    type Mapping = Constants.Mapping
    type Wrapping = Constants.Wrapping
    type TextureFilter = Constants.TextureFilter
    type PixelFormat = Constants.PixelFormat
    type PixelFormatGPU = Constants.PixelFormatGPU
    type TextureDataType = Constants.TextureDataType
    type TextureEncoding = Constants.TextureEncoding

    type [<AllowNullLiteral>] IExports =
        abstract TextureIdCount: float
        abstract Texture: TextureStatic

    type [<AllowNullLiteral>] Texture =
        inherit EventDispatcher
        abstract id: float with get, set
        abstract uuid: string with get, set
        abstract name: string with get, set
        abstract sourceFile: string with get, set
        abstract image: obj option with get, set
        abstract mipmaps: ResizeArray<ImageData> with get, set
        abstract mapping: Mapping with get, set
        abstract wrapS: Wrapping with get, set
        abstract wrapT: Wrapping with get, set
        abstract magFilter: TextureFilter with get, set
        abstract minFilter: TextureFilter with get, set
        abstract anisotropy: float with get, set
        abstract format: PixelFormat with get, set
        abstract internalFormat: PixelFormatGPU option with get, set
        abstract ``type``: TextureDataType with get, set
        abstract offset: Vector2 with get, set
        abstract repeat: Vector2 with get, set
        abstract center: Vector2 with get, set
        abstract rotation: float with get, set
        abstract generateMipmaps: bool with get, set
        abstract premultiplyAlpha: bool with get, set
        abstract flipY: bool with get, set
        abstract unpackAlignment: float with get, set
        abstract encoding: TextureEncoding with get, set
        abstract version: float with get, set
        abstract needsUpdate: bool with get, set
        abstract onUpdate: (unit -> unit) with get, set
        abstract clone: unit -> Texture
        abstract copy: source: Texture -> Texture
        abstract toJSON: meta: obj option -> obj option
        abstract dispose: unit -> unit
        abstract transformUv: uv: Vector -> unit

    type [<AllowNullLiteral>] TextureStatic =
        [<Emit "new $0($1...)">] abstract Create: ?image: U3<HTMLImageElement, HTMLCanvasElement, HTMLVideoElement> * ?mapping: Mapping * ?wrapS: Wrapping * ?wrapT: Wrapping * ?magFilter: TextureFilter * ?minFilter: TextureFilter * ?format: PixelFormat * ?``type``: TextureDataType * ?anisotropy: float * ?encoding: TextureEncoding -> Texture
        abstract DEFAULT_IMAGE: obj option with get, set
        abstract DEFAULT_MAPPING: obj option with get, set

module __textures_VideoTexture =
    type Texture = __textures_Texture.Texture
    type Mapping = Constants.Mapping
    type Wrapping = Constants.Wrapping
    type TextureFilter = Constants.TextureFilter
    type PixelFormat = Constants.PixelFormat
    type TextureDataType = Constants.TextureDataType

    type [<AllowNullLiteral>] IExports =
        abstract VideoTexture: VideoTextureStatic

    type [<AllowNullLiteral>] VideoTexture =
        inherit Texture

    type [<AllowNullLiteral>] VideoTextureStatic =
        [<Emit "new $0($1...)">] abstract Create: video: HTMLVideoElement * ?mapping: Mapping * ?wrapS: Wrapping * ?wrapT: Wrapping * ?magFilter: TextureFilter * ?minFilter: TextureFilter * ?format: PixelFormat * ?``type``: TextureDataType * ?anisotropy: float -> VideoTexture

module __animation_tracks_BooleanKeyframeTrack =
    type KeyframeTrack = __animation_KeyframeTrack.KeyframeTrack

    type [<AllowNullLiteral>] IExports =
        abstract BooleanKeyframeTrack: BooleanKeyframeTrackStatic

    type [<AllowNullLiteral>] BooleanKeyframeTrack =
        inherit KeyframeTrack

    type [<AllowNullLiteral>] BooleanKeyframeTrackStatic =
        [<Emit "new $0($1...)">] abstract Create: name: string * times: ResizeArray<obj option> * values: ResizeArray<obj option> -> BooleanKeyframeTrack

module __animation_tracks_ColorKeyframeTrack =
    type KeyframeTrack = __animation_KeyframeTrack.KeyframeTrack
    type InterpolationModes = Constants.InterpolationModes

    type [<AllowNullLiteral>] IExports =
        abstract ColorKeyframeTrack: ColorKeyframeTrackStatic

    type [<AllowNullLiteral>] ColorKeyframeTrack =
        inherit KeyframeTrack

    type [<AllowNullLiteral>] ColorKeyframeTrackStatic =
        [<Emit "new $0($1...)">] abstract Create: name: string * times: ResizeArray<obj option> * values: ResizeArray<obj option> * ?interpolation: InterpolationModes -> ColorKeyframeTrack

module __animation_tracks_NumberKeyframeTrack =
    type KeyframeTrack = __animation_KeyframeTrack.KeyframeTrack
    type InterpolationModes = Constants.InterpolationModes

    type [<AllowNullLiteral>] IExports =
        abstract NumberKeyframeTrack: NumberKeyframeTrackStatic

    type [<AllowNullLiteral>] NumberKeyframeTrack =
        inherit KeyframeTrack

    type [<AllowNullLiteral>] NumberKeyframeTrackStatic =
        [<Emit "new $0($1...)">] abstract Create: name: string * times: ResizeArray<obj option> * values: ResizeArray<obj option> * ?interpolation: InterpolationModes -> NumberKeyframeTrack

module __animation_tracks_QuaternionKeyframeTrack =
    type KeyframeTrack = __animation_KeyframeTrack.KeyframeTrack
    type InterpolationModes = Constants.InterpolationModes

    type [<AllowNullLiteral>] IExports =
        abstract QuaternionKeyframeTrack: QuaternionKeyframeTrackStatic

    type [<AllowNullLiteral>] QuaternionKeyframeTrack =
        inherit KeyframeTrack

    type [<AllowNullLiteral>] QuaternionKeyframeTrackStatic =
        [<Emit "new $0($1...)">] abstract Create: name: string * times: ResizeArray<obj option> * values: ResizeArray<obj option> * ?interpolation: InterpolationModes -> QuaternionKeyframeTrack

module __animation_tracks_StringKeyframeTrack =
    type KeyframeTrack = __animation_KeyframeTrack.KeyframeTrack
    type InterpolationModes = Constants.InterpolationModes

    type [<AllowNullLiteral>] IExports =
        abstract StringKeyframeTrack: StringKeyframeTrackStatic

    type [<AllowNullLiteral>] StringKeyframeTrack =
        inherit KeyframeTrack

    type [<AllowNullLiteral>] StringKeyframeTrackStatic =
        [<Emit "new $0($1...)">] abstract Create: name: string * times: ResizeArray<obj option> * values: ResizeArray<obj option> * ?interpolation: InterpolationModes -> StringKeyframeTrack

module __animation_tracks_VectorKeyframeTrack =
    type KeyframeTrack = __animation_KeyframeTrack.KeyframeTrack
    type InterpolationModes = Constants.InterpolationModes

    type [<AllowNullLiteral>] IExports =
        abstract VectorKeyframeTrack: VectorKeyframeTrackStatic

    type [<AllowNullLiteral>] VectorKeyframeTrack =
        inherit KeyframeTrack

    type [<AllowNullLiteral>] VectorKeyframeTrackStatic =
        [<Emit "new $0($1...)">] abstract Create: name: string * times: ResizeArray<obj option> * values: ResizeArray<obj option> * ?interpolation: InterpolationModes -> VectorKeyframeTrack

module __extras_core_Curve =
    type Vector = __math_Vector2.Vector

    type [<AllowNullLiteral>] IExports =
        abstract Curve: CurveStatic

    /// An extensible curve object which contains methods for interpolation
    /// class Curve&lt;T extends Vector&gt;
    type [<AllowNullLiteral>] Curve<'T> =
        /// This value determines the amount of divisions when calculating the cumulative segment lengths of a curve via .getLengths.
        /// To ensure precision when using methods like .getSpacedPoints, it is recommended to increase .arcLengthDivisions if the curve is very large.
        /// Default is 200.
        abstract arcLengthDivisions: float with get, set
        /// Returns a vector for point t of the curve where t is between 0 and 1
        /// getPoint(t: number): T;
        abstract getPoint: t: float * ?optionalTarget: 'T -> 'T
        /// Returns a vector for point at relative position in curve according to arc length
        /// getPointAt(u: number): T;
        abstract getPointAt: u: float * ?optionalTarget: 'T -> 'T
        /// Get sequence of points using getPoint( t )
        /// getPoints(divisions?: number): T[];
        abstract getPoints: ?divisions: float -> ResizeArray<'T>
        /// Get sequence of equi-spaced points using getPointAt( u )
        /// getSpacedPoints(divisions?: number): T[];
        abstract getSpacedPoints: ?divisions: float -> ResizeArray<'T>
        /// Get total curve arc length
        abstract getLength: unit -> float
        /// Get list of cumulative segment lengths
        abstract getLengths: ?divisions: float -> ResizeArray<float>
        /// Update the cumlative segment distance cache
        abstract updateArcLengths: unit -> unit
        /// Given u ( 0 .. 1 ), get a t to find p. This gives you points which are equi distance
        abstract getUtoTmapping: u: float * distance: float -> float
        /// Returns a unit vector tangent at t. If the subclassed curve do not implement its tangent derivation, 2 points a small delta apart will be used to find its gradient which seems to give a reasonable approximation
        /// getTangent(t: number): T;
        abstract getTangent: t: float -> 'T
        /// Returns tangent at equidistance point u on the curve
        /// getTangentAt(u: number): T;
        abstract getTangentAt: u: float -> 'T

    /// An extensible curve object which contains methods for interpolation
    /// class Curve&lt;T extends Vector&gt;
    type [<AllowNullLiteral>] CurveStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Curve<'T>
        abstract create: constructorFunc: Function * getPointFunc: Function -> Function

module __extras_core_CurvePath =
    type Curve<'a> = __extras_core_Curve.Curve<'a>
    type Geometry = __core_Geometry.Geometry
    type Vector = __math_Vector2.Vector

    type [<AllowNullLiteral>] IExports =
        abstract CurvePath: CurvePathStatic

    type [<AllowNullLiteral>] CurvePath<'T> =
        inherit Curve<'T>
        abstract curves: ResizeArray<Curve<'T>> with get, set
        abstract autoClose: bool with get, set
        abstract add: curve: Curve<'T> -> unit
        abstract checkConnection: unit -> bool
        abstract closePath: unit -> unit
        abstract getPoint: t: float -> 'T
        abstract getLength: unit -> float
        abstract updateArcLengths: unit -> unit
        abstract getCurveLengths: unit -> ResizeArray<float>
        abstract getSpacedPoints: ?divisions: float -> ResizeArray<'T>
        abstract getPoints: ?divisions: float -> ResizeArray<'T>
        abstract createPointsGeometry: divisions: float -> Geometry
        abstract createSpacedPointsGeometry: divisions: float -> Geometry
        abstract createGeometry: points: ResizeArray<'T> -> Geometry

    type [<AllowNullLiteral>] CurvePathStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> CurvePath<'T>

module __extras_core_Font =
    type Shape = __extras_core_Shape.Shape

    type [<AllowNullLiteral>] IExports =
        abstract Font: FontStatic

    type [<AllowNullLiteral>] Font =
        abstract data: string with get, set
        abstract generateShapes: text: string * size: float -> ResizeArray<Shape>

    type [<AllowNullLiteral>] FontStatic =
        [<Emit "new $0($1...)">] abstract Create: jsondata: obj option -> Font

module __extras_core_Interpolations =
    let [<Import("Interpolations","three/extras/core/Interpolations")>] interpolations: Interpolations.IExports = jsNative

    module Interpolations =

        type [<AllowNullLiteral>] IExports =
            abstract CatmullRom: t: float * p0: float * p1: float * p2: float * p3: float -> float
            abstract QuadraticBezier: t: float * p0: float * p1: float * p2: float -> float
            abstract CubicBezier: t: float * p0: float * p1: float * p2: float * p3: float -> float

module __extras_core_Path =
    type Vector2 = __math_Vector2.Vector2
    type CurvePath<'a> = __extras_core_CurvePath.CurvePath<'a>

    type [<AllowNullLiteral>] IExports =
        abstract Path: PathStatic

    type PathActions =
        obj

    type [<AllowNullLiteral>] PathAction =
        abstract action: PathActions with get, set
        abstract args: obj option with get, set

    /// a 2d path representation, comprising of points, lines, and cubes, similar to the html5 2d canvas api. It extends CurvePath.
    type [<AllowNullLiteral>] Path =
        inherit CurvePath<Vector2>
        abstract currentPoint: Vector2 with get, set
        abstract fromPoints: vectors: ResizeArray<Vector2> -> Path
        abstract setFromPoints: vectors: ResizeArray<Vector2> -> Path
        abstract moveTo: x: float * y: float -> Path
        abstract lineTo: x: float * y: float -> Path
        abstract quadraticCurveTo: aCPx: float * aCPy: float * aX: float * aY: float -> Path
        abstract bezierCurveTo: aCP1x: float * aCP1y: float * aCP2x: float * aCP2y: float * aX: float * aY: float -> Path
        abstract splineThru: pts: ResizeArray<Vector2> -> Path
        abstract arc: aX: float * aY: float * aRadius: float * aStartAngle: float * aEndAngle: float * aClockwise: bool -> Path
        abstract absarc: aX: float * aY: float * aRadius: float * aStartAngle: float * aEndAngle: float * aClockwise: bool -> Path
        abstract ellipse: aX: float * aY: float * xRadius: float * yRadius: float * aStartAngle: float * aEndAngle: float * aClockwise: bool * aRotation: float -> Path
        abstract absellipse: aX: float * aY: float * xRadius: float * yRadius: float * aStartAngle: float * aEndAngle: float * aClockwise: bool * aRotation: float -> Path

    /// a 2d path representation, comprising of points, lines, and cubes, similar to the html5 2d canvas api. It extends CurvePath.
    type [<AllowNullLiteral>] PathStatic =
        [<Emit "new $0($1...)">] abstract Create: ?points: ResizeArray<Vector2> -> Path

module __extras_core_Shape =
    type Vector2 = __math_Vector2.Vector2
    type Path = __extras_core_Path.Path
    type ExtrudeGeometry = __geometries_ExtrudeGeometry.ExtrudeGeometry
    type ShapeGeometry = __geometries_ShapeGeometry.ShapeGeometry

    type [<AllowNullLiteral>] IExports =
        abstract Shape: ShapeStatic

    /// Defines a 2d shape plane using paths.
    type [<AllowNullLiteral>] Shape =
        inherit Path
        abstract holes: ResizeArray<Path> with get, set
        abstract extrude: ?options: obj -> ExtrudeGeometry
        abstract makeGeometry: ?options: obj -> ShapeGeometry
        abstract getPointsHoles: divisions: float -> ResizeArray<ResizeArray<Vector2>>
        abstract extractAllPoints: divisions: float -> ShapeExtractAllPointsReturn
        abstract extractPoints: divisions: float -> ShapeExtractPointsReturn

    type [<AllowNullLiteral>] ShapeExtractAllPointsReturn =
        abstract shape: ResizeArray<Vector2> with get, set
        abstract holes: ResizeArray<ResizeArray<Vector2>> with get, set

    type [<AllowNullLiteral>] ShapeExtractPointsReturn =
        abstract shape: ResizeArray<Vector2> with get, set
        abstract holes: ResizeArray<ResizeArray<Vector2>> with get, set

    /// Defines a 2d shape plane using paths.
    type [<AllowNullLiteral>] ShapeStatic =
        [<Emit "new $0($1...)">] abstract Create: ?points: ResizeArray<Vector2> -> Shape

module __extras_core_ShapePath =
    type Vector2 = __math_Vector2.Vector2
    type Shape = __extras_core_Shape.Shape

    type [<AllowNullLiteral>] IExports =
        abstract ShapePath: ShapePathStatic

    type [<AllowNullLiteral>] ShapePath =
        abstract subPaths: ResizeArray<obj option> with get, set
        abstract currentPath: obj option with get, set
        abstract moveTo: x: float * y: float -> ShapePath
        abstract lineTo: x: float * y: float -> ShapePath
        abstract quadraticCurveTo: aCPx: float * aCPy: float * aX: float * aY: float -> ShapePath
        abstract bezierCurveTo: aCP1x: float * aCP1y: float * aCP2x: float * aCP2y: float * aX: float * aY: float -> ShapePath
        abstract splineThru: pts: ResizeArray<Vector2> -> ShapePath
        abstract toShapes: isCCW: bool * ?noHoles: bool -> ResizeArray<Shape>

    type [<AllowNullLiteral>] ShapePathStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ShapePath

module __extras_curves_ArcCurve =
    type EllipseCurve = __extras_curves_EllipseCurve.EllipseCurve

    type [<AllowNullLiteral>] IExports =
        abstract ArcCurve: ArcCurveStatic

    type [<AllowNullLiteral>] ArcCurve =
        inherit EllipseCurve

    type [<AllowNullLiteral>] ArcCurveStatic =
        [<Emit "new $0($1...)">] abstract Create: aX: float * aY: float * aRadius: float * aStartAngle: float * aEndAngle: float * aClockwise: bool -> ArcCurve

module __extras_curves_CatmullRomCurve3 =
    type Vector3 = __math_Vector3.Vector3
    type Curve<'a> = __extras_core_Curve.Curve<'a>
    let [<Import("CurveUtils","three/extras/curves/CatmullRomCurve3")>] curveUtils: CurveUtils.IExports = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract CatmullRomCurve3: CatmullRomCurve3Static

    module CurveUtils =

        type [<AllowNullLiteral>] IExports =
            abstract tangentQuadraticBezier: t: float * p0: float * p1: float * p2: float -> float
            abstract tangentCubicBezier: t: float * p0: float * p1: float * p2: float * p3: float -> float
            abstract tangentSpline: t: float * p0: float * p1: float * p2: float * p3: float -> float
            abstract interpolate: p0: float * p1: float * p2: float * p3: float * t: float -> float

    type [<AllowNullLiteral>] CatmullRomCurve3 =
        inherit Curve<Vector3>
        abstract points: ResizeArray<Vector3> with get, set
        abstract getPoint: t: float -> Vector3

    type [<AllowNullLiteral>] CatmullRomCurve3Static =
        [<Emit "new $0($1...)">] abstract Create: ?points: ResizeArray<Vector3> * ?closed: bool * ?curveType: string * ?tension: float -> CatmullRomCurve3

module __extras_curves_CubicBezierCurve =
    type Vector2 = __math_Vector2.Vector2
    type Curve<'a> = __extras_core_Curve.Curve<'a>

    type [<AllowNullLiteral>] IExports =
        abstract CubicBezierCurve: CubicBezierCurveStatic

    type [<AllowNullLiteral>] CubicBezierCurve =
        inherit Curve<Vector2>
        abstract v0: Vector2 with get, set
        abstract v1: Vector2 with get, set
        abstract v2: Vector2 with get, set
        abstract v3: Vector2 with get, set

    type [<AllowNullLiteral>] CubicBezierCurveStatic =
        [<Emit "new $0($1...)">] abstract Create: v0: Vector2 * v1: Vector2 * v2: Vector2 * v3: Vector2 -> CubicBezierCurve

module __extras_curves_CubicBezierCurve3 =
    type Vector3 = __math_Vector3.Vector3
    type Curve<'a> = __extras_core_Curve.Curve<'a>

    type [<AllowNullLiteral>] IExports =
        abstract CubicBezierCurve3: CubicBezierCurve3Static

    type [<AllowNullLiteral>] CubicBezierCurve3 =
        inherit Curve<Vector3>
        abstract v0: Vector3 with get, set
        abstract v1: Vector3 with get, set
        abstract v2: Vector3 with get, set
        abstract v3: Vector3 with get, set
        abstract getPoint: t: float -> Vector3

    type [<AllowNullLiteral>] CubicBezierCurve3Static =
        [<Emit "new $0($1...)">] abstract Create: v0: Vector3 * v1: Vector3 * v2: Vector3 * v3: Vector3 -> CubicBezierCurve3

module __extras_curves_EllipseCurve =
    type Curve<'a> = __extras_core_Curve.Curve<'a>
    type Vector2 = __math_Vector2.Vector2

    type [<AllowNullLiteral>] IExports =
        abstract EllipseCurve: EllipseCurveStatic

    type [<AllowNullLiteral>] EllipseCurve =
        inherit Curve<Vector2>
        abstract aX: float with get, set
        abstract aY: float with get, set
        abstract xRadius: float with get, set
        abstract yRadius: float with get, set
        abstract aStartAngle: float with get, set
        abstract aEndAngle: float with get, set
        abstract aClockwise: bool with get, set
        abstract aRotation: float with get, set

    type [<AllowNullLiteral>] EllipseCurveStatic =
        [<Emit "new $0($1...)">] abstract Create: aX: float * aY: float * xRadius: float * yRadius: float * aStartAngle: float * aEndAngle: float * aClockwise: bool * aRotation: float -> EllipseCurve

module __extras_curves_LineCurve =
    type Vector2 = __math_Vector2.Vector2
    type Curve<'a> = __extras_core_Curve.Curve<'a>

    type [<AllowNullLiteral>] IExports =
        abstract LineCurve: LineCurveStatic

    type [<AllowNullLiteral>] LineCurve =
        inherit Curve<Vector2>
        abstract v1: Vector2 with get, set
        abstract v2: Vector2 with get, set

    type [<AllowNullLiteral>] LineCurveStatic =
        [<Emit "new $0($1...)">] abstract Create: v1: Vector2 * v2: Vector2 -> LineCurve

module __extras_curves_LineCurve3 =
    type Vector3 = __math_Vector3.Vector3
    type Curve<'a> = __extras_core_Curve.Curve<'a>

    type [<AllowNullLiteral>] IExports =
        abstract LineCurve3: LineCurve3Static

    type [<AllowNullLiteral>] LineCurve3 =
        inherit Curve<Vector3>
        abstract v1: Vector3 with get, set
        abstract v2: Vector3 with get, set
        abstract getPoint: t: float -> Vector3

    type [<AllowNullLiteral>] LineCurve3Static =
        [<Emit "new $0($1...)">] abstract Create: v1: Vector3 * v2: Vector3 -> LineCurve3

module __extras_curves_QuadraticBezierCurve =
    type Vector2 = __math_Vector2.Vector2
    type Curve<'a> = __extras_core_Curve.Curve<'a>

    type [<AllowNullLiteral>] IExports =
        abstract QuadraticBezierCurve: QuadraticBezierCurveStatic

    type [<AllowNullLiteral>] QuadraticBezierCurve =
        inherit Curve<Vector2>
        abstract v0: Vector2 with get, set
        abstract v1: Vector2 with get, set
        abstract v2: Vector2 with get, set

    type [<AllowNullLiteral>] QuadraticBezierCurveStatic =
        [<Emit "new $0($1...)">] abstract Create: v0: Vector2 * v1: Vector2 * v2: Vector2 -> QuadraticBezierCurve

module __extras_curves_QuadraticBezierCurve3 =
    type Vector3 = __math_Vector3.Vector3
    type Curve<'a> = __extras_core_Curve.Curve<'a>

    type [<AllowNullLiteral>] IExports =
        abstract QuadraticBezierCurve3: QuadraticBezierCurve3Static

    type [<AllowNullLiteral>] QuadraticBezierCurve3 =
        inherit Curve<Vector3>
        abstract v0: Vector3 with get, set
        abstract v1: Vector3 with get, set
        abstract v2: Vector3 with get, set
        abstract getPoint: t: float -> Vector3

    type [<AllowNullLiteral>] QuadraticBezierCurve3Static =
        [<Emit "new $0($1...)">] abstract Create: v0: Vector3 * v1: Vector3 * v2: Vector3 -> QuadraticBezierCurve3

module __extras_curves_SplineCurve =
    type Vector2 = __math_Vector2.Vector2
    type Curve<'a> = __extras_core_Curve.Curve<'a>

    type [<AllowNullLiteral>] IExports =
        abstract SplineCurve: SplineCurveStatic

    type [<AllowNullLiteral>] SplineCurve =
        inherit Curve<Vector2>
        abstract points: ResizeArray<Vector2> with get, set

    type [<AllowNullLiteral>] SplineCurveStatic =
        [<Emit "new $0($1...)">] abstract Create: ?points: ResizeArray<Vector2> -> SplineCurve

module __extras_objects_ImmediateRenderObject =
    type Object3D = __core_Object3D.Object3D
    type Material = __materials_Material.Material

    type [<AllowNullLiteral>] IExports =
        abstract ImmediateRenderObject: ImmediateRenderObjectStatic

    type [<AllowNullLiteral>] ImmediateRenderObject =
        inherit Object3D
        abstract material: Material with get, set
        abstract render: renderCallback: Function -> unit

    type [<AllowNullLiteral>] ImmediateRenderObjectStatic =
        [<Emit "new $0($1...)">] abstract Create: material: Material -> ImmediateRenderObject

module __math_interpolants_CubicInterpolant =
    type Interpolant = __math_Interpolant.Interpolant

    type [<AllowNullLiteral>] IExports =
        abstract CubicInterpolant: CubicInterpolantStatic

    type [<AllowNullLiteral>] CubicInterpolant =
        inherit Interpolant
        abstract interpolate_: i1: float * t0: float * t: float * t1: float -> obj option

    type [<AllowNullLiteral>] CubicInterpolantStatic =
        [<Emit "new $0($1...)">] abstract Create: parameterPositions: obj option * samplesValues: obj option * sampleSize: float * ?resultBuffer: obj -> CubicInterpolant

module __math_interpolants_DiscreteInterpolant =
    type Interpolant = __math_Interpolant.Interpolant

    type [<AllowNullLiteral>] IExports =
        abstract DiscreteInterpolant: DiscreteInterpolantStatic

    type [<AllowNullLiteral>] DiscreteInterpolant =
        inherit Interpolant
        abstract interpolate_: i1: float * t0: float * t: float * t1: float -> obj option

    type [<AllowNullLiteral>] DiscreteInterpolantStatic =
        [<Emit "new $0($1...)">] abstract Create: parameterPositions: obj option * samplesValues: obj option * sampleSize: float * ?resultBuffer: obj -> DiscreteInterpolant

module __math_interpolants_LinearInterpolant =
    type Interpolant = __math_Interpolant.Interpolant

    type [<AllowNullLiteral>] IExports =
        abstract LinearInterpolant: LinearInterpolantStatic

    type [<AllowNullLiteral>] LinearInterpolant =
        inherit Interpolant
        abstract interpolate_: i1: float * t0: float * t: float * t1: float -> obj option

    type [<AllowNullLiteral>] LinearInterpolantStatic =
        [<Emit "new $0($1...)">] abstract Create: parameterPositions: obj option * samplesValues: obj option * sampleSize: float * ?resultBuffer: obj -> LinearInterpolant

module __math_interpolants_QuaternionLinearInterpolant =
    type Interpolant = __math_Interpolant.Interpolant

    type [<AllowNullLiteral>] IExports =
        abstract QuaternionLinearInterpolant: QuaternionLinearInterpolantStatic

    type [<AllowNullLiteral>] QuaternionLinearInterpolant =
        inherit Interpolant
        abstract interpolate_: i1: float * t0: float * t: float * t1: float -> obj option

    type [<AllowNullLiteral>] QuaternionLinearInterpolantStatic =
        [<Emit "new $0($1...)">] abstract Create: parameterPositions: obj option * samplesValues: obj option * sampleSize: float * ?resultBuffer: obj -> QuaternionLinearInterpolant

module __renderers_shaders_ShaderChunk =

    type [<AllowNullLiteral>] IExports =
        abstract ShaderChunk: IExportsShaderChunk

    type [<AllowNullLiteral>] IExportsShaderChunk =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: name: string -> string with get, set
        abstract alphamap_fragment: string with get, set
        abstract alphamap_pars_fragment: string with get, set
        abstract alphatest_fragment: string with get, set
        abstract aomap_fragment: string with get, set
        abstract aomap_pars_fragment: string with get, set
        abstract begin_vertex: string with get, set
        abstract beginnormal_vertex: string with get, set
        abstract bsdfs: string with get, set
        abstract bumpmap_pars_fragment: string with get, set
        abstract clipping_planes_fragment: string with get, set
        abstract clipping_planes_pars_fragment: string with get, set
        abstract clipping_planes_pars_vertex: string with get, set
        abstract clipping_planes_vertex: string with get, set
        abstract color_fragment: string with get, set
        abstract color_pars_fragment: string with get, set
        abstract color_pars_vertex: string with get, set
        abstract color_vertex: string with get, set
        abstract common: string with get, set
        abstract cube_frag: string with get, set
        abstract cube_vert: string with get, set
        abstract cube_uv_reflection_fragment: string with get, set
        abstract defaultnormal_vertex: string with get, set
        abstract depth_frag: string with get, set
        abstract depth_vert: string with get, set
        abstract distanceRGBA_frag: string with get, set
        abstract distanceRGBA_vert: string with get, set
        abstract displacementmap_vertex: string with get, set
        abstract displacementmap_pars_vertex: string with get, set
        abstract emissivemap_fragment: string with get, set
        abstract emissivemap_pars_fragment: string with get, set
        abstract encodings_pars_fragment: string with get, set
        abstract encodings_fragment: string with get, set
        abstract envmap_fragment: string with get, set
        abstract envmap_common_pars_fragment: string with get, set
        abstract envmap_pars_fragment: string with get, set
        abstract envmap_pars_vertex: string with get, set
        abstract envmap_vertex: string with get, set
        abstract equirect_frag: string with get, set
        abstract equirect_vert: string with get, set
        abstract fog_fragment: string with get, set
        abstract fog_pars_fragment: string with get, set
        abstract linedashed_frag: string with get, set
        abstract linedashed_vert: string with get, set
        abstract lightmap_fragment: string with get, set
        abstract lightmap_pars_fragment: string with get, set
        abstract lights_lambert_vertex: string with get, set
        abstract lights_pars_begin: string with get, set
        abstract envmap_physical_pars_fragment: string with get, set
        abstract lights_pars_map: string with get, set
        abstract lights_phong_fragment: string with get, set
        abstract lights_phong_pars_fragment: string with get, set
        abstract lights_physical_fragment: string with get, set
        abstract lights_physical_pars_fragment: string with get, set
        abstract lights_fragment_begin: string with get, set
        abstract lights_fragment_maps: string with get, set
        abstract lights_fragment_end: string with get, set
        abstract logdepthbuf_fragment: string with get, set
        abstract logdepthbuf_pars_fragment: string with get, set
        abstract logdepthbuf_pars_vertex: string with get, set
        abstract logdepthbuf_vertex: string with get, set
        abstract map_fragment: string with get, set
        abstract map_pars_fragment: string with get, set
        abstract map_particle_fragment: string with get, set
        abstract map_particle_pars_fragment: string with get, set
        abstract meshbasic_frag: string with get, set
        abstract meshbasic_vert: string with get, set
        abstract meshlambert_frag: string with get, set
        abstract meshlambert_vert: string with get, set
        abstract meshphong_frag: string with get, set
        abstract meshphong_vert: string with get, set
        abstract meshphysical_frag: string with get, set
        abstract meshphysical_vert: string with get, set
        abstract metalnessmap_fragment: string with get, set
        abstract metalnessmap_pars_fragment: string with get, set
        abstract morphnormal_vertex: string with get, set
        abstract morphtarget_pars_vertex: string with get, set
        abstract morphtarget_vertex: string with get, set
        abstract normal_flip: string with get, set
        abstract normal_frag: string with get, set
        abstract normal_fragment_begin: string with get, set
        abstract normal_fragment_maps: string with get, set
        abstract normal_vert: string with get, set
        abstract normalmap_pars_fragment: string with get, set
        abstract clearcoat_normal_fragment_begin: string with get, set
        abstract clearcoat_normal_fragment_maps: string with get, set
        abstract clearcoat_normalmap_pars_fragment: string with get, set
        abstract packing: string with get, set
        abstract points_frag: string with get, set
        abstract points_vert: string with get, set
        abstract shadow_frag: string with get, set
        abstract shadow_vert: string with get, set
        abstract premultiplied_alpha_fragment: string with get, set
        abstract project_vertex: string with get, set
        abstract roughnessmap_fragment: string with get, set
        abstract roughnessmap_pars_fragment: string with get, set
        abstract shadowmap_pars_fragment: string with get, set
        abstract shadowmap_pars_vertex: string with get, set
        abstract shadowmap_vertex: string with get, set
        abstract shadowmask_pars_fragment: string with get, set
        abstract skinbase_vertex: string with get, set
        abstract skinning_pars_vertex: string with get, set
        abstract skinning_vertex: string with get, set
        abstract skinnormal_vertex: string with get, set
        abstract specularmap_fragment: string with get, set
        abstract specularmap_pars_fragment: string with get, set
        abstract tonemapping_fragment: string with get, set
        abstract tonemapping_pars_fragment: string with get, set
        abstract uv2_pars_fragment: string with get, set
        abstract uv2_pars_vertex: string with get, set
        abstract uv2_vertex: string with get, set
        abstract uv_pars_fragment: string with get, set
        abstract uv_pars_vertex: string with get, set
        abstract uv_vertex: string with get, set
        abstract worldpos_vertex: string with get, set

module __renderers_shaders_ShaderLib =
    type IUniform = __renderers_shaders_UniformsLib.IUniform

    type [<AllowNullLiteral>] IExports =
        abstract ShaderLib: IExportsShaderLib

    type [<AllowNullLiteral>] Shader =
        abstract uniforms: ShaderUniforms with get, set
        abstract vertexShader: string with get, set
        abstract fragmentShader: string with get, set

    type [<AllowNullLiteral>] IExportsShaderLib =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: name: string -> Shader with get, set
        abstract basic: Shader with get, set
        abstract lambert: Shader with get, set
        abstract phong: Shader with get, set
        abstract standard: Shader with get, set
        abstract matcap: Shader with get, set
        abstract points: Shader with get, set
        abstract dashed: Shader with get, set
        abstract depth: Shader with get, set
        abstract normal: Shader with get, set
        abstract sprite: Shader with get, set
        abstract background: Shader with get, set
        abstract cube: Shader with get, set
        abstract equirect: Shader with get, set
        abstract distanceRGBA: Shader with get, set
        abstract shadow: Shader with get, set
        abstract physical: Shader with get, set

    type [<AllowNullLiteral>] ShaderUniforms =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: uniform: string -> IUniform with get, set

module __renderers_shaders_UniformsLib =

    type [<AllowNullLiteral>] IExports =
        abstract UniformsLib: IExportsUniformsLib

    type [<AllowNullLiteral>] IUniform =
        abstract value: obj option with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibCommon =
        abstract diffuse: IUniform with get, set
        abstract opacity: IUniform with get, set
        abstract map: IUniform with get, set
        abstract uvTransform: IUniform with get, set
        abstract uv2Transform: IUniform with get, set
        abstract alphaMap: IUniform with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibSpecularmap =
        abstract specularMap: IUniform with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibEnvmap =
        abstract envMap: IUniform with get, set
        abstract flipEnvMap: IUniform with get, set
        abstract reflectivity: IUniform with get, set
        abstract refractionRatio: IUniform with get, set
        abstract maxMipLevel: IUniform with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibAomap =
        abstract aoMap: IUniform with get, set
        abstract aoMapIntensity: IUniform with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibLightmap =
        abstract lightMap: IUniform with get, set
        abstract lightMapIntensity: IUniform with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibEmissivemap =
        abstract emissiveMap: IUniform with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibBumpmap =
        abstract bumpMap: IUniform with get, set
        abstract bumpScale: IUniform with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibNormalmap =
        abstract normalMap: IUniform with get, set
        abstract normalScale: IUniform with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibDisplacementmap =
        abstract displacementMap: IUniform with get, set
        abstract displacementScale: IUniform with get, set
        abstract displacementBias: IUniform with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibRoughnessmap =
        abstract roughnessMap: IUniform with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibMetalnessmap =
        abstract metalnessMap: IUniform with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibGradientmap =
        abstract gradientMap: IUniform with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibFog =
        abstract fogDensity: IUniform with get, set
        abstract fogNear: IUniform with get, set
        abstract fogFar: IUniform with get, set
        abstract fogColor: IUniform with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibLightsDirectionalLightsPropertiesDirection =
        interface end

    type [<AllowNullLiteral>] IExportsUniformsLibLightsDirectionalLightsProperties =
        abstract direction: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract color: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract shadow: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract shadowBias: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract shadowRadius: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract shadowMapSize: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibLightsDirectionalLights =
        abstract value: ResizeArray<obj option> with get, set
        abstract properties: IExportsUniformsLibLightsDirectionalLightsProperties with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibLightsSpotLightsProperties =
        abstract color: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract position: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract direction: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract distance: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract coneCos: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract penumbraCos: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract decay: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract shadow: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract shadowBias: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract shadowRadius: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract shadowMapSize: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibLightsSpotLights =
        abstract value: ResizeArray<obj option> with get, set
        abstract properties: IExportsUniformsLibLightsSpotLightsProperties with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibLightsPointLightsProperties =
        abstract color: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract position: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract decay: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract distance: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract shadow: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract shadowBias: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract shadowRadius: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract shadowMapSize: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibLightsPointLights =
        abstract value: ResizeArray<obj option> with get, set
        abstract properties: IExportsUniformsLibLightsPointLightsProperties with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibLightsHemisphereLightsProperties =
        abstract direction: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract skycolor: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract groundColor: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibLightsHemisphereLights =
        abstract value: ResizeArray<obj option> with get, set
        abstract properties: IExportsUniformsLibLightsHemisphereLightsProperties with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibLightsRectAreaLightsProperties =
        abstract color: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract position: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract width: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set
        abstract height: IExportsUniformsLibLightsDirectionalLightsPropertiesDirection with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibLightsRectAreaLights =
        abstract value: ResizeArray<obj option> with get, set
        abstract properties: IExportsUniformsLibLightsRectAreaLightsProperties with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibLights =
        abstract ambientLightColor: IUniform with get, set
        abstract directionalLights: IExportsUniformsLibLightsDirectionalLights with get, set
        abstract directionalShadowMap: IUniform with get, set
        abstract directionalShadowMatrix: IUniform with get, set
        abstract spotLights: IExportsUniformsLibLightsSpotLights with get, set
        abstract spotShadowMap: IUniform with get, set
        abstract spotShadowMatrix: IUniform with get, set
        abstract pointLights: IExportsUniformsLibLightsPointLights with get, set
        abstract pointShadowMap: IUniform with get, set
        abstract pointShadowMatrix: IUniform with get, set
        abstract hemisphereLights: IExportsUniformsLibLightsHemisphereLights with get, set
        abstract rectAreaLights: IExportsUniformsLibLightsRectAreaLights with get, set

    type [<AllowNullLiteral>] IExportsUniformsLibPoints =
        abstract diffuse: IUniform with get, set
        abstract opacity: IUniform with get, set
        abstract size: IUniform with get, set
        abstract scale: IUniform with get, set
        abstract map: IUniform with get, set
        abstract uvTransform: IUniform with get, set

    type [<AllowNullLiteral>] IExportsUniformsLib =
        abstract common: IExportsUniformsLibCommon with get, set
        abstract specularmap: IExportsUniformsLibSpecularmap with get, set
        abstract envmap: IExportsUniformsLibEnvmap with get, set
        abstract aomap: IExportsUniformsLibAomap with get, set
        abstract lightmap: IExportsUniformsLibLightmap with get, set
        abstract emissivemap: IExportsUniformsLibEmissivemap with get, set
        abstract bumpmap: IExportsUniformsLibBumpmap with get, set
        abstract normalmap: IExportsUniformsLibNormalmap with get, set
        abstract displacementmap: IExportsUniformsLibDisplacementmap with get, set
        abstract roughnessmap: IExportsUniformsLibRoughnessmap with get, set
        abstract metalnessmap: IExportsUniformsLibMetalnessmap with get, set
        abstract gradientmap: IExportsUniformsLibGradientmap with get, set
        abstract fog: IExportsUniformsLibFog with get, set
        abstract lights: IExportsUniformsLibLights with get, set
        abstract points: IExportsUniformsLibPoints with get, set

module __renderers_shaders_UniformsUtils =

    type [<AllowNullLiteral>] IExports =
        abstract cloneUniforms: uniforms_src: obj option -> obj option
        abstract mergeUniforms: uniforms: ResizeArray<obj option> -> obj option

module __renderers_webgl_WebGLAnimation =

    type [<AllowNullLiteral>] IExports =
        abstract WebGLAnimation: WebGLAnimationStatic

    type [<AllowNullLiteral>] WebGLAnimation =
        abstract start: unit -> unit
        abstract stop: unit -> unit
        abstract setAnimationLoop: callback: Function -> unit
        abstract setContext: value: U2<WebGLRenderingContext, WebGL2RenderingContext> -> unit

    type [<AllowNullLiteral>] WebGLAnimationStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> WebGLAnimation

module __renderers_webgl_WebGLAttributes =
    type BufferAttribute = __core_BufferAttribute.BufferAttribute
    type InterleavedBufferAttribute = __core_InterleavedBufferAttribute.InterleavedBufferAttribute

    type [<AllowNullLiteral>] IExports =
        abstract WebGLAttributes: WebGLAttributesStatic

    type [<AllowNullLiteral>] WebGLAttributes =
        abstract get: attribute: U2<BufferAttribute, InterleavedBufferAttribute> -> WebGLAttributesGetReturn
        abstract remove: attribute: U2<BufferAttribute, InterleavedBufferAttribute> -> unit
        abstract update: attribute: U2<BufferAttribute, InterleavedBufferAttribute> * bufferType: GLenum -> unit

    type [<AllowNullLiteral>] WebGLAttributesGetReturn =
        abstract buffer: WebGLBuffer with get, set
        abstract ``type``: GLenum with get, set
        abstract bytesPerElement: float with get, set
        abstract version: float with get, set

    type [<AllowNullLiteral>] WebGLAttributesStatic =
        [<Emit "new $0($1...)">] abstract Create: gl: U2<WebGLRenderingContext, WebGL2RenderingContext> -> WebGLAttributes

module __renderers_webgl_WebGLBackground =
    type Color = __math_Color.Color
    type WebGLRenderer = __renderers_WebGLRenderer.WebGLRenderer
    type WebGLState = __renderers_webgl_WebGLState.WebGLState
    type WebGLObjects = __renderers_webgl_WebGLObjects.WebGLObjects
    type WebGLRenderLists = __renderers_webgl_WebGLRenderLists.WebGLRenderLists
    type Scene = __scenes_Scene.Scene

    type [<AllowNullLiteral>] IExports =
        abstract WebGLBackground: WebGLBackgroundStatic

    type [<AllowNullLiteral>] WebGLBackground =
        abstract getClearColor: unit -> unit
        abstract setClearColor: color: Color * alpha: obj option -> unit
        abstract getClearAlpha: unit -> unit
        abstract setClearAlpha: alpha: obj option -> unit
        abstract render: renderList: WebGLRenderLists * scene: Scene * camera: obj option * forceClear: obj option -> unit

    type [<AllowNullLiteral>] WebGLBackgroundStatic =
        [<Emit "new $0($1...)">] abstract Create: renderer: WebGLRenderer * state: WebGLState * objects: WebGLObjects * premultipliedAlpha: obj option -> WebGLBackground

module __renderers_webgl_WebGLBufferRenderer =

    type [<AllowNullLiteral>] IExports =
        abstract WebGLBufferRenderer: WebGLBufferRendererStatic

    type [<AllowNullLiteral>] WebGLBufferRenderer =
        abstract setMode: value: obj option -> unit
        abstract render: start: obj option * count: float -> unit
        abstract renderInstances: geometry: obj option -> unit

    type [<AllowNullLiteral>] WebGLBufferRendererStatic =
        [<Emit "new $0($1...)">] abstract Create: _gl: WebGLRenderingContext * extensions: obj option * _infoRender: obj option -> WebGLBufferRenderer

module __renderers_webgl_WebGLCapabilities =

    type [<AllowNullLiteral>] IExports =
        abstract WebGLCapabilities: WebGLCapabilitiesStatic

    type [<AllowNullLiteral>] WebGLCapabilitiesParameters =
        abstract precision: string option with get, set
        abstract logarithmicDepthBuffer: bool option with get, set

    type [<AllowNullLiteral>] WebGLCapabilities =
        abstract isWebGL2: bool with get, set
        abstract precision: string with get, set
        abstract logarithmicDepthBuffer: bool with get, set
        abstract maxTextures: float with get, set
        abstract maxVertexTextures: float with get, set
        abstract maxTextureSize: float with get, set
        abstract maxCubemapSize: float with get, set
        abstract maxAttributes: float with get, set
        abstract maxVertexUniforms: float with get, set
        abstract maxVaryings: float with get, set
        abstract maxFragmentUniforms: float with get, set
        abstract vertexTextures: bool with get, set
        abstract floatFragmentTextures: bool with get, set
        abstract floatVertexTextures: bool with get, set
        abstract getMaxAnisotropy: unit -> float
        abstract getMaxPrecision: precision: string -> string

    type [<AllowNullLiteral>] WebGLCapabilitiesStatic =
        [<Emit "new $0($1...)">] abstract Create: gl: WebGLRenderingContext * extensions: obj option * parameters: WebGLCapabilitiesParameters -> WebGLCapabilities

module __renderers_webgl_WebGLClipping =
    type Camera = __cameras_Camera.Camera

    type [<AllowNullLiteral>] IExports =
        abstract WebGLClipping: WebGLClippingStatic

    type [<AllowNullLiteral>] WebGLClipping =
        abstract uniform: WebGLClippingUniform with get, set
        abstract numPlanes: float with get, set
        abstract init: planes: ResizeArray<obj option> * enableLocalClipping: bool * camera: Camera -> bool
        abstract beginShadows: unit -> unit
        abstract endShadows: unit -> unit
        abstract setState: planes: ResizeArray<obj option> * clipShadows: bool * camera: Camera * cache: bool * fromCache: bool -> unit

    type [<AllowNullLiteral>] WebGLClippingStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> WebGLClipping

    type [<AllowNullLiteral>] WebGLClippingUniform =
        abstract value: obj option with get, set
        abstract needsUpdate: bool with get, set

module __renderers_webgl_WebGLExtensions =

    type [<AllowNullLiteral>] IExports =
        abstract WebGLExtensions: WebGLExtensionsStatic

    type [<AllowNullLiteral>] WebGLExtensions =
        abstract get: name: string -> obj option

    type [<AllowNullLiteral>] WebGLExtensionsStatic =
        [<Emit "new $0($1...)">] abstract Create: gl: WebGLRenderingContext -> WebGLExtensions

module __renderers_webgl_WebGLGeometries =
    type WebGLAttributes = __renderers_webgl_WebGLAttributes.WebGLAttributes
    type WebGLInfo = __renderers_webgl_WebGLInfo.WebGLInfo
    type BufferAttribute = __core_BufferAttribute.BufferAttribute
    type BufferGeometry = __core_BufferGeometry.BufferGeometry
    type Geometry = __core_Geometry.Geometry
    type Object3D = __core_Object3D.Object3D

    type [<AllowNullLiteral>] IExports =
        abstract WebGLGeometries: WebGLGeometriesStatic

    type [<AllowNullLiteral>] WebGLGeometries =
        abstract get: ``object``: Object3D * geometry: U2<Geometry, BufferGeometry> -> BufferGeometry
        abstract update: geometry: U2<Geometry, BufferGeometry> -> unit
        abstract getWireframeAttribute: geometry: U2<Geometry, BufferGeometry> -> BufferAttribute

    type [<AllowNullLiteral>] WebGLGeometriesStatic =
        [<Emit "new $0($1...)">] abstract Create: gl: WebGLRenderingContext * attributes: WebGLAttributes * info: WebGLInfo -> WebGLGeometries

module __renderers_webgl_WebGLIndexedBufferRenderer =

    type [<AllowNullLiteral>] IExports =
        abstract WebGLIndexedBufferRenderer: WebGLIndexedBufferRendererStatic

    type [<AllowNullLiteral>] WebGLIndexedBufferRenderer =
        abstract setMode: value: obj option -> unit
        abstract setIndex: index: obj option -> unit
        abstract render: start: obj option * count: float -> unit
        abstract renderInstances: geometry: obj option * start: obj option * count: float * primcount: float -> unit

    type [<AllowNullLiteral>] WebGLIndexedBufferRendererStatic =
        [<Emit "new $0($1...)">] abstract Create: gl: WebGLRenderingContext * extensions: obj option * info: obj option * capabilities: obj option -> WebGLIndexedBufferRenderer

module __renderers_webgl_WebGLInfo =
    type WebGLProgram = __renderers_webgl_WebGLProgram.WebGLProgram

    type [<AllowNullLiteral>] IExports =
        abstract WebGLInfo: WebGLInfoStatic

    /// An object with a series of statistical information about the graphics board memory and the rendering process.
    type [<AllowNullLiteral>] WebGLInfo =
        abstract autoReset: bool with get, set
        abstract memory: WebGLInfoMemory with get, set
        abstract programs: ResizeArray<WebGLProgram> option with get, set
        abstract render: WebGLInfoRender with get, set
        abstract update: count: float * mode: GLenum * instanceCount: float -> unit
        abstract reset: unit -> unit

    /// An object with a series of statistical information about the graphics board memory and the rendering process.
    type [<AllowNullLiteral>] WebGLInfoStatic =
        [<Emit "new $0($1...)">] abstract Create: gl: WebGLRenderingContext -> WebGLInfo

    type [<AllowNullLiteral>] WebGLInfoMemory =
        abstract geometries: float with get, set
        abstract textures: float with get, set

    type [<AllowNullLiteral>] WebGLInfoRender =
        abstract calls: float with get, set
        abstract frame: float with get, set
        abstract lines: float with get, set
        abstract points: float with get, set
        abstract triangles: float with get, set

module __renderers_webgl_WebGLLights =

    type [<AllowNullLiteral>] IExports =
        abstract WebGLLights: WebGLLightsStatic

    type [<AllowNullLiteral>] WebGLLights =
        abstract state: WebGLLightsState with get, set
        abstract get: light: obj option -> obj option
        abstract setup: lights: obj option * shadows: obj option * camera: obj option -> unit

    type [<AllowNullLiteral>] WebGLLightsStatic =
        [<Emit "new $0($1...)">] abstract Create: gl: WebGLRenderingContext * properties: obj option * info: obj option -> WebGLLights

    type [<AllowNullLiteral>] WebGLLightsStateHash =
        abstract directionalLength: float with get, set
        abstract pointLength: float with get, set
        abstract spotLength: float with get, set
        abstract rectAreaLength: float with get, set
        abstract hemiLength: float with get, set
        abstract numDirectionalShadows: float with get, set
        abstract numPointShadows: float with get, set
        abstract numSpotShadows: float with get, set

    type [<AllowNullLiteral>] WebGLLightsState =
        abstract version: float with get, set
        abstract hash: WebGLLightsStateHash with get, set
        abstract ambient: Array<float> with get, set
        abstract probe: Array<obj option> with get, set
        abstract directional: Array<obj option> with get, set
        abstract directionalShadowMap: Array<obj option> with get, set
        abstract directionalShadowMatrix: Array<obj option> with get, set
        abstract spot: Array<obj option> with get, set
        abstract spotShadowMap: Array<obj option> with get, set
        abstract spotShadowMatrix: Array<obj option> with get, set
        abstract rectArea: Array<obj option> with get, set
        abstract point: Array<obj option> with get, set
        abstract pointShadowMap: Array<obj option> with get, set
        abstract pointShadowMatrix: Array<obj option> with get, set
        abstract hemi: Array<obj option> with get, set
        abstract numDirectionalShadows: float with get, set
        abstract numPointShadows: float with get, set
        abstract numSpotShadows: float with get, set

module __renderers_webgl_WebGLMorphtargets =
    type Object3D = __core_Object3D.Object3D
    type BufferGeometry = __core_BufferGeometry.BufferGeometry
    type Material = __materials_Material.Material
    type WebGLProgram = __renderers_webgl_WebGLProgram.WebGLProgram

    type [<AllowNullLiteral>] IExports =
        abstract WebGLMorphtargets: WebGLMorphtargetsStatic

    type [<AllowNullLiteral>] WebGLMorphtargets =
        abstract update: ``object``: Object3D * geometry: BufferGeometry * material: Material * program: WebGLProgram -> unit

    type [<AllowNullLiteral>] WebGLMorphtargetsStatic =
        [<Emit "new $0($1...)">] abstract Create: gl: WebGLRenderingContext -> WebGLMorphtargets

module __renderers_webgl_WebGLMultiview =
    type Camera = __cameras_Camera.Camera
    type Object3D = __core_Object3D.Object3D
    type WebGLRenderer = __renderers_WebGLRenderer.WebGLRenderer
    type WebGLUniforms = __renderers_webgl_WebGLUniforms.WebGLUniforms

    type [<AllowNullLiteral>] IExports =
        abstract WebGLMultiview: WebGLMultiviewStatic

    type [<AllowNullLiteral>] WebGLMultiview =
        abstract isAvailable: unit -> bool
        abstract attachCamera: camera: Camera -> unit
        abstract detachCamera: camera: Camera -> unit
        abstract updateCameraProjectionMatricesUniform: camera: Camera * uniforms: WebGLUniforms -> unit
        abstract updateCameraViewMatricesUniform: camera: Camera * uniforms: WebGLUniforms -> unit
        abstract updateObjectMatricesUniforms: ``object``: Object3D * camera: Camera * uniforms: WebGLUniforms -> unit

    type [<AllowNullLiteral>] WebGLMultiviewStatic =
        [<Emit "new $0($1...)">] abstract Create: renderer: WebGLRenderer * gl: WebGLRenderingContext -> WebGLMultiview

module __renderers_webgl_WebGLObjects =

    type [<AllowNullLiteral>] IExports =
        abstract WebGLObjects: WebGLObjectsStatic

    type [<AllowNullLiteral>] WebGLObjects =
        abstract update: ``object``: obj option -> obj option
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] WebGLObjectsStatic =
        [<Emit "new $0($1...)">] abstract Create: gl: WebGLRenderingContext * geometries: obj option * attributes: obj option * info: obj option -> WebGLObjects

module __renderers_webgl_WebGLProgram =
    type WebGLRenderer = __renderers_WebGLRenderer.WebGLRenderer
    type WebGLRendererParameters = __renderers_WebGLRenderer.WebGLRendererParameters
    type ShaderMaterial = __materials_ShaderMaterial.ShaderMaterial
    type WebGLShader = __renderers_webgl_WebGLShader.WebGLShader
    type WebGLExtensions = __renderers_webgl_WebGLExtensions.WebGLExtensions
    type WebGLUniforms = __renderers_webgl_WebGLUniforms.WebGLUniforms

    type [<AllowNullLiteral>] IExports =
        abstract WebGLProgram: WebGLProgramStatic

    type [<AllowNullLiteral>] WebGLProgram =
        abstract id: float with get, set
        abstract cacheKey: string with get, set
        abstract usedTimes: float with get, set
        abstract program: obj option with get, set
        abstract vertexShader: WebGLShader with get, set
        abstract fragmentShader: WebGLShader with get, set
        abstract uniforms: obj option with get, set
        abstract attributes: obj option with get, set
        abstract getUniforms: unit -> WebGLUniforms
        abstract getAttributes: unit -> obj option
        abstract destroy: unit -> unit

    type [<AllowNullLiteral>] WebGLProgramStatic =
        [<Emit "new $0($1...)">] abstract Create: renderer: WebGLRenderer * extensions: WebGLExtensions * cacheKey: string * material: ShaderMaterial * shader: WebGLShader * parameters: WebGLRendererParameters -> WebGLProgram

module __renderers_webgl_WebGLPrograms =
    type WebGLRenderer = __renderers_WebGLRenderer.WebGLRenderer
    type WebGLProgram = __renderers_webgl_WebGLProgram.WebGLProgram
    type WebGLCapabilities = __renderers_webgl_WebGLCapabilities.WebGLCapabilities
    type WebGLExtensions = __renderers_webgl_WebGLExtensions.WebGLExtensions
    type Material = __materials_Material.Material

    type [<AllowNullLiteral>] IExports =
        abstract WebGLPrograms: WebGLProgramsStatic

    type [<AllowNullLiteral>] WebGLPrograms =
        abstract programs: ResizeArray<WebGLProgram> with get, set
        abstract getParameters: material: Material * lights: obj option * fog: obj option * nClipPlanes: float * ``object``: obj option -> obj option
        abstract getProgramCacheKey: material: Material * parameters: obj option -> string
        abstract acquireProgram: material: Material * parameters: obj option * cacheKey: string -> WebGLProgram
        abstract releaseProgram: program: WebGLProgram -> unit

    type [<AllowNullLiteral>] WebGLProgramsStatic =
        [<Emit "new $0($1...)">] abstract Create: renderer: WebGLRenderer * extensions: WebGLExtensions * capabilities: WebGLCapabilities -> WebGLPrograms

module __renderers_webgl_WebGLProperties =

    type [<AllowNullLiteral>] IExports =
        abstract WebGLProperties: WebGLPropertiesStatic

    type [<AllowNullLiteral>] WebGLProperties =
        abstract get: ``object``: obj option -> obj option
        abstract remove: ``object``: obj option -> unit
        abstract update: ``object``: obj option * key: obj option * value: obj option -> obj option
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] WebGLPropertiesStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> WebGLProperties

module __renderers_webgl_WebGLRenderLists =
    type Object3D = __core_Object3D.Object3D
    type Material = __materials_Material.Material
    type WebGLProgram = __renderers_webgl_WebGLProgram.WebGLProgram
    type Group = __objects_Group.Group
    type Scene = __scenes_Scene.Scene
    type Camera = __cameras_Camera.Camera
    type BufferGeometry = __core_BufferGeometry.BufferGeometry

    type [<AllowNullLiteral>] IExports =
        abstract WebGLRenderList: WebGLRenderListStatic
        abstract WebGLRenderLists: WebGLRenderListsStatic

    type [<AllowNullLiteral>] RenderTarget =
        interface end

    type [<AllowNullLiteral>] RenderItem =
        abstract id: float with get, set
        abstract ``object``: Object3D with get, set
        abstract geometry: BufferGeometry option with get, set
        abstract material: Material with get, set
        abstract program: WebGLProgram with get, set
        abstract groupOrder: float with get, set
        abstract renderOrder: float with get, set
        abstract z: float with get, set
        abstract group: Group option with get, set

    type [<AllowNullLiteral>] WebGLRenderList =
        abstract opaque: Array<RenderItem> with get, set
        abstract transparent: Array<RenderItem> with get, set
        abstract init: unit -> unit
        abstract push: ``object``: Object3D * geometry: BufferGeometry option * material: Material * groupOrder: float * z: float * group: Group option -> unit
        abstract unshift: ``object``: Object3D * geometry: BufferGeometry option * material: Material * groupOrder: float * z: float * group: Group option -> unit
        abstract sort: unit -> unit

    type [<AllowNullLiteral>] WebGLRenderListStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> WebGLRenderList

    type [<AllowNullLiteral>] WebGLRenderLists =
        abstract dispose: unit -> unit
        abstract get: scene: Scene * camera: Camera -> WebGLRenderList

    type [<AllowNullLiteral>] WebGLRenderListsStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> WebGLRenderLists

module __renderers_webgl_WebGLRenderStates =
    type Scene = __scenes_Scene.Scene
    type Camera = __cameras_Camera.Camera
    type Light = __lights_Light.Light
    type WebGLLights = __renderers_webgl_WebGLLights.WebGLLights

    type [<AllowNullLiteral>] IExports =
        abstract WebGLRenderStates: WebGLRenderStatesStatic

    type [<AllowNullLiteral>] WebGLRenderState =
        abstract init: unit -> unit
        abstract state: WebGLRenderStateState with get, set
        abstract setupLights: camera: Camera -> unit
        abstract pushLight: light: Light -> unit
        abstract pushShadow: shadowLight: Light -> unit

    type [<AllowNullLiteral>] WebGLRenderStates =
        abstract get: scene: Scene * camera: Camera -> WebGLRenderState
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] WebGLRenderStatesStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> WebGLRenderStates

    type [<AllowNullLiteral>] WebGLRenderStateState =
        abstract lightsArray: ResizeArray<Light> with get, set
        abstract shadowsArray: ResizeArray<Light> with get, set
        abstract lights: WebGLLights with get, set

module __renderers_webgl_WebGLShader =

    type [<AllowNullLiteral>] IExports =
        abstract WebGLShader: WebGLShaderStatic

    type [<AllowNullLiteral>] WebGLShader =
        interface end

    type [<AllowNullLiteral>] WebGLShaderStatic =
        [<Emit "new $0($1...)">] abstract Create: gl: WebGLRenderingContext * ``type``: string * string: string -> WebGLShader

module __renderers_webgl_WebGLShadowMap =
    type Scene = __scenes_Scene.Scene
    type Camera = __cameras_Camera.Camera
    type WebGLRenderer = __renderers_WebGLRenderer.WebGLRenderer
    type ShadowMapType = Constants.ShadowMapType

    type [<AllowNullLiteral>] IExports =
        abstract WebGLShadowMap: WebGLShadowMapStatic

    type [<AllowNullLiteral>] WebGLShadowMap =
        abstract enabled: bool with get, set
        abstract autoUpdate: bool with get, set
        abstract needsUpdate: bool with get, set
        abstract ``type``: ShadowMapType with get, set
        abstract render: scene: Scene * camera: Camera -> unit
        abstract cullFace: obj option with get, set

    type [<AllowNullLiteral>] WebGLShadowMapStatic =
        [<Emit "new $0($1...)">] abstract Create: _renderer: WebGLRenderer * _lights: ResizeArray<obj option> * _objects: ResizeArray<obj option> * capabilities: obj option -> WebGLShadowMap

module __renderers_webgl_WebGLState =
    type CullFace = Constants.CullFace
    type Blending = Constants.Blending
    type BlendingEquation = Constants.BlendingEquation
    type BlendingSrcFactor = Constants.BlendingSrcFactor
    type BlendingDstFactor = Constants.BlendingDstFactor
    type DepthModes = Constants.DepthModes
    type WebGLCapabilities = __renderers_webgl_WebGLCapabilities.WebGLCapabilities
    type WebGLExtensions = __renderers_webgl_WebGLExtensions.WebGLExtensions
    type Material = __materials_Material.Material
    type Vector4 = __math_Vector4.Vector4

    type [<AllowNullLiteral>] IExports =
        abstract WebGLColorBuffer: WebGLColorBufferStatic
        abstract WebGLDepthBuffer: WebGLDepthBufferStatic
        abstract WebGLStencilBuffer: WebGLStencilBufferStatic
        abstract WebGLState: WebGLStateStatic

    type [<AllowNullLiteral>] WebGLColorBuffer =
        abstract setMask: colorMask: bool -> unit
        abstract setLocked: lock: bool -> unit
        abstract setClear: r: float * g: float * b: float * a: float * premultipliedAlpha: bool -> unit
        abstract reset: unit -> unit

    type [<AllowNullLiteral>] WebGLColorBufferStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> WebGLColorBuffer

    type [<AllowNullLiteral>] WebGLDepthBuffer =
        abstract setTest: depthTest: bool -> unit
        abstract setMask: depthMask: bool -> unit
        abstract setFunc: depthFunc: DepthModes -> unit
        abstract setLocked: lock: bool -> unit
        abstract setClear: depth: float -> unit
        abstract reset: unit -> unit

    type [<AllowNullLiteral>] WebGLDepthBufferStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> WebGLDepthBuffer

    type [<AllowNullLiteral>] WebGLStencilBuffer =
        abstract setTest: stencilTest: bool -> unit
        abstract setMask: stencilMask: float -> unit
        abstract setFunc: stencilFunc: float * stencilRef: float * stencilMask: float -> unit
        abstract setOp: stencilFail: float * stencilZFail: float * stencilZPass: float -> unit
        abstract setLocked: lock: bool -> unit
        abstract setClear: stencil: float -> unit
        abstract reset: unit -> unit

    type [<AllowNullLiteral>] WebGLStencilBufferStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> WebGLStencilBuffer

    type [<AllowNullLiteral>] WebGLState =
        abstract buffers: WebGLStateBuffers with get, set
        abstract initAttributes: unit -> unit
        abstract enableAttribute: attribute: float -> unit
        abstract enableAttributeAndDivisor: attribute: float * meshPerAttribute: float -> unit
        abstract disableUnusedAttributes: unit -> unit
        abstract enable: id: float -> unit
        abstract disable: id: float -> unit
        abstract useProgram: program: obj option -> bool
        abstract setBlending: blending: Blending * ?blendEquation: BlendingEquation * ?blendSrc: BlendingSrcFactor * ?blendDst: BlendingDstFactor * ?blendEquationAlpha: BlendingEquation * ?blendSrcAlpha: BlendingSrcFactor * ?blendDstAlpha: BlendingDstFactor * ?premultiplyAlpha: bool -> unit
        abstract setMaterial: material: Material * frontFaceCW: bool -> unit
        abstract setFlipSided: flipSided: bool -> unit
        abstract setCullFace: cullFace: CullFace -> unit
        abstract setLineWidth: width: float -> unit
        abstract setPolygonOffset: polygonoffset: bool * factor: float * units: float -> unit
        abstract setScissorTest: scissorTest: bool -> unit
        abstract activeTexture: webglSlot: float -> unit
        abstract bindTexture: webglType: float * webglTexture: obj option -> unit
        abstract unbindTexture: unit -> unit
        abstract compressedTexImage2D: target: float * level: float * internalformat: float * width: float * height: float * border: float * data: ArrayBufferView -> unit
        abstract texImage2D: target: float * level: float * internalformat: float * width: float * height: float * border: float * format: float * ``type``: float * pixels: ArrayBufferView option -> unit
        abstract texImage2D: target: float * level: float * internalformat: float * format: float * ``type``: float * source: obj option -> unit
        abstract texImage3D: target: float * level: float * internalformat: float * width: float * height: float * depth: float * border: float * format: float * ``type``: float * pixels: obj option -> unit
        abstract scissor: scissor: Vector4 -> unit
        abstract viewport: viewport: Vector4 -> unit
        abstract reset: unit -> unit

    type [<AllowNullLiteral>] WebGLStateStatic =
        [<Emit "new $0($1...)">] abstract Create: gl: WebGLRenderingContext * extensions: WebGLExtensions * capabilities: WebGLCapabilities -> WebGLState

    type [<AllowNullLiteral>] WebGLStateBuffers =
        abstract color: WebGLColorBuffer with get, set
        abstract depth: WebGLDepthBuffer with get, set
        abstract stencil: WebGLStencilBuffer with get, set

module __renderers_webgl_WebGLTextures =
    type WebGLExtensions = __renderers_webgl_WebGLExtensions.WebGLExtensions
    type WebGLState = __renderers_webgl_WebGLState.WebGLState
    type WebGLProperties = __renderers_webgl_WebGLProperties.WebGLProperties
    type WebGLCapabilities = __renderers_webgl_WebGLCapabilities.WebGLCapabilities
    type WebGLUtils = __renderers_webgl_WebGLUtils.WebGLUtils
    type WebGLInfo = __renderers_webgl_WebGLInfo.WebGLInfo

    type [<AllowNullLiteral>] IExports =
        abstract WebGLTextures: WebGLTexturesStatic

    type [<AllowNullLiteral>] WebGLTextures =
        abstract allocateTextureUnit: unit -> unit
        abstract resetTextureUnits: unit -> unit
        abstract setTexture2D: texture: obj option * slot: float -> unit
        abstract setTexture2DArray: texture: obj option * slot: float -> unit
        abstract setTexture3D: texture: obj option * slot: float -> unit
        abstract setTextureCube: texture: obj option * slot: float -> unit
        abstract setTextureCubeDynamic: texture: obj option * slot: float -> unit
        abstract setupRenderTarget: renderTarget: obj option -> unit
        abstract updateRenderTargetMipmap: renderTarget: obj option -> unit
        abstract updateMultisampleRenderTarget: renderTarget: obj option -> unit
        abstract safeSetTexture2D: texture: obj option * slot: float -> unit
        abstract safeSetTextureCube: texture: obj option * slot: float -> unit

    type [<AllowNullLiteral>] WebGLTexturesStatic =
        [<Emit "new $0($1...)">] abstract Create: gl: WebGLRenderingContext * extensions: WebGLExtensions * state: WebGLState * properties: WebGLProperties * capabilities: WebGLCapabilities * utils: WebGLUtils * info: WebGLInfo -> WebGLTextures

module __renderers_webgl_WebGLUniforms =
    type WebGLProgram = __renderers_webgl_WebGLProgram.WebGLProgram
    type WebGLTextures = __renderers_webgl_WebGLTextures.WebGLTextures

    type [<AllowNullLiteral>] IExports =
        abstract WebGLUniforms: WebGLUniformsStatic

    type [<AllowNullLiteral>] WebGLUniforms =
        abstract setValue: gl: WebGLRenderingContext * name: string * value: obj option * textures: WebGLTextures -> unit
        abstract setOptional: gl: WebGLRenderingContext * ``object``: obj option * name: string -> unit

    type [<AllowNullLiteral>] WebGLUniformsStatic =
        [<Emit "new $0($1...)">] abstract Create: gl: WebGLRenderingContext * program: WebGLProgram -> WebGLUniforms
        abstract upload: gl: WebGLRenderingContext * seq: obj option * values: ResizeArray<obj option> * textures: WebGLTextures -> unit
        abstract seqWithValue: seq: obj option * values: ResizeArray<obj option> -> ResizeArray<obj option>

module __renderers_webgl_WebGLUtils =

    type [<AllowNullLiteral>] IExports =
        abstract WebGLUtils: WebGLUtilsStatic

    type [<AllowNullLiteral>] WebGLUtils =
        abstract convert: p: obj option -> unit

    type [<AllowNullLiteral>] WebGLUtilsStatic =
        [<Emit "new $0($1...)">] abstract Create: gl: U2<WebGLRenderingContext, WebGL2RenderingContext> * extensions: obj option * capabilities: obj option -> WebGLUtils

module __renderers_webxr_WebXRManager =
    type Group = __objects_Group.Group
    type Camera = __cameras_Camera.Camera

    type [<AllowNullLiteral>] IExports =
        abstract WebXRManager: WebXRManagerStatic

    type [<AllowNullLiteral>] WebXRManager =
        abstract enabled: bool with get, set
        abstract getController: id: float -> Group
        abstract setFramebufferScaleFactor: value: float -> unit
        abstract setReferenceSpaceType: value: string -> unit
        abstract getSession: unit -> obj option
        abstract setSession: value: obj option -> unit
        abstract getCamera: camera: Camera -> Camera
        abstract isPresenting: (unit -> bool) with get, set
        abstract setAnimationLoop: callback: Function -> unit
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] WebXRManagerStatic =
        [<Emit "new $0($1...)">] abstract Create: renderer: obj option * gl: WebGLRenderingContext -> WebXRManager
