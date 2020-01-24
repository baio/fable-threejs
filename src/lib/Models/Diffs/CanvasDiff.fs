namespace Models.Diffs

[<AutoOpen>]
module CanvasDiff = 
    open Models.Objects
    open Models.Diffs.ObjectsDiffs

    type Object = Models.Canvas.Object

    type ObjectDiff = CubeDiff of CubeDiff

    type CanvasDiff =
        { create: Object seq
          update: ObjectDiff seq }
