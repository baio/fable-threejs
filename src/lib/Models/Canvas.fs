module Models.Canvas

open Models.Core
open Models.Objects

type Object = Cube of Cube

type Canvas =
    { Objects: Map<ObjId, Object> }
    static member Objects_ = (fun a -> a.Objects), (fun b a -> { a with Objects = b })
