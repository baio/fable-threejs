namespace Models.Diffs

open Models

[<AutoOpen>]
module CanvasDiff =       
    type Object = Models.Canvas.Object

    type ObjDiff = | ObjCubeDiff of CubeDiff

    type CanvasDiff =
        { create: Object seq
          update: ObjDiff seq }
