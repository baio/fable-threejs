module Models.Diffs.CanvasDiff
open Models.Objects
open Models.Diffs.ObjectsDiffs

type Object = Cube of Cube
type ObjectDiff = CubeDiff of CubeDiff

type CanvasDiff = {
    create: Object seq
    update: ObjectDiff seq
}