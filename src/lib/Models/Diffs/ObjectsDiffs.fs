module Models.Diffs.ObjectsDiffs

open Models.Core

type CubeDiff =
    { id: ObjId
      x: int option
      y: int option
      size: int option }
