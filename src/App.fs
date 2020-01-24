module App

open Models.Canvas
open App.Msg

type Model = Canvas

// TODO
type ModelHolder =
    { mutable model: Model option }

let mutable __modelHolder: ModelHolder = { model = None }


let init(): Model =
    let model = App.Init.init()
    __modelHolder.model <- Some model
    model


let update msg model: Model =
    let upd = App.Update.update msg model
    __modelHolder.model <- Some upd
    upd

open Elmish
open Elmish.React

Program.mkSimple init update App.View.view
|> Program.withReactSynchronous "app"
|> Program.withConsoleTrace
|> Program.run

let canvasGetter() = __modelHolder.model

Renderer.init (canvasGetter)
|> fun env -> Renderer.animate env 0.
|> ignore
