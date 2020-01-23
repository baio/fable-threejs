module CanvasDiffer

open Models.Canvas
open Models.Diffs.CanvasDiff

let getDiff (perv: Canvas option) (cur: Canvas option): CanvasDiff =    
    { create = []
      update = [] }
