module Core

open System
open Fable.Core
open Fable.Core.JS

type ArrayLike<'a> = seq<'a>

type Record<'a, 'b> = Map<'a, 'b>

type Uint8Array = Array

type AnalyserNode = obj

type AudioContext = obj

type GainNode = obj

type PannerNode = obj

type DistanceModelType = obj

type Iterable = System.Collections.IEnumerator

type Iterable<'a> = System.Collections.Generic.IEnumerator<'a>

type WebGLRenderingContext = obj

type WebGL2RenderingContext = obj

type WebGLBuffer = obj

type GLenum = obj

type ImageBitmap = obj

type MimeType = obj

type AudioBuffer = obj

type AudioBufferSourceNode = obj

type MediaStream = obj

type Float32Array = array<float>

type OffscreenCanvas = obj
