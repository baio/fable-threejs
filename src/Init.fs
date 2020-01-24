module App.Init

open Models.Canvas

let init(): Canvas =
    let objects =
        [ 1,
          Cube
              ({ Id = 1
                 Position =
                     { X = 0
                       Y = 0 }
                 Size = 1 }) ]
        |> Map.ofList

    { Objects = objects }

