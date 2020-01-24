module Models.Geometry

type Point =
    { X: int
      Y: int }
    static member X_ = (fun a -> a.X), (fun b a -> { a with X = b })
    static member Y_ = (fun a -> a.Y), (fun b a -> { a with Y = b })
