module Models.Canvas

open Models.Core
open Models.Objects.Cube

type Object = Cube

type Canvas = {
    objects: Map<ObjId, Object>
}