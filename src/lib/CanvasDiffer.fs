module CanvasDiffer

open Models.Canvas
open Models.Diffs.CanvasDiff

let calcUpdate (perv: Canvas) (cur: Canvas): ObjectDiff seq = Seq.empty

let getDiff (perv: Canvas option) (cur: Canvas option): CanvasDiff =
    match perv, cur with
    | None, None ->
        { create = []
          update = [] }
    // TODO probably return option
    | Some _, None ->
        { create = []
          update = [] }
    // TODO
    | Some p, Some c ->
        { create = []
          update = calcUpdate p c }
    | None _, Some canvas ->
        { create =
              canvas.Objects
              |> Map.toSeq
              |> Seq.map (fun x -> snd x)
          update = [] }
