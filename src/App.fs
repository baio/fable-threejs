module App

open Fable.React
open Models.Canvas

type Model = Canvas

type Msg = None

// TODO
let mutable __model: Model option = Option.None

let init(): Model =
    let objects =
        [ 1,
          Cube
              ({ id = 1
                 position =
                     { x = 0
                       y = 0 }
                 size = 1 }) ]
        |> Map.ofList
    { objects = objects }

let update msg model: Model =
    __model <- Some model
    model

let view model dispatch = div [] [ str "hello" ]


open Elmish
open Elmish.React

Program.mkSimple init update view
|> Program.withReactSynchronous "app"
|> Program.withConsoleTrace
|> Program.run

let canvasGetter() = __model

Renderer.init (canvasGetter)
|> fun env -> Renderer.animate env 0.
|> ignore
