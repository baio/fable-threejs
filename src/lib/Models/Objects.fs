namespace Models

[<AutoOpen>]
module Objects =                               
    
    type Cube =
        { Id: ObjId
          Position: Point
          Size: int }
        static member Position_ = (fun a -> a.Position), (fun b a -> { a with Position = b })
        static member Size_ = (fun a -> a.Size), (fun b a -> { a with Size = b })


