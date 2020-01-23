module App

open Fable.React
open Models.Canvas

type Model = Canvas

type Msg = None

// TODO
type ModelHolder =
    { mutable model: Model option }

let mutable __modelHolder: ModelHolder = { model = Option.None }

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

    let model = { objects = objects }
    __modelHolder.model <- Some model
    model

let update msg model: Model =
    __modelHolder.model <- Some model
    model

let view model dispatch = div [] [ str "hello" ]


open Elmish
open Elmish.React

Program.mkSimple init update view
|> Program.withReactSynchronous "app"
|> Program.withConsoleTrace
|> Program.run

let canvasGetter() = __modelHolder.model

Renderer.init (canvasGetter)
|> fun env -> Renderer.animate env 0.
|> ignore
