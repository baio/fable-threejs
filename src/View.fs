module App.View

open Fable.React
open Fable.React.Props

open App.Msg

let view model dispatch = div [] [ button [ OnClick(fun _ -> dispatch Move) ] [ str "<<<" ] ]