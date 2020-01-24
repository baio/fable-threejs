module App.Update

open Models

open Aether
open Aether.Operators
open Aether.Optics

let moveObject = 
    Optic.map (Object.Cube_ >?> Cube.Position_ >?> Point.X_) (fun x -> x - 1)

let update msg model: Canvas =
    match msg with
    | _ -> model |> Optic.map (Canvas.Objects_ >-> Map.key_ 1) moveObject
