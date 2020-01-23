module Models.Canvas

open Models.Core
open Models.Objects

type Object = Cube of Cube

type Canvas = {
    objects: Map<ObjId, Object>
}