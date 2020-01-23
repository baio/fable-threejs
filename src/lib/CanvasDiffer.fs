module CanvasDiffer

open Models.Canvas
open Models.Diffs.CanvasDiff

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
        | Some _, Some _ ->
            { create = []
              update = [] }
        | None _, Some canvas ->
            { create = canvas.objects |> Map.toSeq |> Seq.map (fun x -> snd x)
              update = [] }
              
