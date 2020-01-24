namespace Models

[<AutoOpenAttribute>]
module Canvas =
    type Object =
        | Cube of Cube
        static member Id_ = (function
                            | Cube x -> x.Id), (fun (y: ObjId) (x: Object) -> x)
        static member Cube_ =
            (fun m ->
            match m with
            | Cube i -> Some i
            | _ -> None),
            (fun i m ->
            match m with
            | Cube _ -> Cube i
            | m -> m)

    type Canvas =
        { Objects: Map<ObjId, Object> }
        static member Objects_ = (fun a -> a.Objects), (fun b a -> { a with Objects = b })
