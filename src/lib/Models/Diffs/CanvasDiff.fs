module Models.Diffs.CanvasDiff
open Models.Objects
open Models.Diffs.ObjectsDiffs

type Object = Cube
type ObjectDiff = CubeDiff

type CanvasDiff = {
    create: Object seq
    update: ObjectDiff seq
}