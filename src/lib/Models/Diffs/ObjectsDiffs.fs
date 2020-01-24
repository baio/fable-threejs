namespace Models.Diffs

[<AutoOpen>]
module ObjectsDiffs =
    open Models
    type CubeDiff =
        { id: ObjId
          x: int option
          y: int option
          size: int option }
