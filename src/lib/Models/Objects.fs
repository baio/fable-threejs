module Models.Objects

open Models.Core
open Models.Geometry

type Cube =
    { id: ObjId
      position: Point
      size: int }
