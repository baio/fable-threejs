module App

open Fable.React
open Fable.React.Props
open Models.Canvas

type Model = Canvas

type Msg = Move

// TODO
type ModelHolder =
    { mutable model: Model option }

let mutable __modelHolder: ModelHolder = { model = Option.None }

/// <summary>
/// <code>update f k map</code> updates the value <code>x</code> at key <code>k</code> (if it is in the map).
/// If <code>f x</code> is <code>None</code>, the element is deleted.
/// If it is <code>Some y</code>, the key is bound to the new value <code>y</code>.
/// </summary>
let updateWith f key map =
    let inner v map =
        match f v with
        | Some value -> map |> Map.add key value
        | None -> map |> Map.remove key
    match Map.tryFind key map with
    | Some v -> inner v map
    | None -> map    

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

let moveObject = function
    | Cube cube ->
        let position = { cube.position with x = cube.position.x - 1 }
        Cube { cube with position = position }

let _update msg model: Model =
    let objects = model.objects
    match msg with
    | Move -> { model with objects = objects |> updateWith (moveObject >> Some) 1 }

let update msg model: Model =
    let upd = _update msg model
    __modelHolder.model <- Some upd
    upd

let view model dispatch = div [] [ button [ OnClick(fun _ -> dispatch Move) ] [ str "<<<" ] ]


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
