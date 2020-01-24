namespace Models.Diffs

[<AutoOpen>]
module ObjectsDiffs =
    open Models

    type CubeDiff =
        { Id: ObjId
          X: int option
          Y: int option
          Size: int option }
    
    